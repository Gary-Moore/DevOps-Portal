import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { IVisualStudioTemplate } from '../shared/visual-studio-template';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class VisualStudioTemplateService {

  private _templates: BehaviorSubject<IVisualStudioTemplate[]>;

  private dataStore:{
    templates: IVisualStudioTemplate[]
  }

  constructor(private http: HttpClient) {
    this.dataStore = { templates: [] };
    this._templates = new BehaviorSubject<IVisualStudioTemplate[]>([]);
  }

  get templates(): Observable<IVisualStudioTemplate[]>{
    return this._templates.asObservable();
  }

  loadAll(){
    const templatesUrl = '/api/visual-studio/templates';

    return this.http.get<IVisualStudioTemplate[]>(templatesUrl)
    .subscribe(data => {
      this.dataStore.templates = data;
      this._templates.next(Object.assign({}, this.dataStore).templates);
    },error => {
      console.log('Failed to get resource');
    });
  }
}
