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
        IAuthorsRepository authorsRepository;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDBLoad_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            authorsRepository = new AuthorsRepository();
            dgData.DataSource = authorsRepository.GetAuthorsAll();
        }
    }
}
