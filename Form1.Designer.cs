namespace Inventory_Management
{
    partial class Form1
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
            this.searchButton = new System.Windows.Forms.Button();
            this.addNewItem = new System.Windows.Forms.Button();
            this.restockButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outPutBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbFour = new System.Windows.Forms.RadioButton();
            this.rbThree = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.itemsgroupBox = new System.Windows.Forms.GroupBox();
            this.cbNitro5 = new System.Windows.Forms.CheckBox();
            this.cbDellInspiron = new System.Windows.Forms.CheckBox();
            this.cbChromeBook = new System.Windows.Forms.CheckBox();
            this.cbHpEnvy = new System.Windows.Forms.CheckBox();
            this.cbMac = new System.Windows.Forms.CheckBox();
            this.brandGroupBox = new System.Windows.Forms.GroupBox();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SelectDate = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.itemsgroupBox.SuspendLayout();
            this.brandGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1046, 149);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 32);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addNewItem
            // 
            this.addNewItem.Location = new System.Drawing.Point(68, 874);
            this.addNewItem.Name = "addNewItem";
            this.addNewItem.Size = new System.Drawing.Size(134, 38);
            this.addNewItem.TabIndex = 1;
            this.addNewItem.Text = "Add new item";
            this.addNewItem.UseVisualStyleBackColor = true;
            this.addNewItem.Click += new System.EventHandler(this.addNewItem_Click);
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(232, 877);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(96, 38);
            this.restockButton.TabIndex = 2;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(554, 877);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(114, 37);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove item";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(694, 875);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 38);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(818, 875);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.outPutBox);
            this.panel1.Location = new System.Drawing.Point(33, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 265);
            this.panel1.TabIndex = 6;
            // 
            // outPutBox
            // 
            this.outPutBox.BackColor = System.Drawing.Color.Tan;
            this.outPutBox.FormattingEnabled = true;
            this.outPutBox.ItemHeight = 20;
            this.outPutBox.Location = new System.Drawing.Point(21, 18);
            this.outPutBox.Name = "outPutBox";
            this.outPutBox.Size = new System.Drawing.Size(840, 224);
            this.outPutBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.itemsgroupBox);
            this.panel2.Controls.Add(this.brandGroupBox);
            this.panel2.Location = new System.Drawing.Point(78, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 360);
            this.panel2.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.rbFour);
            this.groupBox3.Controls.Add(this.rbThree);
            this.groupBox3.Controls.Add(this.rbTwo);
            this.groupBox3.Controls.Add(this.rbOne);
            this.groupBox3.Location = new System.Drawing.Point(530, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 315);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quantity";
            // 
            // rbFour
            // 
            this.rbFour.AutoSize = true;
            this.rbFour.Location = new System.Drawing.Point(45, 182);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(43, 24);
            this.rbFour.TabIndex = 3;
            this.rbFour.TabStop = true;
            this.rbFour.Text = "4";
            this.rbFour.UseVisualStyleBackColor = true;
            // 
            // rbThree
            // 
            this.rbThree.AutoSize = true;
            this.rbThree.Location = new System.Drawing.Point(45, 138);
            this.rbThree.Name = "rbThree";
            this.rbThree.Size = new System.Drawing.Size(43, 24);
            this.rbThree.TabIndex = 2;
            this.rbThree.TabStop = true;
            this.rbThree.Text = "3";
            this.rbThree.UseVisualStyleBackColor = true;
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.Location = new System.Drawing.Point(45, 91);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(43, 24);
            this.rbTwo.TabIndex = 1;
            this.rbTwo.TabStop = true;
            this.rbTwo.Text = "2";
            this.rbTwo.UseVisualStyleBackColor = true;
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(45, 43);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(43, 24);
            this.rbOne.TabIndex = 0;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "1";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // itemsgroupBox
            // 
            this.itemsgroupBox.BackColor = System.Drawing.Color.SandyBrown;
            this.itemsgroupBox.Controls.Add(this.checkBox1);
            this.itemsgroupBox.Controls.Add(this.cbNitro5);
            this.itemsgroupBox.Controls.Add(this.cbDellInspiron);
            this.itemsgroupBox.Controls.Add(this.cbChromeBook);
            this.itemsgroupBox.Controls.Add(this.cbHpEnvy);
            this.itemsgroupBox.Controls.Add(this.cbMac);
            this.itemsgroupBox.Location = new System.Drawing.Point(284, 22);
            this.itemsgroupBox.Name = "itemsgroupBox";
            this.itemsgroupBox.Size = new System.Drawing.Size(200, 315);
            this.itemsgroupBox.TabIndex = 1;
            this.itemsgroupBox.TabStop = false;
            this.itemsgroupBox.Text = "Items";
            this.itemsgroupBox.Enter += new System.EventHandler(this.itemsgroupBox_Enter);
            // 
            // cbNitro5
            // 
            this.cbNitro5.AutoSize = true;
            this.cbNitro5.Location = new System.Drawing.Point(6, 199);
            this.cbNitro5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNitro5.Name = "cbNitro5";
            this.cbNitro5.Size = new System.Drawing.Size(81, 24);
            this.cbNitro5.TabIndex = 4;
            this.cbNitro5.Text = "Nitro 5";
            this.cbNitro5.UseVisualStyleBackColor = true;
            // 
            // cbDellInspiron
            // 
            this.cbDellInspiron.AutoSize = true;
            this.cbDellInspiron.Location = new System.Drawing.Point(6, 154);
            this.cbDellInspiron.Name = "cbDellInspiron";
            this.cbDellInspiron.Size = new System.Drawing.Size(123, 24);
            this.cbDellInspiron.TabIndex = 3;
            this.cbDellInspiron.Text = "Dell Inspiron";
            this.cbDellInspiron.UseVisualStyleBackColor = true;
            // 
            // cbChromeBook
            // 
            this.cbChromeBook.AutoSize = true;
            this.cbChromeBook.Location = new System.Drawing.Point(7, 112);
            this.cbChromeBook.Name = "cbChromeBook";
            this.cbChromeBook.Size = new System.Drawing.Size(126, 24);
            this.cbChromeBook.TabIndex = 2;
            this.cbChromeBook.Text = "Chromebook";
            this.cbChromeBook.UseVisualStyleBackColor = true;
            // 
            // cbHpEnvy
            // 
            this.cbHpEnvy.AutoSize = true;
            this.cbHpEnvy.Location = new System.Drawing.Point(7, 73);
            this.cbHpEnvy.Name = "cbHpEnvy";
            this.cbHpEnvy.Size = new System.Drawing.Size(96, 24);
            this.cbHpEnvy.TabIndex = 1;
            this.cbHpEnvy.Text = "HP-Envy";
            this.cbHpEnvy.UseVisualStyleBackColor = true;
            // 
            // cbMac
            // 
            this.cbMac.AutoSize = true;
            this.cbMac.Location = new System.Drawing.Point(7, 34);
            this.cbMac.Name = "cbMac";
            this.cbMac.Size = new System.Drawing.Size(65, 24);
            this.cbMac.TabIndex = 0;
            this.cbMac.Text = "Mac";
            this.cbMac.UseVisualStyleBackColor = true;
            // 
            // brandGroupBox
            // 
            this.brandGroupBox.BackColor = System.Drawing.Color.SandyBrown;
            this.brandGroupBox.Controls.Add(this.itemsListBox);
            this.brandGroupBox.Location = new System.Drawing.Point(40, 22);
            this.brandGroupBox.Name = "brandGroupBox";
            this.brandGroupBox.Size = new System.Drawing.Size(200, 315);
            this.brandGroupBox.TabIndex = 0;
            this.brandGroupBox.TabStop = false;
            this.brandGroupBox.Text = "Brand";
            // 
            // itemsListBox
            // 
            this.itemsListBox.BackColor = System.Drawing.Color.Wheat;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Items.AddRange(new object[] {
            "Apple ",
            "",
            "Hewlett-Packard ",
            "",
            "Google",
            "",
            "Dell",
            "",
            "Acer ",
            "",
            "Razer"});
            this.itemsListBox.Location = new System.Drawing.Point(26, 25);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(140, 284);
            this.itemsListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(184, 45);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 26);
            this.txtCustomerID.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 12;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(384, 42);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(728, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // SelectDate
            // 
            this.SelectDate.AutoSize = true;
            this.SelectDate.Location = new System.Drawing.Point(620, 48);
            this.SelectDate.Name = "SelectDate";
            this.SelectDate.Size = new System.Drawing.Size(97, 20);
            this.SelectDate.TabIndex = 15;
            this.SelectDate.Text = "Select Date:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(1202, 155);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(182, 26);
            this.searchTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 877);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Order item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Blade";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 223);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(2260, 1458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.SelectDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.addNewItem);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.itemsgroupBox.ResumeLayout(false);
            this.itemsgroupBox.PerformLayout();
            this.brandGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addNewItem;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbFour;
        private System.Windows.Forms.RadioButton rbThree;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.GroupBox itemsgroupBox;
        private System.Windows.Forms.CheckBox cbDellInspiron;
        private System.Windows.Forms.CheckBox cbChromeBook;
        private System.Windows.Forms.CheckBox cbHpEnvy;
        private System.Windows.Forms.CheckBox cbMac;
        private System.Windows.Forms.GroupBox brandGroupBox;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.CheckBox cbNitro5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label SelectDate;
        private System.Windows.Forms.ListBox outPutBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

