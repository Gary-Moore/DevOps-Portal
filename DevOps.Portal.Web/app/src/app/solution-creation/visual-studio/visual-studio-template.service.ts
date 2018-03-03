import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { VisualStudioTemplate } from '../shared/visual-studio-template';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class VisualStudioTemplateService {

  private _templates: BehaviorSubject<VisualStudioTemplate[]>;

  private dataStore:{
    templates: VisualStudioTemplate[]
  }

  constructor(private http: HttpClient) {
    this.dataStore = { templates: [] };
    this._templates = new BehaviorSubject<VisualStudioTemplate[]>([]);
  }

  get templates(): Observable<VisualStudioTemplate[]>{
    return this._templates.asObservable();
  }

  loadAll(){
    const templatesUrl = '';

    return this.http.get<VisualStudioTemplate[]>(templatesUrl)
    .subscribe(data => {
      this.dataStore.templates = data;
      this._templates.next(Object.assign({}, this.dataStore).templates);
    },error => {
      console.log('Failed to get resource');
    });
  }
}
