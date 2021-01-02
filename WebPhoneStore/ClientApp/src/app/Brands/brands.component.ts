import {Component, Input} from "@angular/core";
import {Category} from "../header/Category";
import {Brand} from "../header/Brand";

@Component({
  selector: 'app-brands',
  templateUrl: 'brands.component.html',
  styleUrls: ['brands.component.css']
})

export class BrandsComponent{
  isHidden: boolean = true;
  @Input() brands: Brand[];
  @Input() category: Category;

  setHidden(): void{
    this.isHidden = false;
  }

  setHiddenNot(){
    this.isHidden = true;
  }
}
