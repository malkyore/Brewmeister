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
using RestSharp;

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
        public yeast2 getYeast(string yeastID)
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            string jsonurl = dataurl + "/yeast?id=" + yeastID;
            yeast2 returnable = new yeast2();
            var json = new WebClient().DownloadString(jsonurl);
            returnable = JsonConvert.DeserializeObject<yeast2>(json);
            return returnable;
        }

        public List<adjunct2> getAdjuncts()
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            string jsonurl = dataurl + "/adjunct";
            List<adjunct2> hopList = new List<adjunct2>();
            var json = new WebClient().DownloadString(jsonurl);
            hopList = JsonConvert.DeserializeObject<List<adjunct2>>(json);
            return hopList;
        }
        public adjunct2 getAdjunct(string adjunctID)
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            string jsonurl = dataurl + "/adjunct?id=" + adjunctID;
            adjunct2 returnable = new adjunct2();
            var json = new WebClient().DownloadString(jsonurl);
            returnable = JsonConvert.DeserializeObject<adjunct2>(json);
            return returnable;
        }

        public bool postHopAddition(hoplist hopaddition)
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            var client = new RestClient(dataurl);
            RestRequest request = new RestRequest();
            if (hopaddition.id == "")
            {
                request = new RestRequest("/hopaddition/", Method.POST);
            } else {
                request = new RestRequest("/hopaddition/" + hopaddition.id, Method.POST);
            }
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                recipeID = hopaddition.recipeID,
                hopID = hopaddition.hopID,
                amount = hopaddition.amount,
                type = hopaddition.type,
                time = hopaddition.time
            }); 

            IRestResponse response = client.Execute(request);
            return true;
        }

        public string postFermentableAddition(fermentablelist fermentableAddition)
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            var client = new RestClient(dataurl);
            RestRequest request = new RestRequest();
            string returnable = "";
            if (fermentableAddition.id == null)
            {
                request = new RestRequest("/fermentableaddition/", Method.POST);
                returnable = "false";
            }
            else
            {
                request = new RestRequest("/fermentableaddition/" + fermentableAddition.id, Method.POST);
                returnable = fermentableAddition.id;
            }
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                recipeID = fermentableAddition.recipeID,
                fermentableID = fermentableAddition.fermentableID,
                fermentable = fermentableAddition.fermentable,
                use = "Mash",
                weight = fermentableAddition.weight
            });

            IRestResponse response = client.Execute(request);
            return returnable;
        }

        public bool postYeastAddition(yeastlist yeastAddition)
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            var client = new RestClient(dataurl);
            RestRequest request = new RestRequest();
            if (yeastAddition.ID == null)
            {
                request = new RestRequest("/yeastaddition/", Method.POST);
            }
            else
            {
                request = new RestRequest("/yeastaddition/" + yeastAddition.ID, Method.POST);
            }
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                recipeID = yeastAddition.recipeID,
                yeastID = yeastAddition.yeastID
            });

            IRestResponse response = client.Execute(request);
            return true;
        }

        public bool postAdjunctAddition(adjunctList adjunctAddition)
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            var client = new RestClient(dataurl);
            RestRequest request = new RestRequest();
            if (adjunctAddition.id == null)
            {
                request = new RestRequest("/adjunctaddition/", Method.POST);
            }
            else
            {
                request = new RestRequest("/adjunctaddition/" + adjunctAddition.id, Method.POST);
            }
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                recipeID = adjunctAddition.recipeID,
                adjunctID = adjunctAddition.adjunctID,
                amount = adjunctAddition.amount,
                unit = adjunctAddition.unit,
                time = adjunctAddition.time,
                timeUnit = adjunctAddition.timeUnit,
                type = adjunctAddition.type
            });

            IRestResponse response = client.Execute(request);
            return true;
        }
        public bool postRecipe(recipe2 recipe)
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            string dataurl = (string)adsfa.GetValue("dataurl");
            var client = new RestClient(dataurl);
            RestRequest request = new RestRequest();
            if (recipe.id == null)
            {
                request = new RestRequest("/recipe/", Method.POST);
            }
            else
            {
                request = new RestRequest("/recipe/" + recipe.id, Method.POST);
            }
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                name = recipe.name,
                style = recipe.style,
                description = recipe.description,
                abv = recipe.abv,
                ibu = recipe.ibu,
                fg = recipe.fg,
                og = recipe.og,
               srm = recipe.srm
               //version = recipe.version
            });
            IRestResponse response = client.Execute(request);
            return true;
        }

        public recipe2 loadRecipe(string currentRecipeKey)
        {
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            recipe2 returnable = new recipe2();
            string dataurl = (string)adsfa.GetValue("dataurl");

            string recipeURL = dataurl + "/recipe?id=" + currentRecipeKey;
            string fermentableURL = dataurl + "/fermentableaddition?recipeID=" + currentRecipeKey + "&include=fermentable";
            string hopURL = dataurl + "/hopaddition?recipeID=" + currentRecipeKey + "&include=hop";
            string yeastURL = dataurl + "/yeastaddition?recipeID=" + currentRecipeKey + "&include=yeast";
            string adjunctURL = dataurl + "/adjunctaddition?recipeID=" + currentRecipeKey + "&include=adjunct";

            List<fermentablelist> fermentableList = new List<fermentablelist>();
            List<hoplist> hopList = new List<hoplist>();
            List<yeastlist> yeastList = new List<yeastlist>();
            List<adjunctList> adjunctList = new List<adjunctList>();

            string json = new WebClient().DownloadString(recipeURL);
            returnable = JsonConvert.DeserializeObject<recipe2>(json);
            json = new WebClient().DownloadString(fermentableURL);
            fermentableList = JsonConvert.DeserializeObject<List<fermentablelist>>(json);
            json = new WebClient().DownloadString(hopURL);
            hopList = JsonConvert.DeserializeObject<List<hoplist>>(json);
            json = new WebClient().DownloadString(yeastURL);
            yeastList = JsonConvert.DeserializeObject<List<yeastlist>>(json);
            json = new WebClient().DownloadString(adjunctURL);
            adjunctList = JsonConvert.DeserializeObject<List<adjunctList>>(json);
            returnable.fermentables = fermentableList;
            returnable.hops = hopList;
            returnable.yeasts = yeastList;
            returnable.adjuncts = adjunctList;
            int i = 1;
            adsfa = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister", RegistryKeyPermissionCheck.ReadWriteSubTree);
            adsfa.SetValue("LastOpenedRecipe", currentRecipeKey);



            return returnable;
        }

    }    
}
