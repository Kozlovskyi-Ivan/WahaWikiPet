
export interface IStatLine{
    Number:number;
    ModelName:string;
    Move:number;
    WS:number;
    BS:number;
    Strength:number;
    Toughness:number;
    Wounds:number;
    Attacks:number;
    Leadership:number;
    SavingThrows:number;
}

export interface IWeaponStatLine{
    WeaponName:string;
    Range:number;
    Type:string;
    Strength:number;
    AP:number;
    Damage:number;
    Abilities:string;
}