namespace Quantum_Quest_Database_Management_System
{
    partial class Add_Quantity_to_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Quantity_to_Stock));
            pictureBox1 = new PictureBox();
            btnlogout = new Button();
            txtitemnumbersearch = new TextBox();
            btnsearch = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblquantityofitem = new Label();
            txtquantityofitem = new TextBox();
            btnaddquantitytoitem = new Button();
            btnreturntoadmindashboard = new Button();
            label3 = new Label();
            btnadditem = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblcurrentquantity = new Label();
            txtcurrentquantity = new TextBox();
            lblitemname = new Label();
            txtitemname = new TextBox();
            txtprice = new Label();
            txtunitprice = new TextBox();
            lbldate = new Label();
            dtptransactiondate = new DateTimePicker();
            pictureBox6 = new PictureBox();
            btnviewtransactionlog = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.LOGO_03;
            pictureBox1.Location = new Point(124, 747);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Transparent;
            btnlogout.BackgroundImage = Properties.Resources.person_removebg_preview2;
            btnlogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnlogout.Cursor = Cursors.Hand;
            btnlogout.FlatStyle = FlatStyle.Popup;
            btnlogout.Location = new Point(704, 54);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(31, 29);
            btnlogout.TabIndex = 30;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // txtitemnumbersearch
            // 
            txtitemnumbersearch.Location = new Point(436, 54);
            txtitemnumbersearch.Name = "txtitemnumbersearch";
            txtitemnumbersearch.PlaceholderText = "Enter Item Number";
            txtitemnumbersearch.Size = new Size(235, 27);
            txtitemnumbersearch.TabIndex = 29;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.Transparent;
            btnsearch.BackgroundImage = Properties.Resources.search_removebg_preview;
            btnsearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnsearch.Cursor = Cursors.Hand;
            btnsearch.FlatStyle = FlatStyle.Popup;
            btnsearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearch.Location = new Point(671, 54);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(33, 29);
            btnsearch.TabIndex = 28;
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(417, 96);
            label2.Name = "label2";
            label2.Size = new Size(318, 20);
            label2.TabIndex = 27;
            label2.Text = "Hello Admin, Welcome to Add Quantity Form";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.LOGO_03;
            pictureBox2.Location = new Point(2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 185);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 238);
            label1.Name = "label1";
            label1.Size = new Size(458, 20);
            label1.TabIndex = 32;
            label1.Text = "Please fill out the following section to add quantity to a stock item";
            // 
            // lblquantityofitem
            // 
            lblquantityofitem.AutoSize = true;
            lblquantityofitem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblquantityofitem.Location = new Point(159, 382);
            lblquantityofitem.Name = "lblquantityofitem";
            lblquantityofitem.Padding = new Padding(25, 5, 25, 5);
            lblquantityofitem.Size = new Size(172, 30);
            lblquantityofitem.TabIndex = 33;
            lblquantityofitem.Text = "Quantity to Add";
            // 
            // txtquantityofitem
            // 
            txtquantityofitem.Location = new Point(417, 385);
            txtquantityofitem.Name = "txtquantityofitem";
            txtquantityofitem.PlaceholderText = "Enter quantity should be added";
            txtquantityofitem.Size = new Size(253, 27);
            txtquantityofitem.TabIndex = 34;
            // 
            // btnaddquantitytoitem
            // 
            btnaddquantitytoitem.BackColor = Color.White;
            btnaddquantitytoitem.Cursor = Cursors.Hand;
            btnaddquantitytoitem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddquantitytoitem.Location = new Point(502, 546);
            btnaddquantitytoitem.Name = "btnaddquantitytoitem";
            btnaddquantitytoitem.Size = new Size(233, 36);
            btnaddquantitytoitem.TabIndex = 35;
            btnaddquantitytoitem.Text = "Add Quantity to the Item";
            btnaddquantitytoitem.UseVisualStyleBackColor = false;
            btnaddquantitytoitem.Click += btnaddquantitytoitem_Click;
            // 
            // btnreturntoadmindashboard
            // 
            btnreturntoadmindashboard.BackColor = Color.White;
            btnreturntoadmindashboard.Cursor = Cursors.Hand;
            btnreturntoadmindashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnreturntoadmindashboard.Location = new Point(40, 535);
            btnreturntoadmindashboard.Name = "btnreturntoadmindashboard";
            btnreturntoadmindashboard.Size = new Size(256, 34);
            btnreturntoadmindashboard.TabIndex = 36;
            btnreturntoadmindashboard.Text = "Return to Admin Dashboard";
            btnreturntoadmindashboard.UseVisualStyleBackColor = false;
            btnreturntoadmindashboard.Click += btnreturntoadmindashboard_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 189);
            label3.Name = "label3";
            label3.Size = new Size(664, 20);
            label3.TabIndex = 37;
            label3.Text = "Please search the Item Number from the search bar , If it doesn't exists add the item to the stock ";
            // 
            // btnadditem
            // 
            btnadditem.BackColor = Color.White;
            btnadditem.Cursor = Cursors.Hand;
            btnadditem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnadditem.Location = new Point(41, 575);
            btnadditem.Name = "btnadditem";
            btnadditem.Size = new Size(256, 34);
            btnadditem.TabIndex = 38;
            btnadditem.Text = "Add Item to the Stock";
            btnadditem.UseVisualStyleBackColor = false;
            btnadditem.Click += btnadditem_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.add_removebg_preview1;
            pictureBox3.Location = new Point(467, 546);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.add_list_icon_256_removebg_preview__1_1;
            pictureBox4.Location = new Point(18, 575);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 535);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 41;
            pictureBox5.TabStop = false;
            // 
            // lblcurrentquantity
            // 
            lblcurrentquantity.AutoSize = true;
            lblcurrentquantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblcurrentquantity.Location = new Point(159, 343);
            lblcurrentquantity.Name = "lblcurrentquantity";
            lblcurrentquantity.Padding = new Padding(25, 5, 25, 5);
            lblcurrentquantity.Size = new Size(177, 30);
            lblcurrentquantity.TabIndex = 42;
            lblcurrentquantity.Text = "Current Quantity";
            // 
            // txtcurrentquantity
            // 
            txtcurrentquantity.Location = new Point(417, 340);
            txtcurrentquantity.Name = "txtcurrentquantity";
            txtcurrentquantity.Size = new Size(253, 27);
            txtcurrentquantity.TabIndex = 43;
            // 
            // lblitemname
            // 
            lblitemname.AutoSize = true;
            lblitemname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblitemname.Location = new Point(159, 303);
            lblitemname.Name = "lblitemname";
            lblitemname.Padding = new Padding(45, 5, 45, 5);
            lblitemname.Size = new Size(178, 30);
            lblitemname.TabIndex = 46;
            lblitemname.Text = "Item Name";
            // 
            // txtitemname
            // 
            txtitemname.Location = new Point(417, 300);
            txtitemname.Name = "txtitemname";
            txtitemname.Size = new Size(253, 27);
            txtitemname.TabIndex = 47;
            // 
            // txtprice
            // 
            txtprice.AutoSize = true;
            txtprice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtprice.Location = new Point(159, 426);
            txtprice.Name = "txtprice";
            txtprice.Padding = new Padding(45, 5, 50, 5);
            txtprice.Size = new Size(172, 30);
            txtprice.TabIndex = 48;
            txtprice.Text = "Unit Price";
            // 
            // txtunitprice
            // 
            txtunitprice.Location = new Point(417, 429);
            txtunitprice.Name = "txtunitprice";
            txtunitprice.PlaceholderText = "LKR";
            txtunitprice.Size = new Size(254, 27);
            txtunitprice.TabIndex = 49;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbldate.Location = new Point(159, 467);
            lbldate.Name = "lbldate";
            lbldate.Padding = new Padding(25, 5, 25, 5);
            lbldate.Size = new Size(177, 30);
            lbldate.TabIndex = 50;
            lbldate.Text = "Transaction Date";
            // 
            // dtptransactiondate
            // 
            dtptransactiondate.Location = new Point(420, 472);
            dtptransactiondate.Name = "dtptransactiondate";
            dtptransactiondate.Size = new Size(250, 27);
            dtptransactiondate.TabIndex = 51;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(467, 583);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 52;
            pictureBox6.TabStop = false;
            // 
            // btnviewtransactionlog
            // 
            btnviewtransactionlog.BackColor = Color.White;
            btnviewtransactionlog.Cursor = Cursors.Hand;
            btnviewtransactionlog.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnviewtransactionlog.Location = new Point(511, 583);
            btnviewtransactionlog.Name = "btnviewtransactionlog";
            btnviewtransactionlog.Size = new Size(224, 36);
            btnviewtransactionlog.TabIndex = 53;
            btnviewtransactionlog.Text = "View Transaction Log";
            btnviewtransactionlog.UseVisualStyleBackColor = false;
            btnviewtransactionlog.Click += btnviewtransactionlog_Click;
            // 
            // Add_Quantity_to_Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(760, 631);
            Controls.Add(btnviewtransactionlog);
            Controls.Add(pictureBox6);
            Controls.Add(dtptransactiondate);
            Controls.Add(lbldate);
            Controls.Add(txtunitprice);
            Controls.Add(txtprice);
            Controls.Add(txtitemname);
            Controls.Add(lblitemname);
            Controls.Add(txtcurrentquantity);
            Controls.Add(lblcurrentquantity);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btnadditem);
            Controls.Add(label3);
            Controls.Add(btnreturntoadmindashboard);
            Controls.Add(btnaddquantitytoitem);
            Controls.Add(txtquantityofitem);
            Controls.Add(lblquantityofitem);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(btnlogout);
            Controls.Add(txtitemnumbersearch);
            Controls.Add(btnsearch);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_Quantity_to_Stock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Quantity_to_Stock";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnlogout;
        private TextBox txtitemnumbersearch;
        private Button btnsearch;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label lblquantityofitem;
        private TextBox txtquantityofitem;
        private Button btnaddquantitytoitem;
        private Button btnreturntoadmindashboard;
        private Label label3;
        private Button btnadditem;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblcurrentquantity;
        private TextBox txtcurrentquantity;
        private Label lblitemname;
        private TextBox txtitemname;
        private Label txtprice;
        private TextBox txtunitprice;
        private Label lbldate;
        private DateTimePicker dtptransactiondate;
        private PictureBox pictureBox6;
        private Button btnviewtransactionlog;
    }
}