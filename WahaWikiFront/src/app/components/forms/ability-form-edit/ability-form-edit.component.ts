import { Component, Input, OnInit } from '@angular/core';
import { AbilityEntety } from '../../enteties/UnitEntetyCRUD';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FormService } from 'src/app/services/form.service';

@Component({
  selector: 'app-ability-form-edit',
  templateUrl: './ability-form-edit.component.html',
  styleUrls: ['./ability-form-edit.component.css']
})
export class AbilityFormEditComponent {

  editForm: FormGroup;

  @Input()
  set OnFillFormEntety(value: AbilityEntety) {
    this.editForm.patchValue(value);
  }
  @Input() OnSubmitListRefresh!: () => void;
  @Input() OnSublitHideModal!: (isVisible: boolean) => void;


  constructor(private formBuilder: FormBuilder, private formServer: FormService) {
    this.editForm = this.formBuilder.group({
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
    let ability: AbilityEntety = {
      name: this.editForm.get('name')?.value,
      shortName: this.editForm.get('shortName')?.value,
      description: this.editForm.get('description')?.value
    }

    this.formServer.updateAbilityById(this.editForm.get('id')!.value, ability).subscribe({
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
