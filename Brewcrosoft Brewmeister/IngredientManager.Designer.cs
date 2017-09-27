namespace Brewcrosoft_Brewmeister
{
    partial class IngredientManager
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
            this.addHopButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.postnamebox = new System.Windows.Forms.TextBox();
            this.postaaubox = new System.Windows.Forms.TextBox();
            this.hopGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteHopButton = new System.Windows.Forms.Button();
            this.maltGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.maltNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maltPPGBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maltColorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maltTypeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maltMaltsterBox = new System.Windows.Forms.TextBox();
            this.DeleteMaltButton = new System.Windows.Forms.Button();
            this.addMaltButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yeastGrid = new System.Windows.Forms.DataGridView();
            this.deleteYeastButton = new System.Windows.Forms.Button();
            this.addYeastButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.yeastNameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.yeastLabBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.yeastAttenuationBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hopGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maltGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yeastGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addHopButton
            // 
            this.addHopButton.Location = new System.Drawing.Point(346, 372);
            this.addHopButton.Name = "addHopButton";
            this.addHopButton.Size = new System.Drawing.Size(244, 31);
            this.addHopButton.TabIndex = 15;
            this.addHopButton.Text = "Add Hop";
            this.addHopButton.UseVisualStyleBackColor = true;
            this.addHopButton.Click += new System.EventHandler(this.addHopButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "AAU";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // postnamebox
            // 
            this.postnamebox.Location = new System.Drawing.Point(347, 55);
            this.postnamebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postnamebox.Name = "postnamebox";
            this.postnamebox.Size = new System.Drawing.Size(244, 26);
            this.postnamebox.TabIndex = 13;
            this.postnamebox.TextChanged += new System.EventHandler(this.postnamebox_TextChanged);
            // 
            // postaaubox
            // 
            this.postaaubox.Location = new System.Drawing.Point(347, 115);
            this.postaaubox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postaaubox.Name = "postaaubox";
            this.postaaubox.Size = new System.Drawing.Size(244, 26);
            this.postaaubox.TabIndex = 14;
            this.postaaubox.TextChanged += new System.EventHandler(this.postaaubox_TextChanged);
            // 
            // hopGrid
            // 
            this.hopGrid.AllowUserToAddRows = false;
            this.hopGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hopGrid.Location = new System.Drawing.Point(15, 26);
            this.hopGrid.Name = "hopGrid";
            this.hopGrid.ReadOnly = true;
            this.hopGrid.RowTemplate.Height = 28;
            this.hopGrid.Size = new System.Drawing.Size(325, 426);
            this.hopGrid.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteHopButton);
            this.groupBox1.Controls.Add(this.hopGrid);
            this.groupBox1.Controls.Add(this.addHopButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.postaaubox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.postnamebox);
            this.groupBox1.Location = new System.Drawing.Point(764, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 465);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hops";
            // 
            // deleteHopButton
            // 
            this.deleteHopButton.Location = new System.Drawing.Point(347, 423);
            this.deleteHopButton.Name = "deleteHopButton";
            this.deleteHopButton.Size = new System.Drawing.Size(244, 29);
            this.deleteHopButton.TabIndex = 16;
            this.deleteHopButton.Text = "Delete Hop";
            this.deleteHopButton.UseVisualStyleBackColor = true;
            this.deleteHopButton.Click += new System.EventHandler(this.deleteHopButton_Click);
            // 
            // maltGrid
            // 
            this.maltGrid.AllowUserToAddRows = false;
            this.maltGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maltGrid.Location = new System.Drawing.Point(6, 25);
            this.maltGrid.Name = "maltGrid";
            this.maltGrid.ReadOnly = true;
            this.maltGrid.RowTemplate.Height = 28;
            this.maltGrid.Size = new System.Drawing.Size(884, 426);
            this.maltGrid.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(908, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // maltNameBox
            // 
            this.maltNameBox.Location = new System.Drawing.Point(908, 57);
            this.maltNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maltNameBox.Name = "maltNameBox";
            this.maltNameBox.Size = new System.Drawing.Size(244, 26);
            this.maltNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(908, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "PPG";
            // 
            // maltPPGBox
            // 
            this.maltPPGBox.Location = new System.Drawing.Point(908, 124);
            this.maltPPGBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maltPPGBox.Name = "maltPPGBox";
            this.maltPPGBox.Size = new System.Drawing.Size(244, 26);
            this.maltPPGBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(908, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Color";
            // 
            // maltColorBox
            // 
            this.maltColorBox.Location = new System.Drawing.Point(908, 186);
            this.maltColorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maltColorBox.Name = "maltColorBox";
            this.maltColorBox.Size = new System.Drawing.Size(244, 26);
            this.maltColorBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(908, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Type";
            // 
            // maltTypeBox
            // 
            this.maltTypeBox.FormattingEnabled = true;
            this.maltTypeBox.Location = new System.Drawing.Point(908, 252);
            this.maltTypeBox.Name = "maltTypeBox";
            this.maltTypeBox.Size = new System.Drawing.Size(244, 28);
            this.maltTypeBox.TabIndex = 4;
            this.maltTypeBox.SelectedIndexChanged += new System.EventHandler(this.maltTypeBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(908, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Maltster";
            // 
            // maltMaltsterBox
            // 
            this.maltMaltsterBox.Location = new System.Drawing.Point(908, 317);
            this.maltMaltsterBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maltMaltsterBox.Name = "maltMaltsterBox";
            this.maltMaltsterBox.Size = new System.Drawing.Size(244, 26);
            this.maltMaltsterBox.TabIndex = 5;
            // 
            // DeleteMaltButton
            // 
            this.DeleteMaltButton.Location = new System.Drawing.Point(908, 422);
            this.DeleteMaltButton.Name = "DeleteMaltButton";
            this.DeleteMaltButton.Size = new System.Drawing.Size(244, 29);
            this.DeleteMaltButton.TabIndex = 7;
            this.DeleteMaltButton.Text = "Delete Malt";
            this.DeleteMaltButton.UseVisualStyleBackColor = true;
            this.DeleteMaltButton.Click += new System.EventHandler(this.DeleteMaltButton_Click);
            // 
            // addMaltButton
            // 
            this.addMaltButton.Location = new System.Drawing.Point(908, 372);
            this.addMaltButton.Name = "addMaltButton";
            this.addMaltButton.Size = new System.Drawing.Size(244, 31);
            this.addMaltButton.TabIndex = 6;
            this.addMaltButton.Text = "Add Malt";
            this.addMaltButton.UseVisualStyleBackColor = true;
            this.addMaltButton.Click += new System.EventHandler(this.addMaltButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maltGrid);
            this.groupBox2.Controls.Add(this.DeleteMaltButton);
            this.groupBox2.Controls.Add(this.maltNameBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.addMaltButton);
            this.groupBox2.Controls.Add(this.maltPPGBox);
            this.groupBox2.Controls.Add(this.maltMaltsterBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.maltTypeBox);
            this.groupBox2.Controls.Add(this.maltColorBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 465);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fermentables";
            // 
            // yeastGrid
            // 
            this.yeastGrid.AllowUserToAddRows = false;
            this.yeastGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yeastGrid.Location = new System.Drawing.Point(15, 25);
            this.yeastGrid.Name = "yeastGrid";
            this.yeastGrid.ReadOnly = true;
            this.yeastGrid.RowTemplate.Height = 28;
            this.yeastGrid.Size = new System.Drawing.Size(465, 426);
            this.yeastGrid.TabIndex = 18;
            // 
            // deleteYeastButton
            // 
            this.deleteYeastButton.Location = new System.Drawing.Point(486, 422);
            this.deleteYeastButton.Name = "deleteYeastButton";
            this.deleteYeastButton.Size = new System.Drawing.Size(244, 29);
            this.deleteYeastButton.TabIndex = 12;
            this.deleteYeastButton.Text = "Delete Yeast";
            this.deleteYeastButton.UseVisualStyleBackColor = true;
            this.deleteYeastButton.Click += new System.EventHandler(this.deleteYeastButton_Click);
            // 
            // addYeastButton
            // 
            this.addYeastButton.Location = new System.Drawing.Point(486, 385);
            this.addYeastButton.Name = "addYeastButton";
            this.addYeastButton.Size = new System.Drawing.Size(244, 31);
            this.addYeastButton.TabIndex = 11;
            this.addYeastButton.Text = "Add Yeast";
            this.addYeastButton.UseVisualStyleBackColor = true;
            this.addYeastButton.Click += new System.EventHandler(this.addYeastButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Name";
            // 
            // yeastNameBox
            // 
            this.yeastNameBox.Location = new System.Drawing.Point(490, 112);
            this.yeastNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yeastNameBox.Name = "yeastNameBox";
            this.yeastNameBox.Size = new System.Drawing.Size(244, 26);
            this.yeastNameBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Lab";
            // 
            // yeastLabBox
            // 
            this.yeastLabBox.Location = new System.Drawing.Point(490, 52);
            this.yeastLabBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yeastLabBox.Name = "yeastLabBox";
            this.yeastLabBox.Size = new System.Drawing.Size(244, 26);
            this.yeastLabBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 147);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Attenuation";
            // 
            // yeastAttenuationBox
            // 
            this.yeastAttenuationBox.Location = new System.Drawing.Point(490, 170);
            this.yeastAttenuationBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yeastAttenuationBox.Name = "yeastAttenuationBox";
            this.yeastAttenuationBox.Size = new System.Drawing.Size(244, 26);
            this.yeastAttenuationBox.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.yeastGrid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.yeastAttenuationBox);
            this.groupBox3.Controls.Add(this.yeastLabBox);
            this.groupBox3.Controls.Add(this.deleteYeastButton);
            this.groupBox3.Controls.Add(this.yeastNameBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.addYeastButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 483);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(746, 463);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeasts";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1179, 23);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(187, 37);
            this.refreshButton.TabIndex = 17;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // IngredientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 957);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IngredientManager";
            this.Text = "IngredientManager";
            ((System.ComponentModel.ISupportInitialize)(this.hopGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maltGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yeastGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addHopButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox postnamebox;
        private System.Windows.Forms.TextBox postaaubox;
        private System.Windows.Forms.DataGridView hopGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteHopButton;
        private System.Windows.Forms.DataGridView maltGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maltNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maltPPGBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maltColorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox maltTypeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maltMaltsterBox;
        private System.Windows.Forms.Button DeleteMaltButton;
        private System.Windows.Forms.Button addMaltButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView yeastGrid;
        private System.Windows.Forms.Button deleteYeastButton;
        private System.Windows.Forms.Button addYeastButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox yeastNameBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox yeastLabBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox yeastAttenuationBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button refreshButton;
    }
}