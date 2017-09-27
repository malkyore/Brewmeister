using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brewcrosoft_Brewmeister.Data;
using System.Net;
using Newtonsoft.Json.Linq;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace Brewcrosoft_Brewmeister
{
    class APIHandler
    {
        public void GetRecipes()
        {
            
        }
        
        public List<loadedRecipe> loadRecipes(string jsonurl)
        {
            List<loadedRecipe> recipeList = new List<loadedRecipe>();
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
            return recipeList;
        }

        public List<fermentable2> getFermentables()
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            string jsonurl = dataurl + "/fermentables";
            List<fermentable2> fermentableList = new List<fermentable2>();
            var json = new WebClient().DownloadString(jsonurl);
            fermentableList = JsonConvert.DeserializeObject<List<fermentable2>>(json);
            return fermentableList;
        }

        public List<hop2> getHops()
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            string jsonurl = dataurl + "/hop";
            List<hop2> hopList = new List<hop2>();
            var json = new WebClient().DownloadString(jsonurl);
            hopList = JsonConvert.DeserializeObject<List<hop2>>(json);
            return hopList;
        }

        public hop2 getHop(string hopID)
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            string jsonurl = dataurl + "/hop?id=" + hopID;
            hop2 returnable = new hop2();
            var json = new WebClient().DownloadString(jsonurl);
            returnable = JsonConvert.DeserializeObject<hop2>(json);
            return returnable;
        }

        public fermentable2 getFermentable(string fermentableID)
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            string jsonurl = dataurl + "/fermentables?id=" + fermentableID;
            fermentable2 returnable = new fermentable2();
            var json = new WebClient().DownloadString(jsonurl);
            returnable = JsonConvert.DeserializeObject<fermentable2>(json);
            return returnable;
        }

        public List<yeast2> getYeasts()
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            string jsonurl = dataurl + "/yeast";
            List<yeast2> hopList = new List<yeast2>();
            var json = new WebClient().DownloadString(jsonurl);
            hopList = JsonConvert.DeserializeObject<List<yeast2>>(json);
            return hopList;
        }
    }    
}
