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
        public string id;
        public string name;
        public string type;
        public string description;
        public float minOG;
        public float maxOG;
        public float minFG;
        public float maxFG;
        public float minIBU;
        public float maxIBU;
        public float minABV;
        public float maxABV;
        public float minSRM;
        public float maxSRM;
        public float minCarb;
        public float maxCarb;
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

    public class recipe2
    {
        public string name;
        public string style;
        public string styleID;
        public string description;
        public float abv;
        public float ibu;
        public float fg;
        public float og;
        public float srm;
        public string id;
        public string test;

        public List<yeastlist> yeasts = new List<yeastlist>();
        public List<fermentablelist> fermentables = new List<fermentablelist>();
        public List<adjunctList> adjuncts = new List<adjunctList>();
        public List<hoplist> hops = new List<hoplist>();

        public BeerStats beerStatistics = new BeerStats();

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
        public string recipeID;
        public string yeastID;
        public string ID;
        public yeast2 yeast = new yeast2();
    }

    public class yeast2
    {
        public string lab { get; set; }
        public string name { get; set; }
        public float attenuation { get; set; }
        public string id { get; set; }
    }

    public class fermentablelist
    {
        public string recipeID;
        public string fermentableID;
        public string use;
        public float weight;
        public string id;
        public fermentable2 fermentable = new fermentable2();
    }

    public class fermentable2
    {
        public string name { get; set;}
        public float ppg { get; set; }
        public float color { get; set; }
        public string type { get; set; }
        public string maltster { get; set; }
        public string id { get; set; }
    }

    public class adjunctList
    {
        public string recipeID;
        public string adjunctID;
        public float amount;
        public string unit;
        public float time;
        public string timeUnit;
        public string type;
        public string id;
        public adjunct2 adjunct = new adjunct2();
    }

    public class adjunct2
    {
        public string name;
        public string id;
    }

    public class hoplist
    {
        public string recipeID;
        public string hopID;
        public float amount;
        public string type;
        public float time;
        public string id;
        public hop2 hop = new hop2();
    }

    public class hop2
    {
        public string name { get; set; }
        public float aau { get; set; }
        public string id { get; set; }
    }
}
