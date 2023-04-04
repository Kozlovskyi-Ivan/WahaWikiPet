import { Pipe, PipeTransform } from "@angular/core";

@Pipe({
    name: 'numOfModelsPipe',
    pure: true
})

export class NumOfModelsPipe implements PipeTransform {
    transform(value: number, suffix: number) {
        if (value == suffix) {
            return value;
        }
        else{
            return value +"-"+ suffix;
        }
    }
}