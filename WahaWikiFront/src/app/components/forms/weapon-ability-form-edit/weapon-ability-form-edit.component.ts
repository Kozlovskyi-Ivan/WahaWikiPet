import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FormWeaponAbilityService } from 'src/app/services/form-weapon-ability.service';
import { WeaponAbility } from '../../enteties/UnitEntety';

@Component({
  selector: 'app-weapon-ability-form-edit',
  templateUrl: './weapon-ability-form-edit.component.html',
  styleUrls: ['./weapon-ability-form-edit.component.css']
})
export class WeaponAbilityFormEditComponent {

  editForm: FormGroup;

  @Input()
  set OnFillFormEntety(value: WeaponAbility) {
    this.editForm.patchValue(value);
  }
  @Input() OnSubmitListRefresh!: () => void;
  @Input() OnSublitHideModal!: (isVisible: boolean) => void;

  constructor(private FormBuilder: FormBuilder,
    private FormWeaponAbilityService: FormWeaponAbilityService) {
    this.editForm = this.FormBuilder.group({
      id: [null],
      name: [null, Validators.required],
      shortName: [null, Validators.required],
      description: [null, Validators.required]
    });
  }

  isFormValid() {
    return !(this.editForm.valid);
  }

  onSubmit() {
    let weaponAbility: WeaponAbility = {
      name: this.editForm.get('name')?.value,
      shortName: this.editForm.get('shortName')?.value,
      description: this.editForm.get('description')?.value
    }

    this.FormWeaponAbilityService.updateWeaponAbilityById(this.editForm.get('id')?.value,weaponAbility).subscribe({
      next: () => {
        this.editForm.get('name')?.setValue('');;
        this.editForm.get('shortName')?.setValue('');
        this.editForm.get('description')?.setValue('');
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
