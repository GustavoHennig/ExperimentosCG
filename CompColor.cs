/* 
 * 
 * Autores: 
 * Gustavo Augusto Hennig
 * 
 * Junho de 2008
 * 
 * Distribuído sob os termos da licença GPL.
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Trab2_CG
{
    public class CompColor : IComparer<Color>
    {


        #region IComparer<Color> Members

        public int Compare(Color x, Color y)
        {
            if (x.R + x.G + x.B + x.A == y.R + y.G + y.B + y.A)
            {
                return 0;
            }
            else if (x.R + x.G + x.B + x.A > y.R + y.G + y.B + y.A)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }

        #endregion
    }
}
