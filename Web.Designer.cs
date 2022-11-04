namespace WebBrowser
{
  partial class Web
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Web));
      this.TsHerramientas = new System.Windows.Forms.ToolStrip();
      this.BtnBack = new System.Windows.Forms.ToolStripButton();
      this.BtnForward = new System.Windows.Forms.ToolStripButton();
      this.BtnReload = new System.Windows.Forms.ToolStripButton();
      this.BtnHome = new System.Windows.Forms.ToolStripButton();
      this.TxtSearch = new System.Windows.Forms.ToolStripTextBox();
      this.BtnSearch = new System.Windows.Forms.ToolStripButton();
      this.CbxFav = new System.Windows.Forms.ToolStripComboBox();
      this.BtnFav = new System.Windows.Forms.ToolStripButton();
      this.WbBrowser = new System.Windows.Forms.WebBrowser();
      this.TsHerramientas.SuspendLayout();
      this.SuspendLayout();
      // 
      // TsHerramientas
      // 
      this.TsHerramientas.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.TsHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnBack,
            this.BtnForward,
            this.BtnReload,
            this.BtnHome,
            this.TxtSearch,
            this.BtnSearch,
            this.CbxFav,
            this.BtnFav});
      this.TsHerramientas.Location = new System.Drawing.Point(0, 0);
      this.TsHerramientas.Name = "TsHerramientas";
      this.TsHerramientas.Size = new System.Drawing.Size(1320, 28);
      this.TsHerramientas.TabIndex = 0;
      this.TsHerramientas.Text = "toolStrip1";
      // 
      // BtnBack
      // 
      this.BtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnBack.Image = global::WebBrowser.Properties.Resources.backButton;
      this.BtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnBack.Name = "BtnBack";
      this.BtnBack.Size = new System.Drawing.Size(29, 25);
      this.BtnBack.Text = "Atras";
      this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
      // 
      // BtnForward
      // 
      this.BtnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnForward.Image = global::WebBrowser.Properties.Resources.forwardButton;
      this.BtnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnForward.Name = "BtnForward";
      this.BtnForward.Size = new System.Drawing.Size(29, 25);
      this.BtnForward.Text = "toolStripButton1";
      this.BtnForward.ToolTipText = "Avanzar";
      this.BtnForward.Click += new System.EventHandler(this.BtnForward_Click);
      // 
      // BtnReload
      // 
      this.BtnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnReload.Image = global::WebBrowser.Properties.Resources.reloadButton;
      this.BtnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnReload.Name = "BtnReload";
      this.BtnReload.Size = new System.Drawing.Size(29, 25);
      this.BtnReload.Text = "toolStripButton1";
      this.BtnReload.ToolTipText = "Refrescar";
      this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
      // 
      // BtnHome
      // 
      this.BtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnHome.Image = global::WebBrowser.Properties.Resources.homeButton;
      this.BtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnHome.Name = "BtnHome";
      this.BtnHome.Size = new System.Drawing.Size(29, 25);
      this.BtnHome.Text = "toolStripButton1";
      this.BtnHome.ToolTipText = "Inicio";
      this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
      // 
      // TxtSearch
      // 
      this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.TxtSearch.Name = "TxtSearch";
      this.TxtSearch.Size = new System.Drawing.Size(599, 28);
      this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Web_KeyDown);
      // 
      // BtnSearch
      // 
      this.BtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnSearch.Image = global::WebBrowser.Properties.Resources.searchButton;
      this.BtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnSearch.Name = "BtnSearch";
      this.BtnSearch.Size = new System.Drawing.Size(29, 25);
      this.BtnSearch.Text = "toolStripButton1";
      this.BtnSearch.ToolTipText = "Buscar";
      this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
      // 
      // CbxFav
      // 
      this.CbxFav.Name = "CbxFav";
      this.CbxFav.Size = new System.Drawing.Size(160, 28);
      this.CbxFav.SelectedIndexChanged += new System.EventHandler(this.CbxFav_SelectedIndexChanged);
      // 
      // BtnFav
      // 
      this.BtnFav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BtnFav.Image = global::WebBrowser.Properties.Resources.favButton;
      this.BtnFav.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BtnFav.Name = "BtnFav";
      this.BtnFav.Size = new System.Drawing.Size(29, 25);
      this.BtnFav.Text = "toolStripButton1";
      this.BtnFav.ToolTipText = "Favoritos";
      this.BtnFav.Click += new System.EventHandler(this.BtnFav_Click);
      // 
      // WbBrowser
      // 
      this.WbBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.WbBrowser.Location = new System.Drawing.Point(0, 28);
      this.WbBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.WbBrowser.MinimumSize = new System.Drawing.Size(27, 25);
      this.WbBrowser.Name = "WbBrowser";
      this.WbBrowser.Size = new System.Drawing.Size(1320, 606);
      this.WbBrowser.TabIndex = 1;
      // 
      // Web
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1320, 634);
      this.Controls.Add(this.WbBrowser);
      this.Controls.Add(this.TsHerramientas);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Web";
      this.Text = "WebBrowser";
      this.Load += new System.EventHandler(this.Web_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Web_KeyDown);
      this.TsHerramientas.ResumeLayout(false);
      this.TsHerramientas.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip TsHerramientas;
    private System.Windows.Forms.ToolStripButton BtnBack;
    private System.Windows.Forms.WebBrowser WbBrowser;
    private System.Windows.Forms.ToolStripButton BtnForward;
    private System.Windows.Forms.ToolStripButton BtnHome;
    private System.Windows.Forms.ToolStripButton BtnReload;
    private System.Windows.Forms.ToolStripTextBox TxtSearch;
    private System.Windows.Forms.ToolStripButton BtnSearch;
    private System.Windows.Forms.ToolStripComboBox CbxFav;
    private System.Windows.Forms.ToolStripButton BtnFav;
  }
}

