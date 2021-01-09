import  {Component, OnInit} from "@angular/core";
import {ActivatedRoute} from "@angular/router";
import {switchMap} from "rxjs/operators";
import {Products} from "./Products";


@Component({
  selector: 'app-products',
  templateUrl: 'products.component.html'
})

export class ProductsComponent implements OnInit{

  products: Products[];
  category: string;

  constructor(private route: ActivatedRoute) {
  }

  ngOnInit() {
    this.route.paramMap.pipe(switchMap(param => param.getAll('category')))
      .subscribe( i => this.products = i['products'])
  }
}
