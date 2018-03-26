using System;
using System.Data.SQLite;
using System.Windows.Forms;
using CompeteSystem.CL;
using CompeteSystem.DAL;
using DevExpress.XtraEditors;
using static CompeteSystem.CL.UserControlCompetitions;
using static CompeteSystem.CL.UserControlCompetitors;
using static CompeteSystem.CL.UserControlGifts;
using static CompeteSystem.CL.UserControlWinners;
namespace CompeteSystem.VL
{
    public partial class FrmMain :XtraForm
    {
        public static FrmMain _FrmMain;
        public FrmMain()
        {
            InitializeComponent();
            _FrmMain = this;
            navigationPageCompetitions.Controls.Add(new UserControlCompetitions());
        }
        private void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            if (!splashScreenManager.IsSplashFormVisible)
            {
                splashScreenManager.ShowWaitForm();
            }

            switch (e.Group.Name)
            {
                case "navBarGroupCompetitions":
                    navigationPageCompetitions.Controls.Clear();
                    navigationPageCompetitions.Controls.Add(new UserControlCompetitions());
                    navigationFrame.SelectedPage = navigationPageCompetitions;
                    break;
                case "navBarGroupGifts":
                    navigationPageGifts.Controls.Clear();
                    navigationPageGifts.Controls.Add(new UserControlGifts());
                    navigationFrame.SelectedPage = navigationPageGifts;
                    break;
                case "navBarGroupCompetitors":
                    navigationPageCompetitors.Controls.Clear();
                    navigationPageCompetitors.Controls.Add(new UserControlCompetitors());
                    navigationFrame.SelectedPage = navigationPageCompetitors;
                    break;
                case "navBarGroupWinners":
                    navigationPageWinners.Controls.Clear();
                    navigationPageWinners.Controls.Add(new UserControlWinners());
                    navigationFrame.SelectedPage = navigationPageWinners;
                    break;
            }

            if (splashScreenManager.IsSplashFormVisible)
            {
                splashScreenManager.CloseWaitForm();
            }
        }

        private void navBarItemAddCompetitions_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new FrmCompetitionsAdd();
            frm.ShowDialog();
        }

        private void navBarItemEditCompetitions_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!_UserControlCompetitions.gridViewCompetitions.IsDataRow(_UserControlCompetitions.gridViewCompetitions.FocusedRowHandle))
                return;
            var name = _UserControlCompetitions.gridViewCompetitions.GetFocusedRowCellValue("Name").ToString();
            var date =_UserControlCompetitions.gridViewCompetitions.GetFocusedRowCellValue("Date").ToString();
            var frm = new FrmCompetitionsEdit
            {
                txtName = {Text = name},
                txtDate = {DateTime = Convert.ToDateTime(date)}
            };
            frm.ShowDialog();
        }

        private void navBarItemDelCompetitions_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!_UserControlCompetitions.gridViewCompetitions.IsDataRow(_UserControlCompetitions.gridViewCompetitions.FocusedRowHandle))
                return;

            var id = _UserControlCompetitions.gridViewCompetitions.GetFocusedRowCellValue("Id").ToString();
            var prm1 = new SQLiteParameter[1];
            prm1[0] = new SQLiteParameter("@Id", id);
            var dtCheck = SqliteDbAccess.ReturnDataTable("SELECT * FROM Competitors WHERE CompetitionId=@Id", prm1);

            if (dtCheck.Rows.Count > 0)
            {
                XtraMessageBox.Show("لايمكن الحذف المسابقة مرتبطة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = XtraMessageBox.Show("هل تريد الحذف فعلا؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;
            var prm2 = new SQLiteParameter[1];
            prm2[0] = new SQLiteParameter("@Id", id);
            SqliteDbAccess.ExcuteData("DELETE FROM Competitions WHERE Id=@Id", prm2);
            _UserControlCompetitions.gridControlCompetitions.DataSource = SqliteDbAccess.ReturnDataTable("SELECT * FROM Competitions", null);
        }

        private void navBarItemAddCompetitors_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm=new FrmCompetitorsAdd();
            frm.ShowDialog();
        }

        private void navBarItemEditCompetitors_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!_UserControlCompetitors.gridViewCompetitors.IsDataRow(_UserControlCompetitors.gridViewCompetitors.FocusedRowHandle))
                return;
            var name = _UserControlCompetitors.gridViewCompetitors.GetFocusedRowCellValue("Name").ToString();
            var city = _UserControlCompetitors.gridViewCompetitors.GetFocusedRowCellValue("City").ToString();
            var school = _UserControlCompetitors.gridViewCompetitors.GetFocusedRowCellValue("School").ToString();
            var phone = _UserControlCompetitors.gridViewCompetitors.GetFocusedRowCellValue("Phone").ToString();
            var editValue = _UserControlCompetitors.gridViewCompetitors.GetFocusedRowCellValue("CompetitionId").ToString();
            var frm = new FrmCompetitorsEdit
            {
                txtName = {Text = name},
                txtCity = {Text = city},
                txtSchool = {Text = school},
                txtPhone = {Text = phone},
                lookUpEditCompetitions = {EditValue = editValue}
            };
            frm.ShowDialog();
        }

        private void navBarItemDelCompetitors_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!_UserControlCompetitors.gridViewCompetitors.IsDataRow(_UserControlCompetitors.gridViewCompetitors.FocusedRowHandle))
                return;
            var result = XtraMessageBox.Show("هل تريد الحذف فعلا؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;
            var id = _UserControlCompetitors.gridViewCompetitors.GetFocusedRowCellValue("Id").ToString();
            var prm = new SQLiteParameter[1];
            prm[0] = new SQLiteParameter("@Id", id);
            SqliteDbAccess.ExcuteData("DELETE FROM Competitors WHERE Id=@Id", prm);
            var sqlStr = "SELECT " +
                         "Competitors.Id,Competitors.Name,Competitors.City,Competitors.School, Competitors.Phone,Competitors.CompetitionId,Competitions.Name As CompetitionName " +
                         "FROM " +
                         "Competitors " +
                         "INNER JOIN " +
                         "Competitions " +
                         "ON " +
                         "Competitors.CompetitionId = Competitions.Id";
            _UserControlCompetitors.gridControlCompetitors.DataSource = SqliteDbAccess.ReturnDataTable(sqlStr, null);
        }

        private void navBarItemStartLottery_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm = new FrmLottery();
            frm.ShowDialog();
        }

        private void navBarItemDelGifts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!_UserControlGifts.gridViewGifts.IsDataRow(_UserControlGifts.gridViewGifts.FocusedRowHandle))
                return;

            var id = _UserControlGifts.gridViewGifts.GetFocusedRowCellValue("Id").ToString();
            var prm1 = new SQLiteParameter[1];
            prm1[0] = new SQLiteParameter("@Id", id);
            var dtCheck=SqliteDbAccess.ReturnDataTable("SELECT * FROM Competitors WHERE GiftId=@Id", prm1);

            if (dtCheck.Rows.Count>0)
            {
                XtraMessageBox.Show("لايمكن الحذف الهدية مرتبطة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = XtraMessageBox.Show("هل تريد الحذف فعلا؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;
            var prm2 = new SQLiteParameter[1];
            prm2[0] = new SQLiteParameter("@Id", id);
            SqliteDbAccess.ExcuteData("DELETE FROM Gifts WHERE Id=@Id", prm2);
            _UserControlGifts.gridControlGifts.DataSource = SqliteDbAccess.ReturnDataTable("SELECT * FROM Gifts", null);
        }

        private void navBarItemAddGifts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm=new FrmGiftsAdd();
            frm.ShowDialog();
        }

        private void navBarItemEditGifts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!_UserControlGifts.gridViewGifts.IsDataRow(_UserControlGifts.gridViewGifts.FocusedRowHandle))
                return;
            var name = _UserControlGifts.gridViewGifts.GetFocusedRowCellValue("Name").ToString();
            var frm = new FrmGiftsEdit {txtName = {Text = name}};
            frm.ShowDialog();
        }

        private void navBarItemEditWinners_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            var ids ="";
            for (var i = 0; i < _UserControlWinners.gridViewWinners.SelectedRowsCount; i++)
            {
                if (_UserControlWinners.gridViewWinners.GetSelectedRows()[i] >= 0)
                ids+=","+Convert.ToString( _UserControlWinners.gridViewWinners.GetDataRow(_UserControlWinners.gridViewWinners
                    .GetSelectedRows()[i])["Id"]);

            }

            if (ids.Length <= 0) return;

            ids = ids.Substring(1, ids.Length - 1);
            var sqlStr1 = "UPDATE Competitors SET GiftId=0 WHERE Id IN("+ ids + ")";
            SqliteDbAccess.ExcuteData(sqlStr1, null);


            var sqlStr2 = "SELECT " +
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
                          "Competitors.GiftId = Gifts.Id ";
            _UserControlWinners.gridControlWinners.DataSource = SqliteDbAccess.ReturnDataTable(sqlStr2, null);
        }

        private void navBarItemImportCompetitors_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var frm=new FrmImport();
            frm.ShowDialog();
        }

        private void navBarItemExportWinners_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog { Title = @"تصدير", Filter = @"Excel(*.xls)|*.xlsx", FileName = "Report" + System.DateTime.Now.ToString("-yyyy-MM-dd") })
            {
                var dialogResult = saveFileDialog.ShowDialog(this);
                if (dialogResult != DialogResult.OK) return;
                var options = new DevExpress.XtraPrinting.XlsxExportOptions
                {
                    TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value,
                    ExportMode = DevExpress.XtraPrinting.XlsxExportMode.SingleFile,
                    ShowGridLines = true,
                    SheetName = this.Text
                };
                _UserControlWinners.gridViewWinners.ExportToXlsx(saveFileDialog.FileName, options);
            }
        }
        
    }
}


