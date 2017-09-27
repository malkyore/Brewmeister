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
            YeastGrid.Columns.Add("Product", "Product");
            YeastGrid.Columns.Add("Attenuation", "Attenuation");
            YeastGrid.Columns[0].Width = 100;
            YeastGrid.Columns[1].Width = 100;
            YeastGrid.Columns[2].Width = 100;
            PopulateMaltList();
            RefreshStatistics();

            //Other Ingredients Grid Stuff
            OtherIngredientsGrid.Columns.Add("Name", "Name");
            OtherIngredientsGrid.Columns.Add("Amount", "Amount");
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
            for (int i = 0; i < HopGrid.RowCount - 1; i++)
            {
                if (currentRecipe.hops.Count > i)
                {
                    if (HopGrid[1, i].Value != null && HopGrid.RowCount > 0)
                        currentRecipe.hops[i].type = HopGrid[1, i].Value.ToString();
                    float.TryParse(HopGrid[2, i].Value.ToString(), out currentRecipe.hops[i].amount);
                    float.TryParse(HopGrid[4, i].Value.ToString(), out currentRecipe.hops[i].time);
                }

            }

            /*
             * My dearest me of the future...
             * 
             * If you would be so kind as to set the correct fermentableID inside of the Ferbemtables object
             * for items added via the add fermentables window that would be awesome.
             * 
             * FermentableadditionID's will be added when they are added to the API and returned via that method.
             * 
             * 
             * thaaaaannnks.  *bitch*
             * */
            for (int i = 0; i < MaltGrid.RowCount - 1; i++)
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
            List<String> LinesList = new List<String>();
            String TempLine = "";
            //Beer Info
            TempLine = BeerName + "\t" + DateTime.Now + "\t" + this.BeerDescription;
            LinesList.Add(TempLine);
            TempLine = "";
            TempLine = BeerStyle + "\t" + IBULabel.Text + "\t" + SRMLabel.Text + "\t" + OGLabel.Text + "\t" + ABVLabel.Text;
            LinesList.Add(TempLine);

            //Schedule


            //Recipe
            TempLine = "RECIPE";
            LinesList.Add(TempLine);
            TempLine = "MALTS";
            LinesList.Add(TempLine);
            int i = 0;
            foreach (string maltname in MaltNameList)
            {
                TempLine = MaltNameList[i] + "\t" + WeightList[i] + "\t" + PPGList[i] + "\t" + ColorList[i] + "\t" + ExtractList[i];
                i++;
                LinesList.Add(TempLine);
            }
            TempLine = "ENDMALTS";
            LinesList.Add(TempLine);
            TempLine = "HOPS";
            LinesList.Add(TempLine);
            i = 0;
            foreach (string hopname in HopNameList)
            {
                TempLine = HopNameList[i] + "\t" + HopAmountList[i] + "\t" + AAUList[i] + "\t" + HopTimeList[i] + "\t" + HopTypeList[i];
                i++;
                LinesList.Add(TempLine);
            }
            TempLine = "ENDHOPS";
            LinesList.Add(TempLine);
            TempLine = "YEASTS";
            LinesList.Add(TempLine);
            i = 0;
            foreach (string labname in YeastLabList)
            {
                TempLine = YeastLabList[i] + "\t" + YeastProductList[i] + "\t" + YeastAttenuationList[i];
                i++;
                LinesList.Add(TempLine);
            }
            TempLine = "ENDYEAST";
            LinesList.Add(TempLine);
            TempLine = "ADJUNCTS";
            LinesList.Add(TempLine);
            i = 0;
            foreach (string labname in YeastLabList)
            {
                TempLine = OtherIngredientName[i] + "\t" + OtherIngredientAmount[i] + "\t" + OtherIngredientType[i];
                i++;
                LinesList.Add(TempLine);
            }
            TempLine = "ENDADJUNCTS";
            LinesList.Add(TempLine);
            TempLine = "ENDRECIPE";
            LinesList.Add(TempLine);
            String FilePath = RecipeFileLocation + "\\" + BeerName + ".txt";
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(FilePath))
            {
                foreach (string line in LinesList)
                {
                    file.WriteLine(line);
                }
            }
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
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        #endregion

        #region Hop Stuff
        /*
         * Opens the new add hops dialog.
         * */
        private void AddHopsButton_Click(object sender, EventArgs e)
        {
            BackPopulateRecipeFromGridChange();

            using (var HopDialog = new GetHops())
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

        /*Populates the hop list
         * */
        public void PopulateHopList()
        {
            HopGrid.Rows.Clear();
            int i = 0;
            foreach (string element in HopNameList)
            {
                HopGrid.Rows.Add(HopNameList[i], HopTypeList[i], HopAmountList[i], AAUList[i], HopTimeList[i]);
                i++;
            }

        }

        /*
         * Deletes a hop from the recipe.
         * */
        private void RemoveHopsButton_Click(object sender, EventArgs e)
        {

            currentRecipe.hops.RemoveAt(HopGrid.CurrentRow.Index);
            PopulateHopList();
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
        * A Shitty attempt to get a combo box thing for picking malts but it fucking sucked and 
        * I hated it.
        * */
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          //  if (e.ColumnIndex == 0)
          //  {
          //      if (e.RowIndex < MaltNameList.Count)
          //      {
          //          MaltNameList[e.RowIndex] = (string)MaltGrid[0, e.RowIndex].Value;
          //          WeightList[e.RowIndex] = float.Parse(MaltGrid[1, e.RowIndex].Value.ToString());
          //          PPGList[e.RowIndex] = float.Parse(MaltGrid[2, e.RowIndex].Value.ToString());
          //          ColorList[e.RowIndex] = float.Parse(MaltGrid[3, e.RowIndex].Value.ToString());
          //          ExtractList[e.RowIndex] = (Boolean)MaltGrid[4, e.RowIndex].Value;
          //
          //      } else
          //      {
          //          MaltNameList.Add((string)MaltGrid[0, e.RowIndex].Value);
          //          WeightList.Add(float.Parse(MaltGrid[1, e.RowIndex].Value.ToString()));
          //          PPGList.Add(float.Parse(MaltGrid[2, e.RowIndex].Value.ToString()));
          //          ColorList.Add(float.Parse(MaltGrid[3, e.RowIndex].Value.ToString()));
          //          ExtractList.Add((Boolean)MaltGrid[4, e.RowIndex].Value);
          //      }
          //     // PopulateMaltList();
          //      RefreshStatistics();
          //  }
        }

        /*
 * Ancient shitty shit that doesn't work.
 * */
        private void AddMaltButton_Click(object sender, EventArgs e)
        {
            BackPopulateRecipeFromGridChange();

            using (var MaltDialog = new GetMalts())
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
            add.id = selectedMalt;
            add.fermentable = handler.getFermentable(selectedMalt);
            add.recipeID = currentRecipe.id;
            currentRecipe.fermentables.Add(add);
            // currentRecipe.hops.Add()
        }

        private void MaltGrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            BackPopulateRecipeFromGridChange();
            //  PopulateHopList();
            RefreshStatistics();
        }

        /*
         * populates the malt list...
         * */
        public void PopulateMaltList()
        {
            MaltGrid.Rows.Clear();
            int i = 0;
            foreach(string element in MaltNameList)
            {
                MaltGrid.Rows.Add(MaltNameList[i], WeightList[i], PPGList[i], ColorList[i], ExtractList[i]);
                i++;
            }

        }


        /*
         * Old broken malt removal code.
         * */
        private void RemoveMaltButton_Click(object sender, EventArgs e)
        {
            MaltNameList.RemoveAt(MaltGrid.CurrentRow.Index);
            WeightList.RemoveAt(MaltGrid.CurrentRow.Index);
            PPGList.RemoveAt(MaltGrid.CurrentRow.Index);
            ColorList.RemoveAt(MaltGrid.CurrentRow.Index);
            ExtractList.RemoveAt(MaltGrid.CurrentRow.Index);
            PopulateMaltList();
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
            YeastLabList.RemoveAt(MaltGrid.CurrentRow.Index);
            YeastProductList.RemoveAt(MaltGrid.CurrentRow.Index);
            YeastAlcoholToleranceList.RemoveAt(MaltGrid.CurrentRow.Index);
            YeastAttenuationList.RemoveAt(MaltGrid.CurrentRow.Index);
            YeastTypeList.RemoveAt(MaltGrid.CurrentRow.Index);
            YeastTempRangeStartList.RemoveAt(MaltGrid.CurrentRow.Index);
            YeastTempRangeEndList.RemoveAt(MaltGrid.CurrentRow.Index);
            YeastFlocculationList.RemoveAt(MaltGrid.CurrentRow.Index);
            PopulateMaltList();
            RefreshStatistics();
        }

        /*
        * Old broken add yeast code.
        * */
        private void AddYeastButton_Click(object sender, EventArgs e)
        {
            using (var YeastDialog = new AddYeast())
            {
                var result = YeastDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String lab = YeastDialog.Lab;
                    //  String flocculation = YeastDialog.Flocculation;
                    //  String alcoholTolerance = YeastDialog.AlcoholTolerance;
                    String product = YeastDialog.Product;
                    //   String type = YeastDialog.YeastType;
                    float attenuation = YeastDialog.Attenuation;
                    // float tempRangeStart = YeastDialog.TempRangeStart;
                    // float tempRangeEnd = YeastDialog.TempRangeEnd;
                    YeastLabList.Add(lab);
                    YeastProductList.Add(product);
                    //YeastAlcoholToleranceList.Add(alcoholTolerance);
                    YeastAttenuationList.Add(attenuation);
                    // YeastTypeList.Add(type);
                    //YeastTempRangeStartList.Add(tempRangeStart);
                    //YeastTempRangeEndList.Add(tempRangeEnd);
                    //YeastFlocculationList.Add(flocculation);

                    PopulateYeastList();
                    RefreshStatistics();
                }
            }
        }

        #endregion

        #region Adjuncts Stuff
        /*
         * old stuff for the adjunct grid.
         * */
        private void AddOtherIngredientsButton_Click(object sender, EventArgs e)
        {
            using (var OtherDialog = new AddOtherIngredients())
            {
                var result = OtherDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String Name = OtherDialog.Name;
                    String type = OtherDialog.Type;
                    float amount = OtherDialog.Amount;

                    OtherIngredientName.Add(Name);
                    OtherIngredientAmount.Add(amount);
                    OtherIngredientType.Add(type);

                    PopulateOtherList();
                    RefreshStatistics();
                }
            }
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
        
    }
}

