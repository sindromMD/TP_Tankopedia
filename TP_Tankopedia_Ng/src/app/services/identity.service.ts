import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt'; //decode token
import { ToastrService } from 'ngx-toastr';
import { BehaviorSubject, Observable, catchError, tap, throwError } from 'rxjs';
import { User } from 'src/models/User';

const apiURL = "http://localhost:5145/api/"

@Injectable({
  providedIn: 'root'
})
export class IdentityService {

  private name$ = new BehaviorSubject<string>("");
  private role$ = new BehaviorSubject<string>("");
  private userPayload: any;

  constructor(public http: HttpClient, private toastr: ToastrService) {
    this.userPayload = this.decodedToken();
  }
  //get Role (streamOfData)
  public getRoleFromTankopedia() {
    return this.role$.asObservable();
  }
  //Set Role
  public setRoleForTankopedia(role: string) {
    this.role$.next(role)
  }

  //Get Name (streamOfData)
  public getNameFromTankopedia() {
    return this.name$.asObservable()
  }

  //Set Name  
  public setNameForTankopedia(name: string) {
    this.name$.next(name)
  }
  //return decoded token
  decodedToken() {
    const jwtHelper = new JwtHelperService();
    const token = this.getToken()!;
    return jwtHelper.decodeToken(token)
  }

  getNameFromToken() {
    if (this.userPayload)
      return this.userPayload.name;
  }

  getRoleFromToken() {
    if (this.userPayload)
      return this.userPayload.role;
  }

  // méthode d'enregistrement d'un nouvel utilisateur
  registerUser(newUser: User): Observable<any> {
    return this.http.post<any>(apiURL + `Users/Register`, newUser).pipe(
      catchError((error: HttpErrorResponse) => {
        this.toastr.error(error.error.message, error.statusText);
        return throwError(() => new Error(error.error.message),
        )
      }),
      tap(() => {
        this.toastr.success(`User ${newUser.username} successfully added`, `Success`)
      })
    )
  }

  // la méthode qui permet de connecter l'utilisateur enregistré
  loginUser(user: User): Observable<any> {
    return this.http.post<any>(apiURL + `Users/Login`, user).pipe(
      catchError((error: HttpErrorResponse) => {
        this.toastr.error(error.error.message, error.statusText);
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
  getToken(): any {
    return localStorage.getItem("authToken_Tankopedia");
  }
}


