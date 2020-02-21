import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { map } from "rxjs/operators"

@Injectable({
  providedIn: 'root'
})
export class DataServiceService {

    constructor(private http: HttpClient) { }

    public products = [];

    loadProducts() {
        this.http.get("/api/products")
            .pipe(
                map((data: any[]) => {
                    this.products = data;
                    return true;
                }));
    }
}
