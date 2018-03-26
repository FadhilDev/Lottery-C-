using System;
using System.Data.SQLite;
using System.Windows.Forms;
using CompeteSystem.DAL;
using DevExpress.XtraEditors.Controls;
using static CompeteSystem.CL.UserControlCompetitors;

namespace CompeteSystem.VL
{
    public partial class FrmCompetitorsAdd : Form
    {
        public FrmCompetitorsAdd()
        {
            InitializeComponent();
            lookUpEditCompetitions.Properties.Columns.Add(new LookUpColumnInfo("Id"));
            lookUpEditCompetitions.Properties.Columns.Add(new LookUpColumnInfo("Name"));
            lookUpEditCompetitions.Properties.Columns["Name"].Caption = @"الأسم";
            lookUpEditCompetitions.Properties.Columns["Id"].Visible = false;
            lookUpEditCompetitions.Properties.ValueMember = "Id";
            lookUpEditCompetitions.Properties.DisplayMember = "Name";
            lookUpEditCompetitions.Properties.NullText = @"الرجاء اختر مسابقة";
            lookUpEditCompetitions.Properties.DataSource = SqliteDbAccess.ReturnDataTable("SELECT * FROM Competitions", null);

        }

        private void btnCancele_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtCity.Text == string.Empty || txtSchool.Text == string.Empty || txtPhone.Text == string.Empty|| lookUpEditCompetitions.EditValue == null)
            {
                return;
            }
            SQLiteParameter[] prm = new SQLiteParameter[5];
            prm[0] = new SQLiteParameter("@Name", txtName.Text);
            prm[1] = new SQLiteParameter("@City", txtCity.Text);
            prm[2] = new SQLiteParameter("@School", txtSchool.Text);
            prm[3] = new SQLiteParameter("@Phone", txtPhone.Text);
            prm[4] = new SQLiteParameter("@Competition", lookUpEditCompetitions.EditValue);
            SqliteDbAccess.ExcuteData("INSERT INTO Competitors(Name,City,School,Phone,CompetitionId) VALUES (@Name,@City,@School,@Phone,@Competition)", prm);
            var sqlStr = "SELECT " +
                         "Competitors.Id,Competitors.Name,Competitors.City,Competitors.School, Competitors.Phone,Competitors.CompetitionId,Competitions.Name As CompetitionName " +
                         "FROM " +
                         "Competitors " +
                         "INNER JOIN " +
                         "Competitions " +
                         "ON " +
                         "Competitors.CompetitionId = Competitions.Id";
            _UserControlCompetitors.gridControlCompetitors.DataSource = SqliteDbAccess.ReturnDataTable(sqlStr, null);
            this.Close();
        }
    }
}
