using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace Databases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<Exchange> parthlist = new List<Exchange>();
            String link_XML = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange";
            XmlDocument doc = new XmlDocument();
            doc.Load(link_XML);
            Exchange ex = new Exchange();


            foreach (XmlNode node in doc.DocumentElement)
            {
               foreach (XmlNode childe in node.ChildNodes)
                {
                   if(childe.Name == "txt")
                    {
                        ex.txt = childe.InnerText;
                    }
                   if(childe.Name == "rate")
                    {
                        ex.rate = childe.InnerText; 
                    }
                    if (childe.Name == "cc")
                    {
                        ex.cc = childe.InnerText;
                    }
                    if (childe.Name == "exchangedate")
                    {
                        ex.exchangedate = childe.InnerText;
                    }
                    //parthlist.Add(ex);
                }
                if (ex.txt == "Долар США")
                {
                    textBox1.Text += ex.txt + Environment.NewLine;
                    textBox1.Text += ex.rate + Environment.NewLine;
                    textBox1.Text += ex.cc + Environment.NewLine;
                    textBox1.Text += ex.exchangedate += Environment.NewLine;
                    textBox1.Text += "**************" + Environment.NewLine;

                }
                else if (ex.txt == "Євро")
                {
                    textBox1.Text += ex.txt + Environment.NewLine;
                    textBox1.Text += ex.rate + Environment.NewLine;
                    textBox1.Text += ex.cc + Environment.NewLine;
                    textBox1.Text += ex.exchangedate += Environment.NewLine;
                    textBox1.Text += "**************" + Environment.NewLine;
                }
                else if (ex.txt == "Російський рубль")
                {
                    textBox1.Text += "**************" + Environment.NewLine;
                    textBox1.Text += ex.txt + Environment.NewLine;
                    textBox1.Text += ex.rate + Environment.NewLine;
                    textBox1.Text += ex.cc + Environment.NewLine;
                    textBox1.Text += ex.exchangedate += Environment.NewLine;
                    textBox1.Text += "**************" + Environment.NewLine;
                }
            }

        }

    }
}
