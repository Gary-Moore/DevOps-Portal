import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'dp-solution-creation',
  templateUrl: './solution-creation.component.html',
  styleUrls: ['./solution-creation.component.scss']
})
export class SolutionCreationComponent implements OnInit {

  visualStudioFormGroup: FormGroup;
  constructor(private _formBuilder: FormBuilder) { }

  ngOnInit() {
    this.visualStudioFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required]
    });
  }

}
