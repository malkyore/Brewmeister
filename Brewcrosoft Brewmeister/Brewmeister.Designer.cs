namespace Brewcrosoft_Brewmeister
{
    partial class HomeScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Era5Button = new System.Windows.Forms.Button();
            this.Era4Button = new System.Windows.Forms.Button();
            this.Era3Button = new System.Windows.Forms.Button();
            this.Era2Button = new System.Windows.Forms.Button();
            this.Era1Button = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBeerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBeerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBeerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BeerDescriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BeerStyleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BeerNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hopname = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.hopnamebox = new System.Windows.Forms.TextBox();
            this.postbutton = new System.Windows.Forms.Button();
            this.postaaubox = new System.Windows.Forms.TextBox();
            this.postnamebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hopaau = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Era5Button);
            this.groupBox1.Controls.Add(this.Era4Button);
            this.groupBox1.Controls.Add(this.Era3Button);
            this.groupBox1.Controls.Add(this.Era2Button);
            this.groupBox1.Controls.Add(this.Era1Button);
            this.groupBox1.Location = new System.Drawing.Point(18, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eras";
            // 
            // Era5Button
            // 
            this.Era5Button.Location = new System.Drawing.Point(9, 258);
            this.Era5Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Era5Button.Name = "Era5Button";
            this.Era5Button.Size = new System.Drawing.Size(282, 46);
            this.Era5Button.TabIndex = 4;
            this.Era5Button.Text = "Era 5: Enjoyment";
            this.Era5Button.UseVisualStyleBackColor = true;
            // 
            // Era4Button
            // 
            this.Era4Button.Location = new System.Drawing.Point(9, 203);
            this.Era4Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Era4Button.Name = "Era4Button";
            this.Era4Button.Size = new System.Drawing.Size(282, 46);
            this.Era4Button.TabIndex = 3;
            this.Era4Button.Text = "Era 4: Post Brew";
            this.Era4Button.UseVisualStyleBackColor = true;
            // 
            // Era3Button
            // 
            this.Era3Button.Location = new System.Drawing.Point(9, 148);
            this.Era3Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Era3Button.Name = "Era3Button";
            this.Era3Button.Size = new System.Drawing.Size(282, 46);
            this.Era3Button.TabIndex = 2;
            this.Era3Button.Text = "Era 3: Brew Day";
            this.Era3Button.UseVisualStyleBackColor = true;
            // 
            // Era2Button
            // 
            this.Era2Button.Location = new System.Drawing.Point(9, 92);
            this.Era2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Era2Button.Name = "Era2Button";
            this.Era2Button.Size = new System.Drawing.Size(282, 46);
            this.Era2Button.TabIndex = 1;
            this.Era2Button.Text = "Era 2: Fix Recipe";
            this.Era2Button.UseVisualStyleBackColor = true;
            // 
            // Era1Button
            // 
            this.Era1Button.Location = new System.Drawing.Point(9, 37);
            this.Era1Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Era1Button.Name = "Era1Button";
            this.Era1Button.Size = new System.Drawing.Size(282, 46);
            this.Era1Button.TabIndex = 0;
            this.Era1Button.Text = "Era 1: Recipe Creation";
            this.Era1Button.UseVisualStyleBackColor = true;
            this.Era1Button.Click += new System.EventHandler(this.OpenRecipeCreator_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRecipesToolStripMenuItem,
            this.ingredientManagerToolStripMenuItem,
            this.newBeerToolStripMenuItem,
            this.openBeerToolStripMenuItem,
            this.saveBeerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // viewRecipesToolStripMenuItem
            // 
            this.viewRecipesToolStripMenuItem.Name = "viewRecipesToolStripMenuItem";
            this.viewRecipesToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.viewRecipesToolStripMenuItem.Text = "View Recipes";
            this.viewRecipesToolStripMenuItem.Click += new System.EventHandler(this.viewRecipesToolStripMenuItem_Click);
            // 
            // ingredientManagerToolStripMenuItem
            // 
            this.ingredientManagerToolStripMenuItem.Name = "ingredientManagerToolStripMenuItem";
            this.ingredientManagerToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.ingredientManagerToolStripMenuItem.Text = "Ingredient Manager";
            this.ingredientManagerToolStripMenuItem.Click += new System.EventHandler(this.ingredientManagerToolStripMenuItem_Click);
            // 
            // newBeerToolStripMenuItem
            // 
            this.newBeerToolStripMenuItem.Name = "newBeerToolStripMenuItem";
            this.newBeerToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.newBeerToolStripMenuItem.Text = "New Beer";
            this.newBeerToolStripMenuItem.Click += new System.EventHandler(this.newBeerToolStripMenuItem_Click);
            // 
            // openBeerToolStripMenuItem
            // 
            this.openBeerToolStripMenuItem.Enabled = false;
            this.openBeerToolStripMenuItem.Name = "openBeerToolStripMenuItem";
            this.openBeerToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openBeerToolStripMenuItem.Text = "Open Beer";
            this.openBeerToolStripMenuItem.Click += new System.EventHandler(this.openBeerToolStripMenuItem_Click);
            // 
            // saveBeerToolStripMenuItem
            // 
            this.saveBeerToolStripMenuItem.Enabled = false;
            this.saveBeerToolStripMenuItem.Name = "saveBeerToolStripMenuItem";
            this.saveBeerToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveBeerToolStripMenuItem.Text = "Save Beer";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(835, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLocationsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // fileLocationsToolStripMenuItem
            // 
            this.fileLocationsToolStripMenuItem.Name = "fileLocationsToolStripMenuItem";
            this.fileLocationsToolStripMenuItem.Size = new System.Drawing.Size(202, 30);
            this.fileLocationsToolStripMenuItem.Text = "File Locations";
            this.fileLocationsToolStripMenuItem.Click += new System.EventHandler(this.fileLocationsToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BeerDescriptionBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BeerStyleBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BeerNameBox);
            this.groupBox2.Location = new System.Drawing.Point(328, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(496, 318);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beer Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beer Description";
            // 
            // BeerDescriptionBox
            // 
            this.BeerDescriptionBox.Location = new System.Drawing.Point(10, 172);
            this.BeerDescriptionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BeerDescriptionBox.Multiline = true;
            this.BeerDescriptionBox.Name = "BeerDescriptionBox";
            this.BeerDescriptionBox.Size = new System.Drawing.Size(475, 130);
            this.BeerDescriptionBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beer Style";
            // 
            // BeerStyleBox
            // 
            this.BeerStyleBox.Location = new System.Drawing.Point(9, 112);
            this.BeerStyleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BeerStyleBox.Name = "BeerStyleBox";
            this.BeerStyleBox.Size = new System.Drawing.Size(475, 26);
            this.BeerStyleBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beer Name";
            // 
            // BeerNameBox
            // 
            this.BeerNameBox.Location = new System.Drawing.Point(9, 52);
            this.BeerNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BeerNameBox.Name = "BeerNameBox";
            this.BeerNameBox.Size = new System.Drawing.Size(475, 26);
            this.BeerNameBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(873, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nothing about this is ghetto";
            // 
            // hopname
            // 
            this.hopname.AutoSize = true;
            this.hopname.Location = new System.Drawing.Point(976, 300);
            this.hopname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hopname.Name = "hopname";
            this.hopname.Size = new System.Drawing.Size(55, 20);
            this.hopname.TabIndex = 4;
            this.hopname.Text = "NAME";
            this.hopname.Click += new System.EventHandler(this.hopname_Click);
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(860, 234);
            this.getButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(112, 35);
            this.getButton.TabIndex = 5;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // hopnamebox
            // 
            this.hopnamebox.Location = new System.Drawing.Point(981, 237);
            this.hopnamebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hopnamebox.Name = "hopnamebox";
            this.hopnamebox.Size = new System.Drawing.Size(244, 26);
            this.hopnamebox.TabIndex = 6;
            // 
            // postbutton
            // 
            this.postbutton.Location = new System.Drawing.Point(860, 148);
            this.postbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postbutton.Name = "postbutton";
            this.postbutton.Size = new System.Drawing.Size(112, 35);
            this.postbutton.TabIndex = 7;
            this.postbutton.Text = "Post";
            this.postbutton.UseVisualStyleBackColor = true;
            this.postbutton.Click += new System.EventHandler(this.postbutton_Click);
            // 
            // postaaubox
            // 
            this.postaaubox.Location = new System.Drawing.Point(981, 178);
            this.postaaubox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postaaubox.Name = "postaaubox";
            this.postaaubox.Size = new System.Drawing.Size(244, 26);
            this.postaaubox.TabIndex = 8;
            // 
            // postnamebox
            // 
            this.postnamebox.Location = new System.Drawing.Point(981, 118);
            this.postnamebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postnamebox.Name = "postnamebox";
            this.postnamebox.Size = new System.Drawing.Size(244, 26);
            this.postnamebox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(981, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(981, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "AAU";
            // 
            // hopaau
            // 
            this.hopaau.AutoSize = true;
            this.hopaau.Location = new System.Drawing.Point(976, 326);
            this.hopaau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hopaau.Name = "hopaau";
            this.hopaau.Size = new System.Drawing.Size(43, 20);
            this.hopaau.TabIndex = 12;
            this.hopaau.Text = "AAU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(910, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(921, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "AAU: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 369);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hopaau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.postnamebox);
            this.Controls.Add(this.postaaubox);
            this.Controls.Add(this.postbutton);
            this.Controls.Add(this.hopnamebox);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.hopname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeScreen";
            this.Text = "Brewcrosoft Brewmeister";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Era5Button;
        private System.Windows.Forms.Button Era4Button;
        private System.Windows.Forms.Button Era3Button;
        private System.Windows.Forms.Button Era2Button;
        private System.Windows.Forms.Button Era1Button;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBeerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBeerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBeerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BeerDescriptionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BeerStyleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BeerNameBox;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileLocationsToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hopname;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.TextBox hopnamebox;
        private System.Windows.Forms.Button postbutton;
        private System.Windows.Forms.TextBox postaaubox;
        private System.Windows.Forms.TextBox postnamebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hopaau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem viewRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientManagerToolStripMenuItem;
    }
}

