namespace Brewcrosoft_Brewmeister
{
    partial class GetHops
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
            this.SelectButton.Location = new System.Drawing.Point(721, 255);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(112, 35);
            this.SelectButton.TabIndex = 5;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // RecipeGrid
            // 
            this.RecipeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeGrid.Location = new System.Drawing.Point(13, 14);
            this.RecipeGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecipeGrid.Name = "RecipeGrid";
            this.RecipeGrid.Size = new System.Drawing.Size(820, 231);
            this.RecipeGrid.TabIndex = 3;
            // 
            // GetHops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 305);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.RecipeGrid);
            this.Name = "GetHops";
            this.Text = "GetHops";
            this.Load += new System.EventHandler(this.loadRecipesOnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.DataGridView RecipeGrid;
    }
}