import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IUltraBuild } from './ultrabuild.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UltraBuildService {

  constructor(private http: HttpClient) { }

  build(model: IUltraBuild): Observable<any> {
    const uri = 'api/ultrabuild';
    return this.http.put(uri, {x: model.visualStudio.solutionName});
  }
}
