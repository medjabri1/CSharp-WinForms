using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equation2degre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a, b, c;


            if(int.TryParse(aText.Text, out a) && int.TryParse(bText.Text, out b) && int.TryParse(cText.Text, out c))
            {
                if(a==0 && c==0 && b==0)
                {
                    result.Text = "Entrer des nombres differents de 0!";
                    return;
                }
                else if(a==0)
                {
                    double x = (-c / b);
                    result.Text = "Le resultat est : x = " + x;
                    return;
                }
                else if(b==0)
                {
                    if(-c/a < 0)
                    {
                        result.Text = "Cette equation n'a pas des solution!";
                        return;
                    }
                    double x = Math.Sqrt((-c) / a);
                    result.Text = "Le resultat est : x = " + x;
                    return;
                }
                

                int delta = b * b - 4 * a * c;
                if(delta > 0)
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                    result.Text = "Le resultat est : x1 = " + Math.Round(x1,2) + " || x2 = " + Math.Round(x2,2);
                }
                else if(delta == 0)
                {
                    double x = (-b) / (2 * a);
                    result.Text = "Le resultat est : x = " + Math.Round(x,2);
                }
                else
                {
                    result.Text = "Cette equation n'a pas des solution!";
                }
            }
            else
            {
                result.Text = "S'il vous plait entrer que les chiffres!";
            }
        }

    }
}
