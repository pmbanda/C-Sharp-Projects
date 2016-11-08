using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterInvoices
{
    public partial class frmInvoice : Form
    {
        const string DELIM = ",";
        const string FILENAME = @"H:\C#\Projects\EnterInvoices\bin\Debug\Invoices.txt";
        int num;
        string name;
        double amount;
        static FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);

        StreamWriter writer = new StreamWriter(outFile);
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnEnterRecord_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtInvoiceNumber.Text);
            name = txtName.Text;
            amount = Convert.ToDouble(txtAmount.Text);

            writer.WriteLine(num + DELIM + name + DELIM + amount);
            txtInvoiceNumber.Clear();
            txtName.Clear();
            txtAmount.Clear();
        }
    }
}
