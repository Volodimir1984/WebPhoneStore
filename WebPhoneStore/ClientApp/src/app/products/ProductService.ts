﻿import {Injectable} from "@angular/core";
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";


@Injectable()
export class ProductService{
  constructor(private http: HttpClient) {
  }

  getProducts(url: string): Observable<any> {
    return this.http.get<any>(url);
  }

}
