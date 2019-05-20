using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformShowPdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            btnOpen.Click += (o, ex) =>
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Navigate(openFileDialog1.FileName);
                }
            };
        }
    }
}
