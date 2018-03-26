using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompeteSystem.DAL;
using static CompeteSystem.CL.UserControlCompetitions;

namespace CompeteSystem.VL
{
    public partial class FrmCompetitionsAdd : Form
    {
        public FrmCompetitionsAdd()
        {
            InitializeComponent();
        }

        private void btnCancele_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtDate.Text == string.Empty)
            {
                return;
            }
            SQLiteParameter[] prm = new SQLiteParameter[2];
                prm[0] = new SQLiteParameter("@Name", txtName.Text);
                prm[1] = new SQLiteParameter("@Date", txtDate.DateTime.ToString("yyyy-MM-dd"));
                SqliteDbAccess.ExcuteData("INSERT INTO Competitions(Name,Date) VALUES (@Name,@Date)", prm);
               _UserControlCompetitions.gridControlCompetitions.DataSource = SqliteDbAccess.ReturnDataTable("SELECT * FROM Competitions", null);
            this.Close();
        }
    }
}
