import { FormWeaponAbilityService } from './../../../services/form-weapon-ability.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Component, Input, OnInit } from '@angular/core';
import { WeaponAbility } from '../../enteties/UnitEntety';

@Component({
  selector: 'app-weapon-ability-form-create',
  templateUrl: './weapon-ability-form-create.component.html',
  styleUrls: ['./weapon-ability-form-create.component.css']
})
export class WeaponAbilityFormCreateComponent {

  createForm: FormGroup;

  @Input() OnSubmitListRefresh!: () => void;
  @Input() OnSublitHideModal!: (isVisible: boolean) => void;

  constructor(private FormBuilder: FormBuilder,
    private FormWeaponAbilityService: FormWeaponAbilityService) {
    this.createForm = this.FormBuilder.group({
      id: [null],
      name: [null, Validators.required],
      shortName: [null, Validators.required],
      description: [null, Validators.required]
    });
  }

  isFormValid() {
    return !(this.createForm.valid && this.createForm.touched);
  }

  onSubmit() {
    let weaponAbility: WeaponAbility = {
      name: this.createForm.get('name')?.value,
      shortName: this.createForm.get('shortName')?.value,
      description: this.createForm.get('description')?.value
    }

    this.FormWeaponAbilityService.createWeaponAbility(weaponAbility).subscribe({
      next: () => {
        this.createForm.get('name')?.setValue('');;
        this.createForm.get('shortName')?.setValue('');
        this.createForm.get('description')?.setValue('');
      },
      error: () => {
      },
      complete: () => {
        this.OnSubmitListRefresh();
        this.OnSublitHideModal(false);
      }
    });
  }

}
