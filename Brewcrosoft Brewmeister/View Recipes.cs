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

namespace Brewcrosoft_Brewmeister
{
    public partial class View_Recipes : Form
    {
        public string currentSelectedRecipe { get { return selectedKey; } }
        public string dataurl;
        public List<loadedRecipe> recipeList = new List<loadedRecipe>();
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
            string jsonurl = dataurl + "/recipe";
            loadRecipes(jsonurl);
            populateGrid();
        }

        private void GetRecipeButton_Click(object sender, EventArgs e)
        {
            string jsonurl = dataurl + "/recipe";
            loadRecipes(jsonurl);
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

        private loadedRecipe loadRecipes(string jsonurl)
        {
            var json = new WebClient().DownloadString(jsonurl);
            var objects = JArray.Parse(json);
            int i = 0;
            loadedRecipe currentRecipe = new loadedRecipe();
            foreach (JObject root in objects)
            {
                currentRecipe = new loadedRecipe();
                foreach (KeyValuePair<String, JToken> recipeFromJson in root)
                {
                    switch (recipeFromJson.Key)
                    {
                        case "name":
                            currentRecipe.name = (String)recipeFromJson.Value;
                            break;
                        case "style":
                            currentRecipe.style = (String)recipeFromJson.Value;
                            break;
                        case "description":
                            currentRecipe.description = (String)recipeFromJson.Value;
                            break;
                        case "abv":
                            currentRecipe.abv = (float)recipeFromJson.Value;
                            break;
                        case "ibu":
                            currentRecipe.ibu = (float)recipeFromJson.Value;
                            break;
                        case "id":
                            currentRecipe.key = (String)recipeFromJson.Value;
                            break;
                    }

                }
                recipeList.Add(currentRecipe);
            }
            return currentRecipe;
        }
    }


    public class loadedRecipe
    {
        public String key;
        public String name;
        public String style;
        public String description;
        public float abv;
        public float ibu;

    }
}
