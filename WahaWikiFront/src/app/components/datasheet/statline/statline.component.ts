import { Component, Input, OnInit } from '@angular/core';
import { UnitStat } from '../../enteties/UnitEntety';

@Component({
  selector: 'app-statline',
  templateUrl: './statline.component.html',
  styleUrls: ['./statline.component.css']
})
export class StatlineComponent implements OnInit {

  @Input('statLine') 
  statLineList?:UnitStat[];

  constructor() { }

  ngOnInit(): void {
  }

}
