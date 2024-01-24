import { WeaponAbilityEntety } from '../../enteties/UnitEntetyCRUD';
import { ListWeaponAbilityService } from './../../../services/list-weapon-ability.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-weapon-ability-list',
  templateUrl: './weapon-ability-list.component.html',
  styleUrls: ['./weapon-ability-list.component.css']
})
export class WeaponAbilityListComponent {

  isVisibleEditForm: boolean = false;
  isVisibleCreateForm: boolean = false;
  
  weaponAbilityList: WeaponAbilityEntety[] = [];

  ability: WeaponAbilityEntety = {
    id: -1,
    name: '',
    shortName: '',
    description: ''
  }

  constructor(private service: ListWeaponAbilityService) {
    service.getWeaponAbilityList().subscribe(list => {
      this.weaponAbilityList = list;
    });
  }

  refreshList = (): void => {
    this.service.getWeaponAbilityList().subscribe(list => {
      this.weaponAbilityList = list;
    })
  }
  setVisibleEditForm = (visible: boolean): void => {
    this.isVisibleEditForm = visible;
  }
  setVisibleCreateForm = (visible: boolean): void => {
    this.isVisibleCreateForm = visible;
  }

  editAbility = (ability:WeaponAbilityEntety):void=>{
    this.ability=ability;
    this.setVisibleEditForm(true);
  }

  deleteWeaponAbility = (id: number): void => {
    this.service.deleteWeaponAbility(id).subscribe({
      next: () => {
        console.log("delete id:" + id);
      },
      error: () => {
        console.log("error id:" + id);
      },
      complete: () => {
        this.refreshList();
      },
    });
  }

}
