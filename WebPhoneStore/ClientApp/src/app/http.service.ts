import {Injectable} from "@angular/core";
import {HttpClient} from "@angular/common/http";

@Injectable()
export class HttpService{
  constructor(private http: HttpClient) {}

  getData(uri: string){
    return this.http.get(uri);
  }
}
