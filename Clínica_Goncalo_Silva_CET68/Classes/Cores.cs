using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clínica_Goncalo_Silva_CET68.Classes
{
    public static class Cores
    {

        /// <summary>
        /// recebe um ramdom dos formularios e com ele seleciona uma cor
        /// atravez do paramtro correcao faz uma ligeira modificacao a corpara ter 2 cores
        /// semelhantes (primaria e secundaria)
        /// </summary>
        public static Color Primaria { get; set; }
        public static Color Secundaria { get; set; }

        public static List<string> ListaCores = new List<string>() { "#3F51B5",
                                                                    "#009688",
                                                                    "#FF5722",
                                                                    "#607D8B",
                                                                    "#FF9800",
                                                                    "#9C27B0",
                                                                    "#2196F3",
                                                                    "#EA676C",
                                                                    "#E41A4A",
                                                                    "#5978BB",
                                                                    "#018790",
                                                                    "#0E3441",
                                                                    "#00B0AD",
                                                                    "#721D47",
                                                                    "#EA4833",
                                                                    "#EF937E",
                                                                    "#F37521",
                                                                    "#A12059",
                                                                    "#126881",
                                                                    "#8BC240",
                                                                    "#364D5B",
                                                                    "#C7DC5B",
                                                                    "#0094BC",
                                                                    "#E4126B",
                                                                    "#43B76E",
                                                                    "#7BCFE9",
                                                                    "#B71C46"};


        public static Color MudarBrilho(Color cor, double correcao)
        {
            double red = cor.R;
            double green = cor.G;
            double blue = cor.B;
            //se corretor for menos de 0, escurecer a cor.
            if (correcao < 0)
            {
                correcao = 1 + correcao;
                red *= correcao;
                green *= correcao;
                blue *= correcao;
            }
            //se corretor for maior que 0, clarear color.
            else
            {
                red = (255 - red) * correcao + red;
                green = (255 - green) * correcao + green;
                blue = (255 - blue) * correcao + blue;
            }
            return Color.FromArgb(cor.A, (byte)red, (byte)green, (byte)blue);
        }

    }
}
