import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AzureService {
  constructor(private http: HttpClient) {}

  public virtualMachines = [];

  loadVirtualMachines(): Observable<boolean> {
    return this.http.get('api/virtualmachines').pipe(
      map((data: any[]) => {
        this.virtualMachines = data;
        return true;
      }),
      catchError(this.handleError)
    );
  }

  private handleError(err: HttpErrorResponse) {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
        errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }

    console.log(errorMessage);
    return throwError(errorMessage);
  }
}
