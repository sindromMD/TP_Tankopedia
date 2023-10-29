import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { BehaviorSubject, Observable, catchError, tap, throwError } from 'rxjs';
import { User } from 'src/models/User';

const apiURL = "http://localhost:5145/api/"

@Injectable({
  providedIn: 'root'
})
export class IdentityService {

  // private tokenSubject: BehaviorSubject<string | null> = new BehaviorSubject<string | null>(localStorage.getItem('authToken_Tankopedia'));
  // public token$: Observable<string | null> = this.tokenSubject.asObservable();
  
  constructor(public http: HttpClient, private toastr: ToastrService) { }

// méthode d'enregistrement d'un nouvel utilisateur
  registerUser(newUser : User):Observable<any>{
    return this.http.post<any>(apiURL + `Users/Register`, newUser).pipe(
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
  
  // la méthode qui permet de connecter l'utilisateur enregistré
  loginUser(user : User):Observable<any>{
    return this.http.post<any>(apiURL + `Users/Login`, user).pipe(
      catchError((error:HttpErrorResponse)=>{
        this.toastr.error( error.error.message ,error.statusText);
        return throwError(() => new Error(error.error.message),
        )
      }),
      tap((x) => {
        localStorage.setItem("authToken_Tankopedia", x.token);
        this.toastr.success(`Welcome ${user.username} you are logged in.`, `Success`)
      })
    )
  }
  
// Disconnet user
  disconnectUser(): void {
    // Retirer le token de localStorage
    localStorage.removeItem("authToken_Tankopedia");
    this.toastr.success(`You have been successfully disconnected`, `Success`)
  }
  getToken():any{
    return localStorage.getItem("authToken_Tankopedia");
  }
}


