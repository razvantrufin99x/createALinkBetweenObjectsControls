using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace createALinkBetweenObjectsControls
{
    public partial class controlUtilizator : UserControl
    {
        public controlUtilizator()
        {
            InitializeComponent();
        }

        public Form1 f;
        public bool ismd = false;

        private void controlUtilizator_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch { }
        }

        private void controlUtilizator_Click(object sender, EventArgs e)
        {
            f.setControlUsed(this);
        }

        private void controlUtilizator_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;
        }

        private void controlUtilizator_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == true)
            {
                this.Left += e.X;
                this.Top += e.Y;
                f.ClearAll();
            }
        }

        private void controlUtilizator_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;
            
        }
    }
}
