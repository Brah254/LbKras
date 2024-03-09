using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logicar;

namespace fullversionlab4
{
    public partial class Form1 : Form
    {
        private Class1 logicar;

        public Form1()
        {
            InitializeComponent();

            logicar = new Class1();
            logicar.SharedNumberChanged += Logicar_SharedNumberChanged;
        }

        public void Logicar_SharedNumberChanged(object sender, int newValue)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() =>
                {
                    label3.Text = newValue.ToString();
                    label4.Text = newValue.ToString();
                }));
            }
            else
            {
                label3.Text = newValue.ToString();
                label4.Text = newValue.ToString();
            }
        }
    }
}
