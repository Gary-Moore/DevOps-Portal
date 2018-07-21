import { Component, OnInit } from '@angular/core';
import { VisualStudioTemplateService } from './visual-studio-template.service';
import { Observable } from 'rxjs/Observable';
import { IVisualStudioTemplate } from '../shared/visual-studio-template';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'dp-visual-studio',
  templateUrl: './visual-studio.component.html',
  styleUrls: ['./visual-studio.component.scss']
})
export class VisualStudioComponent implements OnInit {
  templates: Observable<IVisualStudioTemplate[]>;
  visualStudioForm:FormGroup;

  constructor(private _formBuilder: FormBuilder, private templateService: VisualStudioTemplateService) { }

  ngOnInit() {
   this.templates = this.templateService.templates;
   this.templateService.loadAll();
   this.templates.subscribe(data =>{
     console.log(data);
   });

   this.visualStudioForm = this._formBuilder.group({
      solutionName: ['', Validators.required],
      projectName: ['', Validators.required],
      templateId: ['', Validators.required]
    });
  }
}
