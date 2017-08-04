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
    public partial class Add_Malt : Form
    {
        public string MaltName { get; set; }
        public float Weight { get; set; }
        public float PPG { get; set; }
        public float MaltColor { get; set; }
        public string Extract { get; set; }
        public Add_Malt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MaltName = BeerNameBox.Text;
            this.Weight = float.Parse(WeightBox.Text);
            this.PPG = float.Parse(PPGBox.Text);
            this.MaltColor = float.Parse(ColorBox.Text);
            this.Extract = ExtractCheck.CheckState.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
