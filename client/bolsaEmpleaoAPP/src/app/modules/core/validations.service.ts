import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
  })
  export class ValidationsService {
    validateIdentifications(identification:string):boolean{
        var cad = identification.trim();
        var total = 0;
        var verifi = 0;
        var longitud = cad.length;
        var longcheck = longitud - 1;
        if(longitud === 10){
          verifi = parseInt(cad.charAt(longitud-1));
          for(let i = 0; i < longcheck; i++){
          if (i%2 === 0)
          {
              var aux = parseInt(cad.charAt(i)) * 2;
              if (aux > 9) aux -= 9;
              total += aux;
          }
          else
          {
              total += parseInt(cad.charAt(i));
          }
          }
          total = total % 10 ? 10 - total % 10 : 0;
        }
        else {
          return false;
        }
        if (verifi == total) {
          return true;
        }
        else{
          return false;
        }
      }
    
  }
