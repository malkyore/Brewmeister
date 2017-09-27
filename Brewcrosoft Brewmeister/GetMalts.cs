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
    public partial class GetMalts : Form
    {
        public string currentSelectedRecipe { get { return selectedKey; } }
        public string dataurl;
        List<fermentable2> recipeList = new List<fermentable2>();
        public String selectedKey;
        public GetMalts()
        {
            InitializeComponent();
            RecipeGrid.Columns.Add("Name", "Name");
            RecipeGrid.Columns.Add("PPG", "PPG");
            RecipeGrid.Columns.Add("Color", "Color");
            RecipeGrid.Columns.Add("Type", "Type");
            RecipeGrid.Columns.Add("Maltster", "Maltster");
            populateGrid();
        }

        private void GetRecipeButton_Click(object sender, EventArgs e)
        {
            APIHandler handler = new APIHandler();
            string jsonurl = dataurl + "/recipe";
            List<loadedRecipe> recipeList = handler.loadRecipes(jsonurl);
            populateGrid();
        }

        private void loadRecipesOnFormLoad(object sender, EventArgs e)
        {
            APIHandler handler = new APIHandler();
            string jsonurl = dataurl + "/fermentables";
            recipeList = handler.getFermentables();
            populateGrid();
        }


        private void populateGrid()
        {
            RecipeGrid.Rows.Clear();
            int i = 0;
            foreach (fermentable2 element in recipeList)
            {
                RecipeGrid.Rows.Add(recipeList[i].name, recipeList[i].ppg, recipeList[i].color, recipeList[i].type, recipeList[i].maltster);
                i++;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                selectedKey = recipeList[RecipeGrid.CurrentRow.Index].id;
            }
            catch (Exception ed)
            {

            }
        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            selectedKey = recipeList[RecipeGrid.CurrentCell.RowIndex].id;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RecipeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
