namespace CompeteSystem.CL
{
    partial class UserControlWinners
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlWinners = new DevExpress.XtraGrid.GridControl();
            this.gridViewWinners = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWinners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWinners)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlWinners
            // 
            this.gridControlWinners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlWinners.Location = new System.Drawing.Point(0, 0);
            this.gridControlWinners.MainView = this.gridViewWinners;
            this.gridControlWinners.Name = "gridControlWinners";
            this.gridControlWinners.Size = new System.Drawing.Size(475, 366);
            this.gridControlWinners.TabIndex = 1;
            this.gridControlWinners.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWinners});
            // 
            // gridViewWinners
            // 
            this.gridViewWinners.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridViewWinners.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewWinners.GridControl = this.gridControlWinners;
            this.gridViewWinners.Name = "gridViewWinners";
            this.gridViewWinners.OptionsBehavior.Editable = false;
            this.gridViewWinners.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewWinners.OptionsSelection.MultiSelect = true;
            this.gridViewWinners.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewWinners.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewWinners.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewWinners.OptionsView.ShowAutoFilterRow = true;
            this.gridViewWinners.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.gridViewWinners.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "الأسم";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "المدينة";
            this.gridColumn3.FieldName = "City";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "المدرسة";
            this.gridColumn4.FieldName = "School";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "الموبايل";
            this.gridColumn5.FieldName = "Phone";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "أسم المسابقة";
            this.gridColumn6.FieldName = "CompetitionName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "أسم الهدية";
            this.gridColumn7.FieldName = "GiftName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // UserControlWinners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlWinners);
            this.Name = "UserControlWinners";
            this.Size = new System.Drawing.Size(475, 366);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWinners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWinners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControlWinners;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewWinners;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}
