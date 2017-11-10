namespace Brewcrosoft_Brewmeister
{
    partial class Recipe_Creator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.YeastBox = new System.Windows.Forms.GroupBox();
            this.RemoveYeastButton = new System.Windows.Forms.Button();
            this.AddYeastButton = new System.Windows.Forms.Button();
            this.YeastGrid = new System.Windows.Forms.DataGridView();
            this.MaltGroup = new System.Windows.Forms.GroupBox();
            this.RemoveMaltButton = new System.Windows.Forms.Button();
            this.AddMaltButton = new System.Windows.Forms.Button();
            this.MaltGrid = new System.Windows.Forms.DataGridView();
            this.HopGroup = new System.Windows.Forms.GroupBox();
            this.RemoveHopsButton = new System.Windows.Forms.Button();
            this.AddHopsButton = new System.Windows.Forms.Button();
            this.HopGrid = new System.Windows.Forms.DataGridView();
            this.RecipeStatsBox = new System.Windows.Forms.GroupBox();
            this.maxABVLabel = new System.Windows.Forms.Label();
            this.minABVLabel = new System.Windows.Forms.Label();
            this.abvSlider = new System.Windows.Forms.TrackBar();
            this.maxSRMLabel = new System.Windows.Forms.Label();
            this.minSRMLabel = new System.Windows.Forms.Label();
            this.srmSlider = new System.Windows.Forms.TrackBar();
            this.maxIBULabel = new System.Windows.Forms.Label();
            this.minIBULabel = new System.Windows.Forms.Label();
            this.ibuSlider = new System.Windows.Forms.TrackBar();
            this.maxFGLabel = new System.Windows.Forms.Label();
            this.minFGLabel = new System.Windows.Forms.Label();
            this.fgSlider = new System.Windows.Forms.TrackBar();
            this.maxOGLabel = new System.Windows.Forms.Label();
            this.minOGLabel = new System.Windows.Forms.Label();
            this.SRMSimulator = new System.Windows.Forms.TextBox();
            this.FGLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ABVLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IBULabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OGLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IntoFermenterVolumeBox = new System.Windows.Forms.TextBox();
            this.SRMLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KitEfficiencyBox = new System.Windows.Forms.TextBox();
            this.ogSlider = new System.Windows.Forms.TrackBar();
            this.RawPPGLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GravityPointsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeRecipeBuilderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecipeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPILocationHandlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BeerStyleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddOtherIngredientsButton = new System.Windows.Forms.Button();
            this.OtherIngredientsGrid = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BeerNameBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.YeastBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YeastGrid)).BeginInit();
            this.MaltGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaltGrid)).BeginInit();
            this.HopGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HopGrid)).BeginInit();
            this.RecipeStatsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abvSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srmSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibuSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogSlider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherIngredientsGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // YeastBox
            // 
            this.YeastBox.Controls.Add(this.RemoveYeastButton);
            this.YeastBox.Controls.Add(this.AddYeastButton);
            this.YeastBox.Controls.Add(this.YeastGrid);
            this.YeastBox.Location = new System.Drawing.Point(889, 47);
            this.YeastBox.Name = "YeastBox";
            this.YeastBox.Size = new System.Drawing.Size(338, 269);
            this.YeastBox.TabIndex = 0;
            this.YeastBox.TabStop = false;
            this.YeastBox.Text = "Yeasts";
            // 
            // RemoveYeastButton
            // 
            this.RemoveYeastButton.Location = new System.Drawing.Point(209, 28);
            this.RemoveYeastButton.Name = "RemoveYeastButton";
            this.RemoveYeastButton.Size = new System.Drawing.Size(123, 23);
            this.RemoveYeastButton.TabIndex = 6;
            this.RemoveYeastButton.Text = "Remove Yeast";
            this.RemoveYeastButton.UseVisualStyleBackColor = true;
            this.RemoveYeastButton.Click += new System.EventHandler(this.RemoveYeastButton_Click);
            // 
            // AddYeastButton
            // 
            this.AddYeastButton.Location = new System.Drawing.Point(7, 28);
            this.AddYeastButton.Name = "AddYeastButton";
            this.AddYeastButton.Size = new System.Drawing.Size(123, 23);
            this.AddYeastButton.TabIndex = 5;
            this.AddYeastButton.Text = "Add Yeast";
            this.AddYeastButton.UseVisualStyleBackColor = true;
            this.AddYeastButton.Click += new System.EventHandler(this.AddYeastButton_Click);
            // 
            // YeastGrid
            // 
            this.YeastGrid.AllowUserToAddRows = false;
            this.YeastGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YeastGrid.Location = new System.Drawing.Point(7, 57);
            this.YeastGrid.Name = "YeastGrid";
            this.YeastGrid.Size = new System.Drawing.Size(325, 206);
            this.YeastGrid.TabIndex = 2;
            // 
            // MaltGroup
            // 
            this.MaltGroup.Controls.Add(this.RemoveMaltButton);
            this.MaltGroup.Controls.Add(this.AddMaltButton);
            this.MaltGroup.Controls.Add(this.MaltGrid);
            this.MaltGroup.Location = new System.Drawing.Point(12, 47);
            this.MaltGroup.Name = "MaltGroup";
            this.MaltGroup.Size = new System.Drawing.Size(408, 528);
            this.MaltGroup.TabIndex = 1;
            this.MaltGroup.TabStop = false;
            this.MaltGroup.Text = "Malts";
            // 
            // RemoveMaltButton
            // 
            this.RemoveMaltButton.Location = new System.Drawing.Point(278, 31);
            this.RemoveMaltButton.Name = "RemoveMaltButton";
            this.RemoveMaltButton.Size = new System.Drawing.Size(123, 23);
            this.RemoveMaltButton.TabIndex = 2;
            this.RemoveMaltButton.Text = "Remove Malt";
            this.RemoveMaltButton.UseVisualStyleBackColor = true;
            this.RemoveMaltButton.Click += new System.EventHandler(this.RemoveMaltButton_Click);
            // 
            // AddMaltButton
            // 
            this.AddMaltButton.Location = new System.Drawing.Point(7, 31);
            this.AddMaltButton.Name = "AddMaltButton";
            this.AddMaltButton.Size = new System.Drawing.Size(123, 23);
            this.AddMaltButton.TabIndex = 1;
            this.AddMaltButton.Text = "Add Malt";
            this.AddMaltButton.UseVisualStyleBackColor = true;
            this.AddMaltButton.Click += new System.EventHandler(this.AddMaltButton_Click);
            // 
            // MaltGrid
            // 
            this.MaltGrid.AllowUserToAddRows = false;
            this.MaltGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaltGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaltGrid.Location = new System.Drawing.Point(7, 60);
            this.MaltGrid.Name = "MaltGrid";
            this.MaltGrid.RowHeadersVisible = false;
            this.MaltGrid.ShowEditingIcon = false;
            this.MaltGrid.Size = new System.Drawing.Size(394, 462);
            this.MaltGrid.TabIndex = 0;
            // 
            // HopGroup
            // 
            this.HopGroup.Controls.Add(this.RemoveHopsButton);
            this.HopGroup.Controls.Add(this.AddHopsButton);
            this.HopGroup.Controls.Add(this.HopGrid);
            this.HopGroup.Location = new System.Drawing.Point(426, 47);
            this.HopGroup.Name = "HopGroup";
            this.HopGroup.Size = new System.Drawing.Size(457, 528);
            this.HopGroup.TabIndex = 1;
            this.HopGroup.TabStop = false;
            this.HopGroup.Text = "Hops";
            // 
            // RemoveHopsButton
            // 
            this.RemoveHopsButton.Location = new System.Drawing.Point(135, 31);
            this.RemoveHopsButton.Name = "RemoveHopsButton";
            this.RemoveHopsButton.Size = new System.Drawing.Size(123, 23);
            this.RemoveHopsButton.TabIndex = 4;
            this.RemoveHopsButton.Text = "Remove Hop";
            this.RemoveHopsButton.UseVisualStyleBackColor = true;
            this.RemoveHopsButton.Click += new System.EventHandler(this.RemoveHopsButton_Click);
            // 
            // AddHopsButton
            // 
            this.AddHopsButton.Location = new System.Drawing.Point(6, 31);
            this.AddHopsButton.Name = "AddHopsButton";
            this.AddHopsButton.Size = new System.Drawing.Size(123, 23);
            this.AddHopsButton.TabIndex = 3;
            this.AddHopsButton.Text = "Add Hop";
            this.AddHopsButton.UseVisualStyleBackColor = true;
            this.AddHopsButton.Click += new System.EventHandler(this.AddHopsButton_Click);
            // 
            // HopGrid
            // 
            this.HopGrid.AllowUserToAddRows = false;
            this.HopGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HopGrid.Location = new System.Drawing.Point(6, 60);
            this.HopGrid.Name = "HopGrid";
            this.HopGrid.RowHeadersVisible = false;
            this.HopGrid.ShowEditingIcon = false;
            this.HopGrid.Size = new System.Drawing.Size(444, 462);
            this.HopGrid.TabIndex = 1;
            // 
            // RecipeStatsBox
            // 
            this.RecipeStatsBox.Controls.Add(this.maxABVLabel);
            this.RecipeStatsBox.Controls.Add(this.minABVLabel);
            this.RecipeStatsBox.Controls.Add(this.abvSlider);
            this.RecipeStatsBox.Controls.Add(this.maxSRMLabel);
            this.RecipeStatsBox.Controls.Add(this.minSRMLabel);
            this.RecipeStatsBox.Controls.Add(this.srmSlider);
            this.RecipeStatsBox.Controls.Add(this.maxIBULabel);
            this.RecipeStatsBox.Controls.Add(this.minIBULabel);
            this.RecipeStatsBox.Controls.Add(this.ibuSlider);
            this.RecipeStatsBox.Controls.Add(this.maxFGLabel);
            this.RecipeStatsBox.Controls.Add(this.minFGLabel);
            this.RecipeStatsBox.Controls.Add(this.fgSlider);
            this.RecipeStatsBox.Controls.Add(this.maxOGLabel);
            this.RecipeStatsBox.Controls.Add(this.minOGLabel);
            this.RecipeStatsBox.Controls.Add(this.SRMSimulator);
            this.RecipeStatsBox.Controls.Add(this.FGLabel);
            this.RecipeStatsBox.Controls.Add(this.label11);
            this.RecipeStatsBox.Controls.Add(this.ABVLabel);
            this.RecipeStatsBox.Controls.Add(this.label9);
            this.RecipeStatsBox.Controls.Add(this.IBULabel);
            this.RecipeStatsBox.Controls.Add(this.label7);
            this.RecipeStatsBox.Controls.Add(this.OGLabel);
            this.RecipeStatsBox.Controls.Add(this.label6);
            this.RecipeStatsBox.Controls.Add(this.label3);
            this.RecipeStatsBox.Controls.Add(this.IntoFermenterVolumeBox);
            this.RecipeStatsBox.Controls.Add(this.SRMLabel);
            this.RecipeStatsBox.Controls.Add(this.label4);
            this.RecipeStatsBox.Controls.Add(this.label1);
            this.RecipeStatsBox.Controls.Add(this.KitEfficiencyBox);
            this.RecipeStatsBox.Controls.Add(this.ogSlider);
            this.RecipeStatsBox.Location = new System.Drawing.Point(1233, 121);
            this.RecipeStatsBox.Name = "RecipeStatsBox";
            this.RecipeStatsBox.Size = new System.Drawing.Size(300, 415);
            this.RecipeStatsBox.TabIndex = 1;
            this.RecipeStatsBox.TabStop = false;
            this.RecipeStatsBox.Text = "Recipe Statistics";
            // 
            // maxABVLabel
            // 
            this.maxABVLabel.AutoSize = true;
            this.maxABVLabel.Location = new System.Drawing.Point(267, 339);
            this.maxABVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxABVLabel.Name = "maxABVLabel";
            this.maxABVLabel.Size = new System.Drawing.Size(26, 13);
            this.maxABVLabel.TabIndex = 32;
            this.maxABVLabel.Text = "max";
            // 
            // minABVLabel
            // 
            this.minABVLabel.AutoSize = true;
            this.minABVLabel.Location = new System.Drawing.Point(13, 339);
            this.minABVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minABVLabel.Name = "minABVLabel";
            this.minABVLabel.Size = new System.Drawing.Size(23, 13);
            this.minABVLabel.TabIndex = 31;
            this.minABVLabel.Text = "min";
            // 
            // abvSlider
            // 
            this.abvSlider.Location = new System.Drawing.Point(13, 311);
            this.abvSlider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.abvSlider.Name = "abvSlider";
            this.abvSlider.Size = new System.Drawing.Size(287, 45);
            this.abvSlider.TabIndex = 33;
            // 
            // maxSRMLabel
            // 
            this.maxSRMLabel.AutoSize = true;
            this.maxSRMLabel.Location = new System.Drawing.Point(265, 273);
            this.maxSRMLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxSRMLabel.Name = "maxSRMLabel";
            this.maxSRMLabel.Size = new System.Drawing.Size(26, 13);
            this.maxSRMLabel.TabIndex = 29;
            this.maxSRMLabel.Text = "max";
            // 
            // minSRMLabel
            // 
            this.minSRMLabel.AutoSize = true;
            this.minSRMLabel.Location = new System.Drawing.Point(10, 273);
            this.minSRMLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minSRMLabel.Name = "minSRMLabel";
            this.minSRMLabel.Size = new System.Drawing.Size(23, 13);
            this.minSRMLabel.TabIndex = 28;
            this.minSRMLabel.Text = "min";
            // 
            // srmSlider
            // 
            this.srmSlider.Location = new System.Drawing.Point(11, 245);
            this.srmSlider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.srmSlider.Name = "srmSlider";
            this.srmSlider.Size = new System.Drawing.Size(287, 45);
            this.srmSlider.TabIndex = 30;
            // 
            // maxIBULabel
            // 
            this.maxIBULabel.AutoSize = true;
            this.maxIBULabel.Location = new System.Drawing.Point(265, 207);
            this.maxIBULabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxIBULabel.Name = "maxIBULabel";
            this.maxIBULabel.Size = new System.Drawing.Size(26, 13);
            this.maxIBULabel.TabIndex = 26;
            this.maxIBULabel.Text = "max";
            // 
            // minIBULabel
            // 
            this.minIBULabel.AutoSize = true;
            this.minIBULabel.Location = new System.Drawing.Point(10, 207);
            this.minIBULabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minIBULabel.Name = "minIBULabel";
            this.minIBULabel.Size = new System.Drawing.Size(23, 13);
            this.minIBULabel.TabIndex = 25;
            this.minIBULabel.Text = "min";
            // 
            // ibuSlider
            // 
            this.ibuSlider.Location = new System.Drawing.Point(11, 179);
            this.ibuSlider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ibuSlider.Name = "ibuSlider";
            this.ibuSlider.Size = new System.Drawing.Size(287, 45);
            this.ibuSlider.TabIndex = 27;
            // 
            // maxFGLabel
            // 
            this.maxFGLabel.AutoSize = true;
            this.maxFGLabel.Location = new System.Drawing.Point(256, 141);
            this.maxFGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxFGLabel.Name = "maxFGLabel";
            this.maxFGLabel.Size = new System.Drawing.Size(26, 13);
            this.maxFGLabel.TabIndex = 23;
            this.maxFGLabel.Text = "max";
            // 
            // minFGLabel
            // 
            this.minFGLabel.AutoSize = true;
            this.minFGLabel.Location = new System.Drawing.Point(9, 141);
            this.minFGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minFGLabel.Name = "minFGLabel";
            this.minFGLabel.Size = new System.Drawing.Size(23, 13);
            this.minFGLabel.TabIndex = 22;
            this.minFGLabel.Text = "min";
            // 
            // fgSlider
            // 
            this.fgSlider.Location = new System.Drawing.Point(9, 113);
            this.fgSlider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fgSlider.Name = "fgSlider";
            this.fgSlider.Size = new System.Drawing.Size(287, 45);
            this.fgSlider.TabIndex = 24;
            // 
            // maxOGLabel
            // 
            this.maxOGLabel.AutoSize = true;
            this.maxOGLabel.Location = new System.Drawing.Point(255, 66);
            this.maxOGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxOGLabel.Name = "maxOGLabel";
            this.maxOGLabel.Size = new System.Drawing.Size(26, 13);
            this.maxOGLabel.TabIndex = 20;
            this.maxOGLabel.Text = "max";
            // 
            // minOGLabel
            // 
            this.minOGLabel.AutoSize = true;
            this.minOGLabel.Location = new System.Drawing.Point(8, 66);
            this.minOGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minOGLabel.Name = "minOGLabel";
            this.minOGLabel.Size = new System.Drawing.Size(23, 13);
            this.minOGLabel.TabIndex = 19;
            this.minOGLabel.Text = "min";
            // 
            // SRMSimulator
            // 
            this.SRMSimulator.Location = new System.Drawing.Point(102, 224);
            this.SRMSimulator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SRMSimulator.Name = "SRMSimulator";
            this.SRMSimulator.Size = new System.Drawing.Size(68, 20);
            this.SRMSimulator.TabIndex = 18;
            // 
            // FGLabel
            // 
            this.FGLabel.AutoSize = true;
            this.FGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FGLabel.Location = new System.Drawing.Point(67, 81);
            this.FGLabel.Name = "FGLabel";
            this.FGLabel.Size = new System.Drawing.Size(20, 24);
            this.FGLabel.TabIndex = 17;
            this.FGLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "FG:";
            // 
            // ABVLabel
            // 
            this.ABVLabel.AutoSize = true;
            this.ABVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABVLabel.Location = new System.Drawing.Point(72, 288);
            this.ABVLabel.Name = "ABVLabel";
            this.ABVLabel.Size = new System.Drawing.Size(20, 24);
            this.ABVLabel.TabIndex = 15;
            this.ABVLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "ABV:";
            // 
            // IBULabel
            // 
            this.IBULabel.AutoSize = true;
            this.IBULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBULabel.Location = new System.Drawing.Point(68, 156);
            this.IBULabel.Name = "IBULabel";
            this.IBULabel.Size = new System.Drawing.Size(20, 24);
            this.IBULabel.TabIndex = 13;
            this.IBULabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "IBU:";
            // 
            // OGLabel
            // 
            this.OGLabel.AutoSize = true;
            this.OGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OGLabel.Location = new System.Drawing.Point(67, 16);
            this.OGLabel.Name = "OGLabel";
            this.OGLabel.Size = new System.Drawing.Size(20, 24);
            this.OGLabel.TabIndex = 11;
            this.OGLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "OG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Into Fermenter Volume";
            // 
            // IntoFermenterVolumeBox
            // 
            this.IntoFermenterVolumeBox.Location = new System.Drawing.Point(171, 364);
            this.IntoFermenterVolumeBox.Name = "IntoFermenterVolumeBox";
            this.IntoFermenterVolumeBox.Size = new System.Drawing.Size(123, 20);
            this.IntoFermenterVolumeBox.TabIndex = 6;
            this.IntoFermenterVolumeBox.TextChanged += new System.EventHandler(this.ChangeIntoFermenterVolume);
            // 
            // SRMLabel
            // 
            this.SRMLabel.AutoSize = true;
            this.SRMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRMLabel.Location = new System.Drawing.Point(69, 222);
            this.SRMLabel.Name = "SRMLabel";
            this.SRMLabel.Size = new System.Drawing.Size(20, 24);
            this.SRMLabel.TabIndex = 5;
            this.SRMLabel.Text = "0";
            this.SRMLabel.Click += new System.EventHandler(this.SRMLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "SRM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ideal Brew Kit Efficiency";
            // 
            // KitEfficiencyBox
            // 
            this.KitEfficiencyBox.Location = new System.Drawing.Point(171, 388);
            this.KitEfficiencyBox.Name = "KitEfficiencyBox";
            this.KitEfficiencyBox.Size = new System.Drawing.Size(123, 20);
            this.KitEfficiencyBox.TabIndex = 0;
            this.KitEfficiencyBox.TextChanged += new System.EventHandler(this.ChangeKitEfficiency);
            // 
            // ogSlider
            // 
            this.ogSlider.Location = new System.Drawing.Point(9, 38);
            this.ogSlider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ogSlider.Name = "ogSlider";
            this.ogSlider.Size = new System.Drawing.Size(287, 45);
            this.ogSlider.TabIndex = 21;
            // 
            // RawPPGLabel
            // 
            this.RawPPGLabel.AutoSize = true;
            this.RawPPGLabel.Location = new System.Drawing.Point(1385, 552);
            this.RawPPGLabel.Name = "RawPPGLabel";
            this.RawPPGLabel.Size = new System.Drawing.Size(13, 13);
            this.RawPPGLabel.TabIndex = 9;
            this.RawPPGLabel.Text = "0";
            this.RawPPGLabel.Visible = false;
            this.RawPPGLabel.Click += new System.EventHandler(this.RawPPGLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1331, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Raw PPG:";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // GravityPointsLabel
            // 
            this.GravityPointsLabel.AutoSize = true;
            this.GravityPointsLabel.Location = new System.Drawing.Point(1385, 565);
            this.GravityPointsLabel.Name = "GravityPointsLabel";
            this.GravityPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.GravityPointsLabel.TabIndex = 3;
            this.GravityPointsLabel.Text = "0";
            this.GravityPointsLabel.Visible = false;
            this.GravityPointsLabel.Click += new System.EventHandler(this.GravityPointsLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1313, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adjusted PPG:";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.recipesToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1539, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveRecipeToolStripMenuItem,
            this.closeRecipeBuilderToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveRecipeToolStripMenuItem
            // 
            this.saveRecipeToolStripMenuItem.Name = "saveRecipeToolStripMenuItem";
            this.saveRecipeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveRecipeToolStripMenuItem.Text = "Save Recipe";
            // 
            // closeRecipeBuilderToolStripMenuItem
            // 
            this.closeRecipeBuilderToolStripMenuItem.Name = "closeRecipeBuilderToolStripMenuItem";
            this.closeRecipeBuilderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.closeRecipeBuilderToolStripMenuItem.Text = "Close Recipe Builder";
            // 
            // recipesToolStripMenuItem
            // 
            this.recipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRecipeToolStripMenuItem,
            this.openRecipeToolStripMenuItem,
            this.saveRecipeToolStripMenuItem1});
            this.recipesToolStripMenuItem.Name = "recipesToolStripMenuItem";
            this.recipesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.recipesToolStripMenuItem.Text = "Recipes";
            // 
            // newRecipeToolStripMenuItem
            // 
            this.newRecipeToolStripMenuItem.Name = "newRecipeToolStripMenuItem";
            this.newRecipeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newRecipeToolStripMenuItem.Text = "New Recipe";
            this.newRecipeToolStripMenuItem.Click += new System.EventHandler(this.newRecipeToolStripMenuItem_Click);
            // 
            // openRecipeToolStripMenuItem
            // 
            this.openRecipeToolStripMenuItem.Name = "openRecipeToolStripMenuItem";
            this.openRecipeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openRecipeToolStripMenuItem.Text = "Open Recipe";
            this.openRecipeToolStripMenuItem.Click += new System.EventHandler(this.viewRecipesToolStripMenuItem_Click);
            // 
            // saveRecipeToolStripMenuItem1
            // 
            this.saveRecipeToolStripMenuItem1.Name = "saveRecipeToolStripMenuItem1";
            this.saveRecipeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveRecipeToolStripMenuItem1.Text = "SaveRecipe";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingredientManagerToolStripMenuItem,
            this.aPILocationHandlerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // ingredientManagerToolStripMenuItem
            // 
            this.ingredientManagerToolStripMenuItem.Name = "ingredientManagerToolStripMenuItem";
            this.ingredientManagerToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ingredientManagerToolStripMenuItem.Text = "Ingredient Manager";
            this.ingredientManagerToolStripMenuItem.Click += new System.EventHandler(this.ingredientManagerToolStripMenuItem_Click);
            // 
            // aPILocationHandlerToolStripMenuItem
            // 
            this.aPILocationHandlerToolStripMenuItem.Name = "aPILocationHandlerToolStripMenuItem";
            this.aPILocationHandlerToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aPILocationHandlerToolStripMenuItem.Text = "API Location Handler";
            this.aPILocationHandlerToolStripMenuItem.Click += new System.EventHandler(this.aPILocationHandlerToolStripMenuItem_Click);
            // 
            // BeerStyleLabel
            // 
            this.BeerStyleLabel.AutoSize = true;
            this.BeerStyleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerStyleLabel.Location = new System.Drawing.Point(646, 24);
            this.BeerStyleLabel.Name = "BeerStyleLabel";
            this.BeerStyleLabel.Size = new System.Drawing.Size(85, 20);
            this.BeerStyleLabel.TabIndex = 4;
            this.BeerStyleLabel.Text = "BeerName";
            this.BeerStyleLabel.Click += new System.EventHandler(this.BeerStyleLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Style:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AddOtherIngredientsButton);
            this.groupBox1.Controls.Add(this.OtherIngredientsGrid);
            this.groupBox1.Location = new System.Drawing.Point(889, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 256);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other Ingredients";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOtherIngredientsButton
            // 
            this.AddOtherIngredientsButton.Location = new System.Drawing.Point(7, 28);
            this.AddOtherIngredientsButton.Name = "AddOtherIngredientsButton";
            this.AddOtherIngredientsButton.Size = new System.Drawing.Size(123, 23);
            this.AddOtherIngredientsButton.TabIndex = 5;
            this.AddOtherIngredientsButton.Text = "Add";
            this.AddOtherIngredientsButton.UseVisualStyleBackColor = true;
            this.AddOtherIngredientsButton.Click += new System.EventHandler(this.AddOtherIngredientsButton_Click);
            // 
            // OtherIngredientsGrid
            // 
            this.OtherIngredientsGrid.AllowUserToAddRows = false;
            this.OtherIngredientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OtherIngredientsGrid.Location = new System.Drawing.Point(7, 57);
            this.OtherIngredientsGrid.Name = "OtherIngredientsGrid";
            this.OtherIngredientsGrid.Size = new System.Drawing.Size(325, 193);
            this.OtherIngredientsGrid.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1404, 542);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 33);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BeerNameBox
            // 
            this.BeerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerNameBox.Location = new System.Drawing.Point(19, 21);
            this.BeerNameBox.Name = "BeerNameBox";
            this.BeerNameBox.Size = new System.Drawing.Size(401, 26);
            this.BeerNameBox.TabIndex = 10;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(6, 19);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(285, 61);
            this.descriptionBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.descriptionBox);
            this.groupBox2.Location = new System.Drawing.Point(1233, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 88);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipe Description";
            // 
            // Recipe_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BeerNameBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BeerStyleLabel);
            this.Controls.Add(this.RecipeStatsBox);
            this.Controls.Add(this.HopGroup);
            this.Controls.Add(this.MaltGroup);
            this.Controls.Add(this.YeastBox);
            this.Controls.Add(this.RawPPGLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GravityPointsLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Recipe_Creator";
            this.Text = "Recipe_Creator";
            this.YeastBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YeastGrid)).EndInit();
            this.MaltGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaltGrid)).EndInit();
            this.HopGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HopGrid)).EndInit();
            this.RecipeStatsBox.ResumeLayout(false);
            this.RecipeStatsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abvSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srmSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibuSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogSlider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OtherIngredientsGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox YeastBox;
        private System.Windows.Forms.GroupBox MaltGroup;
        private System.Windows.Forms.GroupBox HopGroup;
        private System.Windows.Forms.GroupBox RecipeStatsBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button RemoveYeastButton;
        private System.Windows.Forms.Button AddYeastButton;
        private System.Windows.Forms.DataGridView YeastGrid;
        private System.Windows.Forms.Button RemoveMaltButton;
        private System.Windows.Forms.Button AddMaltButton;
        private System.Windows.Forms.DataGridView MaltGrid;
        private System.Windows.Forms.Button RemoveHopsButton;
        private System.Windows.Forms.Button AddHopsButton;
        private System.Windows.Forms.DataGridView HopGrid;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KitEfficiencyBox;
        private System.Windows.Forms.ToolStripMenuItem saveRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeRecipeBuilderToolStripMenuItem;
        private System.Windows.Forms.Label SRMLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GravityPointsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IntoFermenterVolumeBox;
        private System.Windows.Forms.Label OGLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RawPPGLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label IBULabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BeerStyleLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddOtherIngredientsButton;
        private System.Windows.Forms.DataGridView OtherIngredientsGrid;
        private System.Windows.Forms.Label FGLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ABVLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SRMSimulator;
        private System.Windows.Forms.ToolStripMenuItem recipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRecipeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientManagerToolStripMenuItem;
        private System.Windows.Forms.Label maxOGLabel;
        private System.Windows.Forms.Label minOGLabel;
        private System.Windows.Forms.TrackBar ogSlider;
        private System.Windows.Forms.Label maxFGLabel;
        private System.Windows.Forms.Label minFGLabel;
        private System.Windows.Forms.TrackBar fgSlider;
        private System.Windows.Forms.Label maxABVLabel;
        private System.Windows.Forms.Label minABVLabel;
        private System.Windows.Forms.TrackBar abvSlider;
        private System.Windows.Forms.Label maxSRMLabel;
        private System.Windows.Forms.Label minSRMLabel;
        private System.Windows.Forms.TrackBar srmSlider;
        private System.Windows.Forms.Label maxIBULabel;
        private System.Windows.Forms.Label minIBULabel;
        private System.Windows.Forms.TrackBar ibuSlider;
        private System.Windows.Forms.ToolStripMenuItem aPILocationHandlerToolStripMenuItem;
        private System.Windows.Forms.TextBox BeerNameBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}