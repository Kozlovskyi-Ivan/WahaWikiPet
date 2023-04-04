import { Component, Input, OnInit } from '@angular/core';
import { Weapon } from '../../enteties/UnitEntety';

@Component({
  selector: 'app-weapon-list',
  templateUrl: './weapon-list.component.html',
  styleUrls: ['./weapon-list.component.css']
})
export class WeaponListComponent implements OnInit {

  @Input('weaponList')  
  weaponList?:Weapon[];

  constructor() { }

  ngOnInit(): void {
    console.log(this.weaponList);
  }

}
