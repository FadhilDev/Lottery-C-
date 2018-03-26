namespace CompeteSystem.CL
{
    partial class UserControlCompetitions
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCompetitions));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControlCompetitions = new DevExpress.XtraGrid.GridControl();
            this.gridViewCompetitions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelCompetitions = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelCompetitions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCompetitions
            // 
            this.gridControlCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCompetitions.Location = new System.Drawing.Point(0, 0);
            this.gridControlCompetitions.MainView = this.gridViewCompetitions;
            this.gridControlCompetitions.Name = "gridControlCompetitions";
            this.gridControlCompetitions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelCompetitions});
            this.gridControlCompetitions.Size = new System.Drawing.Size(711, 501);
            this.gridControlCompetitions.TabIndex = 0;
            this.gridControlCompetitions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompetitions});
            // 
            // gridViewCompetitions
            // 
            this.gridViewCompetitions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewCompetitions.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewCompetitions.GridControl = this.gridControlCompetitions;
            this.gridViewCompetitions.Name = "gridViewCompetitions";
            this.gridViewCompetitions.OptionsBehavior.Editable = false;
            this.gridViewCompetitions.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCompetitions.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewCompetitions.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewCompetitions.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCompetitions.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn3.Caption = "التاريخ";
            this.gridColumn3.FieldName = "Date";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // btnDelCompetitions
            // 
            this.btnDelCompetitions.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDelCompetitions.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelCompetitions.Name = "btnDelCompetitions";
            this.btnDelCompetitions.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // UserControlCompetitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlCompetitions);
            this.Name = "UserControlCompetitions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(711, 501);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelCompetitions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewCompetitions;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelCompetitions;
        public DevExpress.XtraGrid.GridControl gridControlCompetitions;
    }
}
