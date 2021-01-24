import {Component, OnInit} from "@angular/core";
import {HttpService} from "../http.service";
import {Router} from "@angular/router";
import {Category} from "./Category";

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  providers: [HttpService]
})
export class HeaderComponent implements OnInit{
  categories: Category[];
  isMenuVisible: boolean;

  constructor(private http: HttpService, private route: Router) {}

  ngOnInit() {
    this.http.getData('products/categories').subscribe(i => this.categories = i["categories"])
  }

  isVisible(): boolean{
    if (this.isMenuVisible)
      return false
    return this.route.url != '/';
  }

  showLinks(): void{
    if (this.route.url != '/'){
      this.isMenuVisible = this.isMenuVisible != true;
    }
  }
}
