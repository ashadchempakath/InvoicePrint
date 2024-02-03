using System.Data.SQLite;

namespace WindocPrint
{
    using System.Data;
    using System.Data.SQLite;
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
            dataGridView2.ColumnCount = 100;
            LoadData();
            LoadSavedSettings();
            DatabaseHelper.CreateInvoiceTable();
        }

        public static DataTable ReadInvoices()
        {
            try
            {

                using (SQLiteConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM Invoices";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        return dataTable;
                    }
                }
            }
            catch
            {
                return null;
            }
        }
        private void LoadData()
        {
            DataTable dataTable = ReadInvoices();
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
                // Calculate the position to center the image on the page
                float xPos = (e.PageSettings.PrintableArea.Width - image.Width) / 2;
                //float yPos = (e.PageSettings.PrintableArea.Height - image.Height) / 2;
                e.Graphics.DrawImage(image, xPos, startY);
                startY += image.Height + 25;
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

            e.Graphics.DrawString("Bill To", fontbold, brush, startX, startY);
            Pen pn = new Pen(Color.Black);
            startY += lineHeight;
            e.Graphics.DrawLine(pn, startX, startY, startX + 160, startY);
            startY += 10;

            e.Graphics.DrawString(textBoxCustomerName.Text, font, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString(textBoxCustomeAddress.Text, font, brush, startX, startY);
            startY += (lineHeight + 50);



            // Print invoice items
            //foreach (var item in invoiceData.InvoiceItems)
            //{
            e.Graphics.DrawString($"Item: {textBoxInvoiceNo.Text}, Quantity: {textBoxInvoiceNo.Text}, Total: {textBoxInvoiceNo.Text}", font, brush, startX, startY);
            startY += lineHeight;
            //}

            // Print totals
            startY += lineHeight;
            e.Graphics.DrawString($"Total Amount: {textBoxInvoiceNo.Text}", font, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"VAT: {textBoxInvoiceNo.Text}", font, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Grand Total: {textBoxInvoiceNo.Text}", font, brush, startX, startY);

        }

        private void buttonPasteFromExcelCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asdf");
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
                textBoxInvoiceHeading.Text = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_InvoiceHeadingText", "INVOICE-").ToString();
                checkBoxPrintInvoiceHeading.Checked = Convert.ToBoolean(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Need_print_InvoiceHeading", "0").ToString());
                checkBoxPrintInvoiceHeaderImage.Checked = Convert.ToBoolean(Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_Need_print_headerimage", "0").ToString());


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
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "Windocprint_InvoiceHeadingText", textBoxInvoiceHeading.Text);
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

                string query = @"INSERT INTO Invoices (SenderName, SenderPhone, SenderPhone2)
                             VALUES (@SenderName, @SenderPhone, @SenderPhone2)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SenderName", "serd");
                    command.Parameters.AddWithValue("@SenderPhone", "65656");
                    command.Parameters.AddWithValue("@SenderPhone2", "2144545");


                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International", "initquery", false);
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
                                SenderName TEXT,
                                SenderPhone TEXT,
                                SenderPhone2 TEXT,
                                SenderCompanyName TEXT,
                                SenderAddress  TEXT,
                                SenderCountry TEXT,
                                SenderCity TEXT,
                                RecipientName TEXT,
                                RecipientPhone TEXT TEXT,
                             RecipientPhone2 TEXT,
                             RecipientCompany TEXT,
                                NameRecipient TEXT,
                                Adderess TEXT,
                             RecipientCountry TEXT,
                             RecipientCity TEXT,
                             RecipientDistrict TEXT,
                             RecipientPostalCode TEXT,
                             InternalReference TEXT,
                             TotalWeight TEXT,
                             ItemsValue TEXT,
                             NumberofPackages TEXT,
                             Currency TEXT,
                             ShippingOptions TEXT,
                             ContentsofShipments TEXT,
                             VatPaid TEXT,
                             DutyPaid TEXT

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