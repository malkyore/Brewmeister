using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewcrosoft_Brewmeister.Data
{
        public class loadedRecipe
        {
            public String key;
            public String name;
            public String style;
            public String description;
            public float abv;
            public float ibu;

        }

    public class style
    {
        public id id;
        public string idString;
        public string name;
        public string category;
        public string description;
        public string profile;
        public string ingredients;
        public string examples;
        public double minOG;
        public double maxOG;
        public double minFG;
        public double maxFG;
        public double minIBU;
        public double maxIBU;
        public double minABV;
        public double maxABV;
        public double minColor;
        public double maxColor;
        public double minCarb;
        public double maxCarb;
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

        //public List<hop> hops = new List<hop>();
      public List<fermentable> fermentables = new List<fermentable>();
      public List<yeast> yeasts = new List<yeast>();
      public List<adjunct> adjuncts = new List<adjunct>();
     
        public BeerStats beerStatistics = new BeerStats();

        public class BeerStats
        {
            public float PPGPoints;
            public float SRM;
            public double CurrentOG;
            public double CurrentFG;
            public double CurrentABV;
            public double KitEfficiency;
            public float IntoFermenterVolume;
        }
    }

    public class RecipeStatistics
    {
        public double abv;
        public double ibu;
        public double fg;
        public double og;
        public double srm;
    }

    public class RecipeParameters
    {
        public string ibuCalcType;
        public string fermentableCalcType;
        public double ibuBoilTimeCurveFit;
        public double intoFermenterVolume;
    }

    public class id
    {
        public string timestamp;
        public string machine;
        public string pid;
        public string increment;
        public string creationTime;
    }

    public class recipeResponse
    {
        public RecipeStatistics recipeStats;
        public string idString;
        string success;
        string message;
    }

    public class recipe2
    {
        public id id;
        public string idString;
        public string name;
        public string style;
        public string styleID;
        public string description;
        public float abv;
        public float ibu;
        public float fg;
        public float og;
        public float srm;
       // public string id;
        public string test;

        public List<yeast2> yeasts = new List<yeast2>();
        public List<fermentablelist> fermentables = new List<fermentablelist>();
        public List<adjunctList> adjuncts = new List<adjunctList>();
        public List<hoplist> hops = new List<hoplist>();

      //  public BeerStats beerStatistics = new BeerStats();

        
        public RecipeStatistics recipeStats { get; set; }
        public RecipeParameters recipeParameters { get; set; }
        public double version { get; set; }
        public string parentRecipe { get; set; }
        public string clonedFrom { get; set; }
        public string hidden { get; set; }

    }

    public class BeerStats
    {
        public float PPGPoints;
        public float adjustedPPGPoints;
        public float SRM;
        public float IBU;
        public double CurrentOG;
        public double CurrentFG;
        public double CurrentABV;
        public double KitEfficiency;
        public float IntoFermenterVolume;
    }

    public class yeastlist
    {
       // public string recipeID;
        public string yeastID;
     //   public string ID;
        public yeast2 yeast = new yeast2();
    }

    public class yeast2
    {
        public id id { get; set; }
        public string lab { get; set; }
        public string name { get; set; }
        public float attenuation { get; set; }
        public string idString { get; set; }
    }

    public class fermentablelist
    {
        //public string recipeID;
        public string fermentableID;
        public string use;
        public float weight;
       // public string id;
        public fermentable2 fermentable = new fermentable2();
    }

    public class fermentable2
    {
        public string name { get; set;}
        public float ppg { get; set; }
        public float color { get; set; }
        public string type { get; set; }
        public string maltster { get; set; }
        public string idString { get; set; }
    }

    public class adjunctList
    {
     //   public string recipeID;
        public string adjunctID;
        public float amount;
        public string unit;
        public float time;
        public string timeUnit;
        public string type;
     //   public string id;
        public adjunct2 adjunct = new adjunct2();
    }

    public class adjunct2
    {
        public string name;
        public string idString;
    }

    public class hoplist
    {
     //   public string recipeID;
        public string hopID;
        public float amount;
        public string type;
        public float time;
       // public string id;
        public hop2 hop = new hop2();
    }

    public class hop2
    {
        public string name { get; set; }
        public float aau { get; set; }
        public string idString { get; set; }
    }
}
