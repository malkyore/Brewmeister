using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net.Http;
using Brewcrosoft_Brewmeister.Data;
using Newtonsoft.Json;

namespace Brewcrosoft_Brewmeister
{
    public partial class HomeScreen : Form
    {
        //rest url
        public string dataurl = "http://rest.unacceptable.beer:2403";

        public recipe2 currentRecipe = new recipe2();

        public String currentRecipeKey;

        //Statistical information holder
        //public recipe.BeerStats beerStatistics = new recipe.BeerStats();

        public static String BeerName = "";
        public static String BeerStyle = "";
        public String BeerDescription = "";
        public String BeerCreatedDate = "";
        public String RecipeFileLocation = "";
        public String IngredientFileLocation = "";
        public string CurrentRecipeLocation { get; set; }
        public string LastOpenedFileLocation = "";
        public HomeScreen()
        {
            InitializeComponent();
            Era1Button.Enabled = false;
            Era2Button.Enabled = false;
            Era3Button.Enabled = false;
            Era4Button.Enabled = false;
            Era5Button.Enabled = false;
            BeerNameBox.Enabled = false;
            BeerStyleBox.Enabled = false;
            BeerDescriptionBox.Enabled = false;

            //Set the statistical information
          //  currentRecipe.beerStatistics.PPGPoints = 0;
          //  currentRecipe.beerStatistics.SRM = 0;
          //  currentRecipe.beerStatistics.CurrentOG = 0;
          //  currentRecipe.beerStatistics.CurrentFG = 0;
          //  currentRecipe.beerStatistics.CurrentABV = 0;
          //  currentRecipe.beerStatistics.KitEfficiency = 0.70;//for now....
          //  currentRecipe.beerStatistics.IntoFermenterVolume = 5;//for now...


            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            if (adsfa != null)
            { 
                dataurl = "" + adsfa.GetValue("dataurl");
                currentRecipeKey = "" + adsfa.GetValue("LastOpenedRecipe");
                try
                {
                    LastOpenedFileLocation = "" + adsfa.GetValue("LastOpenedFileLocation");
                    //openFile(LastOpenedFileLocation);
                    adsfa.Close();
                    loadRecipe();
                    populateMainScreen();
                }
                catch (Exception esdjjs)
                {

                }
               
            }
            else
            {
                API_URL_Settings settings = new API_URL_Settings();
                settings.ShowDialog();
                dataurl = settings.restAPIURL;
                    adsfa = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE/Brewmeister");
                    adsfa.SetValue("dataurl", dataurl);
                    adsfa.SetValue("LastOpenedRecipe", "");
                adsfa.Close();
            }
            if(currentRecipeKey != null && currentRecipeKey != "")
            {
                Era1Button.Enabled = true;
            }
        }
        private void populateMainScreen()
        {
            BeerNameBox.Text = currentRecipe.name;
            BeerDescriptionBox.Text = currentRecipe.description;
            BeerStyleBox.Text = currentRecipe.style;

            //Add stuff to handle the button enabler things here too
        }

        private void OpenRecipeCreator_Click(object sender, EventArgs e)
        {
            Recipe_Creator recipemaker = new Recipe_Creator();
            var result = recipemaker.ShowDialog();
            if (result == DialogResult.OK)
            {
              //  currentRecipe.beerStatistics.PPGPoints = recipemaker.PPGPoints;
              //  currentRecipe.beerStatistics.SRM = recipemaker.SRM;
              //  currentRecipe.beerStatistics.CurrentOG = recipemaker.CurrentOG;
              //  currentRecipe.beerStatistics.CurrentFG = recipemaker.CurrentFG;
              //  currentRecipe.beerStatistics.CurrentABV = recipemaker.CurrentABV;
              //  currentRecipe.beerStatistics.KitEfficiency = recipemaker.KitEfficiency;
              //  currentRecipe.beerStatistics.IntoFermenterVolume = recipemaker.IntoFermenterVolume;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newBeerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var newBeer = new New_Beer())
            {
                var result = newBeer.ShowDialog(); ;
                recipe2 newRecipe = new recipe2();
                if (result == DialogResult.OK)
                {
                    newRecipe.name = newBeer.BeerName;
                    newRecipe.style = newBeer.BeerStyle;
                    newRecipe.description = newBeer.BeerDescription;
                    APIHandler handler = new APIHandler();
                   // handler.postRecipe(newRecipe);
                }
            }
        }

        private void fileLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLocationSettings fls = new FileLocationSettings();
            fls.ShowDialog();
        }

        private void openBeerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String FilePath = "";
            String[] linesFromFile;
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();

          //  currentRecipe.beerStatistics.PPGPoints = 0;
          //  currentRecipe.beerStatistics.SRM = 0;
          //  currentRecipe.beerStatistics.CurrentOG = 0;
          //  currentRecipe.beerStatistics.CurrentFG = 0;
          //  currentRecipe.beerStatistics.CurrentABV = 0;
          //  currentRecipe.beerStatistics.KitEfficiency = 0.70;//for now....
          //  currentRecipe.beerStatistics.IntoFermenterVolume = 5;//for now...
            
                        RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister", true);
                        if (adsfa != null)
                        {
                            adsfa.SetValue("LastOpenedFileLocation", FilePath);
                        }
                        else
                        {
                            adsfa = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE/Brewmeister");
                            adsfa.SetValue("LastOpenedFileLocation", FilePath);
                        }
                        adsfa.Close();

                        Era1Button.Enabled = true;
                    }


        private void hopname_Click(object sender, EventArgs e)
        {

        }

        private void getButton_Click(object sender, EventArgs e)
        {
            string jsonurl = dataurl + "/hop?name=" + hopnamebox.Text;
            var json = new WebClient().DownloadString(jsonurl);
            var objects = JArray.Parse(json);
            int i = 0;
            foreach(JObject root in objects)
            {
                foreach(KeyValuePair<String, JToken> hop in root)
                {
                    if (i == 0)
                    {
                        String hopnamefromjson = (String)hop.Value;
                        hopname.Text = hopnamefromjson;
                        i++;
                    } else if (i == 1)
                    {
                        String hopnamefromjson = (String)hop.Value;
                        hopaau.Text = hopnamefromjson;
                        i++;
                    }
                    
                }
            }
        }

        private void postbutton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(dataurl);
            var request = new RestRequest("/hop/", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
             name = postnamebox.Text,
             aau = postaaubox.Text
            }); // AddJsonBody serializes the object automatically

            IRestResponse response = client.Execute(request);
        }

        private void viewRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Recipes recipeViewer = new View_Recipes();
            recipeViewer.dataurl = dataurl;
            recipeViewer.ShowDialog();
            currentRecipeKey = recipeViewer.currentSelectedRecipe;
            if (currentRecipeKey != null)
            {
                loadRecipe();
                populateMainScreen();
                Era1Button.Enabled = true;
            }
        }

        private void loadRecipe()
        {
            //load recipe
            //http://rest.unacceptable.beer:2403/recipe?id=decef696bf3f7806&include=fullrecipe

            string jsonurl = dataurl + "/recipe?id=" + currentRecipeKey + "&include=fullrecipe";
            string json = new WebClient().DownloadString(jsonurl);
            APIHandler handler = new APIHandler();
            currentRecipe = handler.loadRecipe(currentRecipeKey);
            //currentRecipe = JsonConvert.DeserializeObject<recipe2>(json);
            int i = 1;

            //currentRecipe.name = rootObject.name;

            //var objects = JArray.Parse(json);
            //int i = 0;
            //foreach (JObject root in objects)
            //{
            //    foreach (KeyValuePair<String, JToken> recipeFromJson in root)
            //    {
            //        switch (recipeFromJson.Key)
            //        {
            //            case "name":
            //                currentRecipe.name = (String)recipeFromJson.Value;
            //                break;
            //            case "style":
            //                currentRecipe.style = (String)recipeFromJson.Value;
            //                break;
            //            case "description":
            //                currentRecipe.description = (String)recipeFromJson.Value;
            //                break;
            //            case "abv":
            //                currentRecipe.abv = (float)recipeFromJson.Value;
            //                break;
            //            case "ibu":
            //                currentRecipe.ibu = (float)recipeFromJson.Value;
            //                break;
            //            case "fg":
            //                currentRecipe.fg = (float)recipeFromJson.Value;
            //                break;
            //            case "og":
            //                currentRecipe.og = (float)recipeFromJson.Value;
            //                break;
            //            case "srm":
            //                currentRecipe.srm = (float)recipeFromJson.Value;
            //                break;
            //            case "version":
            //                currentRecipe.version = (float)recipeFromJson.Value;
            //                break;
            //            case "parentRecipe":
            //                currentRecipe.parentRecipe = (String)recipeFromJson.Value;
            //                break;
            //            case "clonedFrom":
            //                currentRecipe.clonedFrom = (String)recipeFromJson.Value;
            //                break;
            //            case "hidden":
            //                currentRecipe.hidden = (String)recipeFromJson.Value;
            //                break;
            //            case "id":
            //                currentRecipe.key = (String)recipeFromJson.Value;
            //                break;
            //        }
            //    }
            //}

            //load fermentables
            //jsonurl = dataurl + "/fermentableaddition?recipeid=" + currentRecipeKey;
            //if there's only one hop this might break
            //json = new WebClient().DownloadString(jsonurl);
            //objects = JArray.Parse(json);
            //i = 0;
            //foreach (JObject root in objects)
            //{
            //    foreach (KeyValuePair<String, JToken> recipeFromJson in root)
            //    {
            //        switch (recipeFromJson.Key)
            //        {
            //            case "name":
            //                currentRecipe.name = (String)recipeFromJson.Value;
            //                break;
            //        }
            //    }
            //}
            //load hops

            //load yeasts

            //load adjuncts
            RegistryKey adsfa = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister", RegistryKeyPermissionCheck.ReadWriteSubTree);
            adsfa.SetValue("LastOpenedRecipe", currentRecipeKey);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string jsonurl = "http://rest.unacceptable.beer:2403/recipe?name=Recipe1&include=fullrecipe"; //dataurl + "/hop?name=" + hopnamebox.Text;
            var json = new WebClient().DownloadString(jsonurl);
            var objects = JArray.Parse(json);
            int i = 0;
            foreach (JObject root in objects)
            {
                foreach (KeyValuePair<String, JToken> recipeFromJson in root)
                {
                    switch (recipeFromJson.Key)
                    {
                        case "name":
                            currentRecipe.name = (String)recipeFromJson.Value;
                            break;
                    }
                }
            }
        }

        private void loadRecipeList()
        {

        }

        private void loadRecipeFromId()
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ingredientManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngredientManager manager = new IngredientManager();
            manager.Show();
        }
    }
}
