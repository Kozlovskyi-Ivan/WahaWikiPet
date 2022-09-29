import { Component, OnInit } from '@angular/core';
import { IWeaponStatLine } from 'src/app/entities/entities';

@Component({
  selector: 'app-weapon-list',
  templateUrl: './weapon-list.component.html',
  styleUrls: ['./weapon-list.component.css']
})
export class WeaponListComponent implements OnInit {

  WeaponList:IWeaponStatLine={
    WeaponName: 'Drakkis',
    Range: 12,
    Type: 'Assault D6',
    Strength: 4,
    AP: 1,
    Damage: 1,
    Abilities: '-'
  };
  constructor() { }

  ngOnInit(): void {
  }

}
