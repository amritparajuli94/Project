using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EposSystemProject
{
    public partial class AddProduct : Form
    {

        private EposSystemDatabaseDataSet esds = new EposSystemDatabaseDataSet();
        private Byte[] byteBLOBData;

        public AddProduct()
        {
            InitializeComponent();

            cmbCategory.DataSource = esds.TblProductType;
            cmbCategory.DisplayMember = "Description";
            cmbCategory.ValueMember = "ProductType";

            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                FileStream fsBLOBFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                byteBLOBData = new Byte[fsBLOBFile.Length];
                fsBLOBFile.Read(byteBLOBData, 0, byteBLOBData.Length);
                fsBLOBFile.Close();

                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);

                pictureBox1.Image = Image.FromStream(stmBLOBData);
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TblProduct product = new TblProduct();

            product.Description = textBox1.Text;
            product.Price = decimal.Parse(textBox2.Text);
            product.Image = byteBLOBData;
            product.ProductType = (int)cmbCategory.SelectedValue;

            esds.AddToTblProduct(product);
            esds.SaveChanges();

            MessageBox.Show("Product has been Successfully added.");
        }
    }
}
