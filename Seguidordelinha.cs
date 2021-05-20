    void seguirlinha(){

    while(5>4){
   if(bc.ReturnColor(0)=="BRANCO" && bc.ReturnColor(1)=="BRANCO"){
	bc.MoveFrontal(100, 100);
    }   
    else if(bc.ReturnColor(0)=="BRANCO" && bc.ReturnColor(1)=="PRETO"){
    bc.MoveFrontal(150,-150);
    }   
    else if (bc.ReturnColor(0)=="PRETO" && bc.ReturnColor(1)=="BRANCO"){
    bc.MoveFrontal(-150, 150);
        }
//seguir linha 4-12
    
     if(bc.ReturnColor(0) == "PRETO" && bc.ReturnColor(1) == "PRETO"){  
    bc.PrintConsole(1, "Encruzilhada!");
    bc.MoveFrontal(100, 100);
         bc.Wait(150);
 }
//encruzilhada 15-18

      if (bc.Inclination() > 0 && bc.Inclination() <= 45){
          bc.PrintConsole(1, (bc.Inclination().ToString()));
          	bc.MoveFrontal(150, 150);

//inclinação 21-22
          }
     }
}

void Main(){
seguirlinha();
}
