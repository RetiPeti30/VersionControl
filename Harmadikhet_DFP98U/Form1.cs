using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harmadikhet_DFP98U
{
    BindingList<User> users = new BindingList<User>();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource2.LastName;
            label2.Text = Resource2.FirstName;
            button1.Text = Resource2.Add;

            //listbox
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";

        }
    }
}
