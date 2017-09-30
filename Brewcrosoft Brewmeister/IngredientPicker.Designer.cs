namespace Brewcrosoft_Brewmeister
{
    partial class IngredientPicker
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
            this.SelectButton = new System.Windows.Forms.Button();
            this.IngredientGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(481, 166);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 5;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // IngredientGrid
            // 
            this.IngredientGrid.AllowUserToAddRows = false;
            this.IngredientGrid.AllowUserToDeleteRows = false;
            this.IngredientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientGrid.Location = new System.Drawing.Point(9, 9);
            this.IngredientGrid.Name = "IngredientGrid";
            this.IngredientGrid.RowHeadersVisible = false;
            this.IngredientGrid.Size = new System.Drawing.Size(547, 150);
            this.IngredientGrid.TabIndex = 3;
            this.IngredientGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipeGrid_CellDoubleClick);
            this.IngredientGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RecipeGrid_KeyDown);
            // 
            // IngredientPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 198);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.IngredientGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IngredientPicker";
            this.Text = "GetHops";
            this.Load += new System.EventHandler(this.loadIngredientsOnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.IngredientGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.DataGridView IngredientGrid;
    }
}