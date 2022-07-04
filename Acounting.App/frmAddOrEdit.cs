﻿using System;
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
using System.IO;







namespace Acounting.App
{
    public partial class frmAddOrEdit : Form
    {

        public int customerId = 0;
        UnitOfWork db = new UnitOfWork();

        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // pcCustomer.ima
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {




            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomer.Image.Save(path + imageName);
                Customers customers = new Customers()
                {
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    FullName = txtName.Text,
                    Mobile = txtMobile.Text,
                    CustomerImage = imageName
                };
                if (customerId == 0)
                {
                    db.customerRepository.InsertCustomer(customers);
                }
                else
                {
                    customers.CustomersID = customerId;
                    db.customerRepository.UpdateCustomer(customers);
                }

                db.Save();
                DialogResult = DialogResult.OK;
            }


        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                var customer = db.customerRepository.GetCustomersById(customerId);
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                txtMobile.Text = customer.Mobile;
                txtName.Text = customer.FullName;
                pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
            }
        }
        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                var customer = db.customerRepository.GetCustomersById(customerId);
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                txtMobile.Text = customer.Mobile;
                txtName.Text = customer.FullName;
                pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
            }
        }
    }




 

}
