import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { FormService } from 'src/app/services/form.service';
import { AbilityEntety } from '../../enteties/UnitEntetyCRUD';

@Component({
  selector: 'app-abilityform',
  templateUrl: './abilityform.component.html',
  styleUrls: ['./abilityform.component.css']
})
export class AbilityformComponent implements OnInit {

  form: FormGroup;

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

  constructor(private formservice: FormService, private formBuilder: FormBuilder) {
    this.form = this.formBuilder.group({
      id: [null],
      name: [null, [Validators.required]],
      shortName: [null, [Validators.required]],
      description: [null, [Validators.required]],
      selAbility: [null]
    });

    this.form.get('name')?.setValue("Games");

    this.form.patchValue({
      shortName:'asd'
    });
  }
  
  private get name(){
    return this.form.get('name')?.value;
  }

  private set name(name: string){
    this.form.get('name')?.setValue(name);
  }

  ngOnInit(): void {
  }

  onCreateToggle() {
    this.isEdit = !this.isEdit;
    if (!this.isEdit) {
      this.form.get('id')?.setValue(0);
      this.form.get('name')?.setValue('asd');
      this.form.get('shortName')?.setValue('');
      this.form.get('description')?.setValue('');

      console.log(this.name)
      this.name='fff';
      console.log(this.name)
      
      // this.ability.id = 0;
      // this.ability.name = "";
      // this.ability.shortName = "";
      // this.ability.description = "";

      this.form.get('selAbility')?.removeValidators(Validators.required);
    }
    else {
      this.selectBind();
      this.form.get('selAbility')?.addValidators(Validators.required);
    }
    this.form.get('selAbility')?.updateValueAndValidity();
  }

  onSelect(Id: string) {
    this.formservice.getAbilityById(Id).subscribe(ability => {
      this.ability = ability;
    });
  }

  onDelete() {
    // this.formservice.deleteAbility(this.ability?.id).subscribe({
    //   next: () => {
    //     this.selectBind();
    //     this.showMsgBox(true, this.ability.name + ": deleted");
    //   },
    //   error: () => {
    //     this.showMsgBox(false, this.ability.name + ": failed to delete");
    //   }
    // });
  }

  onSubmit() {
    // if (this.isEdit) {
    //   this.formservice.updateAbilityById(this.ability.id, this.ability).subscribe({
    //     next: () => {
    //       this.showMsgBox(true, this.ability.name + ": edited");
    //     },
    //     error: () => {
    //       this.showMsgBox(false, this.ability.name + ": failed to edit");
    //     },
    //   });
    // }
    // else {
    //   this.formservice.createAbility(this.ability).subscribe({
    //     next: () => {
    //       this.showMsgBox(true, this.ability.name + ": created");
    //     },
    //     error: () => {
    //       this.showMsgBox(false, this.ability.name + ": failed to create");
    //     },
    //   });
    // }
  }

  selectBind() {
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
