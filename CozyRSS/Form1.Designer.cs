namespace CozyRSS
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.feedList = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.indexTab = new System.Windows.Forms.TabPage();
            this.loadOpml = new System.Windows.Forms.Button();
            this.feedGrid = new System.Windows.Forms.DataGridView();
            this.TreeIcons = new System.Windows.Forms.ImageList(this.components);
            this.Bookmarked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Published = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.indexTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fILEToolStripMenuItem.Text = "File";
            this.fILEToolStripMenuItem.Click += new System.EventHandler(this.fILEToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.feedList);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainTabs);
            this.splitContainer1.Size = new System.Drawing.Size(853, 562);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 1;
            // 
            // feedList
            // 
            this.feedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedList.ImageIndex = 0;
            this.feedList.ImageList = this.TreeIcons;
            this.feedList.Location = new System.Drawing.Point(3, 0);
            this.feedList.Name = "feedList";
            this.feedList.SelectedImageIndex = 0;
            this.feedList.Size = new System.Drawing.Size(280, 562);
            this.feedList.TabIndex = 3;
            this.feedList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.feedList_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 562);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.indexTab);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(566, 562);
            this.mainTabs.TabIndex = 0;
            // 
            // indexTab
            // 
            this.indexTab.Controls.Add(this.loadOpml);
            this.indexTab.Controls.Add(this.feedGrid);
            this.indexTab.Location = new System.Drawing.Point(4, 29);
            this.indexTab.Name = "indexTab";
            this.indexTab.Padding = new System.Windows.Forms.Padding(3);
            this.indexTab.Size = new System.Drawing.Size(558, 529);
            this.indexTab.TabIndex = 0;
            this.indexTab.Text = "Feed";
            this.indexTab.UseVisualStyleBackColor = true;
            // 
            // loadOpml
            // 
            this.loadOpml.Location = new System.Drawing.Point(413, 482);
            this.loadOpml.Name = "loadOpml";
            this.loadOpml.Size = new System.Drawing.Size(137, 39);
            this.loadOpml.TabIndex = 2;
            this.loadOpml.Text = "button1";
            this.loadOpml.UseVisualStyleBackColor = true;
            this.loadOpml.Click += new System.EventHandler(this.button1_Click);
            // 
            // feedGrid
            // 
            this.feedGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.feedGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.feedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bookmarked,
            this.Blog,
            this.Title,
            this.Published,
            this.Link});
            this.feedGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedGrid.Location = new System.Drawing.Point(3, 3);
            this.feedGrid.Name = "feedGrid";
            this.feedGrid.ReadOnly = true;
            this.feedGrid.RowHeadersVisible = false;
            this.feedGrid.RowHeadersWidth = 62;
            this.feedGrid.RowTemplate.Height = 28;
            this.feedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.feedGrid.Size = new System.Drawing.Size(552, 523);
            this.feedGrid.TabIndex = 3;
            this.feedGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.feedGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feedGrid_CellDoubleClick);
            // 
            // TreeIcons
            // 
            this.TreeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeIcons.ImageStream")));
            this.TreeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeIcons.Images.SetKeyName(0, "folder");
            this.TreeIcons.Images.SetKeyName(1, "folder-open.png");
            this.TreeIcons.Images.SetKeyName(2, "feed");
            // 
            // Bookmarked
            // 
            this.Bookmarked.HeaderText = "*";
            this.Bookmarked.MinimumWidth = 32;
            this.Bookmarked.Name = "Bookmarked";
            this.Bookmarked.ReadOnly = true;
            this.Bookmarked.Width = 32;
            // 
            // Blog
            // 
            this.Blog.HeaderText = "Blog";
            this.Blog.MinimumWidth = 8;
            this.Blog.Name = "Blog";
            this.Blog.ReadOnly = true;
            this.Blog.Width = 150;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.DefaultCellStyle = dataGridViewCellStyle1;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Published
            // 
            this.Published.HeaderText = "Published";
            this.Published.MinimumWidth = 8;
            this.Published.Name = "Published";
            this.Published.ReadOnly = true;
            this.Published.Width = 150;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.MinimumWidth = 8;
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 595);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CozyRSS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mainTabs.ResumeLayout(false);
            this.indexTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage indexTab;
        private System.Windows.Forms.Button loadOpml;
        private System.Windows.Forms.TreeView feedList;
        private System.Windows.Forms.DataGridView feedGrid;
        private System.Windows.Forms.ImageList TreeIcons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bookmarked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Published;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
    }
}

