
namespace Lab01.Lab3c
{
    partial class Lab3c
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
            this.lsbShop = new System.Windows.Forms.ListBox();
            this.btnToCrat = new System.Windows.Forms.Button();
            this.btnToShop = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lsbCart = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbShop
            // 
            this.lsbShop.FormattingEnabled = true;
            this.lsbShop.Location = new System.Drawing.Point(82, 72);
            this.lsbShop.Name = "lsbShop";
            this.lsbShop.Size = new System.Drawing.Size(120, 121);
            this.lsbShop.TabIndex = 0;
            // 
            // btnToCrat
            // 
            this.btnToCrat.Location = new System.Drawing.Point(253, 72);
            this.btnToCrat.Name = "btnToCrat";
            this.btnToCrat.Size = new System.Drawing.Size(75, 23);
            this.btnToCrat.TabIndex = 2;
            this.btnToCrat.Text = "--->";
            this.btnToCrat.UseVisualStyleBackColor = true;
            this.btnToCrat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnToShop
            // 
            this.btnToShop.Location = new System.Drawing.Point(253, 140);
            this.btnToShop.Name = "btnToShop";
            this.btnToShop.Size = new System.Drawing.Size(75, 23);
            this.btnToShop.TabIndex = 3;
            this.btnToShop.Text = "<---";
            this.btnToShop.UseVisualStyleBackColor = true;
            this.btnToShop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(308, 247);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(446, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lsbCart
            // 
            this.lsbCart.FormattingEnabled = true;
            this.lsbCart.Location = new System.Drawing.Point(387, 72);
            this.lsbCart.Name = "lsbCart";
            this.lsbCart.Size = new System.Drawing.Size(120, 121);
            this.lsbCart.TabIndex = 6;
            // 
            // Lab3c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 402);
            this.Controls.Add(this.lsbCart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnToShop);
            this.Controls.Add(this.btnToCrat);
            this.Controls.Add(this.lsbShop);
            this.Name = "Lab3c";
            this.Text = "Lab3c";
            this.Load += new System.EventHandler(this.Lab3c_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbShop;
        private System.Windows.Forms.Button btnToCrat;
        private System.Windows.Forms.Button btnToShop;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lsbCart;
    }
}