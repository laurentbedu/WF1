namespace WF1
{
    partial class FormExo3
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
            this.buttonNoteQtyMoins = new System.Windows.Forms.Button();
            this.textBoxNoteQty = new System.Windows.Forms.TextBox();
            this.buttonNoteQtyPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNotes = new System.Windows.Forms.Panel();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMoy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalcul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNoteQtyMoins
            // 
            this.buttonNoteQtyMoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNoteQtyMoins.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNoteQtyMoins.Location = new System.Drawing.Point(143, 11);
            this.buttonNoteQtyMoins.Name = "buttonNoteQtyMoins";
            this.buttonNoteQtyMoins.Size = new System.Drawing.Size(32, 32);
            this.buttonNoteQtyMoins.TabIndex = 0;
            this.buttonNoteQtyMoins.Text = "-";
            this.buttonNoteQtyMoins.UseVisualStyleBackColor = true;
            this.buttonNoteQtyMoins.Click += new System.EventHandler(this.buttonNoteQtyMoins_Click);
            // 
            // textBoxNoteQty
            // 
            this.textBoxNoteQty.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNoteQty.Location = new System.Drawing.Point(181, 12);
            this.textBoxNoteQty.Name = "textBoxNoteQty";
            this.textBoxNoteQty.ReadOnly = true;
            this.textBoxNoteQty.Size = new System.Drawing.Size(32, 31);
            this.textBoxNoteQty.TabIndex = 1;
            this.textBoxNoteQty.Text = "1";
            this.textBoxNoteQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonNoteQtyPlus
            // 
            this.buttonNoteQtyPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNoteQtyPlus.Location = new System.Drawing.Point(219, 11);
            this.buttonNoteQtyPlus.Name = "buttonNoteQtyPlus";
            this.buttonNoteQtyPlus.Size = new System.Drawing.Size(32, 32);
            this.buttonNoteQtyPlus.TabIndex = 2;
            this.buttonNoteQtyPlus.Text = "+";
            this.buttonNoteQtyPlus.UseVisualStyleBackColor = true;
            this.buttonNoteQtyPlus.Click += new System.EventHandler(this.buttonNoteQtyPlus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de notes";
            // 
            // panelNotes
            // 
            this.panelNotes.Location = new System.Drawing.Point(12, 49);
            this.panelNotes.Name = "panelNotes";
            this.panelNotes.Size = new System.Drawing.Size(393, 332);
            this.panelNotes.TabIndex = 4;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(496, 82);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(44, 27);
            this.textBoxMin.TabIndex = 5;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(496, 16);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(44, 27);
            this.textBoxMax.TabIndex = 6;
            // 
            // textBoxMoy
            // 
            this.textBoxMoy.Location = new System.Drawing.Point(496, 49);
            this.textBoxMoy.Name = "textBoxMoy";
            this.textBoxMoy.ReadOnly = true;
            this.textBoxMoy.Size = new System.Drawing.Size(44, 27);
            this.textBoxMoy.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Note min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Note max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Moyenne";
            // 
            // buttonCalcul
            // 
            this.buttonCalcul.Location = new System.Drawing.Point(311, 12);
            this.buttonCalcul.Name = "buttonCalcul";
            this.buttonCalcul.Size = new System.Drawing.Size(94, 29);
            this.buttonCalcul.TabIndex = 11;
            this.buttonCalcul.Text = "Calculer";
            this.buttonCalcul.UseVisualStyleBackColor = true;
            this.buttonCalcul.Click += new System.EventHandler(this.buttonCalcul_Click);
            // 
            // FormExo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 388);
            this.Controls.Add(this.buttonCalcul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMoy);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.panelNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNoteQtyPlus);
            this.Controls.Add(this.textBoxNoteQty);
            this.Controls.Add(this.buttonNoteQtyMoins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExo3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExo3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonNoteQtyMoins;
        private TextBox textBoxNoteQty;
        private Button buttonNoteQtyPlus;
        private Label label1;
        private Panel panelNotes;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private TextBox textBoxMoy;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCalcul;
    }
}