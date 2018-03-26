using System;
using System.Data.SQLite;
using System.Windows.Forms;
using CompeteSystem.DAL;
using static CompeteSystem.CL.UserControlGifts;
namespace CompeteSystem.VL
{
    public partial class FrmGiftsEdit : Form
    {
        public FrmGiftsEdit()
        {
            InitializeComponent();
        }

        private void btnCancele_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_UserControlGifts.gridViewGifts.IsDataRow(_UserControlGifts.gridViewGifts.FocusedRowHandle))
                return;
            var id = Convert.ToInt32(_UserControlGifts.gridViewGifts.GetFocusedRowCellValue("Id"));
            if (txtName.Text == string.Empty)
            {
                return;
            }
            SQLiteParameter[] prm = new SQLiteParameter[2];
            prm[0] = new SQLiteParameter("@Id", id);
            prm[1] = new SQLiteParameter("@Name", txtName.Text);

            SqliteDbAccess.ExcuteData("UPDATE  Gifts SET Name=@Name WHERE Id=@Id ", prm);
            _UserControlGifts.gridControlGifts.DataSource = SqliteDbAccess.ReturnDataTable("SELECT * FROM Gifts", null);
            this.Close();
        }
    }
}
