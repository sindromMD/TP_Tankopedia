import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Observable, catchError, tap, throwError } from 'rxjs';
import { User } from 'src/models/User';

const apiURL = "http://localhost:5145/api/"

@Injectable({
  providedIn: 'root'
})
export class IdentityService {

  constructor(public http: HttpClient, private toastr: ToastrService) { }

// méthode d'enregistrement d'un nouvel utilisateur
  registerUser(newUser : User):Observable<User>{
    return this.http.post<User>(apiURL + `Users/Register`, newUser).pipe(
      catchError((error:HttpErrorResponse)=>{
        this.toastr.error( error.error.message ,error.statusText);
        return throwError(() => new Error(error.error.message),
        )
      }),
      tap(() => {
        this.toastr.success(`User ${newUser.username} successfully added`, `Success`)
      })
    )
  }
  
}


