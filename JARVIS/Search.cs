using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JARVIS
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        public string inputFound()
        {
            string filename = input.Text;
            if (filename.Contains('.'))
            {
                filename = filename.Substring(0, filename.IndexOf('.'));
            }
            return filename;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string toSearch = inputFound();

            this.Close();
        }
    }
}
