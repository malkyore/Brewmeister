using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brewcrosoft_Brewmeister.Data;

namespace Brewcrosoft_Brewmeister
{
    #region Shared Stuff
    public partial class Recipe_Creator : Form
    {
        public string BeerName { get; set; }
        public string BeerStyle { get; set; }
        public string BeerDescription { get; set; }
        public string RecipeFileLocation { get; set; }
        public string IngredientFileLocation { get; set; }

        //lists of shit
        //Malt Lists
        public List<String> MaltNameList = new List<string>();
        public List<float> PPGList = new List<float>();
        public List<float> ColorList = new List<float>();
        public List<float> WeightList = new List<float>();
        public List<Boolean> ExtractList = new List<Boolean>();
        //Hop Lists
        public List<String> HopNameList = new List<String>();
        public List<float> AAUList = new List<float>();
        public List<float> HopTimeList = new List<float>();
        public List<float> HopAmountList = new List<float>();
        public List<String> HopTypeList = new List<String>();
        //Yeast Lists
        public List<String> YeastLabList = new List<String>();
        public List<String> YeastProductList = new List<String>();
        public List<float> YeastTempRangeStartList = new List<float>();
        public List<float> YeastTempRangeEndList = new List<float>();
        public List<float> YeastAttenuationList = new List<float>();
        public List<String> YeastAlcoholToleranceList = new List<String>();
        public List<String> YeastTypeList = new List<String>();
        public List<String> YeastFlocculationList = new List<String>();

        //Other Ingredients Lists
        public List<String> OtherIngredientName = new List<String>();
        public List<float> OtherIngredientAmount = new List<float>();
        public List<String> OtherIngredientType = new List<String>();
        recipe2 currentRecipe = new recipe2();
        //Statistical information
        public float PPGPoints = 0;
        public float SRM = 0;
        public double CurrentOG = 0;
        public double CurrentFG = 0;
        public double CurrentABV = 0;
        //The below value adjusts the time component of the IBU calculation
        //It can adjust for boil of from more or less vigorous boils over time
        public double IBUBoilTimeCurveFit = -0.04;

        public double KitEfficiency = 0.70;//for now....
        public float IntoFermenterVolume = 5;//for now...

        public void setVars(String thing1, String thing2)
        {
            BeerName = thing1;
            BeerStyle = thing2;
            
        }

        /*
         * Sets all the fucking shit for the grids and shit.
         * */
        public Recipe_Creator(recipe2 currentRecipeFromMainScreen)
        {
            APIHandler handler = new APIHandler();
            List<fermentable2> fermentableList = handler.getFermentables();
            DataGridViewComboBoxColumn maltColumn = new DataGridViewComboBoxColumn();
            maltColumn.DataSource = fermentableList;
            maltColumn.DisplayMember = "name";
            maltColumn.ValueMember = "id";
            currentRecipe = currentRecipeFromMainScreen;
           //Malt Grid Stuff
            InitializeComponent();
            //MaltGrid.Columns.Add(maltColumn);
            MaltGrid.Columns.Add("Name", "Name");
            MaltGrid.Columns[0].ReadOnly = true;
            MaltGrid.Columns.Add("Weight", "Weight");
            MaltGrid.Columns.Add("PPG", "PPG");
            MaltGrid.Columns[2].ReadOnly = true;
            MaltGrid.Columns.Add("Color", "Color");
            MaltGrid.Columns[3].ReadOnly = true;
            DataGridViewCheckBoxColumn ExtractColumn = new DataGridViewCheckBoxColumn();
            ExtractColumn.ReadOnly = true;
            ExtractColumn.Name = "Extract";
            ExtractColumn.HeaderText = "Extract";
            MaltGrid.Columns.Add(ExtractColumn);
            MaltGrid.Columns[0].Width = 150;
            MaltGrid.Columns[1].Width = 50;
            MaltGrid.Columns[2].Width = 50;
            MaltGrid.Columns[3].Width = 50;
            MaltGrid.Columns[4].Width = 50;
            KitEfficiencyBox.Text = "" + KitEfficiency;
            IntoFermenterVolumeBox.Text = "" + IntoFermenterVolume;

            //Hop Grid Stuff
            HopGrid.Columns.Add("Name", "Name");
            HopGrid.Columns[0].ReadOnly = true;
            DataGridViewComboBoxColumn typeColumn = new DataGridViewComboBoxColumn();
            typeColumn.Name = "Type";
            typeColumn.Items.Add("Boil");
            typeColumn.Items.Add("Dry Hop");
            typeColumn.Items.Add("Whirlpool");
            typeColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            HopGrid.Columns.Add(typeColumn);
            //HopGrid.Columns.Add("Type", "Type");
            HopGrid.Columns.Add("Amount", "Amount");
            HopGrid.Columns.Add("AAU", "AAU");
            HopGrid.Columns[3].ReadOnly = true;
            HopGrid.Columns.Add("Time", "Time");
            HopGrid.Columns[0].Width = 150;
            HopGrid.Columns[1].Width = 100;
            HopGrid.Columns[2].Width = 50;
            HopGrid.Columns[3].Width = 50;
            HopGrid.Columns[4].Width = 50;

            //Yeast Grid Stuff
            YeastGrid.Columns.Add("Lab", "Lab");
            YeastGrid.Columns[0].ReadOnly = true;
            YeastGrid.Columns.Add("Product", "Product");
            YeastGrid.Columns[1].ReadOnly = true;
            YeastGrid.Columns.Add("Attenuation", "Attenuation");
            YeastGrid.Columns[2].ReadOnly = true;
            YeastGrid.Columns[0].Width = 100;
            YeastGrid.Columns[1].Width = 100;
            YeastGrid.Columns[2].Width = 100;
            RefreshStatistics();

            //Other Ingredients Grid Stuff
            OtherIngredientsGrid.Columns.Add("Name", "Name");
            OtherIngredientsGrid.Columns.Add("Amount", "Amount");
            OtherIngredientsGrid.Columns.Add("Unit", "Unit");
            OtherIngredientsGrid.Columns.Add("Time", "Time");
            OtherIngredientsGrid.Columns.Add("TimeUnit", "TimeUnit");
            OtherIngredientsGrid.Columns.Add("Type", "Type");

            populateGrids();
            RefreshStatistics();
        }

        /*
         * Repopulates the grids from the current recipe object.
         * */
        private void populateGrids()
        {
            MaltGrid.Rows.Clear();
            HopGrid.Rows.Clear();
            YeastGrid.Rows.Clear();
            OtherIngredientsGrid.Rows.Clear();
            //Populate Screen
            BeerNameLabel.Text = currentRecipe.name;
            BeerStyleLabel.Text = currentRecipe.style;
            foreach (fermentablelist f in currentRecipe.fermentables)
            {
                bool extract = false;
                if (f.fermentable.type == "Liquid Extract" || f.fermentable.type == "Dry Extract")
                {
                    extract = true;
                }
                MaltGrid.Rows.Add(f.fermentable.name, f.weight, f.fermentable.ppg, f.fermentable.color,extract);
                
            }
            foreach (hoplist h in currentRecipe.hops)
                HopGrid.Rows.Add(h.hop.name, h.type, h.amount, h.hop.aau, h.time);
            foreach (yeastlist y in currentRecipe.yeasts)
                YeastGrid.Rows.Add(y.yeast.lab, y.yeast.name, y.yeast.attenuation);
            foreach (adjunctList a in currentRecipe.adjuncts)
                OtherIngredientsGrid.Rows.Add(a.adjunct.name, a.amount, a.type);
        }

        /*
         * copies changes out of the grid into the current 
         * recipe object.
         * */
        private void BackPopulateRecipeFromGridChange()
        {
            for (int i = 0; i < HopGrid.RowCount; i++)
            {
                if (currentRecipe.hops.Count > i)
                {
                    if (HopGrid[1, i].Value != null && HopGrid.RowCount > 0)
                        currentRecipe.hops[i].type = HopGrid[1, i].Value.ToString();
                    float.TryParse(HopGrid[2, i].Value.ToString(), out currentRecipe.hops[i].amount);
                    float.TryParse(HopGrid[4, i].Value.ToString(), out currentRecipe.hops[i].time);
                }

            }
            for (int i = 0; i < MaltGrid.RowCount; i++)
            {
                if (currentRecipe.fermentables.Count > i)
                {
                   float.TryParse(MaltGrid[1, i].Value.ToString(), out currentRecipe.fermentables[i].weight);
                }
           
            }
        }

        /*
    * Does all the math for the beer info.
    * 
    * This should at some point be moved to a thing so it can be used elsewhere.
    * */
        public void RefreshStatistics()
        {
            double PPGCalc = 0;
            double SRMCalc = 0;
            double IBUCalc = 0;

            //IBU Math Variables
            double fG = 0;
            double fT = 0;
            double Util = 0;

            int i = 0;
            foreach (fermentablelist f in currentRecipe.fermentables)
            {
                PPGCalc += f.fermentable.ppg * f.weight;
                SRMCalc += f.fermentable.color * f.weight;
            }

            foreach (hoplist h in currentRecipe.hops)
            {
                if (h.type == "Boil")
                {
                    //Where the shit is CurrentOG Set at this point?!?
                    fG = 1.65 * (Math.Pow(0.000125, (CurrentOG - 1)));
                    fT = (1 - Math.Pow(Math.E, IBUBoilTimeCurveFit * h.time)) / 4.15;
                    Util = fG * fT;
                    IBUCalc += ((h.amount * h.hop.aau) * Util * 74.89) / IntoFermenterVolume;
                }
            }

            //Final Gravity Estimate based off of the average of the attenuations of the added yeasts
            int yeastCount = 0;
            float attenuationTotal = 0;
            foreach (yeastlist y in currentRecipe.yeasts)
            {
                yeastCount += 1;
                attenuationTotal += y.yeast.attenuation;
            }

            float finalAttenuation = attenuationTotal / yeastCount;
            CurrentFG = 1 + (((CurrentOG - 1) * 1000) * ((100 - finalAttenuation) / 100)) / 1000;

            //calculate ABV
            CurrentABV = (CurrentOG - CurrentFG) * 131.25;
            if (CurrentABV > 10)
            {
                CurrentABV = (76.08 * (CurrentOG - CurrentFG) / (1.775 - CurrentOG)) * (CurrentFG / 0.794);
            }

            //update the statistics box
            RawPPGLabel.Text = "" + PPGCalc;
            PPGCalc = PPGCalc * KitEfficiency;
            SRMCalc = 1.4922 * (Math.Pow(SRMCalc / IntoFermenterVolume, 0.69));
            GravityPointsLabel.Text = "" + PPGCalc;
            CurrentOG = (1 + (PPGCalc / IntoFermenterVolume) / 1000);

            OGLabel.Text = "" + CurrentOG;
            FGLabel.Text = "" + CurrentFG;
            SRMLabel.Text = "" + SRMCalc;
            IBULabel.Text = "" + IBUCalc;
            ABVLabel.Text = "" + CurrentABV;

            currentRecipe.abv = (float)CurrentABV;
            currentRecipe.fg = (float)CurrentFG;
            currentRecipe.og = (float)CurrentOG;
            currentRecipe.srm = (float)SRMCalc;
            currentRecipe.ibu = (float)IBUCalc;

            KitEfficiencyBox.Text = "" + KitEfficiency;
            IntoFermenterVolumeBox.Text = "" + IntoFermenterVolume;
        }

        /*
       * IDK.... this might still work.  It recalculates the information based
       * on changes to the into-fermenter volume.
       * */
        private void ChangeIntoFermenterVolume(object sender, EventArgs e)
        {
            if (IntoFermenterVolumeBox.Text != "")
            {
                try
                {
                    IntoFermenterVolume = float.Parse(IntoFermenterVolumeBox.Text);
                }
                catch (Exception exceptionsjfjf)
                {
                    MessageBox.Show("Error in Fermetner Volume.  Please Reenter.");
                    IntoFermenterVolumeBox.Text = "" + IntoFermenterVolume;
                }
                PopulateYeastList();
                RefreshStatistics();
            }
        }

        /*
         * This also might still work.  It updates the shit based on changes in the kit efficency.
         * */
        private void ChangeKitEfficiency(object sender, EventArgs e)
        {
            if (KitEfficiencyBox.Text != "")
            {
                try
                {
                    KitEfficiency = float.Parse(KitEfficiencyBox.Text);
                }
                catch (Exception fjdjfdj)
                {
                    MessageBox.Show("Error in Kit Effiency.  Please Reenter.");
                    KitEfficiencyBox.Text = "" + KitEfficiency;
                }
                PopulateYeastList();
                RefreshStatistics();
            }
        }

        /*
         * The shittiest oldest least-working code I've ever saw.
         * */
        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool reload = false;
            APIHandler handler = new APIHandler();
            foreach (hoplist h in currentRecipe.hops)
            {
                handler.postHopAddition(h);
            }
            foreach(fermentablelist f in currentRecipe.fermentables)
            {
                string response = handler.postFermentableAddition(f);
                if(response == "false")
                {
                    reload = true;
                }
            }
            foreach (yeastlist y in currentRecipe.yeasts)
            {
                handler.postYeastAddition(y);
            }
            foreach (adjunctList a in currentRecipe.adjuncts)
            {
                handler.postAdjunctAddition(a);
            }
            handler.postRecipe(currentRecipe);
            if(reload)
            {
                currentRecipe = handler.loadRecipe(currentRecipe.id);
                populateGrids();
               // RefreshStatistics();
            }
        }

        #endregion

        #region Hop Stuff
        /*
         * Opens the new add hops dialog.
         * */
        private void AddHopsButton_Click(object sender, EventArgs e)
        {
            BackPopulateRecipeFromGridChange();

            using (var HopDialog = new IngredientPicker("Hops"))
            {
                var result = HopDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadHop(HopDialog.selectedKey);
                    populateGrids();
                }
            }
        }

        /*
         * Interfaces with the data access layer to load a single hops information out of the API
         * */
        private void LoadHop(string selectedHop)
        {
            APIHandler handler = new APIHandler();
            hoplist add = new hoplist();
            add.hopID = selectedHop;
            add.hop = handler.getHop(selectedHop);
            add.recipeID = currentRecipe.id;
            currentRecipe.hops.Add(add);
           // currentRecipe.hops.Add()
        }

        /*
         * Deletes a hop from the recipe.
         * */
        private void RemoveHopsButton_Click(object sender, EventArgs e)
        {
            int index = HopGrid.CurrentRow.Index;
            HopGrid.Rows.Clear();
            currentRecipe.hops.RemoveAt(index);
            populateGrids();
            RefreshStatistics();
        }

        /*
         * recalculates the math stuff when you change cells on the hop grid.
         * */
        private void HopGrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            BackPopulateRecipeFromGridChange();
            //  PopulateHopList();
            RefreshStatistics();
        }
        #endregion

        #region Malt Stuff
        /*
 * Opens the ingredient picker in malt mode...
 * */
        private void AddMaltButton_Click(object sender, EventArgs e)
        {
            BackPopulateRecipeFromGridChange();

            using (var MaltDialog = new IngredientPicker("Malts"))
            {
                var result = MaltDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadMalt(MaltDialog.selectedKey);
                    populateGrids();
                }
            }
        

            }

        /*
         * Interfaces with the data access layer to load a single hops information out of the API
         * */
        private void LoadMalt(string selectedMalt)
        {
            APIHandler handler = new APIHandler();
            fermentablelist add = new fermentablelist();
           // add.id = selectedMalt;
            add.fermentableID = selectedMalt;
            add.fermentable = handler.getFermentable(selectedMalt);
            add.recipeID = currentRecipe.id;
            currentRecipe.fermentables.Add(add);
            //currentRecipe.fermentables.Add()
        }

        private void MaltGrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            BackPopulateRecipeFromGridChange();
            RefreshStatistics();
        }


        /*
         * Old broken malt removal code.
         * */
        private void RemoveMaltButton_Click(object sender, EventArgs e)
        {
            int index = MaltGrid.CurrentRow.Index;
            MaltGrid.Rows.Clear();
            currentRecipe.fermentables.RemoveAt(index);
            populateGrids();
            RefreshStatistics();
        }

        #endregion

        #region Yeast Stuff
        /*
         * populates the yeast list.
         * */
        public void PopulateYeastList()
        {
            YeastGrid.Rows.Clear();
            int i = 0;
            foreach (string element in YeastLabList)
            {
                YeastGrid.Rows.Add(YeastLabList[i], YeastProductList[i], YeastAttenuationList[i]);
                i++;
            }

        }


        /*
         * Old broken remove yeast code.
         * */
        private void RemoveYeastButton_Click(object sender, EventArgs e)
        {
            int index = YeastGrid.CurrentRow.Index;
            YeastGrid.Rows.Clear();
            currentRecipe.yeasts.RemoveAt(index);
            populateGrids();
            RefreshStatistics();
        }

        /*
        * Opens the Ingredient Picker for yeasts
        * */
        private void AddYeastButton_Click(object sender, EventArgs e)
        {
            using (var yeastDialog = new IngredientPicker("Yeasts"))
            {
                var result = yeastDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadYeast(yeastDialog.selectedKey);
                    populateGrids();
                }
            }
        }

        private void LoadYeast(string selectedYeast)
        {
            APIHandler handler = new APIHandler();
            yeastlist add = new yeastlist();
         //   add.ID = selectedYeast;
            add.yeastID = selectedYeast;
            add.yeast = handler.getYeast(selectedYeast);
            add.recipeID = currentRecipe.id;
            currentRecipe.yeasts.Add(add);
        }

        #endregion

        #region Adjuncts Stuff
        /*
         * old stuff for the adjunct grid.
         * */
        private void AddOtherIngredientsButton_Click(object sender, EventArgs e)
        {
            using (var adjunctDialog = new IngredientPicker("Adjuncts"))
            {
                var result = adjunctDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadAdjunct(adjunctDialog.selectedKey);
                    populateGrids();
                }
            }
        }

        private void LoadAdjunct(string selectedAdjunct)
        {
            APIHandler handler = new APIHandler();
            adjunctList add = new adjunctList();
       //     add.id = selectedAdjunct;
            add.adjunctID = selectedAdjunct;
            add.adjunct = handler.getAdjunct(selectedAdjunct);
            add.recipeID = currentRecipe.id;
            currentRecipe.adjuncts.Add(add);
        }

        /*
         * populates the adjuncts grid.
         * */
        public void PopulateOtherList()
        {
            OtherIngredientsGrid.Rows.Clear();
            int i = 0;
            foreach (string element in OtherIngredientName)
            {
                OtherIngredientsGrid.Rows.Add(OtherIngredientName[i],OtherIngredientAmount[i],OtherIngredientType[i]);
                i++;
            }

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            int index = OtherIngredientsGrid.CurrentRow.Index;
            OtherIngredientsGrid.Rows.Clear();
            currentRecipe.adjuncts.RemoveAt(index);
            populateGrids();
            RefreshStatistics();
        }
    }
}

