
namespace WinFormsApp1
{
    partial class mainpage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.depositphotos_153165422_stock_photo_person_cooking_with_cookbook;
            this.pictureBox1.Location = new System.Drawing.Point(200, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 357);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.userBtn);
            this.panel1.Controls.Add(this.AdminBtn);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 357);
            this.panel1.TabIndex = 1;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.LightGreen;
            this.aboutBtn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutBtn.Location = new System.Drawing.Point(12, 224);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(182, 58);
            this.aboutBtn.TabIndex = 6;
            this.aboutBtn.Text = "ABOUT US :)";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.Color.LightGreen;
            this.userBtn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userBtn.Location = new System.Drawing.Point(12, 131);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(182, 58);
            this.userBtn.TabIndex = 5;
            this.userBtn.Text = "USER";
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.BackColor = System.Drawing.Color.LightGreen;
            this.AdminBtn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdminBtn.Location = new System.Drawing.Point(12, 35);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(182, 58);
            this.AdminBtn.TabIndex = 3;
            this.AdminBtn.Text = "ADMIN";
            this.AdminBtn.UseVisualStyleBackColor = false;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(145, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recipe Management System";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainpage";
            this.Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

