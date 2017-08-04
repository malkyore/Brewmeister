namespace Brewcrosoft_Brewmeister
{
    partial class FileLocationSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.RecipeLocationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IngredientLocationBox = new System.Windows.Forms.TextBox();
            this.OpenRecipeFileLocation = new System.Windows.Forms.Button();
            this.OpenIngredientFileLocation = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe File Locations";
            // 
            // RecipeLocationBox
            // 
            this.RecipeLocationBox.Location = new System.Drawing.Point(13, 30);
            this.RecipeLocationBox.Name = "RecipeLocationBox";
            this.RecipeLocationBox.Size = new System.Drawing.Size(518, 20);
            this.RecipeLocationBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingredient File Locations";
            // 
            // IngredientLocationBox
            // 
            this.IngredientLocationBox.Location = new System.Drawing.Point(12, 69);
            this.IngredientLocationBox.Name = "IngredientLocationBox";
            this.IngredientLocationBox.Size = new System.Drawing.Size(518, 20);
            this.IngredientLocationBox.TabIndex = 3;
            // 
            // OpenRecipeFileLocation
            // 
            this.OpenRecipeFileLocation.Location = new System.Drawing.Point(537, 28);
            this.OpenRecipeFileLocation.Name = "OpenRecipeFileLocation";
            this.OpenRecipeFileLocation.Size = new System.Drawing.Size(75, 23);
            this.OpenRecipeFileLocation.TabIndex = 4;
            this.OpenRecipeFileLocation.Text = "Open";
            this.OpenRecipeFileLocation.UseVisualStyleBackColor = true;
            this.OpenRecipeFileLocation.Click += new System.EventHandler(this.OpenRecipeFileLocation_Click);
            // 
            // OpenIngredientFileLocation
            // 
            this.OpenIngredientFileLocation.Location = new System.Drawing.Point(537, 66);
            this.OpenIngredientFileLocation.Name = "OpenIngredientFileLocation";
            this.OpenIngredientFileLocation.Size = new System.Drawing.Size(76, 23);
            this.OpenIngredientFileLocation.TabIndex = 5;
            this.OpenIngredientFileLocation.Text = "Open";
            this.OpenIngredientFileLocation.UseVisualStyleBackColor = true;
            this.OpenIngredientFileLocation.Click += new System.EventHandler(this.OpenIngredientFileLocation_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(537, 102);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(76, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FileLocationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 137);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenIngredientFileLocation);
            this.Controls.Add(this.OpenRecipeFileLocation);
            this.Controls.Add(this.IngredientLocationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecipeLocationBox);
            this.Controls.Add(this.label1);
            this.Name = "FileLocationSettings";
            this.Text = "FileLocationSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RecipeLocationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IngredientLocationBox;
        private System.Windows.Forms.Button OpenRecipeFileLocation;
        private System.Windows.Forms.Button OpenIngredientFileLocation;
        private System.Windows.Forms.Button SaveButton;
    }
}