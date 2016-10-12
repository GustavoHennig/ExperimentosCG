using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ExperimentosCG
{
    class PincelRabisco : PincelBase
    {


        public override void Apply(Bitmap bmp, int x, int y)
        {

            Random variacao = new Random();

            for (int i = this.Size * -1; i < Size; i++)
            {

                int v = variacao.Next(-1, 2);

                int lx = x + i + v;
                int ly = y + i + v;

                if (ExistsPixel(bmp, lx, ly))
                {

                    bmp.SetPixel(lx, ly, Transform(bmp.GetPixel(lx, ly)));
                }



            }
        }


        private Color Transform(Color cin)
        {

            //Brush b = new Brush();
            return Color.FromArgb(FixByte(cin.R + 10), FixByte(cin.G + 10), FixByte(cin.B + 10));

        //    return Color.Black;
        }



        private bool ExistsPixel(Bitmap bmp, int x, int y)
        {
            if (x >= 0 && y >= 0 && x < bmp.Width && y < bmp.Height)
            {
                return true;
            }

            return false;
        }


    }
}
