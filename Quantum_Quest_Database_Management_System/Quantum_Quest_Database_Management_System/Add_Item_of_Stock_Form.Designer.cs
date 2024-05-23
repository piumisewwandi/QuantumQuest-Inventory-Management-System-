namespace Quantum_Quest_Database_Management_System
{
    partial class Add_Item_of_Stock_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Item_of_Stock_Form));
            pblogo = new PictureBox();
            lblitemnumber = new Label();
            lblitemname = new Label();
            lbldescription = new Label();
            lblquantity = new Label();
            lblunitprice = new Label();
            lbladdmessage = new Label();
            txtitemnumber = new TextBox();
            txtitemname = new TextBox();
            txtitemdescription = new TextBox();
            txtunitprice = new TextBox();
            updownquantity = new NumericUpDown();
            btnaddtostock = new Button();
            lbldate = new Label();
            dtpdate = new DateTimePicker();
            btnreturndashboard = new Button();
            btnclear = new Button();
            btnlogout = new Button();
            txtitemnumbersearch = new TextBox();
            btnsearch = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnviewtransactionlog = new Button();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updownquantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pblogo
            // 
            pblogo.BackColor = Color.Transparent;
            pblogo.Image = Properties.Resources.LOGO_03;
            pblogo.Location = new Point(-3, 0);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(277, 167);
            pblogo.SizeMode = PictureBoxSizeMode.Zoom;
            pblogo.TabIndex = 0;
            pblogo.TabStop = false;
            pblogo.Click += pblogo_Click;
            // 
            // lblitemnumber
            // 
            lblitemnumber.AutoSize = true;
            lblitemnumber.BackColor = Color.Transparent;
            lblitemnumber.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblitemnumber.ForeColor = Color.White;
            lblitemnumber.Location = new Point(131, 218);
            lblitemnumber.Name = "lblitemnumber";
            lblitemnumber.Size = new Size(113, 23);
            lblitemnumber.TabIndex = 1;
            lblitemnumber.Text = "Item Number";
            // 
            // lblitemname
            // 
            lblitemname.AutoSize = true;
            lblitemname.BackColor = Color.Transparent;
            lblitemname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblitemname.ForeColor = Color.White;
            lblitemname.Location = new Point(131, 260);
            lblitemname.Name = "lblitemname";
            lblitemname.Size = new Size(96, 23);
            lblitemname.TabIndex = 2;
            lblitemname.Text = "Item Name";
            lblitemname.Click += lblitemname_Click;
            // 
            // lbldescription
            // 
            lbldescription.AutoSize = true;
            lbldescription.BackColor = Color.Transparent;
            lbldescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbldescription.ForeColor = Color.White;
            lbldescription.Location = new Point(128, 307);
            lbldescription.Name = "lbldescription";
            lbldescription.Size = new Size(96, 23);
            lbldescription.TabIndex = 3;
            lbldescription.Text = "Description";
            // 
            // lblquantity
            // 
            lblquantity.AutoSize = true;
            lblquantity.BackColor = Color.Transparent;
            lblquantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblquantity.ForeColor = Color.White;
            lblquantity.Location = new Point(129, 420);
            lblquantity.Name = "lblquantity";
            lblquantity.Size = new Size(82, 23);
            lblquantity.TabIndex = 4;
            lblquantity.Text = "Quantity ";
            lblquantity.Click += label4_Click;
            // 
            // lblunitprice
            // 
            lblunitprice.AutoSize = true;
            lblunitprice.BackColor = Color.Transparent;
            lblunitprice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblunitprice.ForeColor = Color.White;
            lblunitprice.Location = new Point(131, 464);
            lblunitprice.Name = "lblunitprice";
            lblunitprice.Size = new Size(125, 23);
            lblunitprice.TabIndex = 5;
            lblunitprice.Text = "Unit Price(LKR)";
            // 
            // lbladdmessage
            // 
            lbladdmessage.AutoSize = true;
            lbladdmessage.BackColor = Color.Transparent;
            lbladdmessage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbladdmessage.ForeColor = Color.White;
            lbladdmessage.Location = new Point(26, 158);
            lbladdmessage.Name = "lbladdmessage";
            lbladdmessage.Size = new Size(573, 25);
            lbladdmessage.TabIndex = 6;
            lbladdmessage.Text = "Please fill out the following sections to add a new item to the stock";
            // 
            // txtitemnumber
            // 
            txtitemnumber.Location = new Point(329, 214);
            txtitemnumber.Name = "txtitemnumber";
            txtitemnumber.Size = new Size(310, 27);
            txtitemnumber.TabIndex = 7;
            // 
            // txtitemname
            // 
            txtitemname.Location = new Point(329, 260);
            txtitemname.Name = "txtitemname";
            txtitemname.Size = new Size(310, 27);
            txtitemname.TabIndex = 8;
            // 
            // txtitemdescription
            // 
            txtitemdescription.BorderStyle = BorderStyle.FixedSingle;
            txtitemdescription.Location = new Point(328, 303);
            txtitemdescription.Multiline = true;
            txtitemdescription.Name = "txtitemdescription";
            txtitemdescription.Size = new Size(311, 65);
            txtitemdescription.TabIndex = 9;
            
            // 
            // txtunitprice
            // 
            txtunitprice.Location = new Point(329, 464);
            txtunitprice.Name = "txtunitprice";
            txtunitprice.Size = new Size(310, 27);
            txtunitprice.TabIndex = 11;
            // 
            // updownquantity
            // 
            updownquantity.Location = new Point(329, 421);
            updownquantity.Name = "updownquantity";
            updownquantity.Size = new Size(310, 27);
            updownquantity.TabIndex = 12;
            // 
            // btnaddtostock
            // 
            btnaddtostock.BackColor = Color.Transparent;
            btnaddtostock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddtostock.ForeColor = Color.Black;
            btnaddtostock.Location = new Point(490, 547);
            btnaddtostock.Name = "btnaddtostock";
            btnaddtostock.Size = new Size(224, 36);
            btnaddtostock.TabIndex = 13;
            btnaddtostock.Text = "Add to Stock";
            btnaddtostock.UseVisualStyleBackColor = false;
            btnaddtostock.Click += btnaddtostock_Click;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.BackColor = Color.Transparent;
            lbldate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbldate.ForeColor = Color.White;
            lbldate.Location = new Point(131, 377);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(46, 23);
            lbldate.TabIndex = 14;
            lbldate.Text = "Date";
            // 
            // dtpdate
            // 
            dtpdate.Location = new Point(328, 377);
            dtpdate.Name = "dtpdate";
            dtpdate.Size = new Size(311, 27);
            dtpdate.TabIndex = 15;
            // 
            // btnreturndashboard
            // 
            btnreturndashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnreturndashboard.Location = new Point(63, 587);
            btnreturndashboard.Name = "btnreturndashboard";
            btnreturndashboard.Size = new Size(211, 38);
            btnreturndashboard.TabIndex = 16;
            btnreturndashboard.Text = "Return to Admin Dashboard";
            btnreturndashboard.UseVisualStyleBackColor = true;
            btnreturndashboard.Click += btnreturndashboard_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnclear.Location = new Point(63, 547);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(211, 36);
            btnclear.TabIndex = 17;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Transparent;
            btnlogout.BackgroundImage = Properties.Resources.person_removebg_preview2;
            btnlogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnlogout.Cursor = Cursors.Hand;
            btnlogout.FlatStyle = FlatStyle.Popup;
            btnlogout.Location = new Point(672, 49);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(31, 29);
            btnlogout.TabIndex = 26;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // txtitemnumbersearch
            // 
            txtitemnumbersearch.Location = new Point(404, 49);
            txtitemnumbersearch.Name = "txtitemnumbersearch";
            txtitemnumbersearch.PlaceholderText = "Enter Item Number";
            txtitemnumbersearch.Size = new Size(235, 27);
            txtitemnumbersearch.TabIndex = 25;
            
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.Transparent;
            btnsearch.BackgroundImage = Properties.Resources.search_removebg_preview;
            btnsearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnsearch.Cursor = Cursors.Hand;
            btnsearch.FlatStyle = FlatStyle.Popup;
            btnsearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearch.Location = new Point(639, 49);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(33, 29);
            btnsearch.TabIndex = 24;
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(376, 92);
            label2.Name = "label2";
            label2.Size = new Size(348, 20);
            label2.TabIndex = 23;
            label2.Text = "Hello Admin, Welcome to Add Item of Stock Form";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.za8c6sze_removebg_preview;
            pictureBox2.Location = new Point(26, 587);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(453, 547);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 547);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // btnviewtransactionlog
            // 
            btnviewtransactionlog.BackColor = Color.White;
            btnviewtransactionlog.Cursor = Cursors.Hand;
            btnviewtransactionlog.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnviewtransactionlog.Location = new Point(490, 589);
            btnviewtransactionlog.Name = "btnviewtransactionlog";
            btnviewtransactionlog.Size = new Size(224, 36);
            btnviewtransactionlog.TabIndex = 55;
            btnviewtransactionlog.Text = "View Transaction Log";
            btnviewtransactionlog.UseVisualStyleBackColor = false;
            btnviewtransactionlog.Click += btnviewtransactionlog_Click_1;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(453, 589);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 54;
            pictureBox6.TabStop = false;
            // 
            // Add_Item_of_Stock_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(744, 639);
            Controls.Add(btnviewtransactionlog);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnlogout);
            Controls.Add(txtitemnumbersearch);
            Controls.Add(btnsearch);
            Controls.Add(label2);
            Controls.Add(btnclear);
            Controls.Add(btnreturndashboard);
            Controls.Add(dtpdate);
            Controls.Add(lbldate);
            Controls.Add(btnaddtostock);
            Controls.Add(updownquantity);
            Controls.Add(txtunitprice);
            Controls.Add(txtitemdescription);
            Controls.Add(txtitemname);
            Controls.Add(txtitemnumber);
            Controls.Add(lbladdmessage);
            Controls.Add(lblunitprice);
            Controls.Add(lblquantity);
            Controls.Add(lbldescription);
            Controls.Add(lblitemname);
            Controls.Add(lblitemnumber);
            Controls.Add(pblogo);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_Item_of_Stock_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Item of Stock";
            Load += Add_Item_of_Stock_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)updownquantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pblogo;
        private Label lblitemnumber;
        private Label lblitemname;
        private Label lbldescription;
        private Label lblquantity;
        private Label lblunitprice;
        private Label lbladdmessage;
        private TextBox txtitemnumber;
        private TextBox txtitemname;
        private TextBox txtitemdescription;
        private TextBox txtunitprice;
        private NumericUpDown updownquantity;
        private Button btnaddtostock;
        private Label lbldate;
        private DateTimePicker dtpdate;
        private Button btnreturndashboard;
        private Button btnclear;
        private Button btnlogout;
        private TextBox txtitemnumbersearch;
        private Button btnsearch;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnviewtransactionlog;
        private PictureBox pictureBox6;
    }
}