import { Component, ElementRef, Injectable, OnInit, ViewChild } from '@angular/core';
import { DataApiService } from '../services/data-api.service';
import { ActivatedRoute, Params, Router} from '@angular/router';
import { Tank } from 'src/models/Tank';
import { Nation } from 'src/models/Nation';
import { TypeTank } from 'src/models/TypeTank';
import { StrategicRole } from 'src/models/StrategicRole';
import { Characteristics } from 'src/models/Characteristics';
import { HttpEventType } from '@angular/common/http';
import { IdentityService } from '../services/identity.service';

@Component({
  selector: 'app-tank-details',
  templateUrl: './tank-details.component.html',
  styleUrls: ['./tank-details.component.css']
})
@Injectable({
  providedIn: 'root'
})
export class TankDetailsComponent implements OnInit{
  @ViewChild("image", {static:false}) image?:ElementRef;

  fileupload: any;
  varPictureId?:number; //Id image ajoutée
  oldPictureID?:number;
  progress: number=0; //progress bar

  tank ?: Tank
  tankId?: number;
  allNations: Nation[] = [];
  allTypesOfTanks: TypeTank[] = [];
  allStrategicRoles : StrategicRole[] = [];
  errorMessage: string='';
  characteristics: Characteristics = new Characteristics(0,0,0,0,0,0,0,0,0,0)
  role : string = '';

  constructor(public route: ActivatedRoute,
    public router : Router,
    private dataApiService: DataApiService,
    private identityService:IdentityService
    ){}

  async ngOnInit(): Promise<void> {
    this.route.params.subscribe(async(params:Params)=>{
      this.tankId = params['tankId'];
      
      await this.dataApiService.getTankById(params['tankId']).subscribe(
        {next:(t) =>{
        console.log(`Tank with id=${params['tankId']}`, t);
        this.tank = t;
          if(this.tank.strategicRole)
          this.tank.strategicRole.imageURL = `assets/image/role/${t.strategicRole?.name.split(' ')[0]}.svg`;
      },
      error: (err) => {
        console.error('We have an error :', err.message);
        if (err && err.message) {
          this.errorMessage = err.message;
        } else {
          // Si faux, un message d'erreur générique est affiché.
          this.errorMessage = 'An error occurred during the request. Please try again later.';
        }
      }
      });
      await this.getAllNationRequest();
      await this.getAllTypesOfTanksRequest();
      await this.getAllStrategicRolesRequest();

      this.role = this.identityService.getRoleFromToken();
    });
  }

  async getAllNationRequest():Promise<void>{
    await this.dataApiService.getNations().subscribe(n=>{
      console.log('List of nations :', n);
      this.allNations = n;
    })
  }
  async getAllTypesOfTanksRequest():Promise<void>{
    await this.dataApiService.getTankTypes().subscribe(tt=>{
      console.log('All types of tanks :', tt);
      this.allTypesOfTanks = tt;
    })
  }
  async getAllStrategicRolesRequest():Promise<void>{
    await this.dataApiService.getAllStrategicRoles().subscribe(sr=>{
      console.log('All strategic Roles:', sr);
      this.allStrategicRoles = sr;
    })
  }
//EDIT tank
  async modifyTank(tankId:number, editedTank:Tank):Promise<void>{
    await this.dataApiService.editTank(tankId,editedTank).subscribe(
    {next:(t)=>{
      console.log('Edited tank :', t);
      this.router.navigate([], { queryParams: { reload: new Date().getTime() } });
    },
    error:(err) => {
      console.error(err.message, err);
        if (err && err.message) {
          this.errorMessage = err.message;
        } else {
          // Si faux, un message d'erreur générique est affiché.
          this.errorMessage = 'An error occurred during the request. Please try again later.';
        }   
      }
    });
  }

//DELETE tank
  async confirmDeleteTank(){
    if(this.tankId != null)
    {
      await this.dataApiService.deleteTank(this.tankId).subscribe(t=>{
        if(this.tank?.pictureId)
                  this.dataApiService.deleteOldImage(this.tank.pictureId);
        console.log('You\'ve deleted the tank:: ', t);
        this.navigateToListOfAllTanks();
      })
    }
  }
  navigateToListOfAllTanks(): void {
    
    this.router.navigate(['/list-of-all-tanks/']);
  }

//PUT tank
  ConfirmUpdate(){
    if(this.tankId != null){
      if(this.tank != null){
         this.modifyTank(this.tankId, this.tank)
      }
    }
  }

  async addCharacteristics(newInfo:Characteristics):Promise<void>{
    newInfo.tankId=this.tankId?this.tankId:0;
    console.log('char modif add :',newInfo);
    await this.dataApiService.addTankCharacteristics(newInfo).subscribe(
      { next:(n) =>{
      console.log('Info :', n);
      this.ngOnInit();
    },
    error:(err) => {
      console.error('The form is not filled in correctly:',err.message);
      if(err && err.message){
        this.errorMessage = err.message;
      }else{
        this.errorMessage="Unknown error"
      }
    }
    })
  }

  //upload image
  uploadViewChild():void{
    if(this.image && this.image.nativeElement.files[0]!=null){
      let file = this.image.nativeElement.files[0];
      this.dataApiService.uploadImage(file).subscribe(
          p=>{
              if(p !=undefined){
              if(p.type===HttpEventType.UploadProgress && p.total !=undefined){
                this.progress = Math.round(100*p.loaded / p.total);
              }
              else if (p.type===HttpEventType.Response){
                console.log("photo chargée !", p.body);
                this.progress = 100;
                this.varPictureId = p.body.pictureId;
                if(this.tank && this.tank.pictureId != null)
                {
                  this.oldPictureID = this.tank.pictureId;
                  this.tank.pictureId = this.varPictureId;
                  console.log('Nation picture mod :' , this.tank)
                  this.ConfirmUpdate()
                  if(this.oldPictureID)
                  this.dataApiService.deleteOldImage(this.oldPictureID);
                }
                else  
                {
                 this.tank? this.tank.pictureId = this.varPictureId : undefined;
                  this.ConfirmUpdate()
                }
              }
            }
          });    
    }
    else
    {
      if(this.tank?.pictureId)
      {
        this.ConfirmUpdate();
      }
    }
  }

}
