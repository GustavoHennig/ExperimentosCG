using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ExperimentosCG
{
    class PincelBase
    {
        public int Size;
        public string Name;
        public int Tranparencia;

        public virtual void Apply(Bitmap bmp, int x, int y){}


        public int FixByte(int v) {

            if (v < 0) {
                return 0;
            }

            if (v > 255) {
                return 255;
            }

            return v;

        }
    }
}
