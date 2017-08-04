namespace Brewcrosoft_Brewmeister
{
    partial class New_Beer
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
            this.BeerNameBox = new System.Windows.Forms.TextBox();
            this.BeerStyleBox = new System.Windows.Forms.TextBox();
            this.BeerDescriptionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveBeerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BeerNameBox
            // 
            this.BeerNameBox.Location = new System.Drawing.Point(9, 45);
            this.BeerNameBox.Name = "BeerNameBox";
            this.BeerNameBox.Size = new System.Drawing.Size(267, 20);
            this.BeerNameBox.TabIndex = 0;
            // 
            // BeerStyleBox
            // 
            this.BeerStyleBox.Location = new System.Drawing.Point(9, 84);
            this.BeerStyleBox.Name = "BeerStyleBox";
            this.BeerStyleBox.Size = new System.Drawing.Size(267, 20);
            this.BeerStyleBox.TabIndex = 1;
            // 
            // BeerDescriptionBox
            // 
            this.BeerDescriptionBox.Location = new System.Drawing.Point(9, 124);
            this.BeerDescriptionBox.Multiline = true;
            this.BeerDescriptionBox.Name = "BeerDescriptionBox";
            this.BeerDescriptionBox.Size = new System.Drawing.Size(267, 96);
            this.BeerDescriptionBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Beer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beer Style";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beer Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Create New Beer";
            // 
            // SaveBeerButton
            // 
            this.SaveBeerButton.Location = new System.Drawing.Point(8, 226);
            this.SaveBeerButton.Name = "SaveBeerButton";
            this.SaveBeerButton.Size = new System.Drawing.Size(268, 22);
            this.SaveBeerButton.TabIndex = 7;
            this.SaveBeerButton.Text = "Save";
            this.SaveBeerButton.UseVisualStyleBackColor = true;
            this.SaveBeerButton.Click += new System.EventHandler(this.SaveBeerButton_Click);
            // 
            // New_Beer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.SaveBeerButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BeerDescriptionBox);
            this.Controls.Add(this.BeerStyleBox);
            this.Controls.Add(this.BeerNameBox);
            this.Name = "New_Beer";
            this.Text = "New Beer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BeerNameBox;
        private System.Windows.Forms.TextBox BeerStyleBox;
        private System.Windows.Forms.TextBox BeerDescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveBeerButton;
    }
}