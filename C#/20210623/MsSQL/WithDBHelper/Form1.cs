using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithDBHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            DBHelper dh = new DBHelper();
            dh.ex1 = 100;
            dh.ex2 = 200;
            dh.example();
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            DBSelect();
        }

        private void DBSelect()
        {
            DBHelper.Query_Select();
            dataGridView1.DataSource = DBHelper.ds;
            dataGridView1.DataMember = "TB_CUST";
        }
        

        private void button_Insert_Click(object sender, EventArgs e)
        {
            DBInsert();
            DBSelect();
        }



        private void DBInsert()
        {
            DBHelper.Query_Insert(textBox_ID.Text, textBox_Birth.Text);
            DBHelper.Query_Select();           
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            DBUpdate();
            DBSelect();
        }

        private void DBUpdate()
        {
            DBHelper.Query_update(textBox_ID.Text, textBox_Birth.Text);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DBDelete();
            DBSelect();
        }

        private void DBDelete()
        {
            DBHelper.Query_Delete(textBox_ID.Text);
        }
    }
}
