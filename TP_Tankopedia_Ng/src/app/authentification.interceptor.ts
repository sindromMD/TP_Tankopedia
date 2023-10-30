import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { IdentityService } from './services/identity.service';

@Injectable()
export class AuthentificationInterceptor implements HttpInterceptor {

  constructor(private identityService: IdentityService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    let url: URL = new URL(request.url);    
    if(url.host == "http://localhost:5145" &&  request.url != 'http://localhost:5145/api/Users/Register'){
          request = request.clone ({
            setHeaders: {
              'Content-Type' : 'application/json',
              'Authorization' : 'Bearer ' + this.identityService.getToken()
            }
          });
        }
    
        console.log("MON INTERCEPTOR FONCTIONNE :", request, this.identityService.getToken());
        return next.handle(request);
      }
}
