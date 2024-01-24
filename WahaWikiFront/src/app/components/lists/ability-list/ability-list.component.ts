import { Component, OnInit, ViewChild } from '@angular/core';
import { ListAbilityService } from 'src/app/services/list-ability.service';
import { AbilityEntety } from '../../enteties/UnitEntetyCRUD';

@Component({
  selector: 'app-ability-list',
  templateUrl: './ability-list.component.html',
  styleUrls: ['./ability-list.component.css']
})
export class AbilityListComponent {

  isVisibleEditForm: boolean = false;
  isVisibleCreateForm: boolean = false;
  abilityList: AbilityEntety[] = [];

  ability: AbilityEntety = {
    id: -1,
    name: '',
    shortName: '',
    description: ''
  }
  
  constructor(private service: ListAbilityService) {
    service.getAbilityList().subscribe(list => {
      this.abilityList = list;
    })
  }

  refreshList = (): void => {
    this.service.getAbilityList().subscribe(list => {
      this.abilityList = list;
    })
  }
  setVisibleEditForm = (visible: boolean): void => {
    this.isVisibleEditForm = visible;
  }
  setVisibleCreateForm = (visible: boolean): void => {
    this.isVisibleCreateForm = visible;
  }

  editAbility = (ability:AbilityEntety):void=>{
    this.ability=ability;
    this.setVisibleEditForm(true);
  }

  deleteAbility = (id: number): void => {
    this.service.deleteAbility(id).subscribe({
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
