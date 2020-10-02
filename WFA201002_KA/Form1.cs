using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA201002_KA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var txt = new Label();
            txt.SetBounds(0, 0, 2000, 20);
            txt.Text = "Hello World";
            Controls.Add(txt);
        }
    }
}
