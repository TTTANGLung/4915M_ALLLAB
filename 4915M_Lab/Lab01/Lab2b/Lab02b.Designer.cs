
namespace Lab01.Lab2b
{
    partial class Lab02b
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxWeather = new System.Windows.Forms.GroupBox();
            this.rbtCloudy = new System.Windows.Forms.RadioButton();
            this.rbtRainy = new System.Windows.Forms.RadioButton();
            this.rbtSonwy = new System.Windows.Forms.RadioButton();
            this.rbtSunny = new System.Windows.Forms.RadioButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.picSunny = new System.Windows.Forms.PictureBox();
            this.picSnowy = new System.Windows.Forms.PictureBox();
            this.picRainy = new System.Windows.Forms.PictureBox();
            this.picCloudy = new System.Windows.Forms.PictureBox();
            this.groupBoxWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your naem here: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBoxWeather
            // 
            this.groupBoxWeather.Controls.Add(this.rbtSunny);
            this.groupBoxWeather.Controls.Add(this.rbtSonwy);
            this.groupBoxWeather.Controls.Add(this.rbtRainy);
            this.groupBoxWeather.Controls.Add(this.rbtCloudy);
            this.groupBoxWeather.Location = new System.Drawing.Point(47, 116);
            this.groupBoxWeather.Name = "groupBoxWeather";
            this.groupBoxWeather.Size = new System.Drawing.Size(198, 149);
            this.groupBoxWeather.TabIndex = 2;
            this.groupBoxWeather.TabStop = false;
            this.groupBoxWeather.Text = "Choose";
            // 
            // rbtCloudy
            // 
            this.rbtCloudy.AutoSize = true;
            this.rbtCloudy.Location = new System.Drawing.Point(23, 35);
            this.rbtCloudy.Name = "rbtCloudy";
            this.rbtCloudy.Size = new System.Drawing.Size(57, 17);
            this.rbtCloudy.TabIndex = 0;
            this.rbtCloudy.TabStop = true;
            this.rbtCloudy.Text = "Cloudy";
            this.rbtCloudy.UseVisualStyleBackColor = true;
            this.rbtCloudy.CheckedChanged += new System.EventHandler(this.rbtCloudy_CheckedChanged);
            // 
            // rbtRainy
            // 
            this.rbtRainy.AutoSize = true;
            this.rbtRainy.Location = new System.Drawing.Point(23, 58);
            this.rbtRainy.Name = "rbtRainy";
            this.rbtRainy.Size = new System.Drawing.Size(52, 17);
            this.rbtRainy.TabIndex = 1;
            this.rbtRainy.TabStop = true;
            this.rbtRainy.Text = "Rainy";
            this.rbtRainy.UseVisualStyleBackColor = true;
            this.rbtRainy.CheckedChanged += new System.EventHandler(this.rbtRainy_CheckedChanged);
            // 
            // rbtSonwy
            // 
            this.rbtSonwy.AutoSize = true;
            this.rbtSonwy.Location = new System.Drawing.Point(23, 81);
            this.rbtSonwy.Name = "rbtSonwy";
            this.rbtSonwy.Size = new System.Drawing.Size(57, 17);
            this.rbtSonwy.TabIndex = 2;
            this.rbtSonwy.TabStop = true;
            this.rbtSonwy.Text = "Snowy";
            this.rbtSonwy.UseVisualStyleBackColor = true;
            this.rbtSonwy.CheckedChanged += new System.EventHandler(this.rbtSonwy_CheckedChanged);
            // 
            // rbtSunny
            // 
            this.rbtSunny.AutoSize = true;
            this.rbtSunny.Location = new System.Drawing.Point(23, 104);
            this.rbtSunny.Name = "rbtSunny";
            this.rbtSunny.Size = new System.Drawing.Size(55, 17);
            this.rbtSunny.TabIndex = 3;
            this.rbtSunny.TabStop = true;
            this.rbtSunny.Text = "Sunny";
            this.rbtSunny.UseVisualStyleBackColor = true;
            this.rbtSunny.CheckedChanged += new System.EventHandler(this.rbtSunny_CheckedChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(47, 285);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(393, 95);
            this.lblMessage.TabIndex = 7;
            // 
            // picSunny
            // 
            this.picSunny.Image = global::Lab01.Properties.Resources.sky;
            this.picSunny.InitialImage = null;
            this.picSunny.Location = new System.Drawing.Point(360, 190);
            this.picSunny.Name = "picSunny";
            this.picSunny.Size = new System.Drawing.Size(80, 75);
            this.picSunny.TabIndex = 6;
            this.picSunny.TabStop = false;
            // 
            // picSnowy
            // 
            this.picSnowy.Image = global::Lab01.Properties.Resources.snow263;
            this.picSnowy.InitialImage = null;
            this.picSnowy.Location = new System.Drawing.Point(281, 190);
            this.picSnowy.Name = "picSnowy";
            this.picSnowy.Size = new System.Drawing.Size(80, 75);
            this.picSnowy.TabIndex = 5;
            this.picSnowy.TabStop = false;
            // 
            // picRainy
            // 
            this.picRainy.Image = global::Lab01.Properties.Resources.raindrops2;
            this.picRainy.InitialImage = null;
            this.picRainy.Location = new System.Drawing.Point(360, 116);
            this.picRainy.Name = "picRainy";
            this.picRainy.Size = new System.Drawing.Size(80, 75);
            this.picRainy.TabIndex = 4;
            this.picRainy.TabStop = false;
            // 
            // picCloudy
            // 
            this.picCloudy.Image = global::Lab01.Properties.Resources.cloud316;
            this.picCloudy.InitialImage = null;
            this.picCloudy.Location = new System.Drawing.Point(281, 116);
            this.picCloudy.Name = "picCloudy";
            this.picCloudy.Size = new System.Drawing.Size(80, 75);
            this.picCloudy.TabIndex = 3;
            this.picCloudy.TabStop = false;
            // 
            // Lab2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 400);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picSunny);
            this.Controls.Add(this.picSnowy);
            this.Controls.Add(this.picRainy);
            this.Controls.Add(this.picCloudy);
            this.Controls.Add(this.groupBoxWeather);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Lab2b";
            this.Text = "Lab2b";
            this.groupBoxWeather.ResumeLayout(false);
            this.groupBoxWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxWeather;
        private System.Windows.Forms.RadioButton rbtSunny;
        private System.Windows.Forms.RadioButton rbtSonwy;
        private System.Windows.Forms.RadioButton rbtRainy;
        private System.Windows.Forms.RadioButton rbtCloudy;
        private System.Windows.Forms.PictureBox picCloudy;
        private System.Windows.Forms.PictureBox picRainy;
        private System.Windows.Forms.PictureBox picSnowy;
        private System.Windows.Forms.PictureBox picSunny;
        private System.Windows.Forms.Label lblMessage;
    }
}