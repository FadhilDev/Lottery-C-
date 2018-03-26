using System;
using System.Windows.Forms;
using static CompeteSystem.VL.FrmMain;
namespace CompeteSystem.VL
{
    public partial class FrmWait : Form
    {
        public FrmWait()
        {
            InitializeComponent();
            timer.Enabled = true;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }
        private int _value = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_value >100)
            {
                _value = 0;
                timer.Enabled = false;
                this.Close();
                 _FrmMain.navBarControl.ActiveGroupName = "navBarGroupWinners";
            }
            circularProgressBar1.Text = _value+ @"%";
            circularProgressBar1.Value = _value;
            circularProgressBar1.Update();
            _value++;
        }
    }
}
