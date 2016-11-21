/// <reference path="Assets/admin/libs/angular/angular.js" />
(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox', '$filter'];
   
    function productCategoryListController($scope, apiService, notificationService, $ngBootbox, $filter) {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.getProductCagories = getProductCagories;
        $scope.keyword = '';
        $scope.search = search;
        $scope.delProductCategory = delProductCategory;      
        $scope.deleteMultiple = deleteMultiple;
        $scope.productCategoryCheckeds = {};
                   
        function deleteMultiple() {
            var listID = [];
            $.each($scope.productCategoryCheckeds, function (i, item) {
                if (item.Check == true)
                {
                    listID.push(item.ID);
                }
                
            });
            var config = {
                params: {
                    checkedProductCategories: JSON.stringify(listID)
                }
            }
            apiService.del('api/productcategory/deletemulti', config, function (result) {
                notificationService.displaySuccess('Xóa thành công ' + result.data + ' bản ghi.');
                search();
            }, function (error) {
                notificationService.displayError('Xóa không thành công');
            });
        }

        function delProductCategory(id) {
            $ngBootbox.confirm('Bạn có muốn xóa không ?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('/api/productcategory/delete', config, function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được xóa thành công.');
                    search();
                }, function (error) {
                    notificationService.displayError(error);
                });
            });
        }
       
        function search() {
            getProductCagories();
        }
        function getProductCagories(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 5
                }
            };

            apiService.get('/api/productcategory/getall', config, function (result) {
                if (result.data.TotalCount == 0) {
                    notificationService.displayWarning('Không tìm thấy bản ghi nào.');
                }

                $scope.productCategories = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;
            }, function () {
                console.log('Load productcategory failed.');
            });
        }

        $scope.getProductCagories();
    }
})(angular.module('tedushop.product_categories'));