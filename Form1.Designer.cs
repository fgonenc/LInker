namespace Linker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btStartURL = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbURL = new System.Windows.Forms.Label();
            this.txLink = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbCatCombo = new System.Windows.Forms.Label();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.cmCategory = new System.Windows.Forms.ComboBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmnuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmnuBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmAddCategory = new System.Windows.Forms.ComboBox();
            this.txAddKeywords = new System.Windows.Forms.TextBox();
            this.txAddURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStartURL
            // 
            this.btStartURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStartURL.BackColor = System.Drawing.Color.White;
            this.btStartURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartURL.Location = new System.Drawing.Point(438, 219);
            this.btStartURL.Name = "btStartURL";
            this.btStartURL.Size = new System.Drawing.Size(84, 35);
            this.btStartURL.TabIndex = 11;
            this.btStartURL.Text = "START URL";
            this.toolTip1.SetToolTip(this.btStartURL, "Starts selected URL in default browser. ");
            this.btStartURL.UseVisualStyleBackColor = false;
            this.btStartURL.Click += new System.EventHandler(this.btStartURL_Click);
            // 
            // btInsert
            // 
            this.btInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btInsert.BackColor = System.Drawing.Color.White;
            this.btInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsert.Location = new System.Drawing.Point(436, 213);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(89, 39);
            this.btInsert.TabIndex = 9;
            this.btInsert.Text = "ADD NOW";
            this.toolTip1.SetToolTip(this.btInsert, "Show add form to add  new link");
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(590, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(14, 17);
            this.statuslabel.Text = "#";
            // 
            // lbURL
            // 
            this.lbURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(106, 206);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(78, 15);
            this.lbURL.TabIndex = 5;
            this.lbURL.Text = "Selected URL:";
            // 
            // txLink
            // 
            this.txLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txLink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txLink.Location = new System.Drawing.Point(106, 224);
            this.txLink.Name = "txLink";
            this.txLink.Size = new System.Drawing.Size(325, 25);
            this.txLink.TabIndex = 4;
            this.txLink.TextChanged += new System.EventHandler(this.txLink_TextChanged);
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.Color.White;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Location = new System.Drawing.Point(438, 29);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(84, 35);
            this.btSearch.TabIndex = 6;
            this.btSearch.Text = "SEARCH";
            this.toolTip1.SetToolTip(this.btSearch, "Type search text and click SEARCH");
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbCatCombo
            // 
            this.lbCatCombo.AutoSize = true;
            this.lbCatCombo.Location = new System.Drawing.Point(30, 23);
            this.lbCatCombo.Name = "lbCatCombo";
            this.lbCatCombo.Size = new System.Drawing.Size(68, 15);
            this.lbCatCombo.TabIndex = 5;
            this.lbCatCombo.Text = "CATEGORY:";
            // 
            // txSearch
            // 
            this.txSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txSearch.Location = new System.Drawing.Point(228, 41);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(204, 23);
            this.txSearch.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txSearch, "Type Search text for selected category. \r\nType % for all data. Usage Ex: c% \r\nThi" +
        "s will display all data starting with c ");
            this.txSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txSearch_KeyDown);
            // 
            // cmCategory
            // 
            this.cmCategory.FormattingEnabled = true;
            this.cmCategory.Items.AddRange(new object[] {
            "ID",
            "URL",
            "CATEGORY",
            "KEYWORDS"});
            this.cmCategory.Location = new System.Drawing.Point(30, 41);
            this.cmCategory.Name = "cmCategory";
            this.cmCategory.Size = new System.Drawing.Size(192, 23);
            this.cmCategory.TabIndex = 3;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(228, 23);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(54, 15);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "SEARCH:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(30, 79);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(492, 117);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmnuReload,
            this.ctmnuBackup});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 48);
            // 
            // ctmnuReload
            // 
            this.ctmnuReload.Name = "ctmnuReload";
            this.ctmnuReload.Size = new System.Drawing.Size(200, 22);
            this.ctmnuReload.Text = "Reload Grid";
            // 
            // ctmnuBackup
            // 
            this.ctmnuBackup.Name = "ctmnuBackup";
            this.ctmnuBackup.Size = new System.Drawing.Size(200, 22);
            this.ctmnuBackup.Text = "Backup SQLite database";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Location = new System.Drawing.Point(39, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "URL favicon");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 306);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.cmCategory);
            this.tabPage1.Controls.Add(this.btSearch);
            this.tabPage1.Controls.Add(this.lbCatCombo);
            this.tabPage1.Controls.Add(this.txSearch);
            this.tabPage1.Controls.Add(this.btStartURL);
            this.tabPage1.Controls.Add(this.lbSearch);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.lbURL);
            this.tabPage1.Controls.Add(this.txLink);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(551, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SEARCH LINK";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btInsert);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(551, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADD NEW";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmAddCategory);
            this.groupBox1.Controls.Add(this.txAddKeywords);
            this.groupBox1.Controls.Add(this.txAddURL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 170);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Keywords:";
            // 
            // cmAddCategory
            // 
            this.cmAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmAddCategory.FormattingEnabled = true;
            this.cmAddCategory.Location = new System.Drawing.Point(126, 59);
            this.cmAddCategory.Name = "cmAddCategory";
            this.cmAddCategory.Size = new System.Drawing.Size(374, 23);
            this.cmAddCategory.TabIndex = 3;
            // 
            // txAddKeywords
            // 
            this.txAddKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txAddKeywords.Location = new System.Drawing.Point(126, 97);
            this.txAddKeywords.Multiline = true;
            this.txAddKeywords.Name = "txAddKeywords";
            this.txAddKeywords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txAddKeywords.Size = new System.Drawing.Size(374, 55);
            this.txAddKeywords.TabIndex = 5;
            // 
            // txAddURL
            // 
            this.txAddURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txAddURL.Location = new System.Drawing.Point(126, 21);
            this.txAddURL.Name = "txAddURL";
            this.txAddURL.Size = new System.Drawing.Size(374, 23);
            this.txAddURL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "URL:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 84);
            this.panel1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(150, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(425, 62);
            this.textBox1.TabIndex = 13;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keywords:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(590, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Linker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbCatCombo;
        private System.Windows.Forms.Button btSearch;
        public System.Windows.Forms.ComboBox cmCategory;
        public System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.TextBox txLink;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btStartURL;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmAddCategory;
        private System.Windows.Forms.TextBox txAddKeywords;
        private System.Windows.Forms.TextBox txAddURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctmnuReload;
        private System.Windows.Forms.ToolStripMenuItem ctmnuBackup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

