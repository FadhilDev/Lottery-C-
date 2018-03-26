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
    public partial class UserControlGifts : UserControl
    {
        public static UserControlGifts _UserControlGifts;
        public UserControlGifts()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _UserControlGifts = this;
            gridControlGifts.DataSource = SqliteDbAccess.ReturnDataTable("SELECT * FROM Gifts", null);
        }
    }
}
