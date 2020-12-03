using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace _45DataBase
{
    public partial class Form1 : Form
    {
        private IDbConnection db;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDBLoad_Click(object sender, EventArgs e)
        {

        }

        private void DBConnect()
        {
            db = new SqlConnection("Data Source=localhost;Initial Catalog=pubs;Integrated Security=False;User Id=niceman5;Password=gustnr35;MultipleActiveResultSets=True;");
            
            string sql = "SELECT * FROM pubs.DBO.authors";

            db.Query<AttacheFileModel>(sql, commandType: CommandType.Text).ToList();
        }
    }
}
