namespace Brewcrosoft_Brewmeister
{
    partial class Add_Malt
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
            this.ExtractCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BeerNameBox = new System.Windows.Forms.TextBox();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.PPGBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExtractCheck
            // 
            this.ExtractCheck.AutoSize = true;
            this.ExtractCheck.Location = new System.Drawing.Point(19, 129);
            this.ExtractCheck.Name = "ExtractCheck";
            this.ExtractCheck.Size = new System.Drawing.Size(59, 17);
            this.ExtractCheck.TabIndex = 5;
            this.ExtractCheck.Text = "Extract";
            this.ExtractCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // BeerNameBox
            // 
            this.BeerNameBox.Location = new System.Drawing.Point(12, 25);
            this.BeerNameBox.Name = "BeerNameBox";
            this.BeerNameBox.Size = new System.Drawing.Size(181, 20);
            this.BeerNameBox.TabIndex = 1;
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(53, 103);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(140, 20);
            this.ColorBox.TabIndex = 4;
            // 
            // PPGBox
            // 
            this.PPGBox.Location = new System.Drawing.Point(53, 77);
            this.PPGBox.Name = "PPGBox";
            this.PPGBox.Size = new System.Drawing.Size(140, 20);
            this.PPGBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PPG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Malt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weght";
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(53, 51);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(140, 20);
            this.WeightBox.TabIndex = 2;
            // 
            // Add_Malt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 185);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PPGBox);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.BeerNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtractCheck);
            this.Name = "Add_Malt";
            this.Text = "Add Malt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ExtractCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BeerNameBox;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.TextBox PPGBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WeightBox;
    }
}