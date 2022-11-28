
namespace Boodschappen_vergelijken
{
    partial class Form2
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
            this.cbah = new System.Windows.Forms.CheckBox();
            this.cbplus = new System.Windows.Forms.CheckBox();
            this.cbdeka = new System.Windows.Forms.CheckBox();
            this.cbvomar = new System.Windows.Forms.CheckBox();
            this.cbjumbo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxtoevoegen = new System.Windows.Forms.TextBox();
            this.btntoevoegen = new System.Windows.Forms.Button();
            this.listboxproductlijst = new System.Windows.Forms.ListBox();
            this.vergelijkbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listboxwinkel = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listboxproductindividu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbah
            // 
            this.cbah.AutoSize = true;
            this.cbah.Location = new System.Drawing.Point(34, 72);
            this.cbah.Margin = new System.Windows.Forms.Padding(4);
            this.cbah.Name = "cbah";
            this.cbah.Size = new System.Drawing.Size(130, 28);
            this.cbah.TabIndex = 0;
            this.cbah.Text = "Albert Heijn";
            this.cbah.UseVisualStyleBackColor = true;
            this.cbah.CheckedChanged += new System.EventHandler(this.cbah_CheckedChanged);
            // 
            // cbplus
            // 
            this.cbplus.AutoSize = true;
            this.cbplus.Location = new System.Drawing.Point(34, 108);
            this.cbplus.Margin = new System.Windows.Forms.Padding(4);
            this.cbplus.Name = "cbplus";
            this.cbplus.Size = new System.Drawing.Size(68, 28);
            this.cbplus.TabIndex = 1;
            this.cbplus.Text = "Plus";
            this.cbplus.UseVisualStyleBackColor = true;
            this.cbplus.CheckedChanged += new System.EventHandler(this.cbplus_CheckedChanged);
            // 
            // cbdeka
            // 
            this.cbdeka.AutoSize = true;
            this.cbdeka.Location = new System.Drawing.Point(34, 144);
            this.cbdeka.Margin = new System.Windows.Forms.Padding(4);
            this.cbdeka.Name = "cbdeka";
            this.cbdeka.Size = new System.Drawing.Size(120, 28);
            this.cbdeka.TabIndex = 2;
            this.cbdeka.Text = "Dekamarkt";
            this.cbdeka.UseVisualStyleBackColor = true;
            this.cbdeka.CheckedChanged += new System.EventHandler(this.cbdeka_CheckedChanged);
            // 
            // cbvomar
            // 
            this.cbvomar.AutoSize = true;
            this.cbvomar.Location = new System.Drawing.Point(34, 180);
            this.cbvomar.Margin = new System.Windows.Forms.Padding(4);
            this.cbvomar.Name = "cbvomar";
            this.cbvomar.Size = new System.Drawing.Size(88, 28);
            this.cbvomar.TabIndex = 3;
            this.cbvomar.Text = "Vomar";
            this.cbvomar.UseVisualStyleBackColor = true;
            this.cbvomar.CheckedChanged += new System.EventHandler(this.cbvomar_CheckedChanged);
            // 
            // cbjumbo
            // 
            this.cbjumbo.AutoSize = true;
            this.cbjumbo.Location = new System.Drawing.Point(32, 216);
            this.cbjumbo.Margin = new System.Windows.Forms.Padding(4);
            this.cbjumbo.Name = "cbjumbo";
            this.cbjumbo.Size = new System.Drawing.Size(90, 28);
            this.cbjumbo.TabIndex = 4;
            this.cbjumbo.Text = "Jumbo";
            this.cbjumbo.UseVisualStyleBackColor = true;
            this.cbjumbo.CheckedChanged += new System.EventHandler(this.cbjumbo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecteer De winkels die je wilt vergelijken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voeg een Product toe aan de vergelijklijst";
            // 
            // textboxtoevoegen
            // 
            this.textboxtoevoegen.Location = new System.Drawing.Point(32, 288);
            this.textboxtoevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.textboxtoevoegen.Name = "textboxtoevoegen";
            this.textboxtoevoegen.Size = new System.Drawing.Size(353, 28);
            this.textboxtoevoegen.TabIndex = 7;
            // 
            // btntoevoegen
            // 
            this.btntoevoegen.Location = new System.Drawing.Point(393, 277);
            this.btntoevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btntoevoegen.Name = "btntoevoegen";
            this.btntoevoegen.Size = new System.Drawing.Size(126, 51);
            this.btntoevoegen.TabIndex = 8;
            this.btntoevoegen.Text = "Toevoegen";
            this.btntoevoegen.UseVisualStyleBackColor = true;
            this.btntoevoegen.Click += new System.EventHandler(this.btntoevoegen_Click);
            // 
            // listboxproductlijst
            // 
            this.listboxproductlijst.FormattingEnabled = true;
            this.listboxproductlijst.ItemHeight = 22;
            this.listboxproductlijst.Location = new System.Drawing.Point(46, 337);
            this.listboxproductlijst.Margin = new System.Windows.Forms.Padding(4);
            this.listboxproductlijst.Name = "listboxproductlijst";
            this.listboxproductlijst.Size = new System.Drawing.Size(439, 334);
            this.listboxproductlijst.TabIndex = 9;
            // 
            // vergelijkbtn
            // 
            this.vergelijkbtn.Location = new System.Drawing.Point(112, 679);
            this.vergelijkbtn.Margin = new System.Windows.Forms.Padding(4);
            this.vergelijkbtn.Name = "vergelijkbtn";
            this.vergelijkbtn.Size = new System.Drawing.Size(320, 58);
            this.vergelijkbtn.TabIndex = 10;
            this.vergelijkbtn.Text = "vergelijk";
            this.vergelijkbtn.UseVisualStyleBackColor = true;
            this.vergelijkbtn.Click += new System.EventHandler(this.vergelijkbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "De product in totaal zijn goedkoper bij:";
            // 
            // listboxwinkel
            // 
            this.listboxwinkel.FormattingEnabled = true;
            this.listboxwinkel.ItemHeight = 22;
            this.listboxwinkel.Location = new System.Drawing.Point(650, 72);
            this.listboxwinkel.Margin = new System.Windows.Forms.Padding(4);
            this.listboxwinkel.Name = "listboxwinkel";
            this.listboxwinkel.Size = new System.Drawing.Size(409, 114);
            this.listboxwinkel.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "De producten individueel zijn het goedkoopst bij:";
            // 
            // listboxproductindividu
            // 
            this.listboxproductindividu.FormattingEnabled = true;
            this.listboxproductindividu.ItemHeight = 22;
            this.listboxproductindividu.Location = new System.Drawing.Point(650, 249);
            this.listboxproductindividu.Margin = new System.Windows.Forms.Padding(4);
            this.listboxproductindividu.Name = "listboxproductindividu";
            this.listboxproductindividu.Size = new System.Drawing.Size(409, 422);
            this.listboxproductindividu.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1124, 768);
            this.Controls.Add(this.listboxproductindividu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listboxwinkel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vergelijkbtn);
            this.Controls.Add(this.listboxproductlijst);
            this.Controls.Add(this.btntoevoegen);
            this.Controls.Add(this.textboxtoevoegen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbjumbo);
            this.Controls.Add(this.cbvomar);
            this.Controls.Add(this.cbdeka);
            this.Controls.Add(this.cbplus);
            this.Controls.Add(this.cbah);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Boodschappenvergelijker";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbah;
        private System.Windows.Forms.CheckBox cbplus;
        private System.Windows.Forms.CheckBox cbdeka;
        private System.Windows.Forms.CheckBox cbvomar;
        private System.Windows.Forms.CheckBox cbjumbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxtoevoegen;
        private System.Windows.Forms.Button btntoevoegen;
        private System.Windows.Forms.ListBox listboxproductlijst;
        private System.Windows.Forms.Button vergelijkbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listboxwinkel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listboxproductindividu;
    }
}