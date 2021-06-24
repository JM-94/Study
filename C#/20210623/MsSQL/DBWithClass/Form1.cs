using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWithClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataLoad();
        }

        private void DataLoad()
        {
            DataManager.Load();
            dataGridView1.DataSource = DataManager.tb_custs;
        }
        private void button_Select_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            TB_CUST temp = new TB_CUST();
            temp.cust_id = textBox_ID.Text;
            temp.birth_dt = textBox_Birth.Text;
            DataManager.tb_custs.Add(temp);
            DataManager.Save();
            DataLoad();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                TB_CUST temp = DataManager.tb_custs.Single(
                    (x) => x.cust_id.Trim().ToString() == textBox_ID.Text);
                temp.birth_dt = textBox_Birth.Text;
                DataManager.Save();
                DataLoad();
            }
            catch (Exception ex)
            {

            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Single 사용 방법(람다 써야 함)
            try
            {
                TB_CUST temp = DataManager.tb_custs.Single(
                    (x) => x.cust_id.Trim().ToString() == textBox_ID.Text);
                DataManager.tb_custs.Remove(temp);
                DataManager.Save();
                DataLoad();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
