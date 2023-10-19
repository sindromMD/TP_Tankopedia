import { DatePipe } from '@angular/common';
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'dateFormatting'
})
export class DateFormattingPipe implements PipeTransform {
  
  constructor(private datePipe: DatePipe) { }
  transform(value: Date, ...args: unknown[]): string {
    // Vérifier si la valeur est nulle ou indéfinie
    if (!value) {
      return '';
    }
    // Appeler la fonction de formatage de la date
    return this.formatYearOfCreation(value);
  }
  
  formatYearOfCreation(date: Date): string {
    const formattedDate = this.datePipe.transform(date, 'YYYY');
    return formattedDate || ''; 
  }

}
