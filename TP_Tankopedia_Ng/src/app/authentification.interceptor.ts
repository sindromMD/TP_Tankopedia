import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { IdentityService } from './services/identity.service';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

const ApiUrl = 'http://localhost:5145'
@Injectable()
export class AuthentificationInterceptor implements HttpInterceptor {

  constructor(private identityService: IdentityService, public route: ActivatedRoute,
    public router: Router, private toastr: ToastrService) { }

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {

    if (request.url.startsWith(ApiUrl) && !request.url.match(ApiUrl + '/api/Users/.*')) {
      request = request.clone({
        setHeaders: {
          // 'Content-Type' : 'application/json', // J'ai commenté pour permettre la fonctionnalité dataForm que j'utilise lors du téléchargement d'images.
          'Authorization': 'Bearer ' + this.identityService.getToken()
        }
      });
      console.log("MON INTERCEPTOR FONCTIONNE :", request);
    }

    return next.handle(request).pipe(
      catchError((error: HttpErrorResponse) => {
        if (error.status === 401) {
          this.toastr.error('You do not have the rights to perform this operation', error.statusText);
        }
        else this.toastr.error(error.error.message, error.statusText);
        return throwError(() => new Error(error.error.message))
      })
    );

  }
}
