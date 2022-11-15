namespace WinFormsApp4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonrown = new System.Windows.Forms.Button();
            this.wyswietlacz = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mnozenie = new System.Windows.Forms.Button();
            this.dzielenie = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 56);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(132, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 56);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 56);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(72, 74);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 56);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(132, 74);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 56);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(72, 257);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(54, 56);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonrown
            // 
            this.buttonrown.Location = new System.Drawing.Point(134, 257);
            this.buttonrown.Name = "buttonrown";
            this.buttonrown.Size = new System.Drawing.Size(54, 56);
            this.buttonrown.TabIndex = 10;
            this.buttonrown.Text = "=";
            this.buttonrown.UseVisualStyleBackColor = true;
            this.buttonrown.Click += new System.EventHandler(this.buttonrown_Click);
            // 
            // wyswietlacz
            // 
            this.wyswietlacz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wyswietlacz.Location = new System.Drawing.Point(12, 35);
            this.wyswietlacz.Name = "wyswietlacz";
            this.wyswietlacz.Size = new System.Drawing.Size(234, 33);
            this.wyswietlacz.TabIndex = 11;
            this.wyswietlacz.Text = "0";
            this.wyswietlacz.TextChanged += new System.EventHandler(this.wyswietlacz_TextChanged);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(194, 257);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(54, 56);
            this.plus.TabIndex = 12;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(194, 198);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(54, 56);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // mnozenie
            // 
            this.mnozenie.Location = new System.Drawing.Point(192, 136);
            this.mnozenie.Name = "mnozenie";
            this.mnozenie.Size = new System.Drawing.Size(54, 56);
            this.mnozenie.TabIndex = 14;
            this.mnozenie.Text = "x";
            this.mnozenie.UseVisualStyleBackColor = true;
            this.mnozenie.Click += new System.EventHandler(this.mnozenie_Click);
            // 
            // dzielenie
            // 
            this.dzielenie.Location = new System.Drawing.Point(192, 74);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(54, 56);
            this.dzielenie.TabIndex = 15;
            this.dzielenie.Text = "/";
            this.dzielenie.UseVisualStyleBackColor = true;
            this.dzielenie.Click += new System.EventHandler(this.dzielenie_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(12, 257);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(54, 56);
            this.C.TabIndex = 16;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 325);
            this.Controls.Add(this.C);
            this.Controls.Add(this.dzielenie);
            this.Controls.Add(this.mnozenie);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.wyswietlacz);
            this.Controls.Add(this.buttonrown);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonrown;
        private TextBox wyswietlacz;
        private Button plus;
        private Button minus;
        private Button mnozenie;
        private Button dzielenie;
        private Button C;
    }
}