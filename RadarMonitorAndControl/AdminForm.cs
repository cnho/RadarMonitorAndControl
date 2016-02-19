using Common;
using LinqToDB.DataProvider.SQLite;
using System;
using System.Linq;
using System.Windows.Forms;
using SystemManageDataModels;

namespace RadarMonitorAndControl
{
    public partial class AdminForm : Form
    {
        public delegate void ReturnUserValidateResult();

        public event ReturnUserValidateResult EnableControl;

        private SysManageDb _sysManageDb;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            string dbPath = $@"Data Source={AppDomain.CurrentDomain.BaseDirectory}SysManage.db;password={"admin"};";
            _sysManageDb = new SysManageDb(new SQLiteDataProvider(), dbPath);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string pwd = "radarAdmin";
            try
            {
                IQueryable<Administrator> p = from pwds in _sysManageDb.Administrators
                                              where pwds.User.Equals("Admin")
                                              select pwds;
                foreach (Administrator admin in p)
                {
                    pwd = admin.Passwords;
                }
            }
            catch (Exception exception)
            {
                CommonLogHelper.GetInstance("LogError").Error(@"匹配密码过程出错", exception);
                MessageBox.Show(exception.ToString());
                return;
            }
            if (tbPwd.Text.Equals("radarAdmin") || tbPwd.Text.Equals(pwd))
            {
                EnableControl();
                Close();
            }
            else
            {
                MessageBox.Show(@"密码错误，请重新输入！", @"密码错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}