using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brewcrosoft_Brewmeister
{
    
    public partial class New_Beer : Form
    {
        public string BeerName { get; set; }
        public string BeerStyle { get; set; }
        public string BeerDescription { get; set; }
        public New_Beer()
        {
            InitializeComponent();
        }

        private void SaveBeerButton_Click(object sender, EventArgs e)
        {
            BeerName = BeerNameBox.Text;
            BeerStyle = BeerStyleBox.Text;
            BeerDescription = BeerDescriptionBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
