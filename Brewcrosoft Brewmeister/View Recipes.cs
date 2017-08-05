using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brewcrosoft_Brewmeister.Data;

namespace Brewcrosoft_Brewmeister
{
    public partial class View_Recipes : Form
    {
        public string currentSelectedRecipe { get { return selectedKey; } }
        public string dataurl;
        List<loadedRecipe> recipeList = new List<loadedRecipe>();
        public String selectedKey;
        public View_Recipes()
        {
            InitializeComponent();
            RecipeGrid.Columns.Add("Name", "Name");
            RecipeGrid.Columns.Add("Style", "Style");
            RecipeGrid.Columns.Add("Description", "Description");
            RecipeGrid.Columns.Add("ABV", "ABV");
            RecipeGrid.Columns.Add("IBU", "IBU");
        }

        private void loadRecipesOnFormLoad(object sender, EventArgs e)
        {
            APIHandler handler = new APIHandler();
            string jsonurl = dataurl + "/recipe";
            recipeList = handler.loadRecipes(jsonurl);
            populateGrid();
        }

        private void GetRecipeButton_Click(object sender, EventArgs e)
        {
            APIHandler handler = new APIHandler();
            string jsonurl = dataurl + "/recipe";
            List<loadedRecipe> recipeList = handler.loadRecipes(jsonurl);
            populateGrid();
        }

        private void populateGrid()
        {
            RecipeGrid.Rows.Clear();
            int i = 0;
            foreach (loadedRecipe element in recipeList)
            {
                RecipeGrid.Rows.Add(recipeList[i].name, recipeList[i].style, recipeList[i].description, recipeList[i].abv, recipeList[i].ibu);
                i++;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                selectedKey = recipeList[RecipeGrid.CurrentRow.Index].key;
            }
            catch (Exception ed)
            {

            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }


    
}
