import { Component, OnInit } from '@angular/core';
import { UntypedFormBuilder, UntypedFormControl, UntypedFormGroup, Validators } from '@angular/forms';
import { StateEnum } from 'src/app/modules/shared/enum/state';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.css']
})
export class LandingComponent implements OnInit{

  area = [{
    code:1,
    value:'Sistemas'
  },{
    code:2,
    value:'Logistica'
  }]
  civils_status =[{code:1, value:'Soltero'},
  {code:2, value:'Casado'}];
  province=[{code:1,value:'Azuay'},{code:2,value:'Pichincha'}];
  canton = [{code:1,value:'Cuenca',province:1},{code:2,value:'Quito',province:2}]
  validateForm!: UntypedFormGroup;

  constructor(private fb: UntypedFormBuilder) {}
  
  ngOnInit(): void {
    // throw new Error('Method not implemented.');
    this.createForm();
  }
  createForm(){
    this.validateForm = this.fb.group({
      area:[null, Validators.required],
      knowledge:[null, Validators.maxLength(500)],
      public_sector:[0, Validators.required],
      private_sector:[0, Validators.required],
      identification:[null, Validators.maxLength(10)],
      first_name:[null, Validators.minLength(2)],
      second_name:[null, Validators.minLength(0)],
      first_surnname:[null, Validators.minLength(3)],
      second_surname:[null, Validators.minLength(3)],
      phone:[null,],
      mobile:[null,],
      status_civil:[1, Validators.required],
      date_birth:[null, Validators.required],
      province:[null, Validators.required],
      canton:[null, Validators.required],
      address:[null, Validators.required],
      disability:[StateEnum.INACTIVE,Validators.required],
      email: [null, [Validators.email, Validators.email]],
      password: [null, [Validators.required]],
      PHOTO:[null, ]
      // checkPassword: [null, [Validators.required, this.confirmationValidator]],
      // nickname: [null, [Validators.required]],
      // phoneNumberPrefix: ['+86'],
      // phoneNumber: [null, [Validators.required]],
      // website: [null, [Validators.required]],
      // captcha: [null, [Validators.required]],
      // agree: [false]
    });
  }
  confirmationValidator = (control: UntypedFormControl): { [s: string]: boolean } => {
    // if (!control.value) {
    //   return { required: true };
    // } else if (control.value !== this.validateForm.controls.identification.value) {
    //   return { confirm: true, error: true };
    // }
    return {};
  };
  updateConfirmValidator(): void {
    /** wait for refresh value */
    // Promise.resolve().then(() => this.validateForm.controls.checkPassword.updateValueAndValidity());
  }

}
