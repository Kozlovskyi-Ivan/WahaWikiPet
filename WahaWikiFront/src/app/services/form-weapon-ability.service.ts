import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { WeaponAbilityEntety } from '../components/enteties/UnitEntetyCRUD';

@Injectable({
  providedIn: 'root'
})

export class FormWeaponAbilityService {

  private apiUrl = "http://localhost:5200/api";

  constructor(private HttpClient: HttpClient) { }

  getWeaponAbilityList():Observable<WeaponAbilityEntety[]>{
    return this.HttpClient.get<WeaponAbilityEntety[]>(this.apiUrl + `/WeaponAbilities`);
  }

  getWeaponAbilityById(id: string): Observable<WeaponAbilityEntety> {
    return this.HttpClient.get<WeaponAbilityEntety>(this.apiUrl + `/WeaponAbilities/${id}`);
  }

  updateWeaponAbilityById(id: number, ability: WeaponAbilityEntety): Observable<WeaponAbilityEntety> {
    return this.HttpClient.put<WeaponAbilityEntety>(this.apiUrl + `/WeaponAbilities/${id}`, ability);
  }

  createWeaponAbility(ability: WeaponAbilityEntety): Observable<WeaponAbilityEntety> {
    return this.HttpClient.post<WeaponAbilityEntety>(this.apiUrl + `/WeaponAbilities/`, ability)
  }

  deleteWeaponAbility(id: number){
    return this.HttpClient.delete(this.apiUrl+`/WeaponAbilities/${id}`, );
  }
}
