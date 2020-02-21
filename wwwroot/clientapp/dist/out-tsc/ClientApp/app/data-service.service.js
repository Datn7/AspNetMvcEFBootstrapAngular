import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
let DataServiceService = class DataServiceService {
    constructor() {
        this.products = [{
                title: "first",
                price: 23
            },
            {
                title: "second",
                price: 44
            }
        ];
    }
};
DataServiceService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], DataServiceService);
export { DataServiceService };
//# sourceMappingURL=data-service.service.js.map