import { Component, OnInit } from '@angular/core';
import { IdentityService } from './services/identity.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'TP_Tankopedia_Ng';
  token:any;

  constructor(
    private identityService : IdentityService, 
    public route: ActivatedRoute,
    public router: Router,){}
    
  ngOnInit(): void {
    this.token = this.identityService.getToken();
  }

  onLogout() {
    // Appel de la méthode de déconnexion 
    this.identityService.disconnectUser();
    this.token = this.identityService.getToken();
    this.navigateToHome();
  }
  navigateToHome():void {
    this.router.navigate(['home/'])
  }
}
