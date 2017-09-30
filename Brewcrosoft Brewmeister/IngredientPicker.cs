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
                    populateGrid();
                    break;
                case "Malts":
                    jsonurl = dataurl + "/fermentables";
                    fermentableList = handler.getFermentables();
                    populateGrid();
                    break;
            }
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
