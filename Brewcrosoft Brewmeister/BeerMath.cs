using Brewcrosoft_Brewmeister.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewcrosoft_Brewmeister
{
    public static class BeerMath
    {
      //  public static BeerStats calculateStatistics(recipe2 currentRecipe, double IntoFermenterVolume, double IBUBoilTimeCurveFit, double KitEfficiency)
      //  {
      //      BeerStats beerStats = new BeerStats();
      //      double PPGCalc = 0;
      //      currentRecipe.srm = 0;
      //      currentRecipe.ibu = 0;
      //
      //      //IBU Math Variables
      //      double fG = 0;
      //      double fT = 0;
      //      double Util = 0;
      //
      //      int i = 0;
      //      foreach (fermentablelist f in currentRecipe.fermentables)
      //      {
      //          PPGCalc += f.fermentable.ppg * f.weight;
      //          currentRecipe.srm += f.fermentable.color * f.weight;
      //      }
      //      currentRecipe.og = (float)(1 + (PPGCalc / IntoFermenterVolume) / 1000);
      //
      //      foreach (hoplist h in currentRecipe.hops)
      //      {
      //          if (h.type == "Boil")
      //          {
      //              fG = 1.65 * (Math.Pow(0.000125, (currentRecipe.og - 1)));
      //              fT = (1 - Math.Pow(Math.E, IBUBoilTimeCurveFit * h.time)) / 4.15;
      //              Util = fG * fT;
      //              currentRecipe.ibu += (float)(((h.amount * h.hop.aau) * Util * 74.89) / IntoFermenterVolume);
      //          }
      //      }
      //
      //      //Final Gravity Estimate based off of the average of the attenuations of the added yeasts
      //      int yeastCount = 0;
      //      float attenuationTotal = 0;
      //      foreach (yeastlist y in currentRecipe.yeasts)
      //      {
      //          yeastCount += 1;
      //          attenuationTotal += y.yeast.attenuation;
      //      }
      //
      //      float finalAttenuation = attenuationTotal / yeastCount;
      //      currentRecipe.fg = 1 + (((currentRecipe.og - 1) * 1000) * ((100 - finalAttenuation) / 100)) / 1000;
      //
      //      //calculate ABV
      //      currentRecipe.abv = (float)((currentRecipe.og - currentRecipe.fg) * 131.25);
      //      if (currentRecipe.abv > 10)
      //      {
      //          currentRecipe.abv = (float)((76.08 * (currentRecipe.og - currentRecipe.fg) / (1.775 - currentRecipe.og)) * (currentRecipe.fg / 0.794));
      //      }
      //      currentRecipe.srm = (float)(1.4922 * (Math.Pow(currentRecipe.srm / IntoFermenterVolume, 0.69)));
      //
      //
      //      beerStats.PPGPoints = (float)PPGCalc;
      //      //Calculates adjusted PPG not currently returned.
      //      PPGCalc = PPGCalc * KitEfficiency;
      //      beerStats.CurrentOG = currentRecipe.og;
      //      beerStats.CurrentFG = currentRecipe.fg;
      //      beerStats.SRM = currentRecipe.srm;
      //      beerStats.IBU = currentRecipe.ibu;
      //      beerStats.CurrentABV = currentRecipe.abv;
      //      beerStats.adjustedPPGPoints = (float)PPGCalc;
      //      return beerStats;
      //  }

        public static string srmLookup(float srm)
        {
            int srmInt = (int)srm;
            string returnable = "";
            switch (srmInt)
            {
                case 0:
                    returnable = "#FFE699";
                    break;
                case 1:
                    returnable = "#FFE699";
                    break;
                case 2:
                    returnable = "#FFD878";
                    break;
                case 3:
                    returnable = "#FFCA5A";
                    break;
                case 4:
                    returnable = "#FFBF42";
                    break;
                case 5:
                    returnable = "#FBB123";
                    break;
                case 6:
                    returnable = "#F8A600";
                    break;
                case 7:
                    returnable = "#F39C00";
                    break;
                case 8:
                    returnable = "#EA8F00";
                    break;
                case 9:
                    returnable = "#E58500";
                    break;
                case 10:
                    returnable = "#DE7C00";
                    break;
                case 11:
                    returnable = "#D77200";
                    break;
                case 12:
                    returnable = "#CF6900";
                    break;
                case 13:
                    returnable = "#CB6200";
                    break;
                case 14:
                    returnable = "#C35900";
                    break;
                case 15:
                    returnable = "#BB5100";
                    break;
                case 16:
                    returnable = "#B54C00";
                    break;
                case 17:
                    returnable = "#B04500";
                    break;
                case 18:
                    returnable = "#A63E00";
                    break;
                case 19:
                    returnable = "#A13700";
                    break;
                case 20:
                    returnable = "#9B3200";
                    break;
                case 21:
                    returnable = "#952D00";
                    break;
                case 22:
                    returnable = "#8E2900";
                    break;
                case 23:
                    returnable = "#882300";
                    break;
                case 24:
                    returnable = "#821E00";
                    break;
                case 25:
                    returnable = "#7B1A00";
                    break;
                case 26:
                    returnable = "#771900";
                    break;
                case 27:
                    returnable = "#701400";
                    break;
                case 28:
                    returnable = "#6A0E00";
                    break;
                case 29:
                    returnable = "#660D00";
                    break;
                case 30:
                    returnable = "#5E0B00";
                    break;
                case 31:
                    returnable = "#5A0A02";
                    break;
                case 32:
                    returnable = "#600903";
                    break;
                case 33:
                    returnable = "#520907";
                    break;
                case 34:
                    returnable = "#4C0505";
                    break;
                case 35:
                    returnable = "#470606";
                    break;
                case 36:
                    returnable = "#440607";
                    break;
                case 37:
                    returnable = "#3F0708";
                    break;
                case 38:
                    returnable = "#3B0607";
                    break;
                case 39:
                    returnable = "#3A070B";
                    break;
                default:
                    returnable = "#36080A";
                    break;
            }
            return returnable;
        }

    }
}
