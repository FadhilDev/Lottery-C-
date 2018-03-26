namespace CompeteSystem.VL
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CompeteSystem.VL.WaitForm), true, true);
            this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupCompetitions = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemAddCompetitions = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemEditCompetitions = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemDelCompetitions = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemStartLottery = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupGifts = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemAddGifts = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemEditGifts = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemDelGifts = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupCompetitors = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemAddCompetitors = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemEditCompetitors = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemDelCompetitors = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemImportCompetitors = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupWinners = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemEditWinners = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemExportWinners = new DevExpress.XtraNavBar.NavBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPageCompetitions = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageCompetitors = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageGifts = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPageWinners = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // officeNavigationBar
            // 
            this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar.Location = new System.Drawing.Point(0, 523);
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.NavigationClient = this.navBarControl;
            this.officeNavigationBar.Size = new System.Drawing.Size(1057, 44);
            this.officeNavigationBar.TabIndex = 1;
            this.officeNavigationBar.Text = "officeNavigationBar";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGroupCompetitions;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupCompetitions,
            this.navBarGroupGifts,
            this.navBarGroupCompetitors,
            this.navBarGroupWinners});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemAddCompetitions,
            this.navBarItemEditCompetitions,
            this.navBarItemAddCompetitors,
            this.navBarItemEditCompetitors,
            this.navBarItemDelCompetitions,
            this.navBarItemDelCompetitors,
            this.navBarItemStartLottery,
            this.navBarItemAddGifts,
            this.navBarItemEditGifts,
            this.navBarItemDelGifts,
            this.navBarItemEditWinners,
            this.navBarItemImportCompetitors,
            this.navBarItemExportWinners});
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.MaximumSize = new System.Drawing.Size(165, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 165;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(165, 523);
            this.navBarControl.TabIndex = 4;
            this.navBarControl.Text = "navBarControl1";
            this.navBarControl.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl_ActiveGroupChanged);
            // 
            // navBarGroupCompetitions
            // 
            this.navBarGroupCompetitions.Caption = "المسابقات";
            this.navBarGroupCompetitions.Expanded = true;
            this.navBarGroupCompetitions.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAddCompetitions),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemEditCompetitions),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDelCompetitions),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemStartLottery)});
            this.navBarGroupCompetitions.Name = "navBarGroupCompetitions";
            // 
            // navBarItemAddCompetitions
            // 
            this.navBarItemAddCompetitions.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemAddCompetitions.Appearance.Options.UseFont = true;
            this.navBarItemAddCompetitions.Caption = "أضافة";
            this.navBarItemAddCompetitions.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemAddCompetitions.ImageOptions.SmallImage")));
            this.navBarItemAddCompetitions.Name = "navBarItemAddCompetitions";
            this.navBarItemAddCompetitions.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemAddCompetitions_LinkClicked);
            // 
            // navBarItemEditCompetitions
            // 
            this.navBarItemEditCompetitions.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemEditCompetitions.Appearance.Options.UseFont = true;
            this.navBarItemEditCompetitions.Caption = "تعديل";
            this.navBarItemEditCompetitions.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemEditCompetitions.ImageOptions.SmallImage")));
            this.navBarItemEditCompetitions.Name = "navBarItemEditCompetitions";
            this.navBarItemEditCompetitions.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemEditCompetitions_LinkClicked);
            // 
            // navBarItemDelCompetitions
            // 
            this.navBarItemDelCompetitions.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemDelCompetitions.Appearance.Options.UseFont = true;
            this.navBarItemDelCompetitions.Caption = "حذف";
            this.navBarItemDelCompetitions.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDelCompetitions.ImageOptions.SmallImage")));
            this.navBarItemDelCompetitions.Name = "navBarItemDelCompetitions";
            this.navBarItemDelCompetitions.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDelCompetitions_LinkClicked);
            // 
            // navBarItemStartLottery
            // 
            this.navBarItemStartLottery.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemStartLottery.Appearance.Options.UseFont = true;
            this.navBarItemStartLottery.Caption = "أجراء قرعة";
            this.navBarItemStartLottery.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemStartLottery.ImageOptions.SmallImage")));
            this.navBarItemStartLottery.Name = "navBarItemStartLottery";
            this.navBarItemStartLottery.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemStartLottery_LinkClicked);
            // 
            // navBarGroupGifts
            // 
            this.navBarGroupGifts.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroupGifts.Appearance.Options.UseFont = true;
            this.navBarGroupGifts.Caption = "الهدايا";
            this.navBarGroupGifts.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAddGifts),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemEditGifts),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDelGifts)});
            this.navBarGroupGifts.Name = "navBarGroupGifts";
            // 
            // navBarItemAddGifts
            // 
            this.navBarItemAddGifts.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemAddGifts.Appearance.Options.UseFont = true;
            this.navBarItemAddGifts.Caption = "أضافة";
            this.navBarItemAddGifts.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemAddGifts.ImageOptions.SmallImage")));
            this.navBarItemAddGifts.Name = "navBarItemAddGifts";
            this.navBarItemAddGifts.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemAddGifts_LinkClicked);
            // 
            // navBarItemEditGifts
            // 
            this.navBarItemEditGifts.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemEditGifts.Appearance.Options.UseFont = true;
            this.navBarItemEditGifts.Caption = "تعديل";
            this.navBarItemEditGifts.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemEditGifts.ImageOptions.SmallImage")));
            this.navBarItemEditGifts.Name = "navBarItemEditGifts";
            this.navBarItemEditGifts.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemEditGifts_LinkClicked);
            // 
            // navBarItemDelGifts
            // 
            this.navBarItemDelGifts.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemDelGifts.Appearance.Options.UseFont = true;
            this.navBarItemDelGifts.Caption = "حذف";
            this.navBarItemDelGifts.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDelGifts.ImageOptions.SmallImage")));
            this.navBarItemDelGifts.Name = "navBarItemDelGifts";
            this.navBarItemDelGifts.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDelGifts_LinkClicked);
            // 
            // navBarGroupCompetitors
            // 
            this.navBarGroupCompetitors.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroupCompetitors.Appearance.Options.UseFont = true;
            this.navBarGroupCompetitors.Caption = "المشاركين";
            this.navBarGroupCompetitors.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAddCompetitors),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemEditCompetitors),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDelCompetitors),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemImportCompetitors)});
            this.navBarGroupCompetitors.Name = "navBarGroupCompetitors";
            // 
            // navBarItemAddCompetitors
            // 
            this.navBarItemAddCompetitors.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemAddCompetitors.Appearance.Options.UseFont = true;
            this.navBarItemAddCompetitors.Caption = "أضافة";
            this.navBarItemAddCompetitors.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemAddCompetitors.ImageOptions.SmallImage")));
            this.navBarItemAddCompetitors.Name = "navBarItemAddCompetitors";
            this.navBarItemAddCompetitors.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemAddCompetitors_LinkClicked);
            // 
            // navBarItemEditCompetitors
            // 
            this.navBarItemEditCompetitors.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemEditCompetitors.Appearance.Options.UseFont = true;
            this.navBarItemEditCompetitors.Caption = "تعديل";
            this.navBarItemEditCompetitors.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemEditCompetitors.ImageOptions.SmallImage")));
            this.navBarItemEditCompetitors.Name = "navBarItemEditCompetitors";
            this.navBarItemEditCompetitors.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemEditCompetitors_LinkClicked);
            // 
            // navBarItemDelCompetitors
            // 
            this.navBarItemDelCompetitors.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemDelCompetitors.Appearance.Options.UseFont = true;
            this.navBarItemDelCompetitors.Caption = "حذف";
            this.navBarItemDelCompetitors.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDelCompetitors.ImageOptions.SmallImage")));
            this.navBarItemDelCompetitors.Name = "navBarItemDelCompetitors";
            this.navBarItemDelCompetitors.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDelCompetitors_LinkClicked);
            // 
            // navBarItemImportCompetitors
            // 
            this.navBarItemImportCompetitors.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemImportCompetitors.Appearance.Options.UseFont = true;
            this.navBarItemImportCompetitors.Caption = "أستيراد";
            this.navBarItemImportCompetitors.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemImportCompetitors.ImageOptions.SmallImage")));
            this.navBarItemImportCompetitors.Name = "navBarItemImportCompetitors";
            this.navBarItemImportCompetitors.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemImportCompetitors_LinkClicked);
            // 
            // navBarGroupWinners
            // 
            this.navBarGroupWinners.Caption = "الفائزين";
            this.navBarGroupWinners.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemEditWinners),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemExportWinners)});
            this.navBarGroupWinners.Name = "navBarGroupWinners";
            // 
            // navBarItemEditWinners
            // 
            this.navBarItemEditWinners.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemEditWinners.Appearance.Options.UseFont = true;
            this.navBarItemEditWinners.Caption = "حذف";
            this.navBarItemEditWinners.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemEditWinners.ImageOptions.SmallImage")));
            this.navBarItemEditWinners.Name = "navBarItemEditWinners";
            this.navBarItemEditWinners.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemEditWinners_LinkClicked);
            // 
            // navBarItemExportWinners
            // 
            this.navBarItemExportWinners.Caption = "تصدير";
            this.navBarItemExportWinners.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemExportWinners.ImageOptions.SmallImage")));
            this.navBarItemExportWinners.Name = "navBarItemExportWinners";
            this.navBarItemExportWinners.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemExportWinners_LinkClicked);
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.navigationPageCompetitions);
            this.navigationFrame.Controls.Add(this.navigationPageCompetitors);
            this.navigationFrame.Controls.Add(this.navigationPageGifts);
            this.navigationFrame.Controls.Add(this.navigationPageWinners);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(165, 0);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageCompetitions,
            this.navigationPageCompetitors,
            this.navigationPageGifts,
            this.navigationPageWinners});
            this.navigationFrame.SelectedPage = this.navigationPageCompetitions;
            this.navigationFrame.Size = new System.Drawing.Size(892, 523);
            this.navigationFrame.TabIndex = 5;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // navigationPageCompetitions
            // 
            this.navigationPageCompetitions.Caption = "navigationPageCompetitions";
            this.navigationPageCompetitions.Name = "navigationPageCompetitions";
            this.navigationPageCompetitions.Size = new System.Drawing.Size(892, 523);
            // 
            // navigationPageCompetitors
            // 
            this.navigationPageCompetitors.Caption = "navigationPageCompetitors";
            this.navigationPageCompetitors.Name = "navigationPageCompetitors";
            this.navigationPageCompetitors.Size = new System.Drawing.Size(892, 523);
            // 
            // navigationPageGifts
            // 
            this.navigationPageGifts.Caption = "navigationPageGifts";
            this.navigationPageGifts.Name = "navigationPageGifts";
            this.navigationPageGifts.Size = new System.Drawing.Size(892, 523);
            // 
            // navigationPageWinners
            // 
            this.navigationPageWinners.Caption = "navigationPageWinners";
            this.navigationPageWinners.Name = "navigationPageWinners";
            this.navigationPageWinners.Size = new System.Drawing.Size(892, 523);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 567);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.officeNavigationBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج القرعة";
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
  
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupCompetitions;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupCompetitors;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAddCompetitors;
        private DevExpress.XtraNavBar.NavBarItem navBarItemEditCompetitors;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAddCompetitions;
        private DevExpress.XtraNavBar.NavBarItem navBarItemEditCompetitions;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupGifts;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageCompetitions;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageCompetitors;

        private DevExpress.XtraNavBar.NavBarItem navBarItemDelCompetitions;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDelCompetitors;
        private DevExpress.XtraNavBar.NavBarItem navBarItemStartLottery;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAddGifts;
        private DevExpress.XtraNavBar.NavBarItem navBarItemEditGifts;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDelGifts;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupWinners;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageGifts;
        public DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarItem navBarItemEditWinners;
        private DevExpress.XtraNavBar.NavBarItem navBarItemImportCompetitors;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraNavBar.NavBarItem navBarItemExportWinners;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        public DevExpress.XtraBars.Navigation.NavigationPage navigationPageWinners;
        public DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
    }
}

