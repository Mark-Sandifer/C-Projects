namespace PrimogemCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blessingCheck = new System.Windows.Forms.CheckBox();
            this.commissionCheck = new System.Windows.Forms.CheckBox();
            this.abyssCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Current Primogems";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Current Intertwined Fates";
            // 
            // blessingCheck
            // 
            this.blessingCheck.AutoSize = true;
            this.blessingCheck.Location = new System.Drawing.Point(12, 92);
            this.blessingCheck.Name = "blessingCheck";
            this.blessingCheck.Size = new System.Drawing.Size(121, 19);
            this.blessingCheck.TabIndex = 13;
            this.blessingCheck.Text = "Is Blessing Active?";
            this.blessingCheck.UseVisualStyleBackColor = true;
            this.blessingCheck.CheckedChanged += new System.EventHandler(this.blessingCheck_CheckedChanged);
            // 
            // commissionCheck
            // 
            this.commissionCheck.AutoSize = true;
            this.commissionCheck.Location = new System.Drawing.Point(12, 117);
            this.commissionCheck.Name = "commissionCheck";
            this.commissionCheck.Size = new System.Drawing.Size(198, 19);
            this.commissionCheck.TabIndex = 14;
            this.commissionCheck.Text = "Do you clear commissions daily?";
            this.commissionCheck.UseVisualStyleBackColor = true;
            this.commissionCheck.CheckedChanged += new System.EventHandler(this.commissionCheck_CheckedChanged);
            // 
            // abyssCheck
            // 
            this.abyssCheck.AutoSize = true;
            this.abyssCheck.Location = new System.Drawing.Point(12, 142);
            this.abyssCheck.Name = "abyssCheck";
            this.abyssCheck.Size = new System.Drawing.Size(208, 19);
            this.abyssCheck.TabIndex = 15;
            this.abyssCheck.Text = "Do you clear Spiral Abyss on reset?";
            this.abyssCheck.UseVisualStyleBackColor = true;
            this.abyssCheck.CheckedChanged += new System.EventHandler(this.abyssCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 167);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 19);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "90 Pulls";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 192);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 19);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "180 Pulls";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(93, 250);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 15);
            this.labelTotal.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 281);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.abyssCheck);
            this.Controls.Add(this.commissionCheck);
            this.Controls.Add(this.blessingCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Primogem Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private CheckBox blessingCheck;
        private CheckBox commissionCheck;
        private CheckBox abyssCheck;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label labelTotal;
    }
}