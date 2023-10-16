import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, map, tap, throwError } from 'rxjs';
import { Nation } from 'src/models/Nation';
import { StrategicRole } from 'src/models/StrategicRole';
import { Tank } from 'src/models/Tank';
import { TypeTank } from 'src/models/TypeTank';
import { ToastrService } from 'ngx-toastr';
import { Characteristics } from 'src/models/Characteristics';

@Injectable({
  providedIn: 'root'
})
export class DataApiService {

  constructor(public http: HttpClient, private toastr: ToastrService) { }
  nations: Nation[] = [];
  nation?: Nation;
  typeTank?:TypeTank;
  typeTanks :TypeTank[] = [];
  strategicRoles : StrategicRole[] = [];
  tanks:Tank[]=[];
  tank ?: Tank;

  getNations():Observable<Nation[]>{
    return this.http.get<Nation[]>(`http://localhost:5145/api/Nations/GetNations`).pipe(map(x => {
    return this.nations = x;
    }));
  };

  getTankTypes():Observable<TypeTank[]>{
    return this.http.get<TypeTank[]>(`http://localhost:5145/api/TypeTanks/GetTypeTanks`).pipe(map(x => {
      return this.typeTanks = x;
    }));
  }
  getListOfTanksByNation(nationId:number):Observable<Nation>{
    return this.http.get<Nation>(`http://localhost:5145/api/Nations/GetNation/`+ nationId).pipe(map(t =>{
      return this.nation = t;
    }));
  }
  getListOfTanksByType(typeId:number):Observable<TypeTank>{
    return this.http.get<TypeTank>(`http://localhost:5145/api/TypeTanks/GetTypeTank/`+typeId).pipe(map(t => {
      return this.typeTank = t;
    }));
  }
  getAllTanks():Observable<Tank[]>{
    return this.http.get<Tank[]>(`http://localhost:5145/api/Tanks/GetTanks`).pipe(map(t=>{
    return this.tanks = t;
    }));
  }
  getTankById(tankId:number):Observable<Tank>{
    return this.http.get<Tank>(`http://localhost:5145/api/Tanks/GetTank/` + tankId).pipe(map(t => {
      return this.tank = t;
    }),
    catchError((error:HttpErrorResponse)=>{
      return throwError(() => new Error(error.error.message))
    })
    );
  }
  getAllStrategicRoles():Observable<StrategicRole[]>{
    return this.http.get<StrategicRole[]>(`http://localhost:5145/api/StrategicRoles/GetStrategicRoles`).pipe(map(sr=>{
      return this.strategicRoles = sr;
    }));
  }
  //Edit
  editTank(tankId:number, editedTank:Tank):Observable<Tank>{
    return this.http.put<Tank>(`http://localhost:5145/api/Tanks/PutTank/`+ tankId, editedTank).pipe(
      catchError((error:HttpErrorResponse)=>{
        this.toastr.error( `Unable to edit tank with id : ${tankId}`, `Required fields not completed` );
        return throwError(() => new Error(error.error.message),
        )
      }),
      tap(() => {
              // Affichage d'un message de succès avec Toastr lorsque le PUT est terminé avec succès
        this.toastr.success(`Tank ${editedTank.name} edited successfully`, `Success`);
      })
    );
  }

  //Delete
  deleteTank(tankId:number):Observable<Tank>{
    return this.http.delete<Tank>(`http://localhost:5145/api/Tanks/DeleteTank/`+tankId).pipe(
      tap(() => {
        // Affichage d'un message de succès avec Toastr lorsque le DELETE est terminé avec succès
        this.toastr.success(`Tank deleted successfully`, `Success`);
      })
    );
  }

  //Create
  addTank(newTank:Tank):Observable<Tank>{
    return this.http.post<Tank>(`http://localhost:5145/api/Tanks/PostTank`, newTank).pipe(
      catchError((error:HttpErrorResponse)=>{
        this.toastr.error( 'Please fill in all required fields',`Required fields omitted!`);
        return throwError(() => new Error(error.error.message),
        )
      }),
      tap(() => {
        // Affichage d'un message de succès avec Toastr lorsque le POST est terminé avec succès
        this.toastr.success(`Tank ${newTank.name} added successfully`, `Success`);
      })
    );
  }

  //Create
addTankCharacteristics(newInfo:Characteristics):Observable<Characteristics>{
  return this.http.post<Characteristics>(`http://localhost:5145/api/Characteristics/PostCharacteristics`, newInfo).pipe(
    catchError((error:HttpErrorResponse)=>{
      this.toastr.error( 'Please fill in all required fields',`Required fields omitted!`);
      return throwError(() => new Error(error.error.message),
      )
    }),
    tap(() => {
      // Affichage d'un message de succès avec Toastr lorsque le POST est terminé avec succès
      this.toastr.success(`Characteristics for Tank with id: ${newInfo.tankId} was added successfully`, `Success`);
    })
  );
}

}
