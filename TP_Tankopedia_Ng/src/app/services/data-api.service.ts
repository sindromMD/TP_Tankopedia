import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { Nation } from 'src/models/Nation';
import { Tank } from 'src/models/Tank';
import { TypeTank } from 'src/models/TypeTank';

@Injectable({
  providedIn: 'root'
})
export class DataApiService {

  constructor(public http: HttpClient) { }
  nations: Nation[] = [];
  nation?: Nation;
  typeTank?:TypeTank;
  typeTanks :TypeTank[] = [];
  tanks:Tank[]=[];
 

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
  getListOfTanksByNation(nationId:number):Observable<Nation>{
    return this.http.get<Nation>(`http://localhost:5145/api/Nations/GetNation/`+ nationId).pipe(map(t =>{
      return this.nation = t;
    }))
  }
  getListOfTanksByType(typeId:number):Observable<TypeTank>{
    return this.http.get<TypeTank>(`https://localhost:7246/api/TypeTanks/GetTypeTank/`+typeId).pipe(map(t => {
      return this.typeTank = t;
    }))
  }
  getAllTanks():Observable<Tank[]>{
    return this.http.get<Tank[]>(`https://localhost:7246/api/Tanks/GetTanks`).pipe(map(t=>{
    return this.tanks = t;
    }))
  }
}
