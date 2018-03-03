import { Component, OnInit } from '@angular/core';
import { VisualStudioTemplateService } from './visual-studio-template.service';
import { Observable } from 'rxjs/Observable';
import { VisualStudioTemplate } from '../shared/visual-studio-template';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'dp-visual-studio',
  templateUrl: './visual-studio.component.html',
  styleUrls: ['./visual-studio.component.scss']
})
export class VisualStudioComponent implements OnInit {
  templates: Observable<VisualStudioTemplate[]>;
  visualStudioForm:FormGroup;

  constructor(private templateService: VisualStudioTemplateService) { }

  ngOnInit() {
   this.templates = this.templateService.templates;
   this.templateService.loadAll();
   this.templates.subscribe(data =>{
     console.log(data);
   });

   this.visualStudioForm = new FormGroup({
     
   });
  }
}
