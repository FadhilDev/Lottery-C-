namespace CompeteSystem.CL
{
    partial class UserControlGifts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlGifts));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControlGifts = new DevExpress.XtraGrid.GridControl();
            this.gridViewGifts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelCompetitions = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelCompetitions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlGifts
            // 
            this.gridControlGifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGifts.Location = new System.Drawing.Point(0, 0);
            this.gridControlGifts.MainView = this.gridViewGifts;
            this.gridControlGifts.Name = "gridControlGifts";
            this.gridControlGifts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelCompetitions});
            this.gridControlGifts.Size = new System.Drawing.Size(581, 371);
            this.gridControlGifts.TabIndex = 1;
            this.gridControlGifts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGifts});
            // 
            // gridViewGifts
            // 
            this.gridViewGifts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewGifts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewGifts.GridControl = this.gridControlGifts;
            this.gridViewGifts.Name = "gridViewGifts";
            this.gridViewGifts.OptionsBehavior.Editable = false;
            this.gridViewGifts.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewGifts.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewGifts.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewGifts.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGifts.OptionsView.ShowGroupPanel = false;
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
            // btnDelCompetitions
            // 
            this.btnDelCompetitions.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDelCompetitions.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelCompetitions.Name = "btnDelCompetitions";
            this.btnDelCompetitions.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // UserControlGifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlGifts);
            this.Name = "UserControlGifts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(581, 371);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelCompetitions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControlGifts;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewGifts;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelCompetitions;
    }
}
