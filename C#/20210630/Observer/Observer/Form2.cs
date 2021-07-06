using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form2 : Form, Observer
    {
        public Form2(Subject sub)
        {
            sub.register(this);
            InitializeComponent();
        }
        

        public void update(string value)
        {
            textBox1.Text = value;
        }
    }
}
