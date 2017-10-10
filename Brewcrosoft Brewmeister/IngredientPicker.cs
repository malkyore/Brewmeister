using Brewcrosoft_Brewmeister.Data;
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
    public partial class IngredientPicker : Form
    {
        public string currentSelectedRecipe { get { return selectedKey; } }
        public string dataurl;
        List<hop2> hopList = new List<hop2>();
        List<fermentable2> fermentableList = new List<fermentable2>();
        List<yeast2> yeastList = new List<yeast2>();
        List<adjunct2> adjunctList = new List<adjunct2>();
        List<style> styleList = new List<style>();
        public String selectedKey;
        public string versionName;
        public IngredientPicker(string version)
        {
            versionName = version;
            InitializeComponent();
            switch (versionName)
            {
                case "Hops":
                    IngredientGrid.Columns.Add("Name", "Name");
                    IngredientGrid.Columns.Add("AAU", "AAU");
                    break;
                case "Malts":
                    IngredientGrid.Columns.Add("Name", "Name");
                    IngredientGrid.Columns.Add("PPG", "PPG");
                    IngredientGrid.Columns.Add("Color", "Color");
                    IngredientGrid.Columns.Add("Type", "Type");
                    IngredientGrid.Columns.Add("Maltster", "Maltster");
                    break;
                case "Yeasts":
                    IngredientGrid.Columns.Add("Lab", "Lab");
                    IngredientGrid.Columns.Add("Product", "Product");
                    IngredientGrid.Columns.Add("Attenuation", "Attenuation");
                    break;
                case "Adjuncts":
                    IngredientGrid.Columns.Add("Name", "Name");
                    break;
                case "Style":
                    IngredientGrid.Columns.Add("Name", "Name");
                    IngredientGrid.Columns.Add("Type", "Type");
                    break;
            }
            populateGrid();
        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            CompleteDialogAction();
        }

        private void CompleteDialogAction()
        {
            switch (versionName)
            {
                case "Hops":
                    selectedKey = hopList[IngredientGrid.CurrentCell.RowIndex].id;
                    break;
                case "Malts":
                    selectedKey = fermentableList[IngredientGrid.CurrentCell.RowIndex].id;
                    break;
                case "Yeasts":
                    selectedKey = yeastList[IngredientGrid.CurrentCell.RowIndex].id;
                    break;
                case "Adjuncts":
                    selectedKey = adjunctList[IngredientGrid.CurrentCell.RowIndex].id;
                    break;
                case "Style":
                    selectedKey = styleList[IngredientGrid.CurrentCell.RowIndex].id;
                    break;

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void loadIngredientsOnFormLoad(object sender, EventArgs e)
        {
            APIHandler handler = new APIHandler();
            string jsonurl = "";
            switch (versionName)
            {
                case "Hops":
                    jsonurl = dataurl + "/hop";
                    hopList = handler.getHops();
                    break;
                case "Malts":
                    jsonurl = dataurl + "/fermentables";
                    fermentableList = handler.getFermentables();
                    break;
                case "Yeasts":
                    jsonurl = dataurl + "/yeast";
                    yeastList = handler.getYeasts();
                    break;
                case "Adjuncts":
                    jsonurl = dataurl + "/adjunct";
                    adjunctList = handler.getAdjuncts();
                    break;
                case "Style":
                    styleList = handler.getStyles();
                    break;
            }
            populateGrid();
        }


        private void populateGrid()
        {
            IngredientGrid.Rows.Clear();
            int i = 0;
            switch (versionName)
            {
                case "Hops":
                    foreach (hop2 element in hopList)
                    {
                        IngredientGrid.Rows.Add(hopList[i].name, hopList[i].aau);
                        i++;
                    }
                    break;
                case "Malts":
                    foreach (fermentable2 element in fermentableList)
                    {
                        IngredientGrid.Rows.Add(fermentableList[i].name, fermentableList[i].ppg, fermentableList[i].color, fermentableList[i].type, fermentableList[i].maltster);
                        i++;
                    }
                    break;
                case "Yeasts":
                    foreach (yeast2 element in yeastList)
                    {
                        IngredientGrid.Rows.Add(yeastList[i].lab, yeastList[i].name, yeastList[i].attenuation);
                        i++;
                    }
                    break;
                case "Adjuncts":
                    foreach (adjunct2 element in adjunctList)
                    {
                        IngredientGrid.Rows.Add(adjunctList[i].name);
                        i++;
                    }
                    break;
                case "Style":
                    foreach (style element in styleList)
                    {
                        IngredientGrid.Rows.Add(styleList[i].name, styleList[i].type);
                        i++;
                    }
                    break;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                switch (versionName)
            {
                case "Hops":
                        selectedKey = hopList[IngredientGrid.CurrentRow.Index].id;
                    break;
                case "Malts":
                        selectedKey = fermentableList[IngredientGrid.CurrentRow.Index].id;
                        break;
                    case "Adjuncts":
                        selectedKey = adjunctList[IngredientGrid.CurrentRow.Index].id;
                        break;
            }
            }
            catch (Exception ed)
            {

            }

        }

        private void RecipeGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CompleteDialogAction();
            }
        }

        private void RecipeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CompleteDialogAction();
        }
    }
}
