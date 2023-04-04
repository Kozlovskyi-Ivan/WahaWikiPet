import { Component, OnInit } from '@angular/core';
import { FormService } from 'src/app/services/form.service';
import { AbilityEntety } from '../../enteties/UnitEntetyCRUD';

@Component({
  selector: 'app-abilityform',
  templateUrl: './abilityform.component.html',
  styleUrls: ['./abilityform.component.css']
})
export class AbilityformComponent implements OnInit {

  isEdit = false;
  isSucceedRequest = false;
  showMsg = false;

  btnEditText = "";
  msgText = "";

  abilityList: AbilityEntety[] = [];

  ability: AbilityEntety = {
    id: 0,
    name: '',
    shortName: '',
    description: ''
  }

  constructor(private formservice: FormService) {
  }

  ngOnInit(): void {
  }

  onCreateToggle() {
    this.isEdit = !this.isEdit;

    if (!this.isEdit) {
      this.ability.id = 0;
      this.ability.name = "";
      this.ability.shortName = "";
      this.ability.description = "";
    }
    else {
      this.selectBind();
    }
  }

  onSelect(Id: string) {
    this.formservice.getAbilityById(Id).subscribe(ability => {
      this.ability = ability;
    });
  }

  onDelete() {
    this.formservice.deleteAbility(this.ability.id).subscribe({
      next: () => {
        this.selectBind();
        this.showMsgBox(true, this.ability.name + ": deleted");
      },
      error: () => {
        this.showMsgBox(false, this.ability.name + ": failed to delete");
      }
    });
  }

  onSubmit() {
    if (this.isEdit) {
      this.formservice.updateAbilityById(this.ability.id, this.ability).subscribe({
        next: () => {
          this.showMsgBox(true, this.ability.name + ": edited");
        },
        error: () => {
          this.showMsgBox(false, this.ability.name + ": failed to edit");
        },
      });
    }
    else {
      this.formservice.createAbility(this.ability).subscribe({
        next: () => {
          this.showMsgBox(true, this.ability.name + ": created");
        },
        error: () => {
          this.showMsgBox(false, this.ability.name + ": failed to create");
        },
      });
    }
  }

  selectBind(){
    this.formservice.getAbilityList().subscribe(x => {
      this.abilityList = x;
      if (this.abilityList.length) {
        this.ability = this.abilityList[0];
      }
    });
  }

  showMsgBox(isSucceed: boolean, text: string) {
    this.showMsg = true;
    this.isSucceedRequest = isSucceed;
    this.msgText = text;

    setTimeout(() => {
      this.showMsg = false;
    }, 5000);
  }
}
