import { Component, Injectable, OnInit } from '@angular/core';
import { DataApiService } from '../services/data-api.service';
import { ActivatedRoute, Params, Router} from '@angular/router';
import { Tank } from 'src/models/Tank';
import { Nation } from 'src/models/Nation';
import { TypeTank } from 'src/models/TypeTank';
import { StrategicRole } from 'src/models/StrategicRole';

@Component({
  selector: 'app-tank-details',
  templateUrl: './tank-details.component.html',
  styleUrls: ['./tank-details.component.css']
})
@Injectable({
  providedIn: 'root'
})
export class TankDetailsComponent implements OnInit{

  tank ?: Tank
  tankId?: number;
  allNations: Nation[] = [];
  allTypesOfTanks: TypeTank[] = [];
  allStrategicRoles : StrategicRole[] = [];
  errorMessage: string='';

  constructor(public route: ActivatedRoute,
    public router : Router,
    private dataApiService: DataApiService){}

  async ngOnInit(): Promise<void> {
    this.route.params.subscribe(async(params:Params)=>{
      this.tankId = params['tankId'];
      
      await this.dataApiService.getTankById(params['tankId']).subscribe(
        {next:(t) =>{
        console.log(`Tank with id=${params['tankId']}`, t);
        this.tank = t;
      },
      error: (err) => {
        console.error(err.me, err);
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

  async modifyTank(tankId:number, editedTank:Tank):Promise<void>{
    await this.dataApiService.editTank(tankId,editedTank).subscribe(t=>{
      console.log('Edited tank :', t);
      this.ngOnInit();
    })
  }

  async confirmDeleteTank(){
    if(this.tankId != null)
    {
      await this.dataApiService.deleteTank(this.tankId).subscribe(t=>{
        console.log('You\'ve deleted the tank:: ', t);
        this.navigateToListOfAllTanks();
      })
    }
  }
  navigateToListOfAllTanks(): void {
    
    this.router.navigate(['/list-of-all-tanks/']);
  }

  ConfirmUpdate(){
    if(this.tankId != null){
      if(this.tank != null){
         this.modifyTank(this.tankId, this.tank)
      }
    }
  }
}
