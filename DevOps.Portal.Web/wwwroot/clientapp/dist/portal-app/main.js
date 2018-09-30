(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./$$_lazy_route_resource lazy recursive":
/*!******************************************************!*\
  !*** ./$$_lazy_route_resource lazy namespace object ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./app/app.component.html":
/*!********************************!*\
  !*** ./app/app.component.html ***!
  \********************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<app-nav></app-nav>\r\n<div class=\"container-fluid\">\r\n    <div class=\"row flex-xl-nowrap\">\r\n        <div class=\"col-12 col-md-3 col-xl-2\">\r\n            <app-side-nav></app-side-nav>\r\n        </div>\r\n        \r\n        <main class=\"col-12 col-md-9 pl-md-5 pt-5\">\r\n            <router-outlet></router-outlet>\r\n        </main>\r\n    </div>\r\n</div>\r\n"

/***/ }),

/***/ "./app/app.component.scss":
/*!********************************!*\
  !*** ./app/app.component.scss ***!
  \********************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./app/app.component.ts":
/*!******************************!*\
  !*** ./app/app.component.ts ***!
  \******************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};

var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.title = 'app';
    }
    AppComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'portal-app',
            template: __webpack_require__(/*! ./app.component.html */ "./app/app.component.html"),
            styles: [__webpack_require__(/*! ./app.component.scss */ "./app/app.component.scss")]
        })
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./app/app.module.routing.ts":
/*!***********************************!*\
  !*** ./app/app.module.routing.ts ***!
  \***********************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "../node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./dashboard/dashboard.component */ "./app/dashboard/dashboard.component.ts");
/* harmony import */ var _ultrabuild_ultrabuild_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./ultrabuild/ultrabuild.component */ "./app/ultrabuild/ultrabuild.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};




var routes = [
    { path: '', pathMatch: 'full', redirectTo: 'dashboard' },
    { path: 'dashboard', component: _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_2__["DashboardComponent"] },
    { path: 'ultrabuild', component: _ultrabuild_ultrabuild_component__WEBPACK_IMPORTED_MODULE_3__["UltrabuildComponent"] }
];
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forRoot(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"]]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());



/***/ }),

/***/ "./app/app.module.ts":
/*!***************************!*\
  !*** ./app/app.module.ts ***!
  \***************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/platform-browser */ "../node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "../node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "../node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "../node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/forms */ "../node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _app_module_routing__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./app.module.routing */ "./app/app.module.routing.ts");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./app.component */ "./app/app.component.ts");
/* harmony import */ var _core_nav_nav_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./core/nav/nav.component */ "./app/core/nav/nav.component.ts");
/* harmony import */ var _azure_virtual_machine_list_virtual_machine_list_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./azure/virtual-machine-list/virtual-machine-list.component */ "./app/azure/virtual-machine-list/virtual-machine-list.component.ts");
/* harmony import */ var _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./dashboard/dashboard.component */ "./app/dashboard/dashboard.component.ts");
/* harmony import */ var _core_side_nav_side_nav_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./core/side-nav/side-nav.component */ "./app/core/side-nav/side-nav.component.ts");
/* harmony import */ var _ultrabuild_ultrabuild_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./ultrabuild/ultrabuild.component */ "./app/ultrabuild/ultrabuild.component.ts");
/* harmony import */ var _core_wizard_wizard_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./core/wizard/wizard.component */ "./app/core/wizard/wizard.component.ts");
/* harmony import */ var _core_wizard_wizard_step_wizard_step_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./core/wizard/wizard-step/wizard-step.component */ "./app/core/wizard/wizard-step/wizard-step.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};















var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            declarations: [
                _app_component__WEBPACK_IMPORTED_MODULE_7__["AppComponent"],
                _core_nav_nav_component__WEBPACK_IMPORTED_MODULE_8__["NavComponent"],
                _azure_virtual_machine_list_virtual_machine_list_component__WEBPACK_IMPORTED_MODULE_9__["VirtualMachineListComponent"],
                _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_10__["DashboardComponent"],
                _core_side_nav_side_nav_component__WEBPACK_IMPORTED_MODULE_11__["SideNavComponent"],
                _ultrabuild_ultrabuild_component__WEBPACK_IMPORTED_MODULE_12__["UltrabuildComponent"],
                _core_wizard_wizard_component__WEBPACK_IMPORTED_MODULE_13__["WizardComponent"],
                _core_wizard_wizard_step_wizard_step_component__WEBPACK_IMPORTED_MODULE_14__["WizardStepComponent"]
            ],
            imports: [
                _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__["BrowserModule"],
                _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_2__["NgbModule"],
                _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClientModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_5__["FormsModule"],
                _app_module_routing__WEBPACK_IMPORTED_MODULE_6__["AppRoutingModule"]
            ],
            providers: [],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_7__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./app/azure/azure.service.ts":
/*!************************************!*\
  !*** ./app/azure/azure.service.ts ***!
  \************************************/
/*! exports provided: AzureService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AzureService", function() { return AzureService; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common/http */ "../node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "../node_modules/rxjs/_esm5/index.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs/operators */ "../node_modules/rxjs/_esm5/operators/index.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};




var AzureService = /** @class */ (function () {
    function AzureService(http) {
        this.http = http;
        this.virtualMachines = [];
    }
    AzureService.prototype.loadVirtualMachines = function () {
        var _this = this;
        return this.http.get('api/virtualmachines').pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["map"])(function (data) {
            _this.virtualMachines = data;
            return true;
        }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["catchError"])(this.handleError));
    };
    AzureService.prototype.handleError = function (err) {
        var errorMessage = '';
        if (err.error instanceof ErrorEvent) {
            errorMessage = "An error occurred: " + err.error.message;
        }
        else {
            errorMessage = "Server returned code: " + err.status + ", error message is: " + err.message;
        }
        console.log(errorMessage);
        return Object(rxjs__WEBPACK_IMPORTED_MODULE_2__["throwError"])(errorMessage);
    };
    AzureService = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injectable"])({
            providedIn: 'root'
        }),
        __metadata("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpClient"]])
    ], AzureService);
    return AzureService;
}());



/***/ }),

/***/ "./app/azure/virtual-machine-list/virtual-machine-list.component.html":
/*!****************************************************************************!*\
  !*** ./app/azure/virtual-machine-list/virtual-machine-list.component.html ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"container-fluid\">\n    <div class=\"card col-md-4\" *ngFor=\"let vm of virtualMachines\">\n        <div class=\"card-body\">\n            <h3 class=\"card-title\">{{vm.name}}</h3>\n        </div>\n    </div>\n</div>\n"

/***/ }),

/***/ "./app/azure/virtual-machine-list/virtual-machine-list.component.scss":
/*!****************************************************************************!*\
  !*** ./app/azure/virtual-machine-list/virtual-machine-list.component.scss ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./app/azure/virtual-machine-list/virtual-machine-list.component.ts":
/*!**************************************************************************!*\
  !*** ./app/azure/virtual-machine-list/virtual-machine-list.component.ts ***!
  \**************************************************************************/
/*! exports provided: VirtualMachineListComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "VirtualMachineListComponent", function() { return VirtualMachineListComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _azure_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../azure.service */ "./app/azure/azure.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var VirtualMachineListComponent = /** @class */ (function () {
    function VirtualMachineListComponent(azure) {
        this.azure = azure;
        this.virtualMachines = [];
        this.virtualMachines = azure.virtualMachines;
    }
    VirtualMachineListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.azure.loadVirtualMachines()
            .subscribe(function (success) {
            if (success) {
                _this.virtualMachines = _this.azure.virtualMachines;
            }
        });
    };
    VirtualMachineListComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-virtual-machine-list',
            template: __webpack_require__(/*! ./virtual-machine-list.component.html */ "./app/azure/virtual-machine-list/virtual-machine-list.component.html"),
            styles: [__webpack_require__(/*! ./virtual-machine-list.component.scss */ "./app/azure/virtual-machine-list/virtual-machine-list.component.scss")]
        }),
        __metadata("design:paramtypes", [_azure_service__WEBPACK_IMPORTED_MODULE_1__["AzureService"]])
    ], VirtualMachineListComponent);
    return VirtualMachineListComponent;
}());



/***/ }),

/***/ "./app/core/nav/nav.component.html":
/*!*****************************************!*\
  !*** ./app/core/nav/nav.component.html ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<header class=\"navbar navbar-expand-md navbar-dark flex-column flex-md-row\">\r\n    <a class=\"navbar-brand\" href=\"#\">DevOps Portal</a>\r\n</header>"

/***/ }),

/***/ "./app/core/nav/nav.component.scss":
/*!*****************************************!*\
  !*** ./app/core/nav/nav.component.scss ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".navbar {\n  position: -webkit-sticky;\n  position: sticky;\n  min-height: 4rem;\n  top: 0;\n  z-index: 5;\n  background-color: #1c1c1c;\n  box-shadow: 0 3px 8px rgba(0, 0, 0, 0.8); }\n"

/***/ }),

/***/ "./app/core/nav/nav.component.ts":
/*!***************************************!*\
  !*** ./app/core/nav/nav.component.ts ***!
  \***************************************/
/*! exports provided: NavComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "NavComponent", function() { return NavComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var NavComponent = /** @class */ (function () {
    function NavComponent() {
    }
    NavComponent.prototype.ngOnInit = function () {
    };
    NavComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-nav',
            template: __webpack_require__(/*! ./nav.component.html */ "./app/core/nav/nav.component.html"),
            styles: [__webpack_require__(/*! ./nav.component.scss */ "./app/core/nav/nav.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], NavComponent);
    return NavComponent;
}());



/***/ }),

/***/ "./app/core/side-nav/side-nav.component.html":
/*!***************************************************!*\
  !*** ./app/core/side-nav/side-nav.component.html ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"sidenav \">\r\n    <nav class=\"\">\r\n        <div class=\"sidenav-link\">\r\n            <a routerLink=\"/dashboard\" routerLinkActive=\"active\">Dashboard</a>\r\n        </div>\r\n        <div class=\"sidenav-link\">\r\n            <a routerLink=\"/ultrabuild\" routerLinkActive=\"active\">Ultrabuild &trade;</a>\r\n        </div>\r\n    </nav>\r\n</div>\r\n"

/***/ }),

/***/ "./app/core/side-nav/side-nav.component.scss":
/*!***************************************************!*\
  !*** ./app/core/side-nav/side-nav.component.scss ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".sidenav {\n  flex: 0 1 320px;\n  height: calc(100vh - 4rem);\n  position: -webkit-sticky;\n  position: sticky;\n  top: 4rem;\n  left: 0;\n  background-color: #323130;\n  margin-left: -15px;\n  margin-right: -15px;\n  border-right: 1px;\n  box-shadow: inset -6px 0px 8px 0px rgba(0, 0, 0, 0.5); }\n  .sidenav .sidenav-link {\n    padding: .25rem 1.5rem;\n    display: block;\n    color: azure; }\n  .sidenav .sidenav-link a {\n      text-decoration: none; }\n  .sidenav .sidenav-link a.active {\n        color: azure; }\n"

/***/ }),

/***/ "./app/core/side-nav/side-nav.component.ts":
/*!*************************************************!*\
  !*** ./app/core/side-nav/side-nav.component.ts ***!
  \*************************************************/
/*! exports provided: SideNavComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SideNavComponent", function() { return SideNavComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var SideNavComponent = /** @class */ (function () {
    function SideNavComponent() {
    }
    SideNavComponent.prototype.ngOnInit = function () {
    };
    SideNavComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-side-nav',
            template: __webpack_require__(/*! ./side-nav.component.html */ "./app/core/side-nav/side-nav.component.html"),
            styles: [__webpack_require__(/*! ./side-nav.component.scss */ "./app/core/side-nav/side-nav.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], SideNavComponent);
    return SideNavComponent;
}());



/***/ }),

/***/ "./app/core/wizard/wizard-step/wizard-step.component.html":
/*!****************************************************************!*\
  !*** ./app/core/wizard/wizard-step/wizard-step.component.html ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div [hidden]=\"!isActive\"> \n    <ng-content></ng-content>\n</div>\n"

/***/ }),

/***/ "./app/core/wizard/wizard-step/wizard-step.component.scss":
/*!****************************************************************!*\
  !*** ./app/core/wizard/wizard-step/wizard-step.component.scss ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./app/core/wizard/wizard-step/wizard-step.component.ts":
/*!**************************************************************!*\
  !*** ./app/core/wizard/wizard-step/wizard-step.component.ts ***!
  \**************************************************************/
/*! exports provided: WizardStepComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "WizardStepComponent", function() { return WizardStepComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var WizardStepComponent = /** @class */ (function () {
    function WizardStepComponent() {
        this.next = new _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"]();
        this.prev = new _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"]();
        this.active = new _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"]();
        this._isActive = false;
    }
    WizardStepComponent.prototype.ngOnInit = function () {
    };
    Object.defineProperty(WizardStepComponent.prototype, "isActive", {
        get: function () {
            return this._isActive;
        },
        set: function (isActive) {
            this._isActive = isActive;
        },
        enumerable: true,
        configurable: true
    });
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Input"])(),
        __metadata("design:type", String)
    ], WizardStepComponent.prototype, "title", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Input"])(),
        __metadata("design:type", Boolean)
    ], WizardStepComponent.prototype, "showPrev", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Input"])(),
        __metadata("design:type", Boolean)
    ], WizardStepComponent.prototype, "showNext", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Output"])(),
        __metadata("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"])
    ], WizardStepComponent.prototype, "next", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Output"])(),
        __metadata("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"])
    ], WizardStepComponent.prototype, "prev", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Output"])(),
        __metadata("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"])
    ], WizardStepComponent.prototype, "active", void 0);
    WizardStepComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-wizard-step',
            template: __webpack_require__(/*! ./wizard-step.component.html */ "./app/core/wizard/wizard-step/wizard-step.component.html"),
            styles: [__webpack_require__(/*! ./wizard-step.component.scss */ "./app/core/wizard/wizard-step/wizard-step.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], WizardStepComponent);
    return WizardStepComponent;
}());



/***/ }),

/***/ "./app/core/wizard/wizard.component.html":
/*!***********************************************!*\
  !*** ./app/core/wizard/wizard.component.html ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"wizard-card\">\n    <div class=\"wizard-header\">\n        <ul class=\"nav nav-justified step-tab-container\">\n            <li class=\"nav-item active\" *ngFor=\"let step of steps\" [ngClass]=\"{active: step.isActive}\" (click)=\"goToStep(step)\">\n                <a >{{step.title}}</a>\n            </li>\n        </ul>\n    </div>\n    <div class=\"wizard-content\">\n        <ng-content></ng-content>  \n    </div>\n    <div class=\"wizard-footer\">\n        <button class=\"btn btn-secondary\" type=\"button\" (click)=\"prev()\" [hidden]=\"!activeStep.showPrev\">Prev</button>\n        <button class=\"btn btn-secondary\" type=\"button\" (click)=\"next()\" [hidden]=\"!activeStep.showNext\">Next</button>\n        <button class=\"btn btn-secondary\" type=\"button\" (click)=\"complete()\" [hidden]=\"hasNextStep\">Create</button>\n    </div>\n</div>\n"

/***/ }),

/***/ "./app/core/wizard/wizard.component.scss":
/*!***********************************************!*\
  !*** ./app/core/wizard/wizard.component.scss ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".wizard-card .wizard-header .step-tab-container {\n  border-bottom: 1px solid #808080;\n  font-size: 1.25rem; }\n  .wizard-card .wizard-header .step-tab-container .nav-item {\n    padding: 1rem 0rem;\n    font-weight: 500; }\n  .wizard-card .wizard-header .step-tab-container .nav-item.active {\n      border-bottom: 4px solid #1976D2; }\n  .wizard-card .wizard-header .step-tab-container .nav-item:hover {\n      cursor: pointer;\n      background-color: #808080; }\n  .wizard-card .wizard-content {\n  padding-top: 1.25rem; }\n  .wizard-card .wizard-footer {\n  padding-top: 1.25rem;\n  border-top: 1px solid #808080; }\n  .wizard-card .wizard-footer button {\n    margin: 3px;\n    border-radius: 0; }\n"

/***/ }),

/***/ "./app/core/wizard/wizard.component.ts":
/*!*********************************************!*\
  !*** ./app/core/wizard/wizard.component.ts ***!
  \*********************************************/
/*! exports provided: WizardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "WizardComponent", function() { return WizardComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _wizard_step_wizard_step_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./wizard-step/wizard-step.component */ "./app/core/wizard/wizard-step/wizard-step.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var WizardComponent = /** @class */ (function () {
    function WizardComponent() {
        this.completed = new _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"]();
    }
    WizardComponent.prototype.ngOnInit = function () { };
    WizardComponent.prototype.ngAfterContentInit = function () {
        this._steps = this.wizardSteps.toArray();
        this.activeStep = this._steps[0];
    };
    Object.defineProperty(WizardComponent.prototype, "activeStep", {
        get: function () {
            return this.steps.find(function (step) { return step.isActive; });
        },
        set: function (step) {
            if (this.activeStep != null) {
                this.activeStep.isActive = false;
            }
            step.isActive = true;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(WizardComponent.prototype, "steps", {
        get: function () {
            return this._steps;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(WizardComponent.prototype, "hasNextStep", {
        get: function () {
            return this.activeStepIndex < this.steps.length - 1;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(WizardComponent.prototype, "hasPrevStep", {
        get: function () {
            return this.activeStepIndex > 0;
        },
        enumerable: true,
        configurable: true
    });
    WizardComponent.prototype.next = function () {
        this.activeStep = this.steps[this.activeStepIndex + 1];
        this.activeStep.next.emit();
    };
    WizardComponent.prototype.prev = function () {
        this.activeStep = this.steps[this.activeStepIndex - 1];
        this.activeStep.prev.emit();
    };
    WizardComponent.prototype.complete = function () {
        this.completed.emit();
    };
    Object.defineProperty(WizardComponent.prototype, "activeStepIndex", {
        get: function () {
            return this.steps.indexOf(this.activeStep);
        },
        enumerable: true,
        configurable: true
    });
    WizardComponent.prototype.goToStep = function (step) {
        this.activeStep = step;
    };
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ContentChildren"])(_wizard_step_wizard_step_component__WEBPACK_IMPORTED_MODULE_1__["WizardStepComponent"]),
        __metadata("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_0__["QueryList"])
    ], WizardComponent.prototype, "wizardSteps", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Output"])(),
        __metadata("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"])
    ], WizardComponent.prototype, "completed", void 0);
    WizardComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-wizard',
            template: __webpack_require__(/*! ./wizard.component.html */ "./app/core/wizard/wizard.component.html"),
            styles: [__webpack_require__(/*! ./wizard.component.scss */ "./app/core/wizard/wizard.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], WizardComponent);
    return WizardComponent;
}());



/***/ }),

/***/ "./app/dashboard/dashboard.component.html":
/*!************************************************!*\
  !*** ./app/dashboard/dashboard.component.html ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<app-virtual-machine-list></app-virtual-machine-list>\r\n"

/***/ }),

/***/ "./app/dashboard/dashboard.component.scss":
/*!************************************************!*\
  !*** ./app/dashboard/dashboard.component.scss ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./app/dashboard/dashboard.component.ts":
/*!**********************************************!*\
  !*** ./app/dashboard/dashboard.component.ts ***!
  \**********************************************/
/*! exports provided: DashboardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DashboardComponent", function() { return DashboardComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var DashboardComponent = /** @class */ (function () {
    function DashboardComponent() {
    }
    DashboardComponent.prototype.ngOnInit = function () {
    };
    DashboardComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-dashboard',
            template: __webpack_require__(/*! ./dashboard.component.html */ "./app/dashboard/dashboard.component.html"),
            styles: [__webpack_require__(/*! ./dashboard.component.scss */ "./app/dashboard/dashboard.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], DashboardComponent);
    return DashboardComponent;
}());



/***/ }),

/***/ "./app/ultrabuild/shared/create-ultrabuild.model.ts":
/*!**********************************************************!*\
  !*** ./app/ultrabuild/shared/create-ultrabuild.model.ts ***!
  \**********************************************************/
/*! exports provided: UltraBuild */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UltraBuild", function() { return UltraBuild; });
/* harmony import */ var _visual_studio_model__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./visual-studio.model */ "./app/ultrabuild/shared/visual-studio.model.ts");

var UltraBuild = /** @class */ (function () {
    function UltraBuild() {
        this.visualStudio = new _visual_studio_model__WEBPACK_IMPORTED_MODULE_0__["VisualStudio"]();
    }
    return UltraBuild;
}());



/***/ }),

/***/ "./app/ultrabuild/shared/ultrabuild.service.ts":
/*!*****************************************************!*\
  !*** ./app/ultrabuild/shared/ultrabuild.service.ts ***!
  \*****************************************************/
/*! exports provided: UltraBuildService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UltraBuildService", function() { return UltraBuildService; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common/http */ "../node_modules/@angular/common/fesm5/http.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var UltraBuildService = /** @class */ (function () {
    function UltraBuildService(http) {
        this.http = http;
    }
    UltraBuildService.prototype.build = function (model) {
        var uri = 'api/ultrabuild';
        this.http.put(uri, { data: model });
    };
    UltraBuildService = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injectable"])({
            providedIn: 'root'
        }),
        __metadata("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpClient"]])
    ], UltraBuildService);
    return UltraBuildService;
}());



/***/ }),

/***/ "./app/ultrabuild/shared/visual-studio.model.ts":
/*!******************************************************!*\
  !*** ./app/ultrabuild/shared/visual-studio.model.ts ***!
  \******************************************************/
/*! exports provided: VisualStudio */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "VisualStudio", function() { return VisualStudio; });
var VisualStudio = /** @class */ (function () {
    function VisualStudio() {
    }
    return VisualStudio;
}());



/***/ }),

/***/ "./app/ultrabuild/ultrabuild.component.html":
/*!**************************************************!*\
  !*** ./app/ultrabuild/ultrabuild.component.html ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div>\r\n    <h1>Ultrabuild</h1>\r\n\r\n    <app-wizard (completed)=\"complete()\">\r\n        <app-wizard-step (next)=\"stepNext($event)\" [title]=\"'Visual Studio'\" [showPrev]=\"false\" [showNext]=\"true\">\r\n            <form #visualStudioForm=\"ngForm\">\r\n                <div class=\"form-group\">\r\n                    <label>Solution name</label>\r\n                    <input class=\"form-control\" name=\"solutionName\" placeholder=\"Enter a solution name\" [(ngModel)]=\"model.visualStudio.solutionName\" required />\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label>Project name</label>\r\n                    <input class=\"form-control\" placeholder=\"Enter a project name\" required />\r\n                </div>\r\n            </form>\r\n        </app-wizard-step>\r\n        <app-wizard-step [title]=\"'GitLab'\" [showPrev]=\"true\" [showNext]=\"true\">\r\n            <div class=\"form-group\">\r\n                <label>Group name</label>\r\n                <input class=\"form-control\" placeholder=\"Enter a group name\" required />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Project name</label>\r\n                <input class=\"form-control\" placeholder=\"Enter a project name\" required />\r\n            </div>\r\n        </app-wizard-step>\r\n        <app-wizard-step [title]=\"'Teamcity'\" [showPrev]=\"true\" [showNext]=\"true\">\r\n            <div class=\"form-group\">\r\n                <label>Group name</label>\r\n                <input class=\"form-control\" placeholder=\"Enter a group name\" required />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Project name</label>\r\n                <input class=\"form-control\" placeholder=\"Enter a project name\" required />\r\n            </div>\r\n        </app-wizard-step>\r\n        <app-wizard-step [title]=\"'Octopus'\" [showPrev]=\"true\" [showNext]=\"true\">\r\n            <div class=\"form-group\">\r\n                <label>Group name</label>\r\n                <input class=\"form-control\" placeholder=\"Enter a group name\" required />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Project name</label>\r\n                <input class=\"form-control\" placeholder=\"Enter a project name\" required />\r\n            </div>\r\n        </app-wizard-step>\r\n        <app-wizard-step [title]=\"'Azure'\" [showPrev]=\"true\" [showNext]=\"true\">\r\n            <div class=\"form-group\">\r\n                <label>Group name</label>\r\n                <input class=\"form-control\" placeholder=\"Enter a group name\" required />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label>Project name</label>\r\n                <input class=\"form-control\" placeholder=\"Enter a project name\" required />\r\n            </div>\r\n        </app-wizard-step>\r\n        <app-wizard-step [title]=\"'Confirm'\" [showPrev]=\"true\" [showNext]=\"false\">\r\n\r\n        </app-wizard-step>\r\n    </app-wizard>\r\n</div>"

/***/ }),

/***/ "./app/ultrabuild/ultrabuild.component.scss":
/*!**************************************************!*\
  !*** ./app/ultrabuild/ultrabuild.component.scss ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./app/ultrabuild/ultrabuild.component.ts":
/*!************************************************!*\
  !*** ./app/ultrabuild/ultrabuild.component.ts ***!
  \************************************************/
/*! exports provided: UltrabuildComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UltrabuildComponent", function() { return UltrabuildComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _shared_create_ultrabuild_model__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./shared/create-ultrabuild.model */ "./app/ultrabuild/shared/create-ultrabuild.model.ts");
/* harmony import */ var _shared_ultrabuild_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./shared/ultrabuild.service */ "./app/ultrabuild/shared/ultrabuild.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var UltrabuildComponent = /** @class */ (function () {
    function UltrabuildComponent(ultraBuildService) {
        this.ultraBuildService = ultraBuildService;
    }
    UltrabuildComponent.prototype.ngOnInit = function () {
        this.model = new _shared_create_ultrabuild_model__WEBPACK_IMPORTED_MODULE_1__["UltraBuild"]();
    };
    UltrabuildComponent.prototype.stepNext = function (e) {
        console.log(e);
    };
    UltrabuildComponent.prototype.complete = function () {
        this.ultraBuildService.build(this.model);
        console.log('completed');
    };
    UltrabuildComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-ultrabuild',
            template: __webpack_require__(/*! ./ultrabuild.component.html */ "./app/ultrabuild/ultrabuild.component.html"),
            styles: [__webpack_require__(/*! ./ultrabuild.component.scss */ "./app/ultrabuild/ultrabuild.component.scss")]
        }),
        __metadata("design:paramtypes", [_shared_ultrabuild_service__WEBPACK_IMPORTED_MODULE_2__["UltraBuildService"]])
    ], UltrabuildComponent);
    return UltrabuildComponent;
}());



/***/ }),

/***/ "./environments/environment.ts":
/*!*************************************!*\
  !*** ./environments/environment.ts ***!
  \*************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var environment = {
    production: false
};
/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./main.ts":
/*!*****************!*\
  !*** ./main.ts ***!
  \*****************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "../node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "../node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.log(err); });


/***/ }),

/***/ 0:
/*!***********************!*\
  !*** multi ./main.ts ***!
  \***********************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! D:\Development\Projects\Microsoft\DevOps\DevOps-Portal\DevOps.Portal.web\ClientApp\main.ts */"./main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map