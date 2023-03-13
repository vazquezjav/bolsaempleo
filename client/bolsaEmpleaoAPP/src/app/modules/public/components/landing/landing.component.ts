import { Component, OnInit } from '@angular/core';
import { AbstractControl, UntypedFormBuilder, UntypedFormControl, UntypedFormGroup, ValidationErrors, Validators } from '@angular/forms';
import { DisabledTimeFn } from 'ng-zorro-antd/date-picker';
import { Observable, Observer } from 'rxjs';
import { ValidationsService } from 'src/app/modules/core/validations.service';
import { StateEnum } from 'src/app/modules/shared/enum/state';
import { differenceInCalendarDays, setHours } from 'date-fns';
import { NzUploadFile } from 'ng-zorro-antd/upload';
import { NzMessageService } from 'ng-zorro-antd/message';

const getBase64 = (file: File): Promise<string | ArrayBuffer | null> =>
  new Promise((resolve, reject) => {
    const reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = () => resolve(reader.result);
    reader.onerror = error => reject(error);
  });

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.css']
})
export class LandingComponent implements OnInit {

  area = [{
    code: 1,
    value: 'Sistemas'
  }, {
    code: 2,
    value: 'Logistica'
  }]
  civils_status = [{ code: 1, value: 'Soltero' },
  { code: 2, value: 'Casado' }];
  province = [{ code: 1, value: 'Azuay' }, { code: 2, value: 'Pichincha' }];
  canton = [{ code: 1, value: 'Cuenca', province: 1 }, { code: 2, value: 'Quito', province: 2 }]

  validateForm!: UntypedFormGroup;

  disability =[{code:StateEnum.INACTIVE, value:'NO'},{code:StateEnum.ACTIVE, value:'SI'}]
  fileList: NzUploadFile[] = [  ];
  today = new Date();
  loading = false;
  avatarUrl?: string;

  constructor(private fb: UntypedFormBuilder, private validationsSerivice: ValidationsService,
    private msg: NzMessageService) { }

  ngOnInit(): void {
    // throw new Error('Method not implemented.');
    this.createForm();
  }
  createForm() {
    this.validateForm = this.fb.group({
      area: [null, Validators.required],
      knowledge: [null, [Validators.required, Validators.maxLength(500)]],
      public_sector: [0, Validators.required],
      private_sector: [0, Validators.required],
      identification: [null, [Validators.required,Validators.maxLength(10)], [this.validateIdentification]],
      first_name: [null, [Validators.required, Validators.minLength(2)]],
      second_name: [null, Validators.minLength(0)],
      first_surname: [null, [Validators.required, Validators.minLength(2)]],
      second_surname: [null, [Validators.required, Validators.minLength(2)]],
      phone: [null, [this.mobile]],
      mobile: [null,],
      status_civil: [0, Validators.required],
      number_children: [0, Validators.required],
      date_birth: [null, Validators.required],
      province: [null, Validators.required],
      canton: [null, Validators.required],
      address: [null, Validators.required],
      disability: [StateEnum.INACTIVE, Validators.required],
      email: [null, [Validators.required, Validators.email]],
      password: [null, [Validators.required]],
      photo: [null,]
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
  submitForm() {

  }
  validateIdentification = (control: UntypedFormControl) =>
    new Observable((observer: Observer<ValidationErrors | null>) => {
      setTimeout(() => {
        const identification = this.validateForm.get("identification")?.value;
        if (identification == undefined || identification.length <= 9)
          return;
        if (this.validationsSerivice.validateIdentifications(identification))
          observer.next(null);
        else
          observer.next({ error: true, status: false });
        observer.complete();
      }, 500);
    });


    //DISABLE DATE
  disabledDate = (current: Date): boolean =>
    differenceInCalendarDays(current, this.today) > 0;

  disabledDateTime: DisabledTimeFn = () => ({
    nzDisabledHours: () => this.range(0, 24).splice(4, 20),
    nzDisabledMinutes: () => this.range(30, 60),
    nzDisabledSeconds: () => [55, 56]
  });

  range(start: number, end: number): number[] {
    const result: number[] = [];
    for (let i = start; i < end; i++) {
      result.push(i);
    }
    return result;
  }

  beforeUpload = (file: NzUploadFile, _fileList: NzUploadFile[]): Observable<boolean> =>
    new Observable((observer: Observer<boolean>) => {
      const isJpgOrPng = file.type === 'image/jpeg' || file.type === 'image/png';
      if (!isJpgOrPng) {
        this.msg.error('Unicamente puede subir imagenes en formato .jpg o .png!');
        observer.complete();
        return;
      }
      const isLt2M = file.size! / 1024 / 1024 < 5;
      if (!isLt2M) {
        this.msg.error('La imagen no debe superar los 5MB!');
        observer.complete();
        return;
      }
      observer.next(isJpgOrPng && isLt2M);
      this.fileList.push(file);
      observer.complete();
    });

  private getBase64(img: File, callback: (img: string) => void): void {
    const reader = new FileReader();
    reader.addEventListener('load', () => callback(reader.result!.toString()));
    reader.readAsDataURL(img);
  }

  handleChange(info: { file: NzUploadFile }): void {
    switch (info.file.status) {
      case 'uploading':
        this.loading = true;
        this.getBase64(info.file!.originFileObj!, (img: string) => {
          this.loading = false;
          this.avatarUrl = img;
        });
        break;
      case 'done':
        this.getBase64(info.file!.originFileObj!, (img: string) => {
          this.loading = false;
          this.avatarUrl = img;
        });
        break;
      case 'error':
        this.msg.error('Network error');
        this.loading = false;
        break;
    }
  }
  

  mobile(control: AbstractControl): ValidationErrors | null {
    const value = control.value;

    if (value == undefined || value.length == 0) {
      return null;
    }

    return isMobile(value)
      ? null
      : { mobile: { 'es_ES': `手机号码格式不正确`, en: `Mobile phone number is not valid` } };
  }
}
function isMobile(value: string): boolean {
  return typeof value === 'string' && /(^1\d{10}$)/.test(value);
}
