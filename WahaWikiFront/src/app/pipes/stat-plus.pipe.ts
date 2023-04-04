import { Pipe, PipeTransform } from "@angular/core";

@Pipe({
    name: 'statPlusPipe',
    pure: true
})

export class StatPlusPipe implements PipeTransform {
    transform(value: any, suffix: string) {
        return value = value + suffix;
    }
}