import  {Component} from "@angular/core";
import {ActivatedRoute} from "@angular/router";
import {HttpService} from "../http.service";
import {Product} from "./Product";


@Component({
  selector: 'app-products',
  templateUrl: 'products.component.html',
  providers: [HttpService]
})

export class ProductsComponent{

  products: Product[];

  constructor(private route: ActivatedRoute, private http: HttpService) {
    this.route.params.subscribe(
      params => {
        let category: string = params['category'];
        let brand: string = params['brand'];
        this.getProducts(category, brand);
      });
  }

  getProducts(category: string, brand: string): void{

    if (brand != null && brand != "")
      this.http.getData(`products/${category}/${brand}`).subscribe(i => this.products = i['products']);
    else
       this.http.getData(`products/${category}`).subscribe(i => this.products = i['products']);
  }
}
