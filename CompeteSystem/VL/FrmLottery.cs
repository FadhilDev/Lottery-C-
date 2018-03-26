using System;
using System.Data.SQLite;
using System.Windows.Forms;
using CompeteSystem.CL;
using CompeteSystem.DAL;
using DevExpress.XtraEditors.Controls;
using static CompeteSystem.CL.UserControlWinners;
using static CompeteSystem.VL.FrmMain;
namespace CompeteSystem.VL
{
    public partial class FrmLottery : Form
    {
        public FrmLottery()
        {
            InitializeComponent();
            lookUpEditCompetitions.Properties.Columns.Add(new LookUpColumnInfo("Id"));
            lookUpEditCompetitions.Properties.Columns.Add(new LookUpColumnInfo("Name"));
            lookUpEditCompetitions.Properties.Columns["Name"].Caption = @"الأسم";
            lookUpEditCompetitions.Properties.Columns["Id"].Visible = false;
            lookUpEditCompetitions.Properties.ValueMember = "Id";
            lookUpEditCompetitions.Properties.DisplayMember = "Name";
            lookUpEditCompetitions.Properties.NullText = @"الرجاء اختر مسابقة";
            lookUpEditCompetitions.Properties.DataSource= SqliteDbAccess.ReturnDataTable("SELECT * FROM Competitions", null);

            lookUpEditGifts.Properties.Columns.Add(new LookUpColumnInfo("Id"));
            lookUpEditGifts.Properties.Columns.Add(new LookUpColumnInfo("Name"));
            lookUpEditGifts.Properties.Columns["Name"].Caption = @"الأسم";
            lookUpEditGifts.Properties.Columns["Id"].Visible = false;
            lookUpEditGifts.Properties.ValueMember = "Id";
            lookUpEditGifts.Properties.DisplayMember = "Name";
            lookUpEditGifts.Properties.NullText = @"الرجاء اختر الهدية";
            lookUpEditGifts.Properties.DataSource = SqliteDbAccess.ReturnDataTable("SELECT * FROM Gifts", null);

        }

        private void btnCancele_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLiteParameter[] prm = new SQLiteParameter[3];
            if (lookUpEditCompetitions.EditValue==null||lookUpEditGifts.EditValue == null|| spinEditLottery.Value==0)
            {
                return;
            }
            this.Hide();
            prm[0] = new SQLiteParameter("@CompetitionId", lookUpEditCompetitions.EditValue);
            prm[1] = new SQLiteParameter("@GiftId", lookUpEditGifts.EditValue);
            prm[2] = new SQLiteParameter("@Value", spinEditLottery.Value);
            
            var sqlStr = "UPDATE Competitors SET GiftId=@GiftId WHERE Id IN(SELECT Id FROM Competitors WHERE CompetitionId=@CompetitionId AND GiftId=0 ORDER BY RANDOM() LIMIT @Value)";
            SqliteDbAccess.ExcuteData(sqlStr, prm);
            _FrmMain.navigationPageWinners.Controls.Clear();
            _FrmMain.navigationPageWinners.Controls.Add(new UserControlWinners());
            var frm =new FrmWait();
            frm.ShowDialog(this); 
        }

        private void lookUpEditCompetitions_EditValueChanged(object sender, EventArgs e)
        {
            SQLiteParameter[] prm = new SQLiteParameter[1];
            prm[0] = new SQLiteParameter("@CompetitionId", lookUpEditCompetitions.EditValue);
            var dtCount = SqliteDbAccess.ReturnDataTable("SELECT COUNT(*) FROM Competitors WHERE GiftId=0 AND CompetitionId=@CompetitionId", prm);
            if (Convert.ToInt32(dtCount.Rows[0][0]) == 0)
            {
                lookUpEditGifts.Properties.Enabled = false;
                spinEditLottery.Properties.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            lookUpEditGifts.Properties.Enabled = true;
            spinEditLottery.Properties.Enabled = true;
            btnSave.Enabled = true;
            spinEditLottery.Value = Convert.ToInt32(dtCount.Rows[0][0]);
            spinEditLottery.Properties.MaxValue = Convert.ToInt32(dtCount.Rows[0][0]);
        }
    }
}
