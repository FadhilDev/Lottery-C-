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
    public partial class UserControlWinners : UserControl
    {
        public static UserControlWinners _UserControlWinners;
        public UserControlWinners()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            _UserControlWinners = this;
            var sqlStr = "SELECT " +
                         "Competitors.Id,Competitors.Name,Competitors.City,Competitors.School, Competitors.Phone,Competitions.Name As CompetitionName, Gifts.Name As GiftName " +
                         "FROM " +
                         "Competitors " +
                         "INNER JOIN " +
                         "Competitions " +
                         "ON " +
                         "Competitors.CompetitionId = Competitions.Id " +
                         "INNER JOIN " +
                         "Gifts " +
                         "ON " +
                         "Competitors.GiftId = Gifts.Id";
            gridControlWinners.DataSource = SqliteDbAccess.ReturnDataTable(sqlStr, null);
        }
    }
}
