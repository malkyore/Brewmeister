namespace Brewcrosoft_Brewmeister
{
    partial class View_Recipes
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
            this.RecipeGrid = new System.Windows.Forms.DataGridView();
            this.GetRecipeButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeGrid
            // 
            this.RecipeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeGrid.Location = new System.Drawing.Point(13, 14);
            this.RecipeGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecipeGrid.Name = "RecipeGrid";
            this.RecipeGrid.Size = new System.Drawing.Size(820, 231);
            this.RecipeGrid.TabIndex = 0;
            this.RecipeGrid.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // GetRecipeButton
            // 
            this.GetRecipeButton.Location = new System.Drawing.Point(601, 255);
            this.GetRecipeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetRecipeButton.Name = "GetRecipeButton";
            this.GetRecipeButton.Size = new System.Drawing.Size(112, 35);
            this.GetRecipeButton.TabIndex = 1;
            this.GetRecipeButton.Text = "Update Grid";
            this.GetRecipeButton.UseVisualStyleBackColor = true;
            this.GetRecipeButton.Click += new System.EventHandler(this.GetRecipeButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(721, 255);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(112, 35);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // View_Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 298);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.GetRecipeButton);
            this.Controls.Add(this.RecipeGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View_Recipes";
            this.Text = "View Recipes";
            this.Load += new System.EventHandler(this.loadRecipesOnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RecipeGrid;
        private System.Windows.Forms.Button GetRecipeButton;
        private System.Windows.Forms.Button SelectButton;
    }
}