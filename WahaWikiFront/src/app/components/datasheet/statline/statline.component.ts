import { Component, OnInit } from '@angular/core';
import { IStatLine } from 'src/app/entities/entities';

@Component({
  selector: 'app-statline',
  templateUrl: './statline.component.html',
  styleUrls: ['./statline.component.css']
})
export class StatlineComponent implements OnInit {

  statLines:IStatLine={
    ModelName:"Test",
    Number: 0,
    Move: 6,
    WS: 3,
    BS: 4,
    Strength: 5,
    Toughness: 4,
    Wounds: 3,
    Attacks: 2,
    Leadership: 9,
    SavingThrows: 2
  };
  
  constructor() { }

  ngOnInit(): void {
  }

}
