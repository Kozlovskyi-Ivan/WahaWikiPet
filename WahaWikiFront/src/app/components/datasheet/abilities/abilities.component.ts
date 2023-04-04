import { Component,Input, OnInit } from '@angular/core';
import { Ability } from '../../enteties/UnitEntety';

@Component({
  selector: 'app-abilities',
  templateUrl: './abilities.component.html',
  styleUrls: ['./abilities.component.css']
})
export class AbilitiesComponent implements OnInit {

  @Input('AbilityList')
  abilityList?:Ability[] = [];

  constructor() { }

  ngOnInit(): void {
  }

}
