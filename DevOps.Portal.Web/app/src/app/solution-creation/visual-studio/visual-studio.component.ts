import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'dp-visual-studio',
  templateUrl: './visual-studio.component.html',
  styleUrls: ['./visual-studio.component.scss']
})
export class VisualStudioComponent implements OnInit {

  visualStudioFormGroup: FormGroup;
  
  constructor(private _formBuilder: FormBuilder) { }

  ngOnInit() {
    this.visualStudioFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required]
    });
  }
}
