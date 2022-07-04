
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.context;

namespace Acounting.App
{
    public partial class frmCustomer : Form
    {

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void ااا_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frmAdd = new frmAddOrEdit();
           if(frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvCustomer.AutoGenerateColumns = false;
                dgvCustomer.DataSource = db.customerRepository.GetAllCustomers();
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                dgvCustomer.DataSource = db.customerRepository.GetCustomersByFilter(txtFilter.Text);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
            txtFilter.Text = null;
        }
        
        private void btnDeletCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string Name = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($" آیا از حذف {Name} مطمین هستید", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        int customerId = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString());
                        db.customerRepository.DeleteCustomer(customerId);
                        db.Save();
                        BindGrid();

                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا شخص را انتخاب کنید");
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                int customerId = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdit frmAddOrEdit = new frmAddOrEdit();
                frmAddOrEdit.customerId = customerId;

                if(frmAddOrEdit.ShowDialog()== DialogResult.OK)
                {
                    BindGrid();
                }



            }
        }
    }
}
