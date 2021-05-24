void Main(){
    bool loop = true;

    while(loop == true){ 
        // IMPLEMENTAÇÃO DO PID
        float error = bc.Lightness(1) - bc.Lightness(2);
        float kP = 30;
        float proporcional = kP * error;
        float forca = 100;


        if (bc.ReturnColor(1) == "BRANCO" && bc.ReturnColor(2) == "BRANCO"){
            bc.MoveFrontal(forca + proporcional, forca - proporcional);
        }

        if (bc.ReturnColor(0) == "BRANCO" && bc.ReturnColor(1) == "PRETO" && bc.ReturnColor(2) == "BRANCO"){
            //bc.MoveFrontal(-200,200);
            bc.MoveFrontal(-forca + proporcional, forca - proporcional);
        }

        if (bc.ReturnColor(0) == "PRETO" && bc.ReturnColor(1) == "PRETO" && bc.ReturnColor(2) == "BRANCO"){
            //bc.MoveFrontal(200,200);
            bc.MoveFrontal(forca + proporcional, forca - proporcional);
            bc.Wait(120);
              while(bc.ReturnColor(2) != "PRETO"){
                //bc.MoveFrontal(-200,200);
                bc.MoveFrontal(-forca + proporcional, forca - proporcional);
              }
            bc.MoveFrontal(-20,-20);
            bc.MoveFrontal(-forca + proporcional, -forca - proporcional);
        }


        if (bc.ReturnColor(1) == "BRANCO" && bc.ReturnColor(2) == "PRETO" && bc.ReturnColor(3) == "BRANCO"){
           bc.MoveFrontal(forca + proporcional, -forca - proporcional);
            
        }
////////////////ADCIONADO AGR

/////////////adcviomadagrsndkskfskf

        if (bc.ReturnColor(0) == "PRETO" && bc.ReturnColor(1) == "BRANCO"){
            bc.MoveFrontal(forca + proporcional, -forca - proporcional);
        }


        if (bc.ReturnColor(1) == "BRANCO" && bc.ReturnColor(2) == "PRETO" && bc.ReturnColor(3) == "PRETO"){
            bc.MoveFrontal(forca + proporcional, forca - proporcional);
            bc.Wait(120);
              while(bc.ReturnColor(1)!="PRETO"){
              //bc.MoveFrontal(200,-200);
              bc.MoveFrontal(forca + proporcional, -forca - proporcional);
              }
            //bc.MoveFrontal(-20,-20);
            bc.MoveFrontal(-forca + proporcional, -forca - proporcional);
        }

        if (bc.ReturnColor(1)=="PRETO" && bc.ReturnColor(2)=="PRETO"){
            bc.MoveFrontal(forca + proporcional, forca - proporcional);

    if (bc.ReturnColor(0)=="PRETO" && bc.ReturnColor(3)=="PRETO"){
            bc.MoveFrontal(forca + proporcional, forca - proporcional);
               }
         if (bc.ReturnColor(0) == "PRETO"){
           bc.MoveFrontal(forca + proporcional, -forca - proporcional);         
        }
             
        }
 


          //INCLINAÇÃO by Alexandre
       if (bc.Inclination() > 0 && bc.Inclination() <= 341)
        {
            forca = 150;
            bc.MoveFrontal(forca + proporcional, forca - proporcional);
        } else {
            bc.MoveFrontal(forca + proporcional, forca - proporcional);
            bc.PrintConsole(1, error.ToString());
            bc.PrintConsole(2, bc.Inclination().ToString());
        }
       /* Se a inclinação do robô for maior que 0 e menor ou igual a 45°,
        a força dos motores aumentará para que tenha força suficiente na subida.
       */
    }
}