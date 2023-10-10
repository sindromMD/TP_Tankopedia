import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { Nation } from 'src/models/Nation';
import { TypeTank } from 'src/models/TypeTank';

@Injectable({
  providedIn: 'root'
})
export class DataApiService {

  constructor(public http: HttpClient) { }
  nations: Nation[] = [];
  typeTanks :TypeTank[] = [];

  getNations():Observable<Nation[]>{
    return this.http.get<Nation[]>(`http://localhost:5145/api/Nations/GetNations`).pipe(map(x => {
    return this.nations = x;
    }));
  };

  getTankTypes():Observable<TypeTank[]>{
    return this.http.get<TypeTank[]>(`http://localhost:5145/api/TypeTanks/GetTypeTanks`).pipe(map(x => {
      return this.typeTanks = x;
    }))
  }
}
