import {Component, OnInit} from "@angular/core";
import {HttpService} from "../http.service";
import {Category} from "./Category";

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  providers: [HttpService]
})
export class HeaderComponent implements OnInit{
  categories: Category[];

  constructor(private http: HttpService) {}

  ngOnInit() {
    this.http.getData('products/categories').subscribe(i => this.categories = i["categories"])
  }
}
