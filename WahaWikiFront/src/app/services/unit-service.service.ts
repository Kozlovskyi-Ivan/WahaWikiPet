import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { lastValueFrom, Observable } from 'rxjs';
import { Unit } from '../components/enteties/UnitEntety';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  })
}

@Injectable({
  providedIn: 'root'
})

export class UnitServiceService {

  private apiUrl = "http://localhost:5200/api";

  constructor(private http: HttpClient) { }

  getUnitDataSheet(id: number): Observable<Unit> {
    return this.http.get<Unit>(this.apiUrl + `/Units/${id}`)
  }
}
