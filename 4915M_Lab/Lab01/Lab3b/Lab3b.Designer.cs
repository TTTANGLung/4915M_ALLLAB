
namespace Lab01.Lab3b
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblMillion2 = new System.Windows.Forms.Label();
            this.lblMillion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(43, 36);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(157, 33);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(118, 20);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(157, 82);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(118, 20);
            this.txtRate.TabIndex = 3;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(43, 85);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(109, 13);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Interest Tate (Annual)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 119);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(211, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Start Calculation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(46, 176);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(101, 13);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Value after 10 years";
            // 
            // lblValue2
            // 
            this.lblValue2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue2.Location = new System.Drawing.Point(157, 171);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(118, 23);
            this.lblValue2.TabIndex = 6;
            // 
            // lblMillion2
            // 
            this.lblMillion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMillion2.Location = new System.Drawing.Point(157, 211);
            this.lblMillion2.Name = "lblMillion2";
            this.lblMillion2.Size = new System.Drawing.Size(118, 23);
            this.lblMillion2.TabIndex = 8;
            // 
            // lblMillion
            // 
            this.lblMillion.AutoSize = true;
            this.lblMillion.Location = new System.Drawing.Point(46, 216);
            this.lblMillion.Name = "lblMillion";
            this.lblMillion.Size = new System.Drawing.Size(100, 13);
            this.lblMillion.TabIndex = 7;
            this.lblMillion.Text = "Years to reach $1M";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 269);
            this.Controls.Add(this.lblMillion2);
            this.Controls.Add(this.lblMillion);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "Compound Interest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblMillion2;
        private System.Windows.Forms.Label lblMillion;
    }
}