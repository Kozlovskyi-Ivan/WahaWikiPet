import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { lastValueFrom, Observable } from 'rxjs';
import { AbilityEntety } from '../components/enteties/UnitEntetyCRUD';


@Injectable({
  providedIn: 'root'
})
export class FormService {

  private apiUrl = "http://localhost:5200/api";

  constructor(private http: HttpClient) { }

  getAbilityList(): Observable<AbilityEntety[]> {
    return this.http.get<AbilityEntety[]>(this.apiUrl + `/Abilities`);
  }

  getAbilityById(id: string): Observable<AbilityEntety> {
    return this.http.get<AbilityEntety>(this.apiUrl + `/Abilities/${id}`);
  }

  updateAbilityById(id: number, ability: AbilityEntety): Observable<AbilityEntety> {
    return this.http.put<AbilityEntety>(this.apiUrl + `/Abilities/${id}`, ability);
  }

  createAbility(ability: AbilityEntety): Observable<AbilityEntety> {
    return this.http.post<AbilityEntety>(this.apiUrl + `/Abilities/`, ability)
  }

  deleteAbility(id: number){
    return this.http.delete(this.apiUrl+`/Abilities/${id}`, );
  }
}
