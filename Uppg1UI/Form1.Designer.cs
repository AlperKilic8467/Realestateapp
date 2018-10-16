namespace Uppg1UI
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.StreetTB = new System.Windows.Forms.TextBox();
            this.ZipTB = new System.Windows.Forms.TextBox();
            this.SpecTB = new System.Windows.Forms.TextBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SpecLabel = new System.Windows.Forms.Label();
            this.CountryCB = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AddModBtn = new System.Windows.Forms.Button();
            this.SearchCityTB = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.SearchTypeTB = new System.Windows.Forms.TextBox();
            this.SearchTypelbl = new System.Windows.Forms.Label();
            this.SearchCityLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(50, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(295, 186);
            this.listBox1.TabIndex = 0;
            // 
            // TypeCB
            // 
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(499, 118);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(239, 21);
            this.TypeCB.TabIndex = 1;
            this.TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            // 
            // CityTB
            // 
            this.CityTB.Location = new System.Drawing.Point(499, 198);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(239, 20);
            this.CityTB.TabIndex = 3;
            // 
            // StreetTB
            // 
            this.StreetTB.Location = new System.Drawing.Point(499, 235);
            this.StreetTB.Name = "StreetTB";
            this.StreetTB.Size = new System.Drawing.Size(239, 20);
            this.StreetTB.TabIndex = 4;
            // 
            // ZipTB
            // 
            this.ZipTB.Location = new System.Drawing.Point(499, 275);
            this.ZipTB.Name = "ZipTB";
            this.ZipTB.Size = new System.Drawing.Size(239, 20);
            this.ZipTB.TabIndex = 5;
            // 
            // SpecTB
            // 
            this.SpecTB.Location = new System.Drawing.Point(563, 336);
            this.SpecTB.Name = "SpecTB";
            this.SpecTB.Size = new System.Drawing.Size(106, 20);
            this.SpecTB.TabIndex = 6;
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(105, 267);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(109, 28);
            this.ViewBtn.TabIndex = 7;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(105, 301);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(109, 27);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Location = new System.Drawing.Point(629, 410);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(109, 28);
            this.ModifyBtn.TabIndex = 9;
            this.ModifyBtn.Text = "Modify";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(105, 410);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(109, 28);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(514, 410);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 28);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Listings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Zip-Code";
            // 
            // SpecLabel
            // 
            this.SpecLabel.AutoSize = true;
            this.SpecLabel.Location = new System.Drawing.Point(560, 320);
            this.SpecLabel.Name = "SpecLabel";
            this.SpecLabel.Size = new System.Drawing.Size(32, 13);
            this.SpecLabel.TabIndex = 18;
            this.SpecLabel.Text = "Spec";
            // 
            // CountryCB
            // 
            this.CountryCB.FormattingEnabled = true;
            this.CountryCB.Location = new System.Drawing.Point(499, 159);
            this.CountryCB.Name = "CountryCB";
            this.CountryCB.Size = new System.Drawing.Size(239, 21);
            this.CountryCB.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(180, 22);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(180, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(180, 22);
            this.mnuSaveAs.Text = "Save as...";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // CategoryCB
            // 
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(499, 81);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(239, 21);
            this.CategoryCB.TabIndex = 21;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(437, 81);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 22;
            this.CategoryLabel.Text = "Category";
            // 
            // AddModBtn
            // 
            this.AddModBtn.Location = new System.Drawing.Point(563, 362);
            this.AddModBtn.Name = "AddModBtn";
            this.AddModBtn.Size = new System.Drawing.Size(106, 21);
            this.AddModBtn.TabIndex = 23;
            this.AddModBtn.Text = "Add Modification";
            this.AddModBtn.UseVisualStyleBackColor = true;
            this.AddModBtn.Click += new System.EventHandler(this.AddModBtn_Click);
            // 
            // SearchCityTB
            // 
            this.SearchCityTB.Location = new System.Drawing.Point(50, 384);
            this.SearchCityTB.Name = "SearchCityTB";
            this.SearchCityTB.Size = new System.Drawing.Size(239, 20);
            this.SearchCityTB.TabIndex = 24;
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(102, 339);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(97, 13);
            this.SearchLbl.TabIndex = 25;
            this.SearchLbl.Text = "Search for a listing:";
            // 
            // SearchTypeTB
            // 
            this.SearchTypeTB.Location = new System.Drawing.Point(50, 358);
            this.SearchTypeTB.Name = "SearchTypeTB";
            this.SearchTypeTB.Size = new System.Drawing.Size(239, 20);
            this.SearchTypeTB.TabIndex = 26;
            // 
            // SearchTypelbl
            // 
            this.SearchTypelbl.AutoSize = true;
            this.SearchTypelbl.Location = new System.Drawing.Point(13, 358);
            this.SearchTypelbl.Name = "SearchTypelbl";
            this.SearchTypelbl.Size = new System.Drawing.Size(31, 13);
            this.SearchTypelbl.TabIndex = 27;
            this.SearchTypelbl.Text = "Type";
            // 
            // SearchCityLbl
            // 
            this.SearchCityLbl.AutoSize = true;
            this.SearchCityLbl.Location = new System.Drawing.Point(13, 384);
            this.SearchCityLbl.Name = "SearchCityLbl";
            this.SearchCityLbl.Size = new System.Drawing.Size(24, 13);
            this.SearchCityLbl.TabIndex = 28;
            this.SearchCityLbl.Text = "City";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchCityLbl);
            this.Controls.Add(this.SearchTypelbl);
            this.Controls.Add(this.SearchTypeTB);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.SearchCityTB);
            this.Controls.Add(this.AddModBtn);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.CountryCB);
            this.Controls.Add(this.SpecLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.SpecTB);
            this.Controls.Add(this.ZipTB);
            this.Controls.Add(this.StreetTB);
            this.Controls.Add(this.CityTB);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox StreetTB;
        private System.Windows.Forms.TextBox ZipTB;
        private System.Windows.Forms.TextBox SpecTB;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SpecLabel;
        private System.Windows.Forms.ComboBox CountryCB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button AddModBtn;
        private System.Windows.Forms.TextBox SearchCityTB;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.TextBox SearchTypeTB;
        private System.Windows.Forms.Label SearchTypelbl;
        private System.Windows.Forms.Label SearchCityLbl;
    }
}

