import { Component, OnInit } from '@angular/core';
import { DataApiService } from '../services/data-api.service';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { User } from 'src/models/User';
import { IdentityService } from '../services/identity.service';

@Component({
  selector: 'app-login-register',
  templateUrl: './login-register.component.html',
  styleUrls: ['./login-register.component.css']
})
export class LoginRegisterComponent implements OnInit{
 
  // registerActive : boolean = false;
  // loginActive : boolean = false;
  
  loginOuRegistration :string = '';
  user : User =new User();
  errorMessage: string = '';
  token:any;

  constructor(
    public route: ActivatedRoute,
    public router: Router,
    private identityService :IdentityService
  ){}

  async ngOnInit(): Promise<void> {
    this.route.params.subscribe(async(params:Params)=>{
      this.loginOuRegistration = params['register'] || params['login'];
      this.token = this.identityService.getToken();
    })
  }

  // public changeRegisterOnClick(): void{
  //   this.registerActive = !this.registerActive;
  // }
  // public changeLoginOnClick(): void{
  //   this.loginActive = !this.loginActive;
  // }

  //Méthode d'enregistrement de l'utilisateur
  async registerNewUser(newUser:User):Promise<any>{
    await this.identityService.registerUser(newUser).subscribe(
      { next:(nu) =>{
      // console.log('User:', nu,newUser);
      this.navigateToLogin()
    },
    error:(err) => {
        console.error('We have an error :' + err.error.message , err);
        if(err && err.message){
          this.errorMessage = err.error.message;
        }else{
          this.errorMessage="Unknown error"
        }
      }
    })
  }

//Méthode de connexion de l'utilisateur
  async loginUser(user:User):Promise<any>{
    await this.identityService.loginUser(user).subscribe(
      { next:(u) =>{
      // console.log('User:',u, user);
         // rafraîchir la page pour modifier l'affichage des boutons d'en-tête en cas de connexion réussie.
        setTimeout(function () {
          location.reload();
        }, 2000); 

    },
    error:(err) => {
        console.error('We have an error :' + err.error.message , err);
        if(err && err.message){
          this.errorMessage = err.error.message;
        }else{
          this.errorMessage="Unknown error"
        }
      }
    })
  }
  navigateToLogin():void {
    this.router.navigate(['/app-login/', 'login'])
  }
  navigateToHome():void {
    this.router.navigate(['home'])
  }
  
}
