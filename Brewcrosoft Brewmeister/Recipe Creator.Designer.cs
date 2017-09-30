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
            this.FGLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ABVLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IBULabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OGLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RawPPGLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IntoFermenterVolumeBox = new System.Windows.Forms.TextBox();
            this.SRMLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GravityPointsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KitEfficiencyBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeRecipeBuilderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BeerNameLabel = new System.Windows.Forms.Label();
            this.BeerStyleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddOtherIngredientsButton = new System.Windows.Forms.Button();
            this.OtherIngredientsGrid = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.YeastBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YeastGrid)).BeginInit();
            this.MaltGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaltGrid)).BeginInit();
            this.HopGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HopGrid)).BeginInit();
            this.RecipeStatsBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherIngredientsGrid)).BeginInit();
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
            this.MaltGrid.Cursor = System.Windows.Forms.Cursors.No;
            this.MaltGrid.Location = new System.Drawing.Point(7, 60);
            this.MaltGrid.Name = "MaltGrid";
            this.MaltGrid.RowHeadersVisible = false;
            this.MaltGrid.ShowEditingIcon = false;
            this.MaltGrid.Size = new System.Drawing.Size(394, 462);
            this.MaltGrid.TabIndex = 0;
            this.MaltGrid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.HopGrid_CellLeave);
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
            this.HopGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.HopGrid_CellLeave);
            this.HopGrid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.HopGrid_CellLeave);
            this.HopGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.HopGrid_CellLeave);
            // 
            // RecipeStatsBox
            // 
            this.RecipeStatsBox.Controls.Add(this.FGLabel);
            this.RecipeStatsBox.Controls.Add(this.label11);
            this.RecipeStatsBox.Controls.Add(this.ABVLabel);
            this.RecipeStatsBox.Controls.Add(this.label9);
            this.RecipeStatsBox.Controls.Add(this.IBULabel);
            this.RecipeStatsBox.Controls.Add(this.label7);
            this.RecipeStatsBox.Controls.Add(this.OGLabel);
            this.RecipeStatsBox.Controls.Add(this.label6);
            this.RecipeStatsBox.Controls.Add(this.RawPPGLabel);
            this.RecipeStatsBox.Controls.Add(this.label8);
            this.RecipeStatsBox.Controls.Add(this.label3);
            this.RecipeStatsBox.Controls.Add(this.IntoFermenterVolumeBox);
            this.RecipeStatsBox.Controls.Add(this.SRMLabel);
            this.RecipeStatsBox.Controls.Add(this.label4);
            this.RecipeStatsBox.Controls.Add(this.GravityPointsLabel);
            this.RecipeStatsBox.Controls.Add(this.label2);
            this.RecipeStatsBox.Controls.Add(this.label1);
            this.RecipeStatsBox.Controls.Add(this.KitEfficiencyBox);
            this.RecipeStatsBox.Location = new System.Drawing.Point(1233, 47);
            this.RecipeStatsBox.Name = "RecipeStatsBox";
            this.RecipeStatsBox.Size = new System.Drawing.Size(300, 489);
            this.RecipeStatsBox.TabIndex = 1;
            this.RecipeStatsBox.TabStop = false;
            this.RecipeStatsBox.Text = "Recipe Statistics";
            // 
            // FGLabel
            // 
            this.FGLabel.AutoSize = true;
            this.FGLabel.Location = new System.Drawing.Point(79, 57);
            this.FGLabel.Name = "FGLabel";
            this.FGLabel.Size = new System.Drawing.Size(13, 13);
            this.FGLabel.TabIndex = 17;
            this.FGLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "FG:";
            // 
            // ABVLabel
            // 
            this.ABVLabel.AutoSize = true;
            this.ABVLabel.Location = new System.Drawing.Point(247, 48);
            this.ABVLabel.Name = "ABVLabel";
            this.ABVLabel.Size = new System.Drawing.Size(13, 13);
            this.ABVLabel.TabIndex = 15;
            this.ABVLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "ABV:";
            // 
            // IBULabel
            // 
            this.IBULabel.AutoSize = true;
            this.IBULabel.Location = new System.Drawing.Point(246, 16);
            this.IBULabel.Name = "IBULabel";
            this.IBULabel.Size = new System.Drawing.Size(13, 13);
            this.IBULabel.TabIndex = 13;
            this.IBULabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "IBU:";
            // 
            // OGLabel
            // 
            this.OGLabel.AutoSize = true;
            this.OGLabel.Location = new System.Drawing.Point(79, 43);
            this.OGLabel.Name = "OGLabel";
            this.OGLabel.Size = new System.Drawing.Size(13, 13);
            this.OGLabel.TabIndex = 11;
            this.OGLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "OG:";
            // 
            // RawPPGLabel
            // 
            this.RawPPGLabel.AutoSize = true;
            this.RawPPGLabel.Location = new System.Drawing.Point(79, 16);
            this.RawPPGLabel.Name = "RawPPGLabel";
            this.RawPPGLabel.Size = new System.Drawing.Size(13, 13);
            this.RawPPGLabel.TabIndex = 9;
            this.RawPPGLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Raw PPG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Into Fermenter Volume";
            // 
            // IntoFermenterVolumeBox
            // 
            this.IntoFermenterVolumeBox.Location = new System.Drawing.Point(171, 406);
            this.IntoFermenterVolumeBox.Name = "IntoFermenterVolumeBox";
            this.IntoFermenterVolumeBox.Size = new System.Drawing.Size(123, 20);
            this.IntoFermenterVolumeBox.TabIndex = 6;
            this.IntoFermenterVolumeBox.TextChanged += new System.EventHandler(this.ChangeIntoFermenterVolume);
            // 
            // SRMLabel
            // 
            this.SRMLabel.AutoSize = true;
            this.SRMLabel.Location = new System.Drawing.Point(247, 31);
            this.SRMLabel.Name = "SRMLabel";
            this.SRMLabel.Size = new System.Drawing.Size(13, 13);
            this.SRMLabel.TabIndex = 5;
            this.SRMLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SRM:";
            // 
            // GravityPointsLabel
            // 
            this.GravityPointsLabel.AutoSize = true;
            this.GravityPointsLabel.Location = new System.Drawing.Point(79, 29);
            this.GravityPointsLabel.Name = "GravityPointsLabel";
            this.GravityPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.GravityPointsLabel.TabIndex = 3;
            this.GravityPointsLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adjusted PPG:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ideal Brew Kit Efficiency";
            // 
            // KitEfficiencyBox
            // 
            this.KitEfficiencyBox.Location = new System.Drawing.Point(171, 430);
            this.KitEfficiencyBox.Name = "KitEfficiencyBox";
            this.KitEfficiencyBox.Size = new System.Drawing.Size(123, 20);
            this.KitEfficiencyBox.TabIndex = 0;
            this.KitEfficiencyBox.TextChanged += new System.EventHandler(this.ChangeKitEfficiency);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
            // BeerNameLabel
            // 
            this.BeerNameLabel.AutoSize = true;
            this.BeerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerNameLabel.Location = new System.Drawing.Point(15, 24);
            this.BeerNameLabel.Name = "BeerNameLabel";
            this.BeerNameLabel.Size = new System.Drawing.Size(85, 20);
            this.BeerNameLabel.TabIndex = 3;
            this.BeerNameLabel.Text = "BeerName";
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
            // Recipe_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 584);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BeerStyleLabel);
            this.Controls.Add(this.BeerNameLabel);
            this.Controls.Add(this.RecipeStatsBox);
            this.Controls.Add(this.HopGroup);
            this.Controls.Add(this.MaltGroup);
            this.Controls.Add(this.YeastBox);
            this.Controls.Add(this.menuStrip1);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OtherIngredientsGrid)).EndInit();
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
        private System.Windows.Forms.Label BeerNameLabel;
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
    }
}