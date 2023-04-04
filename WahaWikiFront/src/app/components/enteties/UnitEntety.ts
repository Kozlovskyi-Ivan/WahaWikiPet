export interface Unit {
    id: number;
    name: string;
    power: number;
    unitType: UnitType;
    unitStatList?: UnitStat[];
    weapons?: Weapon[];
    abilities?: Ability[];
}
export interface UnitType {
    id: number;
    unitTypeName: string;
}
export interface UnitStat {
    id: number;
    minNumber: number;
    maxNumber: number;
    modelName: string;
    pointPrice: string;
    move: number;
    ws: number;
    bs: number;
    strength: number;
    toughness: number;
    wounds: number;
    attacks: number;
    leadership: number;
    savingThrows: number;
}
export interface Weapon {
    weaponId: number;
    name: string;
    range: number;
    numberOfShot: string;
    strength: string;
    ap: string;
    damage: string;
    weaponType: WeaponType;
    weaponAbilities: WeaponAbility[];

}
export interface WeaponType {
    id: number;
    typeName: string;
    typeRuleText: string;
}
export interface WeaponAbility {
    id: number;
    name: string;
    shortName: string;
    description: string;
}
export interface Ability {
    id: number;
    name: string;
    shortName: string;
    description: string;
}