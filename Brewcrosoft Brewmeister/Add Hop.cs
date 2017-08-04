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
    public partial class Add_Hop : Form
    {
        public string HopName { get; set; }
        public float Amount { get; set; }
        public float AAU { get; set; }
        public float Time { get; set; }
        public string HopType { get; set; }
        public Add_Hop()
        {
            InitializeComponent();
            HopTypeBox.Items.Add("Boil");
            HopTypeBox.Items.Add("Dry Hop");
            HopTypeBox.Items.Add("Whirlpool");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.HopName = HopNameBox.Text;
            try
            {
                this.Amount = float.Parse(AmountBox.Text);
            }
            catch (Exception ecrpskfd)
            {
                MessageBox.Show("ENTER A NUMBER FOR THE AMOUNT!");
                return;
            }
            this.AAU = float.Parse(AAUBox.Text);
            this.Time = float.Parse(TimeBox.Text);
            this.HopType = HopTypeBox.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
