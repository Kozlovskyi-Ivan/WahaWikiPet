import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FormService } from 'src/app/services/form.service';
import { AbilityEntety } from '../../enteties/UnitEntetyCRUD';

@Component({
  selector: 'app-ability-form-create',
  templateUrl: './ability-form-create.component.html',
  styleUrls: ['./ability-form-create.component.css']
})
export class AbilityFormCreateComponent implements OnInit {

  createForm: FormGroup;
  
  @Input() OnSubmitListRefresh!: ()=>void;
  @Input() OnSublitHideModal!: (isVisible: boolean) => void;


  constructor(private formBuilder: FormBuilder, private formServer: FormService) {
    this.createForm = this.formBuilder.group({
      id:[null],
      name: [null, Validators.required],
      shortName: [null, Validators.required],
      description: [null, Validators.required]
    });
  }

  ngOnInit(): void {
  }

  isFormValid() {
    return !(this.createForm.valid && this.createForm.touched);
  }

  onSubmit() {
    let ability: AbilityEntety = {
      name: this.createForm.get('name')?.value,
      shortName: this.createForm.get('shortName')?.value,
      description: this.createForm.get('description')?.value
    }

    this.formServer.createAbility(ability).subscribe({
      next: () => {
        this.createForm.get('name')?.setValue('');;
        this.createForm.get('shortName')?.setValue('');
        this.createForm.get('description')?.setValue('');
      },
      error: () => {
      },
      complete: () =>{
        this.OnSubmitListRefresh();
        this.OnSublitHideModal(false);
      }
    });
  }

}
