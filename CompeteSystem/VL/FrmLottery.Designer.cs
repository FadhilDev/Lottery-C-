namespace CompeteSystem.VL
{
    partial class FrmLottery
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLottery));
            this.spinEditLottery = new DevExpress.XtraEditors.SpinEdit();
            this.lookUpEditCompetitions = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditGifts = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLottery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompetitions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGifts.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // spinEditLottery
            // 
            this.spinEditLottery.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditLottery.Location = new System.Drawing.Point(76, 64);
            this.spinEditLottery.Name = "spinEditLottery";
            this.spinEditLottery.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditLottery.Properties.IsFloatValue = false;
            this.spinEditLottery.Properties.Mask.EditMask = "N00";
            this.spinEditLottery.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.spinEditLottery.Size = new System.Drawing.Size(176, 20);
            this.spinEditLottery.TabIndex = 0;
            // 
            // lookUpEditCompetitions
            // 
            this.lookUpEditCompetitions.Location = new System.Drawing.Point(76, 12);
            this.lookUpEditCompetitions.Name = "lookUpEditCompetitions";
            this.lookUpEditCompetitions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCompetitions.Size = new System.Drawing.Size(176, 20);
            this.lookUpEditCompetitions.TabIndex = 1;
            this.lookUpEditCompetitions.EditValueChanged += new System.EventHandler(this.lookUpEditCompetitions_EditValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(76, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancele
            // 
            this.btnCancele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancele.ImageOptions.Image")));
            this.btnCancele.Location = new System.Drawing.Point(157, 103);
            this.btnCancele.Name = "btnCancele";
            this.btnCancele.Size = new System.Drawing.Size(75, 23);
            this.btnCancele.TabIndex = 3;
            this.btnCancele.Text = "إلغاء";
            this.btnCancele.Click += new System.EventHandler(this.btnCancele_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "العدد";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "المسابقة";
            // 
            // lookUpEditGifts
            // 
            this.lookUpEditGifts.Location = new System.Drawing.Point(76, 38);
            this.lookUpEditGifts.Name = "lookUpEditGifts";
            this.lookUpEditGifts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGifts.Size = new System.Drawing.Size(176, 20);
            this.lookUpEditGifts.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "الهدية";
            // 
            // FrmLottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 165);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lookUpEditGifts);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancele);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lookUpEditCompetitions);
            this.Controls.Add(this.spinEditLottery);
            this.Name = "FrmLottery";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "القرعة";
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLottery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCompetitions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGifts.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spinEditLottery;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCompetitions;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancele;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditGifts;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}