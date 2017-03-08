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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            clsDB db = new EposSystemProject.clsDB();
            DataSet ds = new DataSet();
            ds = db.SelectCommand("SELECT * FROM TblProductType");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //  ProType = Convert.ToInt16(ds.Tables[0].Rows[i]["ProductType"]);
                //   Description = ds.Tables[0].Rows[i]["Description"].ToString();
                comboBox1.Items.Add(ds.Tables[0].Rows[i]["Description"].ToString());
            }
        }
    }
}
