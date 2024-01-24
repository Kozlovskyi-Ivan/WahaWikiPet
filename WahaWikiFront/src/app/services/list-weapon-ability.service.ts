import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { WeaponAbilityEntety } from '../components/enteties/UnitEntetyCRUD';

@Injectable({
  providedIn: 'root'
})
export class ListWeaponAbilityService {

  private apiUrl = "http://localhost:5200/api";

  constructor(private HttpClient: HttpClient) { }

  getWeaponAbilityList(): Observable<WeaponAbilityEntety[]>{
    return this.HttpClient.get<WeaponAbilityEntety[]>(this.apiUrl+`/WeaponAbilities`);
  }

  deleteWeaponAbility(id:number){
    return this.HttpClient.delete(this.apiUrl+`/WeaponAbilities/${id}`);
  }
}
