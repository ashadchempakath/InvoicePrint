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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            checkBoxPrintInvoiceHeaderImage = new CheckBox();
            checkBoxPrintInvoiceHeading = new CheckBox();
            buttonSaveSettings = new Button();
            label13 = new Label();
            textBoxInvoiceHeading = new TextBox();
            label6 = new Label();
            button1 = new Button();
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
            buttonPrint.Location = new Point(36, 450);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(113, 48);
            buttonPrint.TabIndex = 0;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(820, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(288, 569);
            dataGridView1.TabIndex = 1;
            // 
            // buttonExecuteCmd
            // 
            buttonExecuteCmd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonExecuteCmd.Location = new Point(19, 464);
            buttonExecuteCmd.Name = "buttonExecuteCmd";
            buttonExecuteCmd.Size = new Size(163, 23);
            buttonExecuteCmd.TabIndex = 2;
            buttonExecuteCmd.Text = "SQL Command Execute";
            buttonExecuteCmd.UseVisualStyleBackColor = true;
            buttonExecuteCmd.Click += buttonExecuteCmd_Click;
            // 
            // textBoxCommandText
            // 
            textBoxCommandText.Location = new Point(19, 267);
            textBoxCommandText.Multiline = true;
            textBoxCommandText.Name = "textBoxCommandText";
            textBoxCommandText.Size = new Size(748, 180);
            textBoxCommandText.TabIndex = 3;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // textBoxInvoiceNo
            // 
            textBoxInvoiceNo.Location = new Point(653, 19);
            textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            textBoxInvoiceNo.Size = new Size(115, 23);
            textBoxInvoiceNo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(573, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "Invoice No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 128);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "Customer";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(128, 125);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(327, 23);
            textBoxCustomerName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 52);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 9;
            label3.Text = "Sender Address";
            // 
            // textBoxSenderAddress
            // 
            textBoxSenderAddress.Location = new Point(128, 49);
            textBoxSenderAddress.Multiline = true;
            textBoxSenderAddress.Name = "textBoxSenderAddress";
            textBoxSenderAddress.Size = new Size(327, 70);
            textBoxSenderAddress.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(653, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(573, 52);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 25;
            label11.Text = "Date";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 545);
            tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Direct Invoice";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(169, 450);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(113, 48);
            buttonSave.TabIndex = 35;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(575, 450);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 34;
            label5.Text = "Total Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 450);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 33;
            label4.Text = "Total Qty";
            // 
            // textBoxTotalQty
            // 
            textBoxTotalQty.Location = new Point(456, 446);
            textBoxTotalQty.Name = "textBoxTotalQty";
            textBoxTotalQty.Size = new Size(113, 23);
            textBoxTotalQty.TabIndex = 32;
            textBoxTotalQty.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxTotalAmount
            // 
            textBoxTotalAmount.Location = new Point(653, 446);
            textBoxTotalAmount.Name = "textBoxTotalAmount";
            textBoxTotalAmount.Size = new Size(115, 23);
            textBoxTotalAmount.TabIndex = 31;
            textBoxTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Columnslno, ColumnDescription, ColumnQty, ColumnUnitPrice, ColumnTotal });
            dataGridView3.Location = new Point(36, 218);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(732, 217);
            dataGridView3.TabIndex = 30;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            ColumnQty.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnQty.HeaderText = "Quantity";
            ColumnQty.MinimumWidth = 100;
            ColumnQty.Name = "ColumnQty";
            // 
            // ColumnUnitPrice
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            ColumnUnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnUnitPrice.HeaderText = "Unit Price";
            ColumnUnitPrice.MinimumWidth = 100;
            ColumnUnitPrice.Name = "ColumnUnitPrice";
            // 
            // ColumnTotal
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            ColumnTotal.DefaultCellStyle = dataGridViewCellStyle6;
            ColumnTotal.HeaderText = "Total";
            ColumnTotal.MinimumWidth = 100;
            ColumnTotal.Name = "ColumnTotal";
            // 
            // textBoxCustomeAddress
            // 
            textBoxCustomeAddress.Location = new Point(128, 155);
            textBoxCustomeAddress.Multiline = true;
            textBoxCustomeAddress.Name = "textBoxCustomeAddress";
            textBoxCustomeAddress.Size = new Size(327, 57);
            textBoxCustomeAddress.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 158);
            label15.Name = "label15";
            label15.Size = new Size(100, 15);
            label15.TabIndex = 29;
            label15.Text = "Custome Address";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 23);
            label14.Name = "label14";
            label14.Size = new Size(78, 15);
            label14.TabIndex = 27;
            label14.Text = "Sender Name";
            // 
            // textBoxSenderName
            // 
            textBoxSenderName.Location = new Point(128, 20);
            textBoxSenderName.Name = "textBoxSenderName";
            textBoxSenderName.Size = new Size(327, 23);
            textBoxSenderName.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(TxtNoShipment);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(checkBoxFirstRowHeading);
            tabPage2.Controls.Add(buttonPasteFromExcelCopy);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 517);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Excel Invoice";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtNoShipment
            // 
            TxtNoShipment.Location = new Point(295, 47);
            TxtNoShipment.Name = "TxtNoShipment";
            TxtNoShipment.Size = new Size(100, 23);
            TxtNoShipment.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(185, 50);
            label12.Name = "label12";
            label12.Size = new Size(104, 15);
            label12.TabIndex = 5;
            label12.Text = "Total Rows Copied";
            // 
            // checkBoxFirstRowHeading
            // 
            checkBoxFirstRowHeading.AutoSize = true;
            checkBoxFirstRowHeading.Location = new Point(24, 24);
            checkBoxFirstRowHeading.Name = "checkBoxFirstRowHeading";
            checkBoxFirstRowHeading.Size = new Size(133, 19);
            checkBoxFirstRowHeading.TabIndex = 4;
            checkBoxFirstRowHeading.Text = "First Row is Heading";
            checkBoxFirstRowHeading.UseVisualStyleBackColor = true;
            // 
            // buttonPasteFromExcelCopy
            // 
            buttonPasteFromExcelCopy.Location = new Point(21, 47);
            buttonPasteFromExcelCopy.Name = "buttonPasteFromExcelCopy";
            buttonPasteFromExcelCopy.Size = new Size(136, 23);
            buttonPasteFromExcelCopy.TabIndex = 3;
            buttonPasteFromExcelCopy.Text = "Paste";
            buttonPasteFromExcelCopy.UseVisualStyleBackColor = true;
            buttonPasteFromExcelCopy.Click += buttonPasteFromExcelCopy_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(23, 84);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(799, 365);
            dataGridView2.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(checkBoxPrintInvoiceHeaderImage);
            tabPage3.Controls.Add(checkBoxPrintInvoiceHeading);
            tabPage3.Controls.Add(buttonSaveSettings);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(textBoxInvoiceHeading);
            tabPage3.Controls.Add(textBoxCommandText);
            tabPage3.Controls.Add(buttonExecuteCmd);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(794, 517);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrintInvoiceHeaderImage
            // 
            checkBoxPrintInvoiceHeaderImage.AutoSize = true;
            checkBoxPrintInvoiceHeaderImage.Checked = true;
            checkBoxPrintInvoiceHeaderImage.CheckState = CheckState.Checked;
            checkBoxPrintInvoiceHeaderImage.Location = new Point(19, 21);
            checkBoxPrintInvoiceHeaderImage.Name = "checkBoxPrintInvoiceHeaderImage";
            checkBoxPrintInvoiceHeaderImage.Size = new Size(169, 19);
            checkBoxPrintInvoiceHeaderImage.TabIndex = 10;
            checkBoxPrintInvoiceHeaderImage.Text = "Print Invoice Header Image";
            checkBoxPrintInvoiceHeaderImage.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrintInvoiceHeading
            // 
            checkBoxPrintInvoiceHeading.AutoSize = true;
            checkBoxPrintInvoiceHeading.Checked = true;
            checkBoxPrintInvoiceHeading.CheckState = CheckState.Checked;
            checkBoxPrintInvoiceHeading.Location = new Point(19, 46);
            checkBoxPrintInvoiceHeading.Name = "checkBoxPrintInvoiceHeading";
            checkBoxPrintInvoiceHeading.Size = new Size(140, 19);
            checkBoxPrintInvoiceHeading.TabIndex = 9;
            checkBoxPrintInvoiceHeading.Text = "Print Invoice Heading";
            checkBoxPrintInvoiceHeading.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSettings
            // 
            buttonSaveSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSaveSettings.Location = new Point(646, 80);
            buttonSaveSettings.Name = "buttonSaveSettings";
            buttonSaveSettings.Size = new Size(121, 33);
            buttonSaveSettings.TabIndex = 8;
            buttonSaveSettings.Text = "Save Settings";
            buttonSaveSettings.UseVisualStyleBackColor = true;
            buttonSaveSettings.Click += buttonSaveSettings_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(55, 68);
            label13.Name = "label13";
            label13.Size = new Size(93, 15);
            label13.TabIndex = 7;
            label13.Text = "Invoice Heading";
            // 
            // textBoxInvoiceHeading
            // 
            textBoxInvoiceHeading.Location = new Point(19, 86);
            textBoxInvoiceHeading.Name = "textBoxInvoiceHeading";
            textBoxInvoiceHeading.Size = new Size(163, 23);
            textBoxInvoiceHeading.TabIndex = 6;
            textBoxInvoiceHeading.Text = "INVOICE";
            textBoxInvoiceHeading.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 239);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 11;
            label6.Text = "Developer Settings";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(188, 464);
            button1.Name = "button1";
            button1.Size = new Size(231, 23);
            button1.TabIndex = 12;
            button1.Text = "Set Create Tables For Next form Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 569);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView1);
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
        private Button button1;
        private Label label6;
    }
}
