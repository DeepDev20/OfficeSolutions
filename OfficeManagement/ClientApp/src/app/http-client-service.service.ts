import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpClientServiceService {

  constructor(private http: HttpClient) {

   }
  public GetData(url)
   {
    return this.http.get(url);
   }
  public PostData(url,body)
   {
     return this.http.post(url,body);
   }
}
