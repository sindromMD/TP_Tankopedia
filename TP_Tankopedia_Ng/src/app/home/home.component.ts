import { Component, OnInit } from '@angular/core';
import { DataApiService } from '../services/data-api.service';
import { Router } from '@angular/router';
import { Nation } from 'src/models/Nation';
import { TypeTank } from 'src/models/TypeTank';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{
  nations: Nation[] = []
  typeTanks : TypeTank[] = []
  constructor(public dataApiService : DataApiService, private router: Router){}
  
  ngOnInit(): void {
   this.dataApiService.getNations().subscribe(x => {
    this.nations = x;
    console.log(this.nations);
   });
   this.dataApiService.getTankTypes().subscribe(y => {
    this.typeTanks = y;
    console.log(this.typeTanks);
   })
  }

  //DELETE nation
  async confirmDeleteNation(nation:Nation){
      await this.dataApiService.deleteNation(nation).subscribe(t=>{
        console.log('You\'ve deleted the nation:: ', t);
        this.ngOnInit();
      })
    }

}
