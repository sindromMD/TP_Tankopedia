import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, forkJoin, map, mergeMap, switchMap, tap, throwError } from 'rxjs';
import { Nation } from 'src/models/Nation';
import { StrategicRole } from 'src/models/StrategicRole';
import { Tank } from 'src/models/Tank';
import { TypeTank } from 'src/models/TypeTank';
import { ToastrService } from 'ngx-toastr';
import { Characteristics } from 'src/models/Characteristics';

const apiURL = "http://localhost:5145/api/"

@Injectable({
  providedIn: 'root'
})
export class DataApiService {

  constructor(public http: HttpClient, private toastr: ToastrService) { }
  nations: Nation[] = [];
  nation?: Nation;
  typeTank?:TypeTank;
  typeTanks :TypeTank[] = [];
  stratecRole ?: StrategicRole;
  strategicRoles : StrategicRole[] = [];
  tanks:Tank[]=[];
  tank ?: Tank;

  getNations():Observable<Nation[]>{
    return this.http.get<Nation[]>(apiURL + `Nations/GetNations`).pipe(map(x => {
    return this.nations = x;
    }));
  };

  getTankTypes():Observable<TypeTank[]>{
    return this.http.get<TypeTank[]>(apiURL + `TypeTanks/GetTypeTanks`).pipe(map(x => {
      return this.typeTanks = x;
    }));
  }
  getStrategicRoleById(strategicRoleIdId:number):Observable<StrategicRole>{
    return this.http.get<StrategicRole>(apiURL + `StrategicRoles/GetStrategicRole/`+strategicRoleIdId).pipe(map(st => {
      return this.stratecRole = st;
    }));
  }
  getNationById(nationId:number):Observable<Nation>{
    return this.http.get<Nation>(apiURL + `Nations/GetNation/`+ nationId).pipe(map(t =>{
      return this.nation = t;
    }));
  }
  getTypeTankById(typeId:number):Observable<TypeTank>{
    return this.http.get<TypeTank>(apiURL + `TypeTanks/GetTypeTank/`+typeId).pipe(map(t => {
      return this.typeTank = t;
    }));
  }
    //Sous-requêtes HTTP + 2 parametre
    getTanksFileredByNationAndOrRole(nationId: number, roleId:number): Observable<Tank[]> {
      return this.http.get<Tank[]>(apiURL + `Tanks/GetTanksFileredByNationAndRole/${nationId}/${roleId}`).pipe(
        switchMap(n => {
          let listTanksWithRole = n.map(tank => {
            return this.getTankById(tank.id).pipe(
              map(t => {
                tank = t;              // Ajouter un objet strategicRole à chaque tank
                return tank;
              })
            );
          });
          return forkJoin(listTanksWithRole).pipe(        // forkJoin pour attendre toutes les demandes S.Role
            map(tl => {
              n = tl; // Mise à jour de la liste des tank
              return n;
            })
          );
        })
      );
    }

        //Sous-requêtes HTTP + 2 parametre
        getTanksFileredByTypeAndOrRole(typeId: number, roleId:number): Observable<Tank[]> {
          return this.http.get<Tank[]>(apiURL + `Tanks/GetTanksFileredByTypeTankAndRole/${typeId}/${roleId}`).pipe(
            switchMap(n => {
              let listTanksWithRole = n.map(tank => {
                return this.getTankById(tank.id).pipe(
                  map(t => {
                    tank = t;              // Ajouter un objet strategicRole à chaque tank
                    return tank;
                  })
                );
              });
              return forkJoin(listTanksWithRole).pipe(        // forkJoin pour attendre toutes les demandes S.Role
                map(tl => {
                  n = tl; // Mise à jour de la liste des tank
                  return n;
                })
              );
            })
          )
        }
        //Sous-requêtes HTTP
  getAllTanks():Observable<Tank[]>{
    return this.http.get<Tank[]>(apiURL + `Tanks/GetTanks`).pipe(
      switchMap(all => {
      let listTanksWithRole = all.map(tank => {
        return this.getTankById(tank.id).pipe(
          map(t => {
            tank = t;              // Ajouter un objet strategicRole à chaque tank
            return tank;
          })
          // ,
          // catchError((error:HttpErrorResponse)=>{
          //   this.toastr.error( error.error.message ,error.statusText );
          //   return throwError(() => new Error(error.error),
          //   )
          // })
        );
      });
      return forkJoin(listTanksWithRole).pipe(        // forkJoin pour attendre toutes les demandes S.Role
        map(tlmod => {
          all = tlmod; // Mise à jour de la liste des tank
          return all;
        })
      );
    })
  );
}
  getAllTanksBasic ():Observable<Tank[]>{
    return this.http.get<Tank[]>(apiURL + `Tanks/GetTanks`).pipe(map(t=>{
    return this.tanks = t;
    }));
  }
  getTankById(tankId:number):Observable<Tank>{
    return this.http.get<Tank>(apiURL + `Tanks/GetTank/` + tankId).pipe(map(t => {
      return this.tank = t;
    }),
    catchError((error:HttpErrorResponse)=>{
      return throwError(() => new Error(error.error.message))
    })
    );
  }
  getAllStrategicRoles():Observable<StrategicRole[]>{
    return this.http.get<StrategicRole[]>(apiURL + `StrategicRoles/GetStrategicRoles`).pipe(map(sr=>{
      return this.strategicRoles = sr;
    }));
  }
  //Edit
  editTank(tankId:number, editedTank:Tank):Observable<Tank>{
    return this.http.put<Tank>(apiURL + `Tanks/PutTank/`+ tankId, editedTank).pipe(
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
    return this.http.delete<Tank>(apiURL + `Tanks/DeleteTank/`+tankId).pipe(
      tap(() => {
        // Affichage d'un message de succès avec Toastr lorsque le DELETE est terminé avec succès
        this.toastr.success(`Tank deleted successfully`, `Success`);
      })
    );
  }

    //Delete
  deleteNation(selectedNation:Nation):Observable<Nation>{
    return this.http.delete<Nation>(apiURL + `Nations/DeleteNation/`+ selectedNation.id).pipe(
      catchError((error:HttpErrorResponse)=>{
        this.toastr.error( error.error.message ,error.statusText );
        return throwError(() => new Error(error.error.message),
        )
      }),
      tap(() => {
        this.toastr.success(`Nation ${selectedNation.name} deleted successfully`, `Success`);
      })
    );
  }

    //Create
    addNation(newNation:Nation):Observable<Nation>{
      return this.http.post<Nation>(apiURL + `Nations/PostNation`, newNation).pipe(
        catchError((error:HttpErrorResponse)=>{
          this.toastr.error( error.error.message ,error.statusText);
          return throwError(() => new Error(error.error.message),
          )
        }),
        tap(() => {
          // Affichage d'un message de succès avec Toastr lorsque le POST est terminé avec succès
          this.toastr.success(`Tank ${newNation.name} added successfully`, `Success`);
        })
      );
    }
  //Create
  addTank(newTank:Tank):Observable<Tank>{
    return this.http.post<Tank>(apiURL + `Tanks/PostTank`, newTank).pipe(
      catchError((error:HttpErrorResponse)=>{
        this.toastr.error( error.error.message ,error.statusText );
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
  return this.http.post<Characteristics>(apiURL + `Characteristics/PostCharacteristics`, newInfo).pipe(
    catchError((error:HttpErrorResponse)=>{
      this.toastr.error( error.error.message ,error.statusText );
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
