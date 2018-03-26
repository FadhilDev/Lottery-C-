using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using CompeteSystem.DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using static CompeteSystem.CL.UserControlCompetitors;
namespace CompeteSystem.VL
{
    public partial class FrmImport : Form
    {
        DataTable dt = new DataTable();
        public FrmImport()
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


        private object[] GetExcelSheetNames(string fullFileName, string dataProvider)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt22 = null;

            try
            {
                // Connection String. Change the excel file to the file you
                // will search.
                string connectionString = "";

                string prop = "";
                if (comboBoxEdit1.SelectedIndex == 0)
                {
                    prop = "Extended Properties='Excel 8.0';";
                }
                else
                {
                    prop = "Extended Properties='Excel 12.0';";

                }
                connectionString = $"Provider={dataProvider}; data source={fullFileName};{prop}";

                // Create connection object by using the preceding connection string.
                objConn = new OleDbConnection(connectionString);
                // Open connection with the database.
                objConn.Open();
                // Get the data table containg the schema guid.
                dt22 = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (dt22 == null)
                {
                    return null;
                }

                String[] excelSheets = new String[dt22.Rows.Count];
                int i = 0;

                // Add the sheet name to the string array.
                foreach (DataRow row in dt22.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString().Replace("$", "").Replace("'", "");
                    i++;
                }

                return excelSheets;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // Clean up.
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt22 != null)
                {
                    dt22.Dispose();
                }
            }
        }

        public DataTable OpenFile(string fullFileName, string dataProvider, string XlsTableName)
        {
            try
            {
                if (!File.Exists(fullFileName))
                {
                    MessageBox.Show(@"الملف غير موجود");
                    return null;
                }
                string connectionString = "";

                string prop = "";
                if (comboBoxEdit1.SelectedIndex == 0)
                {
                    prop = "Extended Properties='Excel 8.0';";
                }
                else
                {
                    prop = "Extended Properties='Excel 12.0';";

                }
                connectionString = $"Provider={dataProvider}; data source={fullFileName};{prop}";


                var adapter = new OleDbDataAdapter($"select * from [{XlsTableName}$]", connectionString);
                var ds = new DataSet();
                string tableName = "excelData";
                adapter.Fill(ds, tableName);
                DataTable data = ds.Tables[tableName];




                return data;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(filePathBtn.Text) || string.IsNullOrWhiteSpace(comboBoxEdit1.Text) || string.IsNullOrWhiteSpace(txtTableName.Text))
            {
               // MessageBox.Show(@"خطأ", @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!splashScreenManager.IsSplashFormVisible)
            {
                splashScreenManager.ShowWaitForm();

            }
            dt = OpenFile(filePathBtn.Text, comboBoxEdit1.Text, txtTableName.Text);

            gridControl1.DataSource = dt;

            if (splashScreenManager.IsSplashFormVisible)
            {
                splashScreenManager.CloseWaitForm();

            }
        }

        private void filePathBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathBtn.Text = openFileDialog.FileName;
                txtTableName.Properties.Items.Clear();
                txtTableName.Text = null;
                txtTableName.Properties.Items.AddRange(GetExcelSheetNames(filePathBtn.Text, comboBoxEdit1.Text));

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dt == null || lookUpEditCompetitions.EditValue == null) return;
            if (!splashScreenManager.IsSplashFormVisible)
            {
                splashScreenManager.ShowWaitForm();

            }
            foreach (DataRow row in dt.Rows)
            {
                var prm = new SQLiteParameter[5];
                prm[0] = new SQLiteParameter("@Name", row[0]);
                prm[1] = new SQLiteParameter("@City",row[1]);
                prm[2] = new SQLiteParameter("@School", row[2]);
                prm[3] = new SQLiteParameter("@Phone",row[3]);
                prm[4] = new SQLiteParameter("@CompetitionId", lookUpEditCompetitions.EditValue);
                SqliteDbAccess.ExcuteData("INSERT INTO Competitors(Name,City,School,Phone,CompetitionId) VALUES (@Name,@City,@School,@Phone,@CompetitionId)", prm); 
            }
            var sqlStr = "SELECT " +
                         "Competitors.Id,Competitors.Name,Competitors.City,Competitors.School, Competitors.Phone,Competitors.CompetitionId,Competitions.Name As CompetitionName " +
                         "FROM " +
                         "Competitors " +
                         "INNER JOIN " +
                         "Competitions " +
                         "ON " +
                         "Competitors.CompetitionId = Competitions.Id";
            _UserControlCompetitors.gridControlCompetitors.DataSource = SqliteDbAccess.ReturnDataTable(sqlStr, null);
            if (splashScreenManager.IsSplashFormVisible)
            {
                splashScreenManager.CloseWaitForm();

            }
            this.Close();
        }
        private void btnCancele_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
