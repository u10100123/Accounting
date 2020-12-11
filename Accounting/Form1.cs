using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class items
        {
            public string date { get; set; }
            public string item { get; set; }
            public int price { get; set; }
        }
        List<items> itm = new List<items>();
        public int showprice=0;

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = monthCalendar1.SelectionRange.Start.Date.ToShortDateString();
            string item = textBox2.Text;
            itm.Add(new items() { date = date, item = item, price = showprice});

            richTextBox1.Text= "日期"+"\t"+"品項"+"\t"+"價格" + Environment.NewLine;
            for (int i = itm.Count-1; i >-1; i--)
            {
                richTextBox1.Text += itm[i].date + "\t" + itm[i].item + " \t" + itm[i].price + Environment.NewLine;
            }
            showprice = 0;
            label1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showprice = showprice * 10 + 1;
            label1.Text = showprice.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showprice = showprice * 10 + 2;
            label1.Text = showprice.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showprice = showprice * 10 + 3;
            label1.Text = showprice.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showprice = showprice * 10 + 4;
            label1.Text = showprice.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showprice = showprice * 10 + 5;
            label1.Text = showprice.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showprice = showprice * 10 + 6;
            label1.Text = showprice.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            showprice = showprice * 10 + 7;
            label1.Text = showprice.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showprice = showprice * 10 + 8;
            label1.Text = showprice.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showprice = showprice * 10 + 9;
            label1.Text = showprice.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showprice = showprice * 10;
            label1.Text = showprice.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            showprice = 0;
            label1.Text = "";
            textBox2.Text = "";
        }
    }
}
