using System;
using System.Data.SQLite;
using System.Windows.Forms;
using CompeteSystem.DAL;
using static CompeteSystem.CL.UserControlCompetitions;
namespace CompeteSystem.VL
{
    public partial class FrmCompetitionsEdit : Form
    {
        public FrmCompetitionsEdit()
        {
            InitializeComponent();
        }

        private void btnCancele_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(! _UserControlCompetitions.gridViewCompetitions.IsDataRow(_UserControlCompetitions.gridViewCompetitions.FocusedRowHandle))
               return;
               var id=Convert.ToInt32( _UserControlCompetitions.gridViewCompetitions.GetFocusedRowCellValue("Id"));
            if (txtName.Text==string.Empty|| txtDate.Text== string.Empty)
            {
                return;
            }
            SQLiteParameter[] prm = new SQLiteParameter[3];
            prm[0] = new SQLiteParameter("@Id", id);
            prm[1] = new SQLiteParameter("@Name", txtName.Text);
            prm[2] = new SQLiteParameter("@Date", txtDate.DateTime.ToString("yyyy-MM-dd"));
          
            SqliteDbAccess.ExcuteData("UPDATE  Competitions SET Name=@Name,Date=@Date where Id=@Id ", prm);
            _UserControlCompetitions.gridControlCompetitions.DataSource= SqliteDbAccess.ReturnDataTable("SELECT * FROM Competitions", null);
            this.Close();
        }
    }
}
