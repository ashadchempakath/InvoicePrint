using System.Data.SQLite;

namespace WindocPrint
{
    using System.Data;
    using System.Data.SQLite;
    using System.Drawing.Printing;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            print();

        }

        private void print()
        {

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath);
            SetdefaultcolumnForCopyExcel();
            LoadData();
            LoadSavedSettings();
            DatabaseHelper.CreateInvoiceTable();
            GenerateInvoieNo();
        }

        public static DataTable ReadDatas(string query)
        {
            try
            {

                using (SQLiteConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Invoices";
            DataTable dataTable = ReadDatas(query);
            dataGridView1.DataSource = dataTable;
        }

        private void buttonExecuteCmd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = "";
                if (textBoxCommandText.Text.Length > 0)
                {
                    query = textBoxCommandText.Text;
                }

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Command executed successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Query : " + query + " Error :" + ex.Message);

                    }

                }
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Set font and brush
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Set up printing area
            int startX = 50;
            int startY = 50;
            int lineHeight = 20;


            if (checkBoxPrintInvoiceHeaderImage.Checked)
            {
                //print header image
                Image image = Image.FromFile(Application.StartupPath + "/header.png");
                //float xPos = (e.PageSettings.PrintableArea.Width - image.Width) / 2;
                ////float yPos = (e.PageSettings.PrintableArea.Height - image.Height) / 2;
                //e.Graphics.DrawImage(image, e.PageBounds.X, e.PageBounds.Y);
                ////startY += image.Height + 25;
                ///

                // Assuming e is the PrintPageEventArgs object
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                float maxWidth = e.PageBounds.Width;
                float scale = maxWidth / image.Width;

                float newWidth = image.Width * scale;
                float newHeight = image.Height * scale;

                RectangleF destinationRect = new RectangleF(e.PageBounds.X, e.PageBounds.Y, newWidth, newHeight);

                e.Graphics.DrawImage(image, destinationRect);
                startY += 160;
                image.Dispose();
            }


            if (checkBoxPrintInvoiceHeading.Checked)
            {
                // print heading 
                Font fonthead = new Font("Arial", 20, FontStyle.Underline & FontStyle.Bold);
                float pageWidth = e.PageSettings.PrintableArea.Width;
                string centerString = "INVOICE";
                SizeF stringSize = e.Graphics.MeasureString(centerString, fonthead);
                float xPosition = (pageWidth - stringSize.Width) / 2;
                e.Graphics.DrawString(centerString, fonthead, brush, xPosition, startY);
            }


            // Print invoice details
            e.Graphics.DrawString($"Invoice No: {textBoxInvoiceNo.Text}", font, brush, startX + 520, startY);
            e.Graphics.DrawString($"Invoice Date: {dateTimePicker1.Text}", font, brush, startX + 520, startY + lineHeight);


            Font fontbold = new Font("Arial", 12, FontStyle.Bold);
            e.Graphics.DrawString(textBoxSenderName.Text, fontbold, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString(textBoxSenderAddress.Text, font, brush, startX, startY);
            startY += (lineHeight + 50);

            int Billtolineypos = startY;
            e.Graphics.DrawString("Bill To", fontbold, brush, startX, Billtolineypos);
            Pen pn = new Pen(Color.Black);
            startY += lineHeight;

            e.Graphics.DrawLine(pn, startX, Billtolineypos + lineHeight, startX + 160, Billtolineypos + lineHeight);
            startY += 10;

            e.Graphics.DrawString(textBoxCustomerName.Text, font, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString(textBoxCustomeAddress.Text, font, brush, startX, startY);
            startY += (lineHeight + 50);

            e.Graphics.DrawString("Ship To", fontbold, brush, startX + 500, Billtolineypos);
            e.Graphics.DrawLine(pn, startX + 500, Billtolineypos + lineHeight, startX + 660, Billtolineypos + lineHeight);
            Billtolineypos += lineHeight;
            e.Graphics.DrawString(textBoxShipTo.Text, font, brush, startX + 500, Billtolineypos);
            Billtolineypos += lineHeight;
            e.Graphics.DrawString(textBoxShippingAddress.Text, font, brush, startX + 500, Billtolineypos);
            Billtolineypos += (lineHeight + 50);

            float verticallineY = startY;

            e.Graphics.DrawRectangle(pn, startX, startY, 710, 260);
            startY += 5;
            e.Graphics.DrawString("SlNo", fontbold, brush, startX + 12, startY);
            e.Graphics.DrawString("Description", fontbold, brush, startX + 150, startY);
            e.Graphics.DrawString("Qty", fontbold, brush, startX + 400, startY);
            e.Graphics.DrawString("Rate", fontbold, brush, startX + 480, startY);
            e.Graphics.DrawString("Total", fontbold, brush, startX + 620, startY);

            startY += (lineHeight + 5);
            e.Graphics.DrawLine(pn, startX, startY, startX + 710, startY);
            startY += (lineHeight + 10);

            //draw vertical lines
            e.Graphics.DrawLine(pn, startX + 60, verticallineY, startX + 60, startY + 200);
            e.Graphics.DrawLine(pn, startX + 385, verticallineY, startX + 385, startY + 200);
            e.Graphics.DrawLine(pn, startX + 440, verticallineY, startX + 440, startY + 200);
            e.Graphics.DrawLine(pn, startX + 570, verticallineY, startX + 570, startY + 200);
            startY -= 10;

            StringFormat rightAlignedFormat = new StringFormat();
            rightAlignedFormat.Alignment = StringAlignment.Far;

            // Print invoice items
            for (int i = 0; i <= dataGridView3.Rows.Count - 2; i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), font, brush, startX + 10, startY);
                e.Graphics.DrawString(dataGridView3.Rows[i].Cells[1].Value.ToString(), font, brush, startX + 65, startY); //description



                string formattedQty = Convert.ToDecimal(dataGridView3.Rows[i].Cells[2].Value).ToString("0.00");
                string formattedRate = Convert.ToDecimal(dataGridView3.Rows[i].Cells[3].Value).ToString("0.00");
                string formattedTotal = Convert.ToDecimal(dataGridView3.Rows[i].Cells[4].Value).ToString("0.00");


                // Assuming startX and startY are defined somewhere in your code
                e.Graphics.DrawString(formattedQty, font, brush, new RectangleF(startX + 285, startY, 150, 20), rightAlignedFormat); //qty
                e.Graphics.DrawString(formattedRate, font, brush, new RectangleF(startX + 410, startY, 150, 20), rightAlignedFormat); //rate
                e.Graphics.DrawString(formattedTotal, font, brush, new RectangleF(startX + 550, startY, 150, 20), rightAlignedFormat); //total


                startY += lineHeight;
            }
            startY += 210;

            //narration
            StringFormat leftAlignedFormat = new StringFormat();
            leftAlignedFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Narration / Payment Details", fontbold, brush, startX, startY);
            e.Graphics.DrawLine(pn, startX, startY + 25, startX + 220, startY + 25);
            startY += lineHeight + 10;
            e.Graphics.DrawString(textBoxNarration.Text, font, brush, new RectangleF(startX, startY, 350, 100), leftAlignedFormat);

            lineHeight += 7;
            startY = startY - 20;
            // Print totals
            e.Graphics.DrawString("Sub Total : ", font, brush, startX + 400, startY);
            e.Graphics.DrawString(textBoxTotalAmount.Text, font, brush, new RectangleF(startX + 550, startY, 150, 20), rightAlignedFormat);
            startY += lineHeight;
            e.Graphics.DrawString("Discount : ", font, brush, startX + 400, startY);
            e.Graphics.DrawString(textBoxDiscount.Text, font, brush, new RectangleF(startX + 550, startY, 150, 20), rightAlignedFormat);
            startY += lineHeight;
            e.Graphics.DrawString("Sub Total Less Discount : ", font, brush, startX + 400, startY);
            e.Graphics.DrawString(textBoxTotalAmount.Text, font, brush, new RectangleF(startX + 550, startY, 150, 20), rightAlignedFormat);
            startY += lineHeight;
            e.Graphics.DrawString("TAX Rate (%) : ", font, brush, startX + 400, startY);
            e.Graphics.DrawString(textBoxTaxPercent.Text, font, brush, new RectangleF(startX + 550, startY, 150, 20), rightAlignedFormat);
            startY += lineHeight;
            e.Graphics.DrawString("TAX : ", font, brush, startX + 400, startY);
            e.Graphics.DrawString(textBoxTaxAmount.Text, font, brush, new RectangleF(startX + 550, startY, 150, 20), rightAlignedFormat);
            startY += lineHeight;
            e.Graphics.DrawString("Shipping / Additional Charge : ", font, brush, startX + 400, startY);
            e.Graphics.DrawString(textBoxShippingCharge.Text, font, brush, new RectangleF(startX + 550, startY, 150, 20), rightAlignedFormat);
            startY += lineHeight + 5;

            Font fontbold14 = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawString("Total Amount : ", fontbold14, brush, startX + 400, startY);
            e.Graphics.DrawString(textBoxCurrency.Text + " " + textBoxGrandTotal.Text, fontbold14, brush, new RectangleF(startX + 550, startY, 150, 20), rightAlignedFormat);
            e.Graphics.DrawLine(pn, startX + 400, startY + 25, startX + 700, startY + 25);

            startY += lineHeight + 5;
            if (checkBoxPrintInvoicefooterImage.Checked)
            {
                Image image = Image.FromFile(Application.StartupPath + "/footer.png");
                // Calculate the position to center the image on the page
                float xPos = (e.PageSettings.PrintableArea.Width - image.Width) / 2;
                e.Graphics.DrawImage(image, xPos, startY);
                image.Dispose();
            }

            if (checkBoxPrintSignatureandStamp.Checked)
            {
                Image image = Image.FromFile(Application.StartupPath + "/signandstamp.png");
                // Calculate the position to center the image on the page
                float xPos = (e.PageSettings.PrintableArea.Width - image.Width) / 2;
                e.Graphics.DrawImage(image, xPos + 200, startY);
                startY += image.Height + 25;
                image.Dispose();
            }

        }

        private void buttonPasteFromExcelCopy_Click(object sender, EventArgs e)
        {

            try
            {
                string s = Clipboard.GetText();

                string[] lines = s.Replace("\n", "").Split('\r');
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(lines.Length - 2);
                string[] fields;
                int row = 0;
                int col = 0;
                Boolean firstrowHeading = true;

                foreach (string item in lines)
                {
                    fields = item.Split('\t');
                    foreach (string f in fields)
                    {
                        //Console.WriteLine(f);
                        if (checkBoxFirstRowHeading.Checked && firstrowHeading)
                        {
                            dataGridView2.Columns[col].HeaderText = f.ToString() + " (" + col.ToString() + ")";
                            row = -1;
                        }
                        else
                        {
                            dataGridView2[col, row].Value = f;
                        }
                        col++;
                    }
                    firstrowHeading = false;
                    row++;
                    col = 0;
                }
                TxtNoShipment.Text = (row - 1).ToString();
            }
            catch { }
        }


        private void LoadSavedSettings()
        {
            int cont = 0;
            try
            {
                //Auto change Save
                textBoxInvoiceHeading.Text = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_InvoiceHeadingText", "INVOICE").ToString();
                checkBoxPrintInvoiceHeading.Checked = Convert.ToBoolean(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Need_print_InvoiceHeading", "0").ToString());
                checkBoxPrintInvoiceHeaderImage.Checked = Convert.ToBoolean(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Need_print_headerimage", "0").ToString());
                checkBoxPrintInvoicefooterImage.Checked = Convert.ToBoolean(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Need_print_footerimage", "0").ToString());
                checkBoxPrintSignatureandStamp.Checked = Convert.ToBoolean(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Need_print_signature_and_stamp", "0").ToString());

                textBoxCurrency.Text = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Currency_Symbol", "AED").ToString();


                //cont = Convert.ToInt32(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "SahamDHLSoftAutoChangeTotCount", "0").ToString());
                //for (int i = 0; i <= cont - 1; i++)
                //{
                //    string st = "";
                //    //   dataGridViewAutoChange.Rows[i].Cells[1].Value.ToString() + "|" + dataGridViewAutoChange.Rows[i].Cells[2].Value.ToString() + "|" + dataGridViewAutoChange.Rows[i].Cells[3].Value.ToString() + "|" + dataGridViewAutoChange.Rows[i].Cells[4].Value.ToString();
                //    st = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "SahamDHLSoftAutoChange" + i.ToString(), "").ToString();
                //    string[] str = st.Split('|');
                //    dataGridViewAutoChange.Rows.Add((i + 1).ToString(), str[0], str[1], str[2], str[3]);
                //}
            }
            catch { }

        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Need_print_InvoiceHeading", checkBoxPrintInvoiceHeading.Checked);
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Need_print_headerimage", checkBoxPrintInvoiceHeaderImage.Checked);
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Need_print_footerimage", checkBoxPrintInvoicefooterImage.Checked);
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Need_print_signature_and_stamp", checkBoxPrintSignatureandStamp.Checked);

            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_InvoiceHeadingText", textBoxInvoiceHeading.Text);
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Currency_Symbol", textBoxCurrency.Text);

            MessageBox.Show("Settings Saved Successfully.");
        }

        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int slno = 0;
            decimal totalQty = 0;
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                slno++;
                row.Cells[0].Value = slno;
                try
                {
                    row.Cells[4].Value = Convert.ToDecimal(row.Cells[2].Value) * Convert.ToDecimal(row.Cells[3].Value);
                    totalQty += Convert.ToDecimal(row.Cells[2].Value);
                    totalAmount += Convert.ToDecimal(row.Cells[4].Value);
                }
                catch
                {

                }

            }
            textBoxTotalQty.Text = totalQty.ToString("0.00");
            textBoxTotalAmount.Text = totalAmount.ToString("0.00");

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string query = @"INSERT INTO Invoices (VoucherNo, InvoiceNo,InvoiceDate, SenderName, SenderAddress, CustomerName, CustomerAddress,RecipientName,RecipientAddress,
                                InternalReference,TotalWeight,ItemsValue,NumberofPackages,Currency,SubTotal,Discount,ShippingCharge,TotalAmount,Narration )
                 VALUES ((SELECT COALESCE(MAX(VoucherNo), 0) + 1 FROM Invoices), @InvoiceNo,@InvoiceDate, @SenderName, @SenderAddress, @CustomerName, @CustomerAddress, @RecipientName,
                        @RecipientAddress,@InternalReference,@TotalWeight,@ItemsValue,@NumberofPackages,@Currency,@SubTotal,@Discount, @ShippingCharge,@TotalAmount,@Narration);
                 SELECT last_insert_rowid();";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InvoiceNo", textBoxInvoiceNo.Text);
                    command.Parameters.AddWithValue("@InvoiceDate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@SenderName", textBoxSenderName.Text);
                    command.Parameters.AddWithValue("@SenderAddress", textBoxSenderAddress.Text);
                    command.Parameters.AddWithValue("@CustomerName", textBoxCustomerName.Text);
                    command.Parameters.AddWithValue("@CustomerAddress", textBoxCustomeAddress.Text);
                    command.Parameters.AddWithValue("@RecipientName", textBoxShipTo.Text);
                    command.Parameters.AddWithValue("@RecipientAddress", textBoxShippingAddress.Text);
                    command.Parameters.AddWithValue("@InternalReference", "NA");
                    command.Parameters.AddWithValue("@TotalWeight", textBoxTotalWeight.Text);
                    command.Parameters.AddWithValue("@ItemsValue", textBoxItemValue.Text);
                    command.Parameters.AddWithValue("@NumberofPackages", textBoxNoPackage.Text);
                    command.Parameters.AddWithValue("@Currency", textBoxCurrency.Text);
                    command.Parameters.AddWithValue("@SubTotal", textBoxTotalAmount.Text);
                    command.Parameters.AddWithValue("@Discount", textBoxDiscount.Text);
                    command.Parameters.AddWithValue("@ShippingCharge", textBoxShippingCharge.Text);
                    command.Parameters.AddWithValue("@TotalAmount", textBoxGrandTotal.Text);
                    command.Parameters.AddWithValue("@Narration", textBoxNarration.Text);


                    // Execute the query
                    object result = command.ExecuteScalar();

                    // Check if the result is not null
                    if (result != null)
                    {
                        int insertedId = Convert.ToInt32(result);
                        string queryd = queryd = @"INSERT INTO InvoicesItems (InvoiceId, Slno, Description, Qty, Rate, Total)
                                    VALUES (@InvoiceId, @Slno, @Description, @Qty, @Rate, @Total);";

                        for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                        {
                            SQLiteCommand cmdDetails = new SQLiteCommand(queryd, connection);
                            cmdDetails.Parameters.AddWithValue("@InvoiceId", insertedId);
                            cmdDetails.Parameters.AddWithValue("@Slno", dataGridView3.Rows[i].Cells[0].Value.ToString());
                            cmdDetails.Parameters.AddWithValue("@Description", dataGridView3.Rows[i].Cells[1].Value.ToString());
                            cmdDetails.Parameters.AddWithValue("@Qty", dataGridView3.Rows[i].Cells[2].Value.ToString());
                            cmdDetails.Parameters.AddWithValue("@Rate", dataGridView3.Rows[i].Cells[3].Value.ToString());
                            cmdDetails.Parameters.AddWithValue("@Total", dataGridView3.Rows[i].Cells[4].Value.ToString());
                            cmdDetails.ExecuteNonQuery();
                            cmdDetails.Dispose();

                        }
                        MessageBox.Show("Saved Successfully.");
                    }

                    else
                    {
                        Console.WriteLine("Error retrieving inserted ID.");
                    }
                }
            }
        }



        private void GenerateInvoieNo()
        {
            try
            {

                using (SQLiteConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT ifnull(MAX(VoucherNo), 1) as InvoiceNo FROM Invoices";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        int InvoiceNo = Convert.ToInt32(command.ExecuteScalar());
                        textBoxInvoiceNo.Text = "INV-" + InvoiceNo.ToString() + DateTime.Now.ToString("yyyy");


                    }
                }
            }
            catch
            {

            }
        }

        private void buttonSetCreateTables_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "initquery", false);
        }

        private void buttonReaderExecute_Click(object sender, EventArgs e)
        {
            string query = textBoxCommandText.Text;
            DataTable dataTable = ReadDatas(query);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string invoiceid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxSenderName.Text = dataGridView1.Rows[e.RowIndex].Cells["SenderName"].Value.ToString();
            textBoxSenderAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["SenderAddress"].Value.ToString();
            textBoxCustomerName.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
            textBoxCustomeAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerAddress"].Value.ToString();
            textBoxShipTo.Text = dataGridView1.Rows[e.RowIndex].Cells["RecipientName"].Value.ToString();
            textBoxShippingAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["RecipientAddress"].Value.ToString();
            textBoxItemValue.Text = dataGridView1.Rows[e.RowIndex].Cells["ItemsValue"].Value.ToString();
            textBoxTotalWeight.Text = dataGridView1.Rows[e.RowIndex].Cells["TotalWeight"].Value.ToString();
            textBoxInvoiceNo.Text = dataGridView1.Rows[e.RowIndex].Cells["InvoiceNo"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["InvoiceDate"].Value.ToString();
            textBoxDiscount.Text = dataGridView1.Rows[e.RowIndex].Cells["Discount"].Value.ToString();
            textBoxShippingCharge.Text = dataGridView1.Rows[e.RowIndex].Cells["ShippingCharge"].Value.ToString();
            textBoxNarration.Text = dataGridView1.Rows[e.RowIndex].Cells["Narration"].Value.ToString();
            textBoxTotalAmount.Text = dataGridView1.Rows[e.RowIndex].Cells["SubTotal"].Value.ToString();

            string qr = "select * from InvoicesItems where InvoiceId = " + invoiceid;
            DataTable dt = ReadDatas(qr);
            dataGridView3.Rows.Clear();
            dataGridView3.Rows.Add(dt.Rows.Count);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView3.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridView3.Rows[i].Cells[1].Value = dt.Rows[i]["Description"].ToString();
                dataGridView3.Rows[i].Cells[2].Value = dt.Rows[i]["Qty"].ToString();
                dataGridView3.Rows[i].Cells[3].Value = dt.Rows[i]["Rate"].ToString();
                dataGridView3.Rows[i].Cells[4].Value = dt.Rows[i]["Total"].ToString();
            }
        }

        private void textBoxTaxPercent_TextChanged(object sender, EventArgs e)
        {
            UpdateGrandTotal();
        }

        private void UpdateGrandTotal()
        {
            decimal totalAmount = 0;
            decimal taxPercent = 0;
            decimal taxAmount = 0;

            if (!decimal.TryParse(textBoxTotalAmount.Text, out decimal tamount) || tamount == 0)
            {
                textBoxTotalAmount.Text = "0.00";
            }
            if (!decimal.TryParse(textBoxTaxPercent.Text, out decimal taxp) || taxp == 0)
            {
                textBoxTaxPercent.Text = "0.00";
            }
            if (!decimal.TryParse(textBoxTaxAmount.Text, out decimal taxam) || taxam == 0)
            {
                textBoxTaxAmount.Text = "0.00";
            }
            if (!decimal.TryParse(textBoxDiscount.Text, out decimal discount) || discount == 0)
            {
                textBoxDiscount.Text = "0.00";
            }
            if (!decimal.TryParse(textBoxShippingCharge.Text, out decimal shippingCharge) || shippingCharge == 0)
            {
                textBoxShippingCharge.Text = "0.00";
            }

            // Parse values from textboxes, handle invalid input gracefully
            if (decimal.TryParse(textBoxTotalAmount.Text, out totalAmount) &&
                decimal.TryParse(textBoxTaxPercent.Text, out taxPercent) &&
                decimal.TryParse(textBoxTaxAmount.Text, out taxAmount) &&
                decimal.TryParse(textBoxDiscount.Text, out discount) &&
                decimal.TryParse(textBoxShippingCharge.Text, out shippingCharge))
            {
                textBoxAfterDiscount.Text = (totalAmount - discount).ToString("0.00");
                totalAmount = totalAmount - discount;
                textBoxTaxAmount.Text = (totalAmount * taxPercent / 100).ToString("0.00");
                // Calculate grand total
                decimal grandTotal = totalAmount + (totalAmount * taxPercent / 100);

                grandTotal = grandTotal + shippingCharge;
                // Update textBoxGrandTotal with the calculated value
                textBoxGrandTotal.Text = grandTotal.ToString("0.00");
            }
            else
            {
                // Handle invalid input, for example, clear textBoxGrandTotal or display an error message
                textBoxGrandTotal.Text = "0.00";
            }
        }

        private void textBoxTaxAmount_TextChanged(object sender, EventArgs e)
        {
            UpdateGrandTotal();
        }

        private void textBoxTotalAmount_TextChanged(object sender, EventArgs e)
        {
            UpdateGrandTotal();
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            UpdateGrandTotal();
        }

        private void textBoxShippingCharge_TextChanged(object sender, EventArgs e)
        {
            UpdateGrandTotal();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSenderName.Text = string.Empty;
            textBoxSenderAddress.Text = string.Empty;
            textBoxShippingCharge.Text = string.Empty;
            textBoxCustomerName.Text = string.Empty;
            textBoxCustomeAddress.Text = string.Empty;
            textBoxShipTo.Text = string.Empty;
            textBoxShippingAddress.Text = string.Empty;
            textBoxNoPackage.Text = "1";
            dateTimePicker1.Text = DateTime.Now.ToString();
            textBoxNarration.Text = string.Empty;
            dataGridView3.Rows.Clear();
            textBoxTotalAmount.Text = "0.00";
            textBoxTotalQty.Text = "0.00";

            LoadData();
            LoadSavedSettings();
            DatabaseHelper.CreateInvoiceTable();
            GenerateInvoieNo();

            UpdateGrandTotal();

        }

        private void SetdefaultcolumnForCopyExcel()
        {
                        dataGridView2.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "SenderName", HeaderText = "Sender Name" },
                new DataGridViewTextBoxColumn { Name = "SenderPhone", HeaderText = "Sender Phone" },
                new DataGridViewTextBoxColumn { Name = "SenderPhone2", HeaderText = "Sender Phone2" },
                new DataGridViewTextBoxColumn { Name = "SenderCompanyName", HeaderText = "Sender Company Name" },
                new DataGridViewTextBoxColumn { Name = "SenderAddress", HeaderText = "Sender Address" },
                new DataGridViewTextBoxColumn { Name = "SenderCountry", HeaderText = "Sender Country" },
                new DataGridViewTextBoxColumn { Name = "SenderCity", HeaderText = "Sender City" },
                new DataGridViewTextBoxColumn { Name = "RecipientName", HeaderText = "Recipient Name" },
                new DataGridViewTextBoxColumn { Name = "RecipientPhone", HeaderText = "Recipient Phone" },
                new DataGridViewTextBoxColumn { Name = "RecipientPhone2", HeaderText = "Recipient Phone2" },
                new DataGridViewTextBoxColumn { Name = "RecipientCompanyName", HeaderText = "Recipient Company Name" },
                new DataGridViewTextBoxColumn { Name = "RecipientAddress", HeaderText = "Recipient Address" },
                new DataGridViewTextBoxColumn { Name = "RecipientCountry", HeaderText = "Recipient Country" },
                new DataGridViewTextBoxColumn { Name = "RecipientCity", HeaderText = "Recipient City" },
                new DataGridViewTextBoxColumn { Name = "RecipientDistrict", HeaderText = "Recipient District" },
                new DataGridViewTextBoxColumn { Name = "RecipientPostalCode", HeaderText = "Recipient PostalCode" },
                new DataGridViewTextBoxColumn { Name = "InternalReference", HeaderText = "Internal Reference" },
                new DataGridViewTextBoxColumn { Name = "TotalWeight", HeaderText = "Total Weight" },
                new DataGridViewTextBoxColumn { Name = "ItemsValue", HeaderText = "Items Value" },
                new DataGridViewTextBoxColumn { Name = "NumberOfPackages", HeaderText = "Number of Packages" },
                new DataGridViewTextBoxColumn { Name = "Currency", HeaderText = "Currency" },
                new DataGridViewTextBoxColumn { Name = "ShippingOptions", HeaderText = "Shipping Options" },
                new DataGridViewTextBoxColumn { Name = "ContentsOfShipments", HeaderText = "Contents of Shipments" },
                new DataGridViewTextBoxColumn { Name = "VatPaid", HeaderText = "Vat Paid" },
                new DataGridViewTextBoxColumn { Name = "DutyPaid", HeaderText = "Duty Paid" }
            );

        }

        private void buttonExcelCopySaveAndPrint_Click(object sender, EventArgs e)
        {
           for(int i=0;i<= dataGridView2.Rows.Count-2;i++)
            {
                textBoxSenderName.Text = dataGridView2.Rows[i].Cells["SenderName"]?.Value?.ToString();
                string str = string.Empty  ;
                str += dataGridView2.Rows[i].Cells["SenderCompanyName"]?.Value?.ToString();
                str += dataGridView2.Rows[i].Cells["SenderAddress"]?.Value?.ToString();
                str += "\n "+ dataGridView2.Rows[i].Cells["SenderPhone"]?.Value?.ToString();
                str += "\n "+ dataGridView2.Rows[i].Cells["SenderPhone2"]?.Value?.ToString();

                textBoxSenderAddress.Text = str;


            }
        }
    }

}

public class DatabaseHelper
{
    private const string ConnectionString = "Data Source=InvoiceDatabase.db;Version=3;";

    public static SQLiteConnection GetConnection()
    {
        return new SQLiteConnection(ConnectionString);
    }

    public static void CreateInvoiceTable()
    {
      Boolean  initquery = Convert.ToBoolean(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "initquery", false).ToString());

        if(initquery)
        {
            return;
        }


        try
        {
            using (SQLiteConnection connection = GetConnection())
            {
                connection.Open();

                string query = @"CREATE TABLE IF NOT EXISTS Invoices (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                VoucherNo Integer,
                                InvoiceNo TEXT,
                                InvoiceDate datetime,
                                SenderName TEXT,
                                SenderPhone TEXT,
                                SenderAddress  TEXT,
                                CustomerName TEXT,
                                CustomerAddress TEXT,
                                RecipientName TEXT,
                                RecipientAddress TEXT,
                                InternalReference TEXT,
                                TotalWeight TEXT,
                                ItemsValue TEXT,
                                NumberofPackages TEXT,
                                Currency TEXT,
                                SubTotal Decimal(10,2),
                                Discount Decimal(10,2),
                                ShippingCharge Decimal(10,2),
                                TotalAmount Decimal(10,2),
                                Narration TEXT
                            )";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }


                query = @"CREATE TABLE IF NOT EXISTS InvoicesItems (
                         Id INTEGER PRIMARY KEY AUTOINCREMENT,
                         InvoiceId integer,
                         Slno integer,
                         Description TEXT,
                         Qty integer,
                         Rate  decimal(10,2),
                         Total decimal(10,2)
                     

                     )";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);

        }
        finally
        {
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "initquery", true);

        }

    }


}