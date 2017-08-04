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
    public partial class AddYeast : Form
    {
        public string Lab { get; set; }
        public string Product { get; set; }
        public string Flocculation { get; set; }
        public float Attenuation { get; set; }
        public string AlcoholTolerance { get; set; }
        public string YeastType { get; set; }
        public float  TempRangeStart { get; set; }
        public float TempRangeEnd { get; set; } 
        public AddYeast()
        {
            InitializeComponent();
            FlocculationBox.Items.Add("Low");
            FlocculationBox.Items.Add("Medium-Low");
            FlocculationBox.Items.Add("Medium");
            FlocculationBox.Items.Add("Medium-High");
            FlocculationBox.Items.Add("High");

            AlcoholtoleranceBox.Items.Add("Low");
            AlcoholtoleranceBox.Items.Add("Medium");
            AlcoholtoleranceBox.Items.Add("High");

            TypeBox.Items.Add("Liquid");
            TypeBox.Items.Add("Powdered");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Lab = LabBox.Text;
            this.Product = Productbox.Text;
            //this.Flocculation = FlocculationBox.SelectedItem.ToString();
            this.Attenuation = float.Parse(Attenuationbox.Text);
            //this.YeastType = TypeBox.SelectedItem.ToString();
            //this.AlcoholTolerance = AlcoholtoleranceBox.SelectedItem.ToString();
            //this.TempRangeStart = float.Parse(TempRangeStartBox.Text);
            //this.TempRangeEnd = float.Parse(TempRangeStopBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
