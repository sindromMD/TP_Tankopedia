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

@Injectable()
export class AuthentificationInterceptor implements HttpInterceptor {

  constructor(private identityService: IdentityService, public route: ActivatedRoute,
    public router: Router,private toastr: ToastrService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    // let url: URL = new URL(request.url);    
    if(request.url.startsWith('http://localhost:5145') &&  request.url != 'http://localhost:5145/api/Users/Register'){
          request = request.clone ({
            setHeaders: {
              // 'Content-Type' : 'application/json', // J'ai commenté pour permettre la fonctionnalité dataForm que j'utilise lors du téléchargement d'images.
              'Authorization' : 'Bearer ' + this.identityService.getToken()
            }
          });
        }
        console.log("MON INTERCEPTOR FONCTIONNE :", request, this.identityService.getToken());
        return next.handle(request).pipe(
          catchError((error: HttpErrorResponse) => {
            this.toastr.error('You do not have the rights to perform this operation' ,  error.statusText);
            return throwError(() => new Error(error.error.message))
          })
        );
        
      }
}
