using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JARVIS
{
    public partial class googleOther : Form
    {
        public googleOther()
        {
            InitializeComponent();
        }

        public void searchGoogle()
        {
            string toSearch = input.Text;
            string searchTemplate = "www.google.com/search?q=";
            Process.Start(searchTemplate + toSearch);
            this.Close();
        }


    }
}
