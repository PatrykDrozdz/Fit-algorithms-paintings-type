using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_sim
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
    
        /// ///////////////////
    
        private System.Random x = new Random();

       private  System.Drawing.SolidBrush myBrush =
            new System.Drawing.SolidBrush(System.Drawing.Color.Red);//pędzel rysujący
        private System.Drawing.SolidBrush eraseBrush =
            new System.Drawing.SolidBrush(System.Drawing.Color.WhiteSmoke);//pędzel wymazujący

        
        /// /////////////////////////

        private void timer_Tick(object sender, EventArgs e)
        {
            Graphics graf = this.CreateGraphics();

            graf.FillEllipse(myBrush, new Rectangle(tabX[ticks] % 580, tabY[ticks] % 380, 20, 30));

            ticks++;

            if (this.ticks == m)
            {
                timer.Stop();
            }

            this.timerCheck.Text = ticks.ToString();
           
        }

        //czysczenie zmiennych
        private void clear_Click(object sender, EventArgs e)
        {
            Graphics graf = this.CreateGraphics();

            for (int i=0; i< m; i++)
            {
                for(int j=0; j< p; j++)
                {
                    graf.FillEllipse(eraseBrush, new Rectangle(tabX[i] % 600, tabY[j] % 370, 20, 30));
                }
            }

            this.a = 0;
            this.m = 0;
            this.p = 0;
            this.proces.Clear();
            this.ticks = 0;
            this.temp = 0;
            for (int i = 0; i < this.proc.Length; i++)
            {
                proc[i] = 0;
                memor[i] = 0;
                tabX[i] = 0;
                tabY[i] = 0;
            }
            this.timerCheck.Text = "time";
            
            timer.Enabled = false;
            timer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void generator_Click(object sender, EventArgs e)
        {
            this.s1 = proces.Text;
            this.s2 = proces.Text;

            this.m = Convert.ToInt16(s1);
            this.p = Convert.ToInt16(s2);

            if (this.m < 0)
            {
                this.m = (-1) * this.m;
            }

            if (this.p < 0)
            {
                this.p = (-1) * this.p;
            }

            if (this.a == 0)
            {

                proc = new int[this.p];//proces
                tabY = new int[this.p];

                memor = new int[this.m];//pamiec
                tabX = new int[this.m];

                for (int i = 0; i < this.p; i++)
                {
                    proc[i] = x.Next(30, 450);
                }

                for (int i = 0; i < this.m; i++)
                {
                    memor[i] = x.Next(40, 500);
                }

                if (this.first.Checked && this.s1 != null && this.s2 != null && this.a == 0)
                {

                    for (int i = 0; i < this.p; i++)
                    {
                        for (int j = 0; j < this.m; j++)
                        {
                            if (proc[j] <= memor[i] && proc[j] != 0)
                            {
                                memor[i] -= proc[j];
                                tabX[i] = memor[i];
                                tabY[j] = proc[j];

                                proc[j] = 0;
                            }
                        }
                    }
                    a++;
                }


                if (this.best.Checked && this.s1 != null && this.s2 != null && this.a == 0)
                {
                    //sortowanie
                    for (int i = 0; i < this.m; i++)
                    {
                        for (int j = 0; j < this.m - 1; j++)
                        {
                            if (memor[j] > memor[j + 1])
                            {
                                temp = memor[i];
                                memor[i] = memor[j];
                                memor[j] = temp;
                            }
                        }
                    }

                    for (int i = 0; i < this.p; i++)
                    {
                        for (int j = 0; j < this.m; j++)
                        {
                            if (proc[j] <= memor[i] && proc[j] != 0)
                            {
                                memor[i] -= proc[j];
                                tabX[i] = memor[i];
                                tabY[j] = proc[j];

                                proc[j] = 0;
                            }

                        }
                    }
                    a++;
                }

                if (this.worst.Checked && this.s1 != null && this.s2 != null && this.a == 0)
                {
                    //sortowanie
                    for (int i = 0; i < this.m; i++)
                    {
                        for (int j = 0; j < this.m; j++)
                        {
                            if (memor[i] < memor[j])
                            {
                                temp = memor[i];
                                memor[i] = memor[j];
                                memor[j] = temp;

                            }
                        }
                    }



                    for (int i = 0; i < this.p; i++)
                    {
                        for (int j = 0; j < this.m; j++)
                        {
                            if (proc[j] <= memor[i] && proc[j] != 0)
                            {
                                memor[i] -= proc[j];
                                tabX[i] = memor[i];
                                tabY[j] = proc[j];

                                proc[j] = 0;
                            }

                        }
                    }
                    a++;
                }
            }
            timer.Enabled = true;
            timer.Start();
        }

       
    }
}
