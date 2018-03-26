namespace CompeteSystem.CL
{
    partial class UserControlCompetitors
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
            this.gridControlCompetitors = new DevExpress.XtraGrid.GridControl();
            this.gridViewCompetitors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompetitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompetitors)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCompetitors
            // 
            this.gridControlCompetitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCompetitors.Location = new System.Drawing.Point(0, 0);
            this.gridControlCompetitors.MainView = this.gridViewCompetitors;
            this.gridControlCompetitors.Name = "gridControlCompetitors";
            this.gridControlCompetitors.Size = new System.Drawing.Size(568, 430);
            this.gridControlCompetitors.TabIndex = 0;
            this.gridControlCompetitors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompetitors});
            // 
            // gridViewCompetitors
            // 
            this.gridViewCompetitors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridViewCompetitors.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewCompetitors.GridControl = this.gridControlCompetitors;
            this.gridViewCompetitors.Name = "gridViewCompetitors";
            this.gridViewCompetitors.OptionsBehavior.Editable = false;
            this.gridViewCompetitors.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCompetitors.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewCompetitors.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewCompetitors.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCompetitors.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "المدينة";
            this.gridColumn3.FieldName = "City";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "المدرسة";
            this.gridColumn4.FieldName = "School";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "الموبايل";
            this.gridColumn5.FieldName = "Phone";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "CompetitionId";
            this.gridColumn6.FieldName = "CompetitionId";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "GiftId";
            this.gridColumn7.FieldName = "GiftId";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "أسم المسابقه";
            this.gridColumn8.FieldName = "CompetitionName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // UserControlCompetitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCompetitors);
            this.Name = "UserControlCompetitors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(568, 430);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompetitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompetitors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        public DevExpress.XtraGrid.GridControl gridControlCompetitors;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewCompetitors;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}
