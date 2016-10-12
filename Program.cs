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
using System.Windows.Forms;

namespace ExperimentosCG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
