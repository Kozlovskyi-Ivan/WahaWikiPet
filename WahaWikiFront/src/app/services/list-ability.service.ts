import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AbilityEntety } from '../components/enteties/UnitEntetyCRUD';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class ListAbilityService {

  private apiUrl = "http://localhost:5200/api";

  constructor(private httpClient: HttpClient) { }

  getAbilityList(): Observable<AbilityEntety[]> {
    return this.httpClient.get<AbilityEntety[]>(this.apiUrl + `/Abilities`);
  }

  deleteAbility(id: number){
    return this.httpClient.delete(this.apiUrl+`/Abilities/${id}`, );
  }
}