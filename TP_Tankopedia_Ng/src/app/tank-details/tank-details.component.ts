import { Component, OnInit } from '@angular/core';
import { DataApiService } from '../services/data-api.service';
import { ActivatedRoute, Params } from '@angular/router';
import { Tank } from 'src/models/Tank';

@Component({
  selector: 'app-tank-details',
  templateUrl: './tank-details.component.html',
  styleUrls: ['./tank-details.component.css']
})
export class TankDetailsComponent implements OnInit{

  tank! : Tank

  constructor(public route: ActivatedRoute,
    private dataApiService: DataApiService){}

  async ngOnInit(): Promise<void> {
    this.route.params.subscribe(async(params:Params)=>{

      await this.dataApiService.getTankById(params['tankId']).subscribe(t =>{
        console.log(`Tank with id=${params['tankId']}`, t);
        this.tank = t;
        
      })
    });
  }

//  async getTankByIdRequest(tankId:number):Promise<void> {
//   await this.dataApiService.getTankById(tankId).subscribe(t =>{
//     console.log(`Tank with id=${tankId}`, t);
//     this.tank = t;
//   });
//  }
}
