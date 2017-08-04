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

namespace Brewcrosoft_Brewmeister
{
    public partial class HomeScreen : Form
    {
        //rest url
        public string dataurl = "http://rest.unacceptable.beer:2403";

        public recipe currentRecipe = new recipe();

        public String currentRecipeKey;

        //Statistical information
        public float PPGPoints = 0;
        public float SRM = 0;
        public double CurrentOG = 0;
        public double CurrentFG = 0;
        public double CurrentABV = 0;
        public double KitEfficiency = 0.70;//for now....
        public float IntoFermenterVolume = 5;//for now...

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

            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            if (adsfa != null)
            { 
                dataurl = "" + adsfa.GetValue("dataurl");
                currentRecipeKey = "" + adsfa.GetValue("LastOpenedRecipe");
                try
                {
                    LastOpenedFileLocation = "" + adsfa.GetValue("LastOpenedFileLocation");
                    openFile(LastOpenedFileLocation);
                }
                catch (Exception esdjjs)
                {

                }
                adsfa.Close();
                loadRecipe();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recipe_Creator recipemaker = new Recipe_Creator(BeerName, BeerStyle);
            recipemaker.BeerStyle = BeerStyle;
            recipemaker.BeerName = BeerName;
            recipemaker.BeerDescription = BeerDescription;
            recipemaker.RecipeFileLocation = RecipeFileLocation;
            recipemaker.IngredientFileLocation = IngredientFileLocation;
            recipemaker.setVars(BeerName, BeerStyle);
            recipemaker.PPGPoints = this.PPGPoints;
            recipemaker.SRM = this.SRM;
            recipemaker.CurrentOG = this.CurrentOG;
            recipemaker.CurrentFG = this.CurrentFG;
            recipemaker.CurrentABV = this.CurrentABV;
            recipemaker.KitEfficiency = this.KitEfficiency;
            recipemaker.IntoFermenterVolume = this.IntoFermenterVolume;

            recipemaker.PopulateMaltList();
            recipemaker.PopulateHopList();
            recipemaker.PopulateYeastList();
            recipemaker.RefreshStatistics();
            recipemaker.PopulateOtherList();



            var result = recipemaker.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.PPGPoints = recipemaker.PPGPoints;
                this.SRM = recipemaker.SRM;
                this.CurrentOG = recipemaker.CurrentOG;
                this.CurrentFG = recipemaker.CurrentFG;
                this.CurrentABV = recipemaker.CurrentABV;
                this.KitEfficiency = recipemaker.KitEfficiency;
                this.IntoFermenterVolume = recipemaker.IntoFermenterVolume;
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
                if (result == DialogResult.OK)
                {
                    BeerName = newBeer.BeerName;
                    BeerStyle = newBeer.BeerStyle;
                    BeerDescription = newBeer.BeerDescription;

                    BeerNameBox.Text = BeerName;
                    BeerStyleBox.Text = BeerStyle;
                    BeerDescriptionBox.Text = BeerDescription;
                    BeerNameBox.Enabled = true;
                    BeerStyleBox.Enabled = true;
                    BeerDescriptionBox.Enabled = true;
                    Era1Button.Enabled = true;


                    //Statistical information
                    PPGPoints = 0;
                    SRM = 0;
                    CurrentOG = 0;
                    CurrentFG = 0;
                    CurrentABV = 0;
                    KitEfficiency = 0.70;//for now....
                    IntoFermenterVolume = 5;//for now...
                }
            }
        }

        private void fileLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLocationSettings fls = new FileLocationSettings();
            fls.ShowDialog();
        }

        private void openFile(String FilePath)
        {
            String[] linesFromFile;
            linesFromFile = File.ReadAllLines(FilePath);

            String[] chunks;
            chunks = linesFromFile[0].Split('\t');
            BeerName = chunks[0];
            BeerCreatedDate = chunks[1];
            BeerDescription = chunks[2];
            chunks = linesFromFile[1].Split('\t');
            BeerStyle = chunks[0];
            SRM = float.Parse(chunks[1]);
            CurrentOG = float.Parse(chunks[2]);
            CurrentABV = float.Parse(chunks[3]);
            for (int j = 0; j < linesFromFile.Length; j++)
            {
                if (j < 3)
                {

                }
                else
                {
                    chunks = linesFromFile[j].Split('\t');
                    switch (chunks[0])
                    {
                        case "MALTS":
                            while (chunks[0] != "ENDMALTS")
                            {
                                j++;
                                chunks = linesFromFile[j].Split('\t');
                                if (chunks[0] == "ENDMALTS")
                                {
                                    break;
                                }
                                else
                                {

                                    //MaltNameList.Add(chunks[0]);
                                    //WeightList.Add(float.Parse(chunks[1]));
                                    //PPGList.Add(float.Parse(chunks[2]));
                                    //ColorList.Add(float.Parse(chunks[3]));
                                    //ExtractList.Add(bool.Parse(chunks[4]));
                                }

                            }
                            break;
                        case "HOPS":
                            while (chunks[0] != "ENDHOPS")
                            {
                                j++;
                                chunks = linesFromFile[j].Split('\t');
                                if (chunks[0] == "ENDHOPS")
                                {
                                    break;
                                }
                                else
                                {
                                    //HopNameList.Add(chunks[0]);
                                    //HopAmountList.Add(float.Parse(chunks[1]));
                                    //AAUList.Add(float.Parse(chunks[2]));
                                    //HopTimeList.Add(float.Parse(chunks[3]));
                                    //HopTypeList.Add(chunks[4]);
                                }
                            }
                            break;
                        case "YEASTS":
                            while (chunks[0] != "ENDYEAST")
                            {
                                j++;
                                chunks = linesFromFile[j].Split('\t');
                                if (chunks[0] == "ENDYEAST")
                                {
                                    break;
                                }
                                else
                                {
                                    //YeastLabList.Add(chunks[0]);
                                    //YeastProductList.Add(chunks[1]);
                                    //YeastAttenuationList.Add(float.Parse(chunks[2]));
                                }
                            }
                            break;
                        case "ADJUNCTS":
                            while (chunks[0] != "ENDYEAST")
                            {
                                j++;
                                chunks = linesFromFile[j].Split('\t');
                                if (chunks[0] == "ENDADJUNCTS")
                                {
                                    break;
                                }
                                else
                                {
                                    //OtherIngredientName.Add(chunks[0]);
                                    //OtherIngredientAmount.Add(float.Parse(chunks[1]));
                                    //OtherIngredientType.Add(chunks[2]);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                Era1Button.Enabled = true;
            }
        }

        private void openBeerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String FilePath = "";
            String[] linesFromFile;
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            
                PPGPoints = 0;
                SRM = 0;
                CurrentOG = 0;
                CurrentFG = 0;
                CurrentABV = 0;
                KitEfficiency = 0.70;//for now....
                IntoFermenterVolume = 5;//for now...
            
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
            }
        }

        private void loadRecipe()
        {
            //load recipe
            string jsonurl = dataurl + "/recipe?id=" + currentRecipeKey;
            string json = "[" + new WebClient().DownloadString(jsonurl) + "]";
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
                        case "fg":
                            currentRecipe.fg = (float)recipeFromJson.Value;
                            break;
                        case "og":
                            currentRecipe.og = (float)recipeFromJson.Value;
                            break;
                        case "srm":
                            currentRecipe.srm = (float)recipeFromJson.Value;
                            break;
                        case "version":
                            currentRecipe.version = (float)recipeFromJson.Value;
                            break;
                        case "parentRecipe":
                            currentRecipe.parentRecipe = (String)recipeFromJson.Value;
                            break;
                        case "clonedFrom":
                            currentRecipe.clonedFrom = (String)recipeFromJson.Value;
                            break;
                        case "hidden":
                            currentRecipe.hidden = (String)recipeFromJson.Value;
                            break;
                        case "id":
                            currentRecipe.key = (String)recipeFromJson.Value;
                            break;
                    }
                }
            }
            BeerNameBox.Text = currentRecipe.name;
            BeerDescriptionBox.Text = currentRecipe.description;
            BeerStyleBox.Text = currentRecipe.style;
            //load fermentables
            jsonurl = dataurl + "/fermentableaddition?recipeid=" + currentRecipeKey;
            //if there's only one hop this might break
            json = new WebClient().DownloadString(jsonurl);
            objects = JArray.Parse(json);
            i = 0;
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
    }

    public class hop
    {
        public String hopName;
        public float AAU;
        public float hopTime;
        public float hopAmount;
        public string hopType;
    }

    public class fermentable
    {
        public string fermentableName;
        public float PPG;
        public float colorList;
        public float weightList;
        public Boolean extract;
    }

    public class yeast
    {
        public string lab;
        public string product;
        public float tempRangeStart;
        public float tempRangeEnd;
        public float attenuation;
        public string alcoholTolerance;
        public string type;
        public string flocculation;
    }

    public class adjunct
    {
        public string name;
        public float amount;
        public string type;
    }

    public class recipe
    {
        public string key;
        public string name;
        public string style;
        public string description;
        public float abv;
        public float ibu;
        public float fg;
        public float og;
        public float srm;
        public float version;
        public string parentRecipe;
        public string clonedFrom;
        public string hidden;

        public List<hop> hopList = new List<hop>();
        public List<fermentable> fermentableList = new List<fermentable>();
        public List<yeast> yeastList = new List<yeast>();
        public List<adjunct> adjunctList = new List<adjunct>();
    }
}
