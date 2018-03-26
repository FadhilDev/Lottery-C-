using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompeteSystem.DAL;

namespace CompeteSystem.CL
{
    public partial class UserControlCompetitions : UserControl
    {
        public static UserControlCompetitions _UserControlCompetitions;
        public UserControlCompetitions()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            _UserControlCompetitions = this;
            gridControlCompetitions.DataSource = SqliteDbAccess.ReturnDataTable("SELECT * FROM Competitions", null);
 
        }
    }
}
