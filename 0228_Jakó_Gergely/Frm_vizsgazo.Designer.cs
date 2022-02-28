
namespace _0228_Jakó_Gergely
{
    partial class Frm_vizsgazo
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
            this.b_delete = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_telef = new System.Windows.Forms.TextBox();
            this.tb_szul = new System.Windows.Forms.TextBox();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vizsgázó";
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(208, 41);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(62, 47);
            this.b_delete.TabIndex = 1;
            this.b_delete.Text = "Törlés";
            this.b_delete.UseVisualStyleBackColor = true;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(16, 55);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(159, 20);
            this.tb_id.TabIndex = 4;
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(16, 100);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(159, 20);
            this.tb_nev.TabIndex = 5;
            // 
            // tb_telef
            // 
            this.tb_telef.Location = new System.Drawing.Point(16, 151);
            this.tb_telef.Name = "tb_telef";
            this.tb_telef.Size = new System.Drawing.Size(159, 20);
            this.tb_telef.TabIndex = 6;
            // 
            // tb_szul
            // 
            this.tb_szul.Location = new System.Drawing.Point(16, 199);
            this.tb_szul.Name = "tb_szul";
            this.tb_szul.Size = new System.Drawing.Size(159, 20);
            this.tb_szul.TabIndex = 7;
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(208, 100);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(62, 47);
            this.b_edit.TabIndex = 8;
            this.b_edit.Text = "Módosít";
            this.b_edit.UseVisualStyleBackColor = true;
            // 
            // b_new
            // 
            this.b_new.Location = new System.Drawing.Point(208, 163);
            this.b_new.Name = "b_new";
            this.b_new.Size = new System.Drawing.Size(62, 47);
            this.b_new.TabIndex = 9;
            this.b_new.Text = "Új";
            this.b_new.UseVisualStyleBackColor = true;
            this.b_new.Click += new System.EventHandler(this.b_new_Click);
            // 
            // Frm_vizsgazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 252);
            this.Controls.Add(this.b_new);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.tb_szul);
            this.Controls.Add(this.tb_telef);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.label1);
            this.Name = "Frm_vizsgazo";
            this.Text = "vizsgamodosit";
            this.Load += new System.EventHandler(this.Frm_vizsgazo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_telef;
        private System.Windows.Forms.TextBox tb_szul;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_new;
    }
}