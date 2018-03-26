using System;
using System.Data.SQLite;
using System.Windows.Forms;
using CompeteSystem.DAL;
using static CompeteSystem.CL.UserControlGifts;
namespace CompeteSystem.VL
{
    public partial class FrmGiftsAdd : Form
    {
        public FrmGiftsAdd()
        {
            InitializeComponent();
        }

        private void btnCancele_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                return;
            }
            SQLiteParameter[] prm = new SQLiteParameter[1];
            prm[0] = new SQLiteParameter("@Name", txtName.Text);
            SqliteDbAccess.ExcuteData("INSERT INTO Gifts(Name) values (@Name)", prm);
            _UserControlGifts.gridControlGifts.DataSource = SqliteDbAccess.ReturnDataTable("SELECT * FROM Gifts", null);
            this.Close();
        }
    }
}
