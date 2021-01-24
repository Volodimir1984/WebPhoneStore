import {Component, Input} from "@angular/core";
import {Product} from "../products/Product";

@Component({
  selector: 'app-cartProduct',
  templateUrl: 'cartProduct.component.html',
  styleUrls: ['cartProduct.component.css'],
})

export class CartProductComponent{
  @Input() product: Product;
  visibleDescription: boolean = true;

  isVisible(): void{
    this.visibleDescription = !this.visibleDescription;
  }

}
