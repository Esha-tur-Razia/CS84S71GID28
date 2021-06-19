
namespace WinFormsApp1
{
    partial class Editrecipe
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
            this.BTN = new System.Windows.Forms.Button();
            this.bTN1 = new System.Windows.Forms.Button();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enterbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.BTN);
            this.panel1.Controls.Add(this.bTN1);
            this.panel1.Controls.Add(this.richText);
            this.panel1.Controls.Add(this.textname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Calibri", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(297, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 349);
            this.panel1.TabIndex = 0;
            // 
            // BTN
            // 
            this.BTN.BackColor = System.Drawing.Color.Red;
            this.BTN.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN.Location = new System.Drawing.Point(43, 289);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(247, 49);
            this.BTN.TabIndex = 7;
            this.BTN.Text = "CANCEL";
            this.BTN.UseVisualStyleBackColor = false;
            this.BTN.Click += new System.EventHandler(this.BTN_Click);
            // 
            // bTN1
            // 
            this.bTN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bTN1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bTN1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bTN1.Location = new System.Drawing.Point(308, 289);
            this.bTN1.Name = "bTN1";
            this.bTN1.Size = new System.Drawing.Size(253, 49);
            this.bTN1.TabIndex = 6;
            this.bTN1.Text = "UPDATE";
            this.bTN1.UseVisualStyleBackColor = false;
            this.bTN1.Click += new System.EventHandler(this.bTN1_Click);
            // 
            // richText
            // 
            this.richText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richText.Location = new System.Drawing.Point(246, 187);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(274, 79);
            this.richText.TabIndex = 5;
            this.richText.Text = "";
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textname.Location = new System.Drawing.Point(246, 118);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(274, 35);
            this.textname.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(105, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(43, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "DESCRIPTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "UPDATE DATA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.text);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 253);
            this.panel2.TabIndex = 1;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(35, 135);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(219, 35);
            this.text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the name:";
            // 
            // enterbtn
            // 
            this.enterbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.enterbtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enterbtn.Location = new System.Drawing.Point(12, 274);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(279, 49);
            this.enterbtn.TabIndex = 1;
            this.enterbtn.Text = "ENTER";
            this.enterbtn.UseVisualStyleBackColor = false;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // Editrecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 352);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Editrecipe";
            this.Text = "Editrecipe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN;
        private System.Windows.Forms.Button bTN1;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enterbtn;
    }
}