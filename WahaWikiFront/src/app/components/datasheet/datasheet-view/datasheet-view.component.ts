import { Component, OnInit } from '@angular/core';
import { UnitServiceService } from 'src/app/services/unit-service.service';
import { Ability, Unit, UnitStat, Weapon } from '../../enteties/UnitEntety';

@Component({
  selector: 'app-datasheet-view',
  templateUrl: './datasheet-view.component.html',
  styleUrls: ['./datasheet-view.component.css']
})
export class DatasheetViewComponent implements OnInit {

  unitName: string = '';

  powerLvl: number=0;
  unit?: Unit;
  unitStatList?: UnitStat[] = [];
  unitWeaponList?: Weapon[] = [];
  unitAbilityList?: Ability[] = [];

  constructor(private unitService: UnitServiceService) { }

  ngOnInit(): void {
    this.unitService.getUnitDataSheet(2).subscribe((Unit) => {
      this.unit = Unit;
      this.unitStatList = Unit.unitStatList;
      this.unitWeaponList = Unit.weapons;
      this.unitName = Unit.name;
      this.powerLvl=Unit.power;
      this.unitAbilityList=Unit.abilities;
    })
  }

}
