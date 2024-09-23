namespace Corte1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(84, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(205, 22);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(84, 59);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(205, 22);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbShow
            // 
            this.lbShow.FormattingEnabled = true;
            this.lbShow.ItemHeight = 16;
            this.lbShow.Location = new System.Drawing.Point(38, 200);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(410, 212);
            this.lbShow.TabIndex = 7;
            this.lbShow.SelectedIndexChanged += new System.EventHandler(this.lbShow_SelectedIndexChanged);
            // 
            // cbCities
            // 
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Location = new System.Drawing.Point(84, 151);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(121, 24);
            this.cbCities.TabIndex = 8;
            this.cbCities.SelectedIndexChanged += new System.EventHandler(this.cbCities_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ciudad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCities);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.ComboBox cbCities;
        private System.Windows.Forms.Label label3;
    }
}

