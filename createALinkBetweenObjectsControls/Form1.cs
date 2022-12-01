using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace createALinkBetweenObjectsControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;

        public List<controlUtilizator> ctrls = new List<controlUtilizator>();

        public void setControlUsed(controlUtilizator ctrl)
        {
            if (ctrls.Count < 2)
            {
                ctrls.Add(ctrl);
            }
            else
            {
                ctrls.Add(ctrl);
            }

        }

        public void ClearAll()
        {
            g.Clear(Color.White);
            redrawAllShapes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            g.DrawLine(new Pen(Color.Black), controlUtilizator3.Left, controlUtilizator3.Top, controlUtilizator4.Left, controlUtilizator4.Top);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ctrls.Count == 2)
            {
             
              
                g.DrawLine(new Pen(Color.Black), ctrls[0].Left, ctrls[0].Top, ctrls[1].Left, ctrls[1].Top);
        
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        public void redrawAllShapes()
        {
             for (int i = 0; i < ctrls.Count; i++)
            {
                try
                {
                    g.DrawLine(new Pen(Color.Black), ctrls[i].Left, ctrls[i].Top, ctrls[i + 1].Left, ctrls[i + 1].Top);
                }
                catch { }
         
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

            redrawAllShapes();
        }
    }
}
