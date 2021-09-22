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

namespace fileIOGuiDemo
{
    public partial class Form1 : Form
    {
        
        List<Person> people = new List<Person>();
        BindingSource bs = new BindingSource();
        string filepath = @"C:\Demo\test1.txt";

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = people;
            listBox1.DataSource = bs;
        }

        private void btn_addToList_Click(object sender, EventArgs e)
        {
            
            Person p = new Person(txt_firstName.Text, txt_lastName.Text, txt_uRL.Text);
            people.Add(p);
            bs.ResetBindings(false);

        }
        List<string> outContents = new List<string>();
        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            foreach(Person p in people)
            {
                outContents.Add(p.ToString());
            }
            File.WriteAllLines(filepath, outContents);
        }

        private void btn_readFile_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();
            foreach (string line in lines)
            {
                string[] items = line.Split(':');
                Person p = new Person(items[0], items[1], items[2]);
                people.Add(p);
                bs.ResetBindings(false);
            }
            
            
        }
    }
}
