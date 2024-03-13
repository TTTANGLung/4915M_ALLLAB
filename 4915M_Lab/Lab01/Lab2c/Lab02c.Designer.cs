
namespace Lab01.Lab2c
{
    partial class frmStudents
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
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lasStudents = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(240, 153);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(119, 13);
            this.lblDelete.TabIndex = 0;
            this.lblDelete.Text = "[Double-click to delete.]";
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(28, 231);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(531, 60);
            this.lblMessage.TabIndex = 1;
            // 
            // lasStudents
            // 
            this.lasStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasStudents.FormattingEnabled = true;
            this.lasStudents.ItemHeight = 16;
            this.lasStudents.Location = new System.Drawing.Point(28, 22);
            this.lasStudents.Name = "lasStudents";
            this.lasStudents.Size = new System.Drawing.Size(192, 180);
            this.lasStudents.Sorted = true;
            this.lasStudents.TabIndex = 2;
            this.lasStudents.SelectedIndexChanged += new System.EventHandler(this.lasStudents_SelectedIndexChanged);
            this.lasStudents.DoubleClick += new System.EventHandler(this.lasStudents_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(243, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 308);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lasStudents);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblDelete);
            this.Name = "frmStudents";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ListBox lasStudents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
    }
}