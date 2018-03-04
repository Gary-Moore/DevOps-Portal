import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'dp-solution-creation',
  templateUrl: './solution-creation.component.html',
  styleUrls: ['./solution-creation.component.scss']
})
export class SolutionCreationComponent implements OnInit {

  
  gitLabForm: FormGroup;
  teamcityForm: FormGroup;
  octopusForm: FormGroup;
  azureForm: FormGroup;

  constructor(private _formBuilder: FormBuilder) { }

  ngOnInit() {
    

    this.gitLabForm = this._formBuilder.group({

    });

    this.teamcityForm = this._formBuilder.group({
      teamcityParentProject: ['', Validators.required],
      teamcitySubProjecttName: ['', Validators.required]
    });

    this.octopusForm = this._formBuilder.group({

    });

    this.azureForm = this._formBuilder.group({

    });
  }

}
