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
    public partial class GetHops : Form
    {
        public string currentSelectedRecipe { get { return selectedKey; } }
        public string dataurl;
        List<hop2> recipeList = new List<hop2>();
        public String selectedKey;
        public GetHops()
        {
            InitializeComponent();
            RecipeGrid.Columns.Add("Name", "Name");
            RecipeGrid.Columns.Add("AAU", "AAU");
            // RecipeGrid.Columns.Add("Description", "Description");
            // RecipeGrid.Columns.Add("ABV", "ABV");
            // RecipeGrid.Columns.Add("IBU", "IBU");
            populateGrid();
        }

        private void GetRecipeButton_Click(object sender, EventArgs e)
        {
            APIHandler handler = new APIHandler();
            string jsonurl = dataurl + "/recipe";
            List<loadedRecipe> recipeList = handler.loadRecipes(jsonurl);
            populateGrid();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            selectedKey = recipeList[RecipeGrid.CurrentCell.RowIndex].id;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    
       private void loadRecipesOnFormLoad(object sender, EventArgs e)
       {
           APIHandler handler = new APIHandler();
           string jsonurl = dataurl + "/hop";
            recipeList = handler.getHops();
           populateGrid();
       }
    
    
       private void populateGrid()
       {
           RecipeGrid.Rows.Clear();
           int i = 0;
           foreach (hop2 element in recipeList)
           {
               RecipeGrid.Rows.Add(recipeList[i].name, recipeList[i].aau);
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

    }
}
