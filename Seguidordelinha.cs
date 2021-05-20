    void seguirlinha(){
        while(5>4){
   if(bc.ReturnColor(0)=="BRANCO" && bc.ReturnColor(1)=="BRANCO"){
	bc.MoveFrontal(100, 100);
    }   
    while(bc.ReturnColor(0)=="BRANCO" && bc.ReturnColor(1)=="PRETO"){
    bc.MoveFrontal(150,-150);
    }   
    while (bc.ReturnColor(0)=="PRETO" && bc.ReturnColor(1)=="BRANCO"){
    bc.MoveFrontal(-150, 150);
        }


 if(bc.ReturnColor(0) == "PRETO" && bc.ReturnColor(1) == "PRETO"){  
            bc.PrintConsole(1, "Encruzilhada!");
    }


      if (bc.Inclination() > 0 && bc.Inclination() <= 45){
          bc.PrintConsole(1, (bc.Inclination().ToString()));
          }
     }
}

void Main(){
seguirlinha();
}
