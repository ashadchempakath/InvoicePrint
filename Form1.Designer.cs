namespace WindocPrint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            buttonPrint = new Button();
            dataGridView1 = new DataGridView();
            buttonExecuteCmd = new Button();
            textBoxCommandText = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            textBoxInvoiceNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxCustomerName = new TextBox();
            label3 = new Label();
            textBoxSenderAddress = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label25 = new Label();
            textBoxItemValue = new TextBox();
            label24 = new Label();
            textBoxTotalWeight = new TextBox();
            buttonClear = new Button();
            textBoxShippingAddress = new TextBox();
            label20 = new Label();
            label21 = new Label();
            textBoxShipTo = new TextBox();
            label19 = new Label();
            textBoxNarration = new TextBox();
            label18 = new Label();
            textBoxAfterDiscount = new TextBox();
            label17 = new Label();
            textBoxShippingCharge = new TextBox();
            label16 = new Label();
            textBoxDiscount = new TextBox();
            label10 = new Label();
            textBoxGrandTotal = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxTaxPercent = new TextBox();
            textBoxTaxAmount = new TextBox();
            label7 = new Label();
            textBoxNoPackage = new TextBox();
            buttonSave = new Button();
            label5 = new Label();
            label4 = new Label();
            textBoxTotalQty = new TextBox();
            textBoxTotalAmount = new TextBox();
            dataGridView3 = new DataGridView();
            Columnslno = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnQty = new DataGridViewTextBoxColumn();
            ColumnUnitPrice = new DataGridViewTextBoxColumn();
            ColumnTotal = new DataGridViewTextBoxColumn();
            textBoxCustomeAddress = new TextBox();
            label15 = new Label();
            label14 = new Label();
            textBoxSenderName = new TextBox();
            tabPage2 = new TabPage();
            TxtNoShipment = new TextBox();
            label12 = new Label();
            checkBoxFirstRowHeading = new CheckBox();
            buttonPasteFromExcelCopy = new Button();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            checkBoxPrintSignatureandStamp = new CheckBox();
            checkBoxPrintInvoicefooterImage = new CheckBox();
            label23 = new Label();
            label22 = new Label();
            textBoxCurrency = new TextBox();
            buttonReaderExecute = new Button();
            buttonSetCreateTables = new Button();
            label6 = new Label();
            checkBoxPrintInvoiceHeaderImage = new CheckBox();
            checkBoxPrintInvoiceHeading = new CheckBox();
            buttonSaveSettings = new Button();
            label13 = new Label();
            textBoxInvoiceHeading = new TextBox();
            buttonExcelCopySaveAndPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPrint
            // 
            buttonPrint.Location = new Point(36, 616);
            buttonPrint.Margin = new Padding(3, 4, 3, 4);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(95, 44);
            buttonPrint.TabIndex = 12;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(937, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(317, 747);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // buttonExecuteCmd
            // 
            buttonExecuteCmd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonExecuteCmd.Location = new Point(22, 619);
            buttonExecuteCmd.Margin = new Padding(3, 4, 3, 4);
            buttonExecuteCmd.Name = "buttonExecuteCmd";
            buttonExecuteCmd.Size = new Size(186, 31);
            buttonExecuteCmd.TabIndex = 2;
            buttonExecuteCmd.Text = "SQL Command Execute";
            buttonExecuteCmd.UseVisualStyleBackColor = true;
            buttonExecuteCmd.Click += buttonExecuteCmd_Click;
            // 
            // textBoxCommandText
            // 
            textBoxCommandText.Location = new Point(22, 356);
            textBoxCommandText.Margin = new Padding(3, 4, 3, 4);
            textBoxCommandText.Multiline = true;
            textBoxCommandText.Name = "textBoxCommandText";
            textBoxCommandText.Size = new Size(854, 239);
            textBoxCommandText.TabIndex = 3;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // textBoxInvoiceNo
            // 
            textBoxInvoiceNo.Location = new Point(635, 27);
            textBoxInvoiceNo.Margin = new Padding(3, 4, 3, 4);
            textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            textBoxInvoiceNo.Size = new Size(131, 27);
            textBoxInvoiceNo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 5;
            label1.Text = "Invoice No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 152);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Customer";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(162, 148);
            textBoxCustomerName.Margin = new Padding(3, 4, 3, 4);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(357, 27);
            textBoxCustomerName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 69);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 9;
            label3.Text = "Sender Address";
            // 
            // textBoxSenderAddress
            // 
            textBoxSenderAddress.Location = new Point(162, 65);
            textBoxSenderAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxSenderAddress.Multiline = true;
            textBoxSenderAddress.Name = "textBoxSenderAddress";
            textBoxSenderAddress.Size = new Size(357, 75);
            textBoxSenderAddress.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(635, 67);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(131, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(549, 65);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 25;
            label11.Text = "Date";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(14, 16);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(917, 751);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label25);
            tabPage1.Controls.Add(textBoxItemValue);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(textBoxTotalWeight);
            tabPage1.Controls.Add(buttonClear);
            tabPage1.Controls.Add(textBoxShippingAddress);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(textBoxShipTo);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(textBoxNarration);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(textBoxAfterDiscount);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(textBoxShippingCharge);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(textBoxDiscount);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(textBoxGrandTotal);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(textBoxTaxPercent);
            tabPage1.Controls.Add(textBoxTaxAmount);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBoxNoPackage);
            tabPage1.Controls.Add(buttonSave);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBoxTotalQty);
            tabPage1.Controls.Add(textBoxTotalAmount);
            tabPage1.Controls.Add(dataGridView3);
            tabPage1.Controls.Add(textBoxCustomeAddress);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(textBoxSenderName);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(textBoxCustomerName);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(buttonPrint);
            tabPage1.Controls.Add(textBoxSenderAddress);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxInvoiceNo);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(909, 718);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Direct Invoice";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(781, 82);
            label25.Name = "label25";
            label25.Size = new Size(85, 20);
            label25.TabIndex = 60;
            label25.Tag = "Item Value";
            label25.Text = "Items Value";
            // 
            // textBoxItemValue
            // 
            textBoxItemValue.Location = new Point(782, 103);
            textBoxItemValue.Margin = new Padding(3, 4, 3, 4);
            textBoxItemValue.Name = "textBoxItemValue";
            textBoxItemValue.Size = new Size(95, 27);
            textBoxItemValue.TabIndex = 8;
            textBoxItemValue.Text = "1";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(781, 26);
            label24.Name = "label24";
            label24.Size = new Size(93, 20);
            label24.TabIndex = 58;
            label24.Text = "Total Weight";
            // 
            // textBoxTotalWeight
            // 
            textBoxTotalWeight.Location = new Point(782, 47);
            textBoxTotalWeight.Margin = new Padding(3, 4, 3, 4);
            textBoxTotalWeight.Name = "textBoxTotalWeight";
            textBoxTotalWeight.Size = new Size(95, 27);
            textBoxTotalWeight.TabIndex = 7;
            textBoxTotalWeight.Text = "1";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(137, 616);
            buttonClear.Margin = new Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(87, 44);
            buttonClear.TabIndex = 56;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxShippingAddress
            // 
            textBoxShippingAddress.Location = new Point(679, 192);
            textBoxShippingAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxShippingAddress.Multiline = true;
            textBoxShippingAddress.Name = "textBoxShippingAddress";
            textBoxShippingAddress.Size = new Size(198, 59);
            textBoxShippingAddress.TabIndex = 5;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(549, 196);
            label20.Name = "label20";
            label20.Size = new Size(125, 20);
            label20.TabIndex = 55;
            label20.Text = "Shipping Address";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(549, 156);
            label21.Name = "label21";
            label21.Size = new Size(58, 20);
            label21.TabIndex = 54;
            label21.Text = "Ship To";
            // 
            // textBoxShipTo
            // 
            textBoxShipTo.Location = new Point(679, 152);
            textBoxShipTo.Margin = new Padding(3, 4, 3, 4);
            textBoxShipTo.Name = "textBoxShipTo";
            textBoxShipTo.Size = new Size(198, 27);
            textBoxShipTo.TabIndex = 4;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(32, 505);
            label19.Name = "label19";
            label19.Size = new Size(192, 20);
            label19.TabIndex = 51;
            label19.Text = "Narration / Payment Details";
            // 
            // textBoxNarration
            // 
            textBoxNarration.Location = new Point(32, 529);
            textBoxNarration.Margin = new Padding(3, 4, 3, 4);
            textBoxNarration.Multiline = true;
            textBoxNarration.Name = "textBoxNarration";
            textBoxNarration.Size = new Size(337, 65);
            textBoxNarration.TabIndex = 10;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(608, 572);
            label18.Name = "label18";
            label18.Size = new Size(104, 20);
            label18.TabIndex = 49;
            label18.Text = "After Discount";
            // 
            // textBoxAfterDiscount
            // 
            textBoxAfterDiscount.Location = new Point(737, 567);
            textBoxAfterDiscount.Margin = new Padding(3, 4, 3, 4);
            textBoxAfterDiscount.Name = "textBoxAfterDiscount";
            textBoxAfterDiscount.Size = new Size(131, 27);
            textBoxAfterDiscount.TabIndex = 48;
            textBoxAfterDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(609, 638);
            label17.Name = "label17";
            label17.Size = new Size(119, 20);
            label17.TabIndex = 47;
            label17.Text = "Shipping Charge";
            // 
            // textBoxShippingCharge
            // 
            textBoxShippingCharge.Location = new Point(738, 633);
            textBoxShippingCharge.Margin = new Padding(3, 4, 3, 4);
            textBoxShippingCharge.Name = "textBoxShippingCharge";
            textBoxShippingCharge.Size = new Size(131, 27);
            textBoxShippingCharge.TabIndex = 46;
            textBoxShippingCharge.TextAlign = HorizontalAlignment.Right;
            textBoxShippingCharge.TextChanged += textBoxShippingCharge_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(608, 537);
            label16.Name = "label16";
            label16.Size = new Size(67, 20);
            label16.TabIndex = 45;
            label16.Text = "Discount";
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Location = new Point(737, 532);
            textBoxDiscount.Margin = new Padding(3, 4, 3, 4);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.Size = new Size(131, 27);
            textBoxDiscount.TabIndex = 44;
            textBoxDiscount.TextAlign = HorizontalAlignment.Right;
            textBoxDiscount.TextChanged += textBoxDiscount_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(128, 64, 0);
            label10.Location = new Point(608, 671);
            label10.Name = "label10";
            label10.Size = new Size(119, 23);
            label10.TabIndex = 43;
            label10.Text = "Total Amount";
            // 
            // textBoxGrandTotal
            // 
            textBoxGrandTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxGrandTotal.ForeColor = Color.FromArgb(128, 64, 0);
            textBoxGrandTotal.Location = new Point(737, 666);
            textBoxGrandTotal.Margin = new Padding(3, 4, 3, 4);
            textBoxGrandTotal.Name = "textBoxGrandTotal";
            textBoxGrandTotal.Size = new Size(131, 30);
            textBoxGrandTotal.TabIndex = 42;
            textBoxGrandTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(609, 603);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 41;
            label8.Text = "TAX / VAT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(417, 603);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 40;
            label9.Text = "TAX / VAT (%)";
            // 
            // textBoxTaxPercent
            // 
            textBoxTaxPercent.Location = new Point(523, 598);
            textBoxTaxPercent.Margin = new Padding(3, 4, 3, 4);
            textBoxTaxPercent.Name = "textBoxTaxPercent";
            textBoxTaxPercent.Size = new Size(77, 27);
            textBoxTaxPercent.TabIndex = 39;
            textBoxTaxPercent.TextAlign = HorizontalAlignment.Right;
            textBoxTaxPercent.TextChanged += textBoxTaxPercent_TextChanged;
            // 
            // textBoxTaxAmount
            // 
            textBoxTaxAmount.Location = new Point(738, 598);
            textBoxTaxAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxTaxAmount.Name = "textBoxTaxAmount";
            textBoxTaxAmount.Size = new Size(131, 27);
            textBoxTaxAmount.TabIndex = 38;
            textBoxTaxAmount.TextAlign = HorizontalAlignment.Right;
            textBoxTaxAmount.TextChanged += textBoxTaxAmount_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(549, 103);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 37;
            label7.Text = "No Package";
            // 
            // textBoxNoPackage
            // 
            textBoxNoPackage.Location = new Point(635, 103);
            textBoxNoPackage.Margin = new Padding(3, 4, 3, 4);
            textBoxNoPackage.Name = "textBoxNoPackage";
            textBoxNoPackage.Size = new Size(131, 27);
            textBoxNoPackage.TabIndex = 6;
            textBoxNoPackage.Text = "1";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(240, 616);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(129, 44);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(608, 503);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 34;
            label5.Text = "Sub Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 503);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 33;
            label4.Text = "Total Qty";
            // 
            // textBoxTotalQty
            // 
            textBoxTotalQty.Location = new Point(485, 498);
            textBoxTotalQty.Margin = new Padding(3, 4, 3, 4);
            textBoxTotalQty.Name = "textBoxTotalQty";
            textBoxTotalQty.Size = new Size(114, 27);
            textBoxTotalQty.TabIndex = 32;
            textBoxTotalQty.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxTotalAmount
            // 
            textBoxTotalAmount.Location = new Point(737, 498);
            textBoxTotalAmount.Margin = new Padding(3, 4, 3, 4);
            textBoxTotalAmount.Name = "textBoxTotalAmount";
            textBoxTotalAmount.Size = new Size(131, 27);
            textBoxTotalAmount.TabIndex = 31;
            textBoxTotalAmount.TextAlign = HorizontalAlignment.Right;
            textBoxTotalAmount.TextChanged += textBoxTotalAmount_TextChanged;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Columnslno, ColumnDescription, ColumnQty, ColumnUnitPrice, ColumnTotal });
            dataGridView3.Location = new Point(32, 256);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(845, 231);
            dataGridView3.TabIndex = 9;
            dataGridView3.CellEndEdit += dataGridView3_CellEndEdit;
            // 
            // Columnslno
            // 
            Columnslno.HeaderText = "Slno";
            Columnslno.MinimumWidth = 40;
            Columnslno.Name = "Columnslno";
            Columnslno.Width = 40;
            // 
            // ColumnDescription
            // 
            ColumnDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDescription.HeaderText = "Description";
            ColumnDescription.MinimumWidth = 150;
            ColumnDescription.Name = "ColumnDescription";
            // 
            // ColumnQty
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            ColumnQty.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnQty.HeaderText = "Quantity";
            ColumnQty.MinimumWidth = 100;
            ColumnQty.Name = "ColumnQty";
            ColumnQty.Width = 125;
            // 
            // ColumnUnitPrice
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            ColumnUnitPrice.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnUnitPrice.HeaderText = "Unit Price";
            ColumnUnitPrice.MinimumWidth = 100;
            ColumnUnitPrice.Name = "ColumnUnitPrice";
            ColumnUnitPrice.Width = 125;
            // 
            // ColumnTotal
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            ColumnTotal.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnTotal.HeaderText = "Total";
            ColumnTotal.MinimumWidth = 100;
            ColumnTotal.Name = "ColumnTotal";
            ColumnTotal.Width = 125;
            // 
            // textBoxCustomeAddress
            // 
            textBoxCustomeAddress.Location = new Point(162, 188);
            textBoxCustomeAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxCustomeAddress.Multiline = true;
            textBoxCustomeAddress.Name = "textBoxCustomeAddress";
            textBoxCustomeAddress.Size = new Size(357, 59);
            textBoxCustomeAddress.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(32, 192);
            label15.Name = "label15";
            label15.Size = new Size(124, 20);
            label15.TabIndex = 29;
            label15.Text = "Custome Address";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(32, 31);
            label14.Name = "label14";
            label14.Size = new Size(99, 20);
            label14.TabIndex = 27;
            label14.Text = "Sender Name";
            // 
            // textBoxSenderName
            // 
            textBoxSenderName.Location = new Point(162, 27);
            textBoxSenderName.Margin = new Padding(3, 4, 3, 4);
            textBoxSenderName.Name = "textBoxSenderName";
            textBoxSenderName.Size = new Size(357, 27);
            textBoxSenderName.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonExcelCopySaveAndPrint);
            tabPage2.Controls.Add(TxtNoShipment);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(checkBoxFirstRowHeading);
            tabPage2.Controls.Add(buttonPasteFromExcelCopy);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(909, 718);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Excel Invoice";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtNoShipment
            // 
            TxtNoShipment.Location = new Point(337, 63);
            TxtNoShipment.Margin = new Padding(3, 4, 3, 4);
            TxtNoShipment.Name = "TxtNoShipment";
            TxtNoShipment.Size = new Size(114, 27);
            TxtNoShipment.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(211, 67);
            label12.Name = "label12";
            label12.Size = new Size(133, 20);
            label12.TabIndex = 5;
            label12.Text = "Total Rows Copied";
            // 
            // checkBoxFirstRowHeading
            // 
            checkBoxFirstRowHeading.AutoSize = true;
            checkBoxFirstRowHeading.Location = new Point(27, 32);
            checkBoxFirstRowHeading.Margin = new Padding(3, 4, 3, 4);
            checkBoxFirstRowHeading.Name = "checkBoxFirstRowHeading";
            checkBoxFirstRowHeading.Size = new Size(166, 24);
            checkBoxFirstRowHeading.TabIndex = 4;
            checkBoxFirstRowHeading.Text = "First Row is Heading";
            checkBoxFirstRowHeading.UseVisualStyleBackColor = true;
            // 
            // buttonPasteFromExcelCopy
            // 
            buttonPasteFromExcelCopy.Location = new Point(24, 63);
            buttonPasteFromExcelCopy.Margin = new Padding(3, 4, 3, 4);
            buttonPasteFromExcelCopy.Name = "buttonPasteFromExcelCopy";
            buttonPasteFromExcelCopy.Size = new Size(155, 31);
            buttonPasteFromExcelCopy.TabIndex = 3;
            buttonPasteFromExcelCopy.Text = "Paste";
            buttonPasteFromExcelCopy.UseVisualStyleBackColor = true;
            buttonPasteFromExcelCopy.Click += buttonPasteFromExcelCopy_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(26, 112);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(855, 487);
            dataGridView2.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(checkBoxPrintSignatureandStamp);
            tabPage3.Controls.Add(checkBoxPrintInvoicefooterImage);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(textBoxCurrency);
            tabPage3.Controls.Add(buttonReaderExecute);
            tabPage3.Controls.Add(buttonSetCreateTables);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(checkBoxPrintInvoiceHeaderImage);
            tabPage3.Controls.Add(checkBoxPrintInvoiceHeading);
            tabPage3.Controls.Add(buttonSaveSettings);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(textBoxInvoiceHeading);
            tabPage3.Controls.Add(textBoxCommandText);
            tabPage3.Controls.Add(buttonExecuteCmd);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(909, 718);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrintSignatureandStamp
            // 
            checkBoxPrintSignatureandStamp.AutoSize = true;
            checkBoxPrintSignatureandStamp.Checked = true;
            checkBoxPrintSignatureandStamp.CheckState = CheckState.Checked;
            checkBoxPrintSignatureandStamp.Location = new Point(22, 90);
            checkBoxPrintSignatureandStamp.Margin = new Padding(3, 4, 3, 4);
            checkBoxPrintSignatureandStamp.Name = "checkBoxPrintSignatureandStamp";
            checkBoxPrintSignatureandStamp.Size = new Size(294, 24);
            checkBoxPrintSignatureandStamp.TabIndex = 18;
            checkBoxPrintSignatureandStamp.Text = "Print Signature and Office Stamp Image";
            checkBoxPrintSignatureandStamp.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrintInvoicefooterImage
            // 
            checkBoxPrintInvoicefooterImage.AutoSize = true;
            checkBoxPrintInvoicefooterImage.Checked = true;
            checkBoxPrintInvoicefooterImage.CheckState = CheckState.Checked;
            checkBoxPrintInvoicefooterImage.Location = new Point(22, 58);
            checkBoxPrintInvoicefooterImage.Margin = new Padding(3, 4, 3, 4);
            checkBoxPrintInvoicefooterImage.Name = "checkBoxPrintInvoicefooterImage";
            checkBoxPrintInvoicefooterImage.Size = new Size(205, 24);
            checkBoxPrintInvoicefooterImage.TabIndex = 17;
            checkBoxPrintInvoicefooterImage.Text = "Print Invoice Footer Image";
            checkBoxPrintInvoicefooterImage.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.BackColor = Color.Green;
            label23.ForeColor = Color.Green;
            label23.Location = new Point(0, 310);
            label23.Name = "label23";
            label23.Size = new Size(1000, 5);
            label23.TabIndex = 16;
            label23.Text = "Currency";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(22, 235);
            label22.Name = "label22";
            label22.Size = new Size(66, 20);
            label22.TabIndex = 15;
            label22.Text = "Currency";
            // 
            // textBoxCurrency
            // 
            textBoxCurrency.Location = new Point(22, 259);
            textBoxCurrency.Margin = new Padding(3, 4, 3, 4);
            textBoxCurrency.Name = "textBoxCurrency";
            textBoxCurrency.Size = new Size(186, 27);
            textBoxCurrency.TabIndex = 14;
            textBoxCurrency.Text = "AED";
            // 
            // buttonReaderExecute
            // 
            buttonReaderExecute.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonReaderExecute.Location = new Point(214, 619);
            buttonReaderExecute.Margin = new Padding(3, 4, 3, 4);
            buttonReaderExecute.Name = "buttonReaderExecute";
            buttonReaderExecute.Size = new Size(186, 31);
            buttonReaderExecute.TabIndex = 13;
            buttonReaderExecute.Text = "Reader Execute";
            buttonReaderExecute.UseVisualStyleBackColor = true;
            buttonReaderExecute.Click += buttonReaderExecute_Click;
            // 
            // buttonSetCreateTables
            // 
            buttonSetCreateTables.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSetCreateTables.Location = new Point(612, 619);
            buttonSetCreateTables.Margin = new Padding(3, 4, 3, 4);
            buttonSetCreateTables.Name = "buttonSetCreateTables";
            buttonSetCreateTables.Size = new Size(264, 31);
            buttonSetCreateTables.TabIndex = 12;
            buttonSetCreateTables.Text = "Set Create Tables For Next form Load";
            buttonSetCreateTables.UseVisualStyleBackColor = true;
            buttonSetCreateTables.Click += buttonSetCreateTables_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 329);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 11;
            label6.Text = "Developer Settings";
            // 
            // checkBoxPrintInvoiceHeaderImage
            // 
            checkBoxPrintInvoiceHeaderImage.AutoSize = true;
            checkBoxPrintInvoiceHeaderImage.Checked = true;
            checkBoxPrintInvoiceHeaderImage.CheckState = CheckState.Checked;
            checkBoxPrintInvoiceHeaderImage.Location = new Point(22, 28);
            checkBoxPrintInvoiceHeaderImage.Margin = new Padding(3, 4, 3, 4);
            checkBoxPrintInvoiceHeaderImage.Name = "checkBoxPrintInvoiceHeaderImage";
            checkBoxPrintInvoiceHeaderImage.Size = new Size(211, 24);
            checkBoxPrintInvoiceHeaderImage.TabIndex = 10;
            checkBoxPrintInvoiceHeaderImage.Text = "Print Invoice Header Image";
            checkBoxPrintInvoiceHeaderImage.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrintInvoiceHeading
            // 
            checkBoxPrintInvoiceHeading.AutoSize = true;
            checkBoxPrintInvoiceHeading.Checked = true;
            checkBoxPrintInvoiceHeading.CheckState = CheckState.Checked;
            checkBoxPrintInvoiceHeading.Location = new Point(22, 129);
            checkBoxPrintInvoiceHeading.Margin = new Padding(3, 4, 3, 4);
            checkBoxPrintInvoiceHeading.Name = "checkBoxPrintInvoiceHeading";
            checkBoxPrintInvoiceHeading.Size = new Size(173, 24);
            checkBoxPrintInvoiceHeading.TabIndex = 9;
            checkBoxPrintInvoiceHeading.Text = "Print Invoice Heading";
            checkBoxPrintInvoiceHeading.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSettings
            // 
            buttonSaveSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSaveSettings.Location = new Point(738, 252);
            buttonSaveSettings.Margin = new Padding(3, 4, 3, 4);
            buttonSaveSettings.Name = "buttonSaveSettings";
            buttonSaveSettings.Size = new Size(138, 44);
            buttonSaveSettings.TabIndex = 8;
            buttonSaveSettings.Text = "Save Settings";
            buttonSaveSettings.UseVisualStyleBackColor = true;
            buttonSaveSettings.Click += buttonSaveSettings_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(63, 156);
            label13.Name = "label13";
            label13.Size = new Size(117, 20);
            label13.TabIndex = 7;
            label13.Text = "Invoice Heading";
            // 
            // textBoxInvoiceHeading
            // 
            textBoxInvoiceHeading.Location = new Point(22, 180);
            textBoxInvoiceHeading.Margin = new Padding(3, 4, 3, 4);
            textBoxInvoiceHeading.Name = "textBoxInvoiceHeading";
            textBoxInvoiceHeading.Size = new Size(186, 27);
            textBoxInvoiceHeading.TabIndex = 6;
            textBoxInvoiceHeading.Text = "INVOICE";
            textBoxInvoiceHeading.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonExcelCopySaveAndPrint
            // 
            buttonExcelCopySaveAndPrint.Location = new Point(695, 617);
            buttonExcelCopySaveAndPrint.Margin = new Padding(3, 4, 3, 4);
            buttonExcelCopySaveAndPrint.Name = "buttonExcelCopySaveAndPrint";
            buttonExcelCopySaveAndPrint.Size = new Size(186, 55);
            buttonExcelCopySaveAndPrint.TabIndex = 7;
            buttonExcelCopySaveAndPrint.Text = "Save And Print";
            buttonExcelCopySaveAndPrint.UseVisualStyleBackColor = true;
            buttonExcelCopySaveAndPrint.Click += buttonExcelCopySaveAndPrint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 797);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPrint;
        private DataGridView dataGridView1;
        private Button buttonExecuteCmd;
        private TextBox textBoxCommandText;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TextBox textBoxInvoiceNo;
        private Label label1;
        private Label label2;
        private TextBox textBoxCustomerName;
        private Label label3;
        private TextBox textBoxSenderAddress;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private TabPage tabPage3;
        private Button buttonPasteFromExcelCopy;
        private CheckBox checkBoxFirstRowHeading;
        private TextBox TxtNoShipment;
        private Label label12;
        private Label label13;
        private TextBox textBoxInvoiceHeading;
        private Button buttonSaveSettings;
        private CheckBox checkBoxPrintInvoiceHeaderImage;
        private CheckBox checkBoxPrintInvoiceHeading;
        private TextBox textBoxCustomeAddress;
        private Label label15;
        private Label label14;
        private TextBox textBoxSenderName;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Columnslno;
        private DataGridViewTextBoxColumn ColumnDescription;
        private DataGridViewTextBoxColumn ColumnQty;
        private DataGridViewTextBoxColumn ColumnUnitPrice;
        private DataGridViewTextBoxColumn ColumnTotal;
        private Label label5;
        private Label label4;
        private TextBox textBoxTotalQty;
        private TextBox textBoxTotalAmount;
        private Button buttonSave;
        private Button buttonSetCreateTables;
        private Label label6;
        private Label label7;
        private TextBox textBoxNoPackage;
        private Button buttonReaderExecute;
        private Label label8;
        private Label label9;
        private TextBox textBoxTaxPercent;
        private TextBox textBoxTaxAmount;
        private Label label10;
        private TextBox textBoxGrandTotal;
        private Label label17;
        private TextBox textBoxShippingCharge;
        private Label label16;
        private TextBox textBoxDiscount;
        private Label label18;
        private TextBox textBoxAfterDiscount;
        private Label label19;
        private TextBox textBoxNarration;
        private TextBox textBoxShippingAddress;
        private Label label20;
        private Label label21;
        private TextBox textBoxShipTo;
        private Label label22;
        private TextBox textBoxCurrency;
        private Label label23;
        private CheckBox checkBoxPrintInvoicefooterImage;
        private Button buttonClear;
        private CheckBox checkBoxPrintSignatureandStamp;
        private Label label24;
        private TextBox textBoxTotalWeight;
        private Label label25;
        private TextBox textBoxItemValue;
        private Button buttonExcelCopySaveAndPrint;
    }
}
