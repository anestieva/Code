namespace _10CurrencyConverter
{
    partial class Form1
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
            this.numericCurrencyValue = new System.Windows.Forms.NumericUpDown();
            this.labelBGN = new System.Windows.Forms.Label();
            this.labelArrow = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrencyValue)).BeginInit();
            this.SuspendLayout();
            // 
            // numericCurrencyValue
            // 
            this.numericCurrencyValue.DecimalPlaces = 2;
            this.numericCurrencyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCurrencyValue.Location = new System.Drawing.Point(46, 75);
            this.numericCurrencyValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCurrencyValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrencyValue.Name = "numericCurrencyValue";
            this.numericCurrencyValue.Size = new System.Drawing.Size(120, 38);
            this.numericCurrencyValue.TabIndex = 0;
            this.numericCurrencyValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCurrencyValue.ValueChanged += new System.EventHandler(this.numericCurrencyValue_ValueChanged);
            // 
            // labelBGN
            // 
            this.labelBGN.AutoSize = true;
            this.labelBGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBGN.Location = new System.Drawing.Point(207, 75);
            this.labelBGN.Name = "labelBGN";
            this.labelBGN.Size = new System.Drawing.Size(73, 31);
            this.labelBGN.TabIndex = 1;
            this.labelBGN.Text = "BGN";
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrow.Location = new System.Drawing.Point(274, 64);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(55, 42);
            this.labelArrow.TabIndex = 2;
            this.labelArrow.Text = "→";
            this.labelArrow.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResult.Location = new System.Drawing.Point(46, 144);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(410, 40);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "result";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(335, 85);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(121, 33);
            this.comboBoxCurrency.TabIndex = 4;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 326);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelArrow);
            this.Controls.Add(this.labelBGN);
            this.Controls.Add(this.numericCurrencyValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCurrencyValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericCurrencyValue;
        private System.Windows.Forms.Label labelBGN;
        private System.Windows.Forms.Label labelArrow;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
    }
}

