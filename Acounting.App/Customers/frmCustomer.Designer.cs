
namespace Acounting.App
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnEditCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnDeletCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نام = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.موبایل = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ایمیل = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.آدرس = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewCustomer,
            this.btnEditCustomer,
            this.btnDeletCustomer,
            this.btnRefresh,
            this.toolStripLabel1,
            this.txtFilter,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Image = global::Acounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnNewCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(89, 64);
            this.btnNewCustomer.Text = "شخص جدید";
            this.btnNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewCustomer.Click += new System.EventHandler(this.ااا_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.Image = global::Acounting.App.Properties.Resources._1371475973_document_edit;
            this.btnEditCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(110, 64);
            this.btnEditCustomer.Text = "ویرایش اشخاص";
            this.btnEditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeletCustomer
            // 
            this.btnDeletCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletCustomer.Image = global::Acounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDeletCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeletCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletCustomer.Name = "btnDeletCustomer";
            this.btnDeletCustomer.Size = new System.Drawing.Size(90, 64);
            this.btnDeletCustomer.Text = "حذف شخص";
            this.btnDeletCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeletCustomer.Click += new System.EventHandler(this.btnDeletCustomer_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Acounting.App.Properties.Resources._1371476368_Synchronize;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 64);
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 64);
            this.toolStripLabel1.Text = "جستجو :";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 67);
            this.txtFilter.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.نام,
            this.موبایل,
            this.ایمیل,
            this.آدرس,
            this.Column6});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 67);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(582, 286);
            this.dgvCustomer.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomersID";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // نام
            // 
            this.نام.DataPropertyName = "FullName";
            this.نام.HeaderText = "نام";
            this.نام.MinimumWidth = 6;
            this.نام.Name = "نام";
            this.نام.ReadOnly = true;
            // 
            // موبایل
            // 
            this.موبایل.DataPropertyName = "Mobile";
            this.موبایل.HeaderText = "موبایل";
            this.موبایل.MinimumWidth = 6;
            this.موبایل.Name = "موبایل";
            this.موبایل.ReadOnly = true;
            // 
            // ایمیل
            // 
            this.ایمیل.DataPropertyName = "Email";
            this.ایمیل.HeaderText = "ایمیل";
            this.ایمیل.MinimumWidth = 6;
            this.ایمیل.Name = "ایمیل";
            this.ایمیل.ReadOnly = true;
            // 
            // آدرس
            // 
            this.آدرس.DataPropertyName = "Address";
            this.آدرس.HeaderText = "آدرس";
            this.آدرس.MinimumWidth = 6;
            this.آدرس.Name = "آدرس";
            this.آدرس.ReadOnly = true;
            this.آدرس.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CustomerImage";
            this.Column6.HeaderText = "عکس کاربر";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست اشخاص";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewCustomer;
        private System.Windows.Forms.ToolStripButton btnEditCustomer;
        private System.Windows.Forms.ToolStripButton btnDeletCustomer;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn نام;
        private System.Windows.Forms.DataGridViewTextBoxColumn موبایل;
        private System.Windows.Forms.DataGridViewTextBoxColumn ایمیل;
        private System.Windows.Forms.DataGridViewTextBoxColumn آدرس;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}