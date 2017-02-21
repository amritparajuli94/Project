using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EposSystemProject
{
    public partial class ViewProducts : Form
    {

        private EposSystemDatabaseDataSet esds = new EposSystemDatabaseDataSet();

        public ViewProducts()
        {
            InitializeComponent();

            dataGridView1.DataSource = esds.TblProduct;
        }
    }
}
