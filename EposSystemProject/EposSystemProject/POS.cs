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
    public partial class POS : Form
    {

        private BindingList<TblProduct> products = new BindingList<TblProduct>();

        private EposSystemDatabaseDataSet esds = new EposSystemDatabaseDataSet(); 

        public POS()
        {
            InitializeComponent();

            listProductClicked.DataSource = products;
            listProductClicked.DisplayMember = "Description";
        }

        //private void createTabbedPanel()
        //{
        //    foreach(TblProductType pt in esds.TblProductType)
        //    {
        //        tabControl1.TabPages.Add(pt.ProductType.ToString(), pt.Description);
        //    }
        //}

        private void POS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TblProduct p = new TblProduct() { Description = "Apple", Price = 1.50M };
            products.Add(p);
        }

        private void FormatListItem(object sender, ListControlConvertEventArgs e)
        {
            string currentDescription = ((TblProduct)e.ListItem).Description;
            string currentPrice = String.Format("{0:c}",((TblProduct)e.ListItem).Price);
            string currentDescriptionPadded = currentDescription.PadRight(50);

            e.Value = currentDescriptionPadded + currentPrice;
        }
    }
}
