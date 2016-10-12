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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace ExperimentosCG
{
    public partial class Histograma : Form
    {
        public Histograma()
        {
            InitializeComponent();
        }

        public void AtualizaGraficoHistograma(Dictionary<Color, long> histograma, int limiar)
        {

            //histograma.
            Color corlimiar = Color.Black;
            if (limiar <= 255)
            {
                corlimiar = Color.FromArgb(limiar, limiar, limiar);
                if (!histograma.ContainsKey(corlimiar))
                {
                    histograma.Add(corlimiar, 0);
                }
            }
            SortedList<Color, long> sd = new SortedList<Color, long>(histograma, new CompColor());

            //SortedDictionary<Color, long> sd = new SortedDictionary<Color, long>(histograma, new CompColor());

            PointPairList list = new PointPairList();
            PointPairList list2 = new PointPairList();

            int cnt = 0;
            double max = 0;

            foreach (Color k in sd.Keys)
            {
                //long l in sd.Values
                cnt++;
                
                //list.Add((double)cnt, (double)l);

                if (limiar > 255 || corlimiar != k)
                {
                    list.Add((double)k.R, (double)sd[k]);
                    if((double)sd[k] > max){
                    max = (double)sd[k];
                    }
                    list2.Add((double)limiar, 0);     

                }else{
                    //PointPair pp =  new PointPair((double)k.R, (double)sd[k]);
                    //pp.ColorValue= 6464;
                    //list.Add(pp);
                    list2.Add((double)limiar, max);     
                }
            }

            zedGraphControl1.GraphPane = new GraphPane();

            
            BarItem myCurve = zedGraphControl1.GraphPane.AddBar("Item", list, Color.Blue);

            myCurve.Bar.Border.Width = 0;
            myCurve.Bar.Fill.Type= FillType.Solid;
            myCurve.Bar.Border.IsVisible = false;

            if (limiar <= 255){
            BarItem barLimiar = zedGraphControl1.GraphPane.AddBar("Limiar", list2, Color.Red);
            barLimiar.Bar.Border.Width = 2;
            barLimiar.Bar.Fill.Type = FillType.Solid;
            barLimiar.Bar.Border.Color = Color.Red;
        }

            zedGraphControl1.AxisChange();
            zedGraphControl1.GraphPane.XAxis.Type = AxisType.Ordinal;


          //  zedGraphControl1.GraphPane.YAxis.Scale.Max = zedGraphControl1.GraphPane.YAxis.Scale.MajorStep;
            //zedGraphControl1.GraphPane

           // zedGraphControl1.GraphPane.XAxis.Scale.

           

            zedGraphControl1.AxisChange();
            zedGraphControl1.RestoreScale(zedGraphControl1.GraphPane);
            zedGraphControl1.Update();
            zedGraphControl1.Refresh();

            //int cnt = 1;

            //Pen p = new Pen(Color.Blue);
            //int altura = 200;

            //foreach (long l in sd.Values) {

            //    int y = Convert.ToInt32( altura - l / 100 - 1);
            //    int alt = Convert.ToInt32(l / 100 + 1);

            //    grph.DrawRectangle(p, cnt, y, 2, alt); 

            //    cnt+= 3;
            //}

        }
    }
}
