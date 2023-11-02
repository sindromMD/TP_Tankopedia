import { Component, OnInit } from '@angular/core';
import { IdentityService } from './services/identity.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'TP_Tankopedia_Ng';
  token: any;
  public name: string = "";
  public role: string = "";
  constructor(
    private identityService: IdentityService,
    public route: ActivatedRoute,
    public router: Router,) { }

  ngOnInit() {
    this.token = this.identityService.getToken();
    this.identityService.getNameFromTankopedia().subscribe(val => {
      let nameFromToken = this.identityService.getNameFromToken();
      this.name = val || nameFromToken;
    });
    this.identityService.getRoleFromTankopedia().subscribe(val => {
      const roleFromToken = this.identityService.getRoleFromToken()
      this.role = val || roleFromToken;
    })
  }

  onLogout() {
    // Appel de la méthode de déconnexion 
    this.identityService.disconnectUser();
    this.token = this.identityService.getToken();
    this.navigateToHome();
    setTimeout(function () {
      location.reload();
    }, 2000);
  }
  navigateToHome(): void {
    this.router.navigate(['home/'])
  }
}
