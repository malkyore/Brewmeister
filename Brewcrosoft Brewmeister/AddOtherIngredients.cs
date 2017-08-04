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
    public partial class AddOtherIngredients : Form
    {
        public string Name { get; set; }
        public float Amount { get; set; }
        public string Type { get; set; }

        public AddOtherIngredients()
        {
            InitializeComponent();
            TypeBox.Items.Add("Boil");
            TypeBox.Items.Add("Whirlpool");
            TypeBox.Items.Add("Dry Hop");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Name = NameBox.Text;
            this.Type = TypeBox.Text;

            try
            {
                this.Amount = float.Parse(AmountBox.Text);

            }
            catch(Exception exchdhdf)
            {
                MessageBox.Show("Enter a numeric amount");
                return;   
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
