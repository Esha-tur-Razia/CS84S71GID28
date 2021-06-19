
namespace WinFormsApp1
{
    partial class Deleterecipe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancle = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.cancle);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 323);
            this.panel1.TabIndex = 0;
            // 
            // cancle
            // 
            this.cancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cancle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancle.Location = new System.Drawing.Point(197, 271);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(190, 43);
            this.cancle.TabIndex = 3;
            this.cancle.Text = "CANCEL";
            this.cancle.UseVisualStyleBackColor = false;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Red;
            this.Deletebtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Deletebtn.Location = new System.Drawing.Point(399, 271);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(190, 43);
            this.Deletebtn.TabIndex = 1;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(253, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "DELETE RECIPE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.text);
            this.panel2.Controls.Add(this.name);
            this.panel2.Location = new System.Drawing.Point(197, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 183);
            this.panel2.TabIndex = 0;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(56, 101);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(261, 23);
            this.text.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(56, 47);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(76, 30);
            this.name.TabIndex = 0;
            this.name.Text = "NAME";
            // 
            // Deleterecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.panel1);
            this.Name = "Deleterecipe";
            this.Text = "Deleterecipe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button cancle;
    }
}