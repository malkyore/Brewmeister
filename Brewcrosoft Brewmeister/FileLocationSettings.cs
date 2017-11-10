using Microsoft.Win32;
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
    public partial class FileLocationSettings : Form
    {
        public FileLocationSettings()
        {
            InitializeComponent();
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            if (adsfa != null)
            {
                RecipeLocationBox.Text = "" + adsfa.GetValue("RecipeFileLocation");
                IngredientLocationBox.Text = "" + adsfa.GetValue("IngredientFileLocation");
                DeploydBox.Text = "" + adsfa.GetValue("DeploydAddress");
                BeerNetBox.Text = "" + adsfa.GetValue("BeerNetAddress");
                if(adsfa.GetValue("DataProvider").ToString() == "True")
                {
                    beerNetRadio.Checked = true;
                }
                else
                {
                    deploydRadio.Checked = true;
                }
                adsfa.Close();
            }
            
        }

        private void OpenRecipeFileLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                RecipeLocationBox.Text = openFileDialog1.SelectedPath;
            }

        }

        private void OpenIngredientFileLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                IngredientLocationBox.Text = openFileDialog1.SelectedPath;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (beerNetRadio.Checked != true && deploydRadio.Checked != true)
            {
                MessageBox.Show("Select a data provider");
            }
            else
            {
                RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister", true);
                if (adsfa != null)
                {
                    adsfa.SetValue("RecipeFileLocation", RecipeLocationBox.Text);
                    adsfa.SetValue("IngredientFileLocation", IngredientLocationBox.Text);
                    adsfa.SetValue("DeploydAddress", DeploydBox.Text);
                    adsfa.SetValue("BeerNetAddress", BeerNetBox.Text);
                    adsfa.SetValue("DataProvider", beerNetRadio.Checked);
                }
                else
                {
                    adsfa = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE/Brewmeister");
                    adsfa.SetValue("RecipeFileLocation", RecipeLocationBox.Text);
                    adsfa.SetValue("IngredientFileLocation", IngredientLocationBox.Text);
                    adsfa.SetValue("DeploydAddress", DeploydBox.Text);
                    adsfa.SetValue("BeerNetAddress", BeerNetBox.Text);
                    adsfa.SetValue("DataProvider", beerNetRadio.Checked);
                }
                adsfa.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
