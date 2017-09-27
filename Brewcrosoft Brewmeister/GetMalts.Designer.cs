namespace Brewcrosoft_Brewmeister
{
    partial class GetMalts
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
            this.RecipeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(484, 169);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 7;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // RecipeGrid
            // 
            this.RecipeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeGrid.Location = new System.Drawing.Point(12, 12);
            this.RecipeGrid.Name = "RecipeGrid";
            this.RecipeGrid.Size = new System.Drawing.Size(547, 150);
            this.RecipeGrid.TabIndex = 6;
            this.RecipeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipeGrid_CellContentClick);
            // 
            // GetMalts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 196);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.RecipeGrid);
            this.Name = "GetMalts";
            this.Text = "GetMalts";
            this.Load += new System.EventHandler(this.loadRecipesOnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.DataGridView RecipeGrid;
    }
}