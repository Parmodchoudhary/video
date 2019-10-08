namespace video
{
    partial class Customer
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
            this.components = new System.ComponentModel.Container();
            this.phone_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.custid_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.custid_text = new System.Windows.Forms.TextBox();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.address_text = new System.Windows.Forms.TextBox();
            this.lname_text = new System.Windows.Forms.TextBox();
            this.fname_text = new System.Windows.Forms.TextBox();
            this.addcustomer_button = new System.Windows.Forms.Button();
            this.customer_Grid = new System.Windows.Forms.DataGridView();
            this.Srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet6 = new video.Database1DataSet6();
            this.customerTableAdapter = new video.Database1DataSet6TableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customer_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(30, 171);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(49, 17);
            this.phone_label.TabIndex = 27;
            this.phone_label.Text = "Phone";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(28, 141);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(60, 17);
            this.address_label.TabIndex = 26;
            this.address_label.Text = "Address";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Location = new System.Drawing.Point(16, 99);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(76, 17);
            this.lname_label.TabIndex = 25;
            this.lname_label.Text = "Last Name";
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Location = new System.Drawing.Point(12, 60);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(76, 17);
            this.fname_label.TabIndex = 24;
            this.fname_label.Text = "First Name";
            // 
            // custid_label
            // 
            this.custid_label.AutoSize = true;
            this.custid_label.Location = new System.Drawing.Point(30, 17);
            this.custid_label.Name = "custid_label";
            this.custid_label.Size = new System.Drawing.Size(47, 17);
            this.custid_label.TabIndex = 23;
            this.custid_label.Text = "Custid";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(270, 228);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(112, 41);
            this.delete_button.TabIndex = 22;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(148, 228);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(116, 41);
            this.update_button.TabIndex = 21;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // custid_text
            // 
            this.custid_text.Enabled = false;
            this.custid_text.Location = new System.Drawing.Point(98, 14);
            this.custid_text.Name = "custid_text";
            this.custid_text.Size = new System.Drawing.Size(192, 22);
            this.custid_text.TabIndex = 20;
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(98, 171);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(73, 22);
            this.phone_text.TabIndex = 19;
            // 
            // address_text
            // 
            this.address_text.Location = new System.Drawing.Point(98, 136);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(100, 22);
            this.address_text.TabIndex = 18;
            // 
            // lname_text
            // 
            this.lname_text.Location = new System.Drawing.Point(98, 94);
            this.lname_text.Name = "lname_text";
            this.lname_text.Size = new System.Drawing.Size(100, 22);
            this.lname_text.TabIndex = 17;
            // 
            // fname_text
            // 
            this.fname_text.Location = new System.Drawing.Point(98, 55);
            this.fname_text.Name = "fname_text";
            this.fname_text.Size = new System.Drawing.Size(88, 22);
            this.fname_text.TabIndex = 16;
            // 
            // addcustomer_button
            // 
            this.addcustomer_button.Location = new System.Drawing.Point(24, 228);
            this.addcustomer_button.Name = "addcustomer_button";
            this.addcustomer_button.Size = new System.Drawing.Size(118, 41);
            this.addcustomer_button.TabIndex = 15;
            this.addcustomer_button.Text = "Add Customer";
            this.addcustomer_button.UseVisualStyleBackColor = true;
            this.addcustomer_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // customer_Grid
            // 
            this.customer_Grid.AutoGenerateColumns = false;
            this.customer_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Srno,
            this.custIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.customer_Grid.DataSource = this.customerBindingSource;
            this.customer_Grid.Location = new System.Drawing.Point(388, 14);
            this.customer_Grid.Name = "customer_Grid";
            this.customer_Grid.RowTemplate.Height = 24;
            this.customer_Grid.Size = new System.Drawing.Size(506, 255);
            this.customer_Grid.TabIndex = 14;
            this.customer_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Srno
            // 
            this.Srno.DataPropertyName = "CustID";
            this.Srno.HeaderText = "Srno";
            this.Srno.Name = "Srno";
            this.Srno.ReadOnly = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.database1DataSet6;
            // 
            // database1DataSet6
            // 
            this.database1DataSet6.DataSetName = "Database1DataSet6";
            this.database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 393);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.custid_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.custid_text);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.lname_text);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.addcustomer_button);
            this.Controls.Add(this.customer_Grid);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label custid_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox custid_text;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.TextBox lname_text;
        private System.Windows.Forms.TextBox fname_text;
        private System.Windows.Forms.Button addcustomer_button;
        private System.Windows.Forms.DataGridView customer_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srno;
        private Database1DataSet6 database1DataSet6;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Database1DataSet6TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}