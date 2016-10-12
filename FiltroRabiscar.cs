using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ExperimentosCG
{
    class FiltroRabiscar : FiltroBase
    {

        public int Raio = 5;



        public override void ApplyEffect(Bitmap bmp)
        {
            

            Random r = new Random();
            
            PincelRabisco pr = new PincelRabisco();
            pr.Size  = Raio;
            for(int x = 0; x <  bmp.Width; x++){
                
                for(int y = 0; y <  bmp.Width; y++){
            
                    if(r.Next(0,10) == 3){
                    
                       pr.Apply(bmp, x, y);
                            

                    }




                }

            }

            


        }


    }
}
