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
    public partial class UserControlCompetitors : UserControl
    {
        public static UserControlCompetitors _UserControlCompetitors;
        public UserControlCompetitors()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _UserControlCompetitors = this;
            var sqlStr = "SELECT " +
                         "Competitors.Id,Competitors.Name,Competitors.City,Competitors.School, Competitors.Phone,Competitors.CompetitionId,Competitions.Name As CompetitionName " +
                         "FROM " +
                         "Competitors " +
                         "INNER JOIN " +
                         "Competitions " +
                         "ON " +
                         "Competitors.CompetitionId = Competitions.Id";
                        
            gridControlCompetitors.DataSource = SqliteDbAccess.ReturnDataTable(sqlStr, null);
        }
    }
}