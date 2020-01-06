using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainPanel.BackColor = Color.FromArgb(200, 0, 0, 50);
            menuPanel.BackColor = Color.FromArgb(220, 100, 0, 100);

            titleLabel.BackColor = Color.FromArgb(0, 100, 0, 100);
            titleLabel.ForeColor = Color.FromArgb(200, 100, 200);

            mainExitBtn.BackColor = Color.FromArgb(0, 100, 0, 100);
            mainExitBtn.ForeColor = Color.FromArgb(200, 100, 200);

            calculateBtn.BackColor = Color.FromArgb(200, 100, 100, 250);

            resultPanel.BackColor = Color.FromArgb(220, 100, 0, 100);
        }

        private void MainExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            int result;
            bool valid = false;
            bool isLong = false;

            string binary= binaryNumberText.Text;

            result = 0;

            int cpt = binary.Length-1;

            for(int i=0; i < binary.Length; i++)
            {
                valid = true;
                int num;
                if(binary[i]=='1')
                {
                    num = int.Parse(binary[i].ToString());
                    try
                    {
                        result = result + Convert.ToInt32(num * Math.Pow(2, cpt));
                    }
                    catch
                    {
                        valid = false;
                        isLong = true;
                    }
                    cpt--;
                }
                else if(binary[i]=='0')
                {
                    cpt--;
                }
                else
                {
                    valid = false;
                    break;
                }
            }
            if(valid)
            {
                resultLabel.Text = "Result in decimal is : " + result;
            }
            else
            {
                resultLabel.Text = isLong ? "Sorry your number is too long" : "Please enter a valid binary number";
            }
        }
    }
}
