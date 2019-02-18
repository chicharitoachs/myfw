//app = angular.module('app', ['ui.bootstrap', 'ngFileUpload', 'ui.bootstrap.datetimepicker', 'angularjs-dropdown-multiselect']);
app = angular.module('app', ['angular.filter', 'ngSanitize', 'ui.bootstrap', 'ngFileUpload', 'ui.select', 'ngMaterial', 'ngMessages', 'xtForm', 'ui.tree', 'angularTreeview']);
//appTree = angular.module('appTree', ['angularTreeview']);

app.config(function (uiSelectConfig) {
    uiSelectConfig.theme = 'bootstrap';
});
app.config(function ($mdDateLocaleProvider) {
    //$mdDateLocaleProvider.formatDate = function (date) {
    //    return moment(date).format('DD/MM/YYYY');
    //};
    $mdDateLocaleProvider.parseDate = function (dateString) {
        var chk = moment(dateString, 'DDMMYY', true);
        if (chk.isValid()) {
            var currDate = chk.toDate();
            return currDate;
        }
        var m = moment(dateString, 'DD/MM/YYYY', true);
        
        return m.isValid() ? m.toDate() : new Date(NaN);
    };
});

app.config(['$httpProvider', function ($httpProvider) {
        $httpProvider.defaults.headers.common['X-Requested-With'] = 'XMLHttpRequest';
    }]
);

app.filter('propsFilter', function () {
    return function (items, props) {
        var out = [];

        if (angular.isArray(items)) {
            var keys = Object.keys(props);

            items.forEach(function (item) {
                var itemMatches = false;

                for (var i = 0; i < keys.length; i++) {
                    var prop = keys[i];
                    var text = props[prop].toLowerCase();
                    if (item[prop].toString().toLowerCase().indexOf(text) !== -1) {
                        itemMatches = true;
                        break;
                    }
                }

                if (itemMatches) {
                    out.push(item);
                }
            });
        } else {
            // Let the output be the input untouched
            out = items;
        }

        return out;
    };
});

app.directive('ngEnter', function () {
    return function (scope, element, attrs) {
        element.bind("keydown keypress", function (event) {
            if (event.which === 13) {
                scope.$apply(function () {
                    scope.$eval(attrs.ngEnter);
                });
                event.preventDefault();
            }
        });
    };
});
app.directive('date', function (dateFilter) {
    return {
        require: 'ngModel',
        link: function (scope, elm, attrs, ctrl) {
            var dateFormat = attrs['date'] || 'dd/MM/yyyy';
            ctrl.$formatters.unshift(function (modelValue) {
                return dateFilter(modelValue, dateFormat);
            });
        }
    };
});
app.directive('convertToNumber', function () {
    return {
        require: 'ngModel',
        link: function (scope, element, attrs, ngModel) {
            ngModel.$parsers.push(function (val) {
                return parseInt(val, 10);
            });
            ngModel.$formatters.push(function (val) {
                return '' + val;
            });
        }
    };
});
app.directive('loading', ['$http', function ($http) {
    return {
        restrict: 'E',
        link: function (scope, elm, attrs) {
            scope.isLoading = function () {
                return $http.pendingRequests.length > 0;
            };
            scope.$watch(scope.isLoading, function (v) {
                elm.show();
                if (v) {
                    elm.show();
                } else {
                    elm.hide();
                }
            });
        }
    };
}]);
app.service("requestAsync", ['$http', '$q', function ($http, $q) {
    return ({
        send: send
    });
    function send(url, method, params, dataConfig) {
        var deferred = $q.defer();
        var request = "";
        if (method.toLowerCase() == "get") {
            request = $http({
                method: method,
                url: url,
                params: params,
                dataConfig: dataConfig
            });
        } else {
            request = $http({
                method: method,
                url: url,
                data: params
            });
        }
        return (request.then(handleSuccess, handleError));
    }
    function handleError(response) {
        if (
            !angular.isObject(response.data) ||
            !response.data.message
            ) {
            return ($q.reject("An unknown error occurred."));
        }
        return ($q.reject(response));
    }
    function handleSuccess(response) {
        return (response);
    }
}]);
// danh mục dùng chung
app.factory('DanhMucService', function ($http) {
    var danhmuc = {};
    danhmuc.DataDonVi = [];
    danhmuc.DataPhongLuuTru = [];
    danhmuc.DataPhongBan = [];
    danhmuc.DataNhanVien = [];

    danhmuc.loadDonVi = function () {
        var data = {};
        $http({
            method: 'GET',
            url: '/danhmuc/getdonviluutru',
            params: data
        }).then(function successCallback(response) {
            danhmuc.DataDonVi = response.data.items;
        }, function errorCallback(response) {
        });
    };
    danhmuc.loadPhongLuuTru = function () {
        var data = {};
        $http({
            method: 'GET',
            url: '/danhmuc/getphongluutru',
            params: data
        }).then(function successCallback(response) {
            danhmuc.DataPhongLuuTru = response.data.items;
            //$scope.DataPhongLuuTru.unshift($scope.ObjectNull);
        }, function errorCallback(response) {
        });
    };
    danhmuc.loadPhongBan = function () {
        var data = {};
        $http({
            method: 'GET',
            url: '/danhmuc/getphongban',
            params: data
        }).then(function successCallback(response) {
            danhmuc.DataPhongBan = response.data.items;
        }, function errorCallback(response) {
        });
    };
    danhmuc.loadNhanVien = function () {
        var data = {};
        $http({
            method: 'GET',
            url: '/danhmuc/GetNhanVien',
            params: data
        }).then(function successCallback(response) {
            danhmuc.DataNhanVien = response.data.items;
        }, function errorCallback(response) {
        });
    };
    return danhmuc;
});
app.run(function ($rootScope, $http, Upload, $timeout) {
    $rootScope.ChangeStateObj = {};
    $rootScope.ChangeStateObj.Id = '';
    $rootScope.ChangeStateObj.Link = '';
    $rootScope.ChangeStateObj.ToState = '';
    $rootScope.ChangeStateObj.ToStateName = '';
    $rootScope.ChangeStateObj.Workflow = '';

    $rootScope.DataDonVi = [];
    $rootScope.loadDonVi = function () {
        var data = {};
        $http({
            method: 'GET',
            url: '/danhmuc/getdonviluutru',
            params: data
        }).then(function successCallback(response) {
            $rootScope.DataDonVi = response.data.items;
        }, function errorCallback(response) {
        });
    };
    $rootScope.writeAction = function (e, id, type, callback) {

        var formData = $('#' + id).serialize();
        var url = "";
        var method = "";
        method = "POST";
        if (type == 1) {//create
            url = $(e.currentTarget).attr('create-link');
        } else if (type == 2) {// edit
            url = $(e.currentTarget).attr('edit-link');
        }


        $http({
            method: method,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            url: url,
            data: formData
        }).then(function successCallback(response) {
            if (callback) {
                callback(response);
            } else {
                window.location.reload();
            }

        }, function errorCallback(response) {
            $rootScope.ShowMessage();
        });
    };
    $rootScope.ConvertDateToJson = function (input) {
        if (input != null && typeof input == 'string') {
            var re = /-?\d+/;
            var m = re.exec(input);
            return new Date(parseInt(m[0]));
        }
        return input;

    }
    $rootScope.ConvertDateToString = function (input) {
        if (input != null && typeof input == 'string') {

            return input.toString();
        }
        return input;

    }
    $rootScope.ConvertToJson = function (input) {
        if (input != null) {
            return angular.toJson(input);
        }
        return input;

    }
    $rootScope.LoaiHoSoCheck = 0;
    $rootScope.FocusTab = function (fullcheck) {

        for (var i = 0; i < arguments.length; i++) {
            var item = arguments[i];
            if (typeof item == 'string') {
                var urlLower = window.location.href.toLowerCase();

                if (fullcheck == true) {
                    if (urlLower.indexOf(item.toLowerCase() + "?") != -1 || urlLower.endsWith(item.toLowerCase())) {
                        return true;
                    }
                } else {
                    if (urlLower.indexOf(item.toLowerCase()) != -1 || urlLower.endsWith(item.toLowerCase())) {
                        return true;
                    }
                }
                if (item.toLowerCase() == '/hoso/' && urlLower.endsWith("/HoSo".toLowerCase())) {
                    return true;
                }
                if (item.toLowerCase() == '/hosoluutru/index?type=1' && $rootScope.LoaiHoSoCheck == 1) {
                    return true;
                } if (item.toLowerCase() == '/hosoluutru/index?type=2' && $rootScope.LoaiHoSoCheck == 2) {
                    return true;
                } if (item.toLowerCase() == '/hosoluutru/index?type=3' && $rootScope.LoaiHoSoCheck == 3) {
                    return true;
                }
            }
        }
        return false;

    }
    $rootScope.CanAccess = function (address) {
        if (!$rootScope.functions) {
            return false;
        }
        address = address ? address.toLowerCase() : address;
        var index = $rootScope.functions.indexOf(address);
        var isAccess = index >= 0;
        return isAccess;
    }
    $rootScope.ShowMessage = function (text) {
        text = text ? text : "Lỗi kết nối, vui lòng kiểm tra lại đường truyền";
        $('#messageDialog').modal('show');
        $('#warningText').text(text);
    }
    $rootScope.addAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('#FileForm input[name="__RequestVerificationToken"]').val();
        return data;
    };
    $rootScope.uploadFiles = function (file, errFiles) {
        //$scope.f = file;
        //$scope.errFile = errFiles && errFiles[0];
        var f = file;
        var errFile = errFiles && errFiles[0];
        var uploadStatus = '';
        var fileId = 0;
        var fileName = '';
        if (f) {
            f.upload = Upload.upload({
                url: '/file/SaveUploadedFile',
                data: $rootScope.addAntiForgeryToken({ file: f })
            });

            f.upload.then(function (response) {
                if (response.data && response.data.fileId > 0) {
                    uploadStatus = "Thành công";
                    fileId = response.data.fileId;
                    fileName = response.data.fileName;
                } else {
                    $scope.uploadStatus = "Thất bại";
                }
                $timeout(function () {
                    f.result = response.data;
                });
            }, function (response) {
                if (response.status > 0) {
                    uploadStatus = "Thất bại";
                }
            }, function (evt) {
                f.progress = Math.min(100, parseInt(100.0 * evt.loaded / evt.total));
            });
        }
        return {
            file: f,
            errFile: errFile,
            uploadStatus: uploadStatus,
            fileId: fileId,
            fileName: fileName
        };
    }

    $rootScope.uploadFileToServer = function (scope, file, errFiles) {
        //$scope.f = file;
        //$scope.errFile = errFiles && errFiles[0];
        var f = file;
        var errFile = errFiles && errFiles[0];
        var uploadStatus = '';
        var fileId = 0;
        var fileName = '';
        var currentScope = scope;
        if (f) {
            f.upload = Upload.upload({
                url: '/file/UploadedFileToServer',
                data: $rootScope.addAntiForgeryToken({ file: f })
            });

            f.upload.then(function (response) {
                if (response.data && response.data.fileId > 0) {
                    currentScope.uploadStatus = "Thành công";
                    currentScope.fileId = response.data.fileId;
                    currentScope.fileName = response.data.fileName;
                    currentScope.UpdateFileInArray(currentScope.fileId, currentScope.fileName);
                } else {
                    $scope.uploadStatus = "Thất bại";
                }
                $timeout(function () {
                    f.result = response.data;
                });
            }, function (response) {
                if (response.status > 0) {
                    uploadStatus = "Thất bại";
                }
            }, function (evt) {
                f.progress = Math.min(100, parseInt(100.0 * evt.loaded / evt.total));
            });
        }
        return {
            file: f,
            errFile: errFile,
            uploadStatus: uploadStatus,
            fileId: fileId,
            fileName: fileName
        };
    }

    $rootScope.uploadFileInFolderToServer = function (scope, file, errFiles,hosoid) {
        //$scope.f = file;
        //$scope.errFile = errFiles && errFiles[0];
        var f = file;
        var errFile = errFiles && errFiles[0];
        var uploadStatus = '';
        var fileId = 0;
        var fileName = '';
        var currentScope = scope;
        if (f) {
            f.upload = Upload.upload({
                url: '/file/RequestFileFromFolder',
                data: $rootScope.addAntiForgeryToken({ file: f, hoso: hosoid })
            });

            f.upload.then(function (response) {
                if (response.data && response.data.fileId > 0) {
                    currentScope.uploadStatus = "Thành công";
                    currentScope.fileId = response.data.fileId;
                    currentScope.fileName = response.data.fileName;
                    currentScope.UpdateFileInArray(currentScope.fileId, currentScope.fileName);
                } else {
                    $scope.uploadStatus = "Thất bại";
                }
                $timeout(function () {
                    f.result = response.data;
                });
            }, function (response) {
                if (response.status > 0) {
                    uploadStatus = "Thất bại";
                }
            }, function (evt) {
                f.progress = Math.min(100, parseInt(100.0 * evt.loaded / evt.total));
            });
        }
        return {
            file: f,
            errFile: errFile,
            uploadStatus: uploadStatus,
            fileId: fileId,
            fileName: fileName
        };
    }

    $rootScope.uploadFileToServer2 = function (scope, file, errFiles) {
        //$scope.f = file;
        //$scope.errFile = errFiles && errFiles[0];
        var f = file;
        var errFile = errFiles && errFiles[0];
        var uploadStatus = '';
        var fileId = 0;
        var fileName = '';
        var currentScope = scope;
        if (f) {
            f.upload = Upload.upload({
                url: '/file/UploadedFileToServer',
                data: $rootScope.addAntiForgeryToken({ file: f })
            });

            f.upload.then(function (response) {
                if (response.data && response.data.fileId > 0) {
                    currentScope.uploadStatus2 = "Thành công";
                    currentScope.fileId2 = response.data.fileId;
                    currentScope.fileName2 = response.data.fileName;
                    currentScope.UpdateFileInArray2(currentScope.fileId2, currentScope.fileName2);
                } else {
                    uploadStatus = "Thất bại";
                }
                $timeout(function () {
                    f.result = response.data;
                });
            }, function (response) {
                if (response.status > 0) {
                    uploadStatus = "Thất bại";
                }
            }, function (evt) {
                f.progress = Math.min(100, parseInt(100.0 * evt.loaded / evt.total));
            });
        }
        return {
            file: f,
            errFile: errFile,
            uploadStatus: uploadStatus,
            fileId: fileId,
            fileName: fileName
        };
    }
    $rootScope.DeleteData = function (link, id) {
        if (+id == 0) {
            $rootScope.ShowMessage('Vui lòng chọn dữ liệu cần xoá');
            return;
        }
        $http({
            method: 'POST',
            url: link,
            params: { id: +id }
        }).then(function successCallback(response) {
            if (response.data.status) {
                window.location.reload();
            } else {
                $rootScope.ShowMessage(response.data.message);
            }
        }, function errorCallback(response) {
            $rootScope.ShowMessage();
        });
    }
    $rootScope.setActive = function (_controller, _action) {
        var urlLower = window.location.href.toLowerCase();
        _action = _action.toLowerCase();
        _controller = _controller.toLowerCase();
        if (!urlLower.includes(_controller)) return "";
        return (_action != '' && urlLower.includes(_action)) ? "active" : "";
    };
    $rootScope.setMenuActive = function (_controller) {
        var urlLower = window.location.href.toLowerCase();
        return (_controller != '' && urlLower.includes(_controller)) ? "menu-top-active" : "";
    };
    //$rootScope.functions = listfunctions;

    $rootScope.openChangeStateDialog = function (workflow, state, stateName, id, link, labelContent) {
        labelContent = labelContent || "Ghi chú";
        $rootScope.ChangeStateObj = {};
        $rootScope.ChangeStateObj.Id = id;
        $rootScope.ChangeStateObj.Link = link;
        $rootScope.ChangeStateObj.ToState = state;
        $rootScope.ChangeStateObj.ToStateName = stateName;
        $rootScope.ChangeStateObj.Workflow = workflow;
        $rootScope.ChangeStateObj.LabelContent = labelContent;
        $('#changeStateDialog').modal('show');
    }
    $rootScope.changeSate = function () {
        $http({
            method: 'POST',
            url: $rootScope.ChangeStateObj.Link,
            params: {
                id: $rootScope.ChangeStateObj.Id,
                trangthai: $rootScope.ChangeStateObj.ToState,
                ghichu: $rootScope.ChangeStateObj.GhiChu
            }
        }).then(function successCallback(response) {
            if (response.data.status) {
                window.location.reload();
            } else {
                $rootScope.ShowMessage(response.data.message);
            }
        }, function errorCallback(response) {
            $rootScope.ShowMessage();
        });
    }
    $rootScope.openRootDeleteDialog = function (link, id) {
        $rootScope.DeleteObj = {};
        $rootScope.DeleteObj.Id = id;
        $rootScope.DeleteObj.Link = link;
        $('#rootDeleteDialog').modal('show');
    }
    $rootScope.rootDelete = function () {
        if ($rootScope.DeleteObj.Id === undefined || $rootScope.DeleteObj.Id <= 0) {
            $rootScope.ShowMessage('Vui lòng chọn dữ liệu cần xoá');
            return;
        }
        $http({
            method: 'POST',
            url: $rootScope.DeleteObj.Link,
            params: { id: $rootScope.DeleteObj.Id }
        }).then(function successCallback(response) {
            if (response.data.status) {
                window.location.reload();
            } else {
                $rootScope.ShowMessage(response.data.message);
            }
        }, function errorCallback(response) {
            $rootScope.ShowMessage();
        });
    }

    //CuongNm 10/07/2018
    $rootScope.ObjectComment = {};
    $rootScope.DataComment = [];
    $rootScope.loadDataComment = function (item) {
        var data = {};
        data.Parent_GuildId = item;
        $http({
            method: 'GET',
            url: '/hethong/GetComment',
            params: data
        }).then(function successCallback(response) {
            $rootScope.DataComment = response.data.Items;
            
        }, function errorCallback(response) {
        });
    }
    
    $rootScope.comment = function (text, ParentGuild_Id) {
        var data = {};
        data.NoiDung = text;
        data.ParentGuild_Id = ParentGuild_Id;
        $rootScope.ObjectComment = null;
        $http({
            method: 'POST',
            url: '/hethong/doComment',
            data: { model: data }
        }).then(function successCallback(response) {
            if (response.data.status) {
                $rootScope.loadDataComment(ParentGuild_Id);
                
            } else {
                $rootScope.ShowMessage();
            }
        }, function errorCallback(response) {
        });
    }
});

//SinhNH 5/9/2018
(function (angular) {
    'use strict';

    angular.module('angularTreeview', []).directive('treeModel', ['$compile', function ($compile) {
        return {
            restrict: 'A',
            link: function (scope, element, attrs) {
                //tree id
                var treeId = attrs.treeId;

                //tree model
                var treeModel = attrs.treeModel;

                //node id
                var nodeId = attrs.nodeId || 'id';

                //node label
                var nodeLabel = attrs.nodeLabel || 'label';

                //children
                var nodeChildren = attrs.nodeChildren || 'children';

                var searchQuery = attrs.searchQuery;

                //tree template
                var template =
                    '<ul>' +
                    '<li data-ng-repeat="node in ' + treeModel + '| filter:' + searchQuery + ' ">' +
                    '<i class="collapsed" data-ng-show="node.' + nodeChildren + '.length && node.collapsed" data-ng-click="' + treeId + '.selectNodeHead(node)"></i>' +
                    '<i class="expanded" data-ng-show="node.' + nodeChildren + '.length && !node.collapsed" data-ng-click="' + treeId + '.selectNodeHead(node)"></i>' +
                    '<i class="normal" data-ng-hide="node.' + nodeChildren + '.length"></i> ' +
                    '<span data-ng-class="node.selected" data-ng-click="' + treeId + '.selectNodeLabel(node)">{{node.' + nodeLabel + '}}</span>' +
                    '<div data-ng-hide="node.collapsed" data-tree-id="' + treeId + '" data-tree-model="node.' + nodeChildren + '" data-node-id=' + nodeId + ' data-node-label=' + nodeLabel + ' data-node-children=' + nodeChildren + ' data-search-query=' + searchQuery +'></div>' +
                    '</li>' +
                    '</ul>';


                //check tree id, tree model
                if (treeId && treeModel) {

                    //root node
                    if (attrs.angularTreeview) {

                        //create tree object if not exists
                        scope[treeId] = scope[treeId] || {};
                        
                        //if node head clicks,
                        scope[treeId].selectNodeHead = scope[treeId].selectNodeHead || function (selectedNode) {
                            
                            //Collapse or Expand
                            selectedNode.collapsed = !selectedNode.collapsed;
                        };

                        //if node label clicks,
                        scope[treeId].selectNodeLabel = scope[treeId].selectNodeLabel || function (selectedNode) {

                            //remove highlight from previous node
                            if (scope[treeId].currentNode && scope[treeId].currentNode.selected) {
                                scope[treeId].currentNode.selected = undefined;
                            }

                            //set highlight to selected node
                            selectedNode.selected = 'selected';

                            //set currentNode
                            scope[treeId].currentNode = selectedNode;
                        };
                    }

                    //Rendering template.
                    element.html('').append($compile(template)(scope));
                }
            }
        };
    }]);
})(angular);


// the end