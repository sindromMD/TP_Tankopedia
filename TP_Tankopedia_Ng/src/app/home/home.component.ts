import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { DataApiService } from '../services/data-api.service';
import { Router } from '@angular/router';
import { Nation } from 'src/models/Nation';
import { TypeTank } from 'src/models/TypeTank';
import { StrategicRole } from 'src/models/StrategicRole';
import { HttpClient, HttpEventType } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{
  @ViewChild("image", {static:false}) image?:ElementRef;

  fileupload: any;
  varPictureId?:number; //Id image ajoutée
  progress: number=0; //progress bar

  nations: Nation[] = []
  typeTanks : TypeTank[] = []
  strategicRoles: StrategicRole[]=[];
  strategicRoleId:number=0;
  errorMessage: string='';
  newNation:Nation = new Nation(0,'');
  modNation:Nation = new Nation(0,'');
  oldPictureID?:number;
  constructor(public dataApiService : DataApiService, private router: Router, public http : HttpClient){}
  
  ngOnInit(): void {
   this.dataApiService.getNations().subscribe(x => {
    this.nations = x;
    console.log(this.nations);
   });
   this.dataApiService.getTankTypes().subscribe(y => {
    this.typeTanks = y;
    console.log(this.typeTanks);
   });
   this.dataApiService.getAllStrategicRoles().subscribe(sr =>{
    this.strategicRoles = sr
   })
  }

  //DELETE nation
  async confirmDeleteNation(nation:Nation){
      await this.dataApiService.deleteNation(nation).subscribe(t=>{
        if(nation.pictureId)
        this.dataApiService.deleteOldImage(nation.pictureId)
        console.log('You\'ve deleted the nation:: ', t);
        
        this.ngOnInit();
      });
    }
  //CREATE Nation
  async addNewNation(nation:Nation):Promise<void>{
    await this.dataApiService.addNation(nation).subscribe(
      { next:(n) =>{
      console.log('New nation:', n);
      this.ngOnInit();
    },
    error:(err) => {
      console.error('We have an error :',err.message);
      if(err && err.message){
        this.errorMessage = err.message;
      }else{
        this.errorMessage="Unknown error"
      }
    }
    });
  } 

  //upload image
  uploadViewChild():void{
    if(this.image != undefined){
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
                if(this.modNation.pictureId != null)
                {
                  this.oldPictureID = this.modNation.pictureId;
                  this.modNation.pictureId = this.varPictureId;
                  // console.log('Nation picture mod :' , this.newNation)
                  // this.UpdateNation(this.modNation.id,this.modNation)
                  // if(this.oldPictureID)
                  // this.dataApiService.deleteOldImage(this.oldPictureID);
                }
                else
                {
                  this.newNation.pictureId = this.varPictureId;
                  this.addNewNation(this.newNation);
                }
              }
            }
          });    
    }
  }
// getModNation(nation:Nation)
// {
//   this.modNation = nation;
//   console.log('modNation', nation);

// }

//   UpdateNation(nationID:number,nationMod:Nation){

//     this.http.put<Nation>('http://localhost:5096/api/Villas/' + nationID, nationMod ).subscribe(n=>{
//       console.log('Nation modifie :', n)
//     })
//     }
}
