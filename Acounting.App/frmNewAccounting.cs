using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.context;
using ValidationComponents;
using Accounting.DataLayer.Services;



namespace Acounting.App
{
    public partial class frmNewAccounting : Form
    {
        public frmNewAccounting()
        {
            InitializeComponent();
        }

        private void frmNewAccounting_Load(object sender, EventArgs e)
        {
            UnitOfWork db = new UnitOfWork();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.customerRepository.GetNameCustomer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UnitOfWork db = new UnitOfWork();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.customerRepository.GetNameCustomer(txtFilter.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || RbRecive.Checked)
                {
                    string typeId ;
                    if (rbPay.Checked)
                    {
                        typeId = "rbPay";
                    }
                    else
                    {
                        typeId = "RbRecive";
                    }
                    Accounting.DataLayer.Accounting accounting = new Accounting.DataLayer.Accounting()
                    {
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        Discription = txtDiscription.Text,
                        DateTitle = DateTime.Now,
                        TypeID =int.Parse(typeId),
                        
                       
                    }
                 



                }

            }
        }
    }
}
