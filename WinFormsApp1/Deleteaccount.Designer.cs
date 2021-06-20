
namespace WinFormsApp1
{
    partial class Deleteaccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Idtext = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.DELBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.DELBTN);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.Idtext);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 457);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELETE ACCOUNTS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(393, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENTER YOUR ID:";
            // 
            // Idtext
            // 
            this.Idtext.Location = new System.Drawing.Point(31, 154);
            this.Idtext.Multiline = true;
            this.Idtext.Name = "Idtext";
            this.Idtext.Size = new System.Drawing.Size(257, 40);
            this.Idtext.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cancel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel.Location = new System.Drawing.Point(31, 247);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(163, 47);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // DELBTN
            // 
            this.DELBTN.BackColor = System.Drawing.Color.Red;
            this.DELBTN.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DELBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DELBTN.Location = new System.Drawing.Point(206, 247);
            this.DELBTN.Name = "DELBTN";
            this.DELBTN.Size = new System.Drawing.Size(163, 47);
            this.DELBTN.TabIndex = 5;
            this.DELBTN.Text = "DELETE";
            this.DELBTN.UseVisualStyleBackColor = false;
            this.DELBTN.Click += new System.EventHandler(this.DELBTN_Click);
            // 
            // Deleteaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Deleteaccount";
            this.Text = "Deleteaccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DELBTN;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox Idtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}