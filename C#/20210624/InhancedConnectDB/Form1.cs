using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InhancedConnectDB
{
    public partial class Form1 : Form
    {
        //괄호 안에 숫자를 입력하면 1 = mysql, 2 = oracle
        //입력하지 않으면 mssql
        DataManager instance = new DataManager();
        public Form1()
        {
            InitializeComponent();
            DataLoad();
        }

        private void DataLoad()
        {
            instance.Load();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = instance.tb_custs;
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {

            TB_CUST temp = new TB_CUST();
            temp.cust_id = textBox1.Text;
            temp.birth_dt = textBox2.Text;
            instance.tb_custs.Add(temp);
            instance.Save();
            DataLoad();
        }

        private void button_update_Click(object sender, EventArgs e)
        {

            try
            {
                TB_CUST temp = instance.tb_custs.Single
                    ((x) => x.cust_id.Trim().ToString() == textBox1.Text);
                //DataManager.tb_custs.Remove(temp);
                temp.birth_dt = textBox2.Text;
                instance.Save();
                DataLoad();
            }
            catch (Exception ex)
            {

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {


            try
            {
                //싱글은 pk 대상으로 해야 함
                //값이 두 개 들어 있으면 catch에서 걸림
                TB_CUST temp = instance.tb_custs.Single
                    ((x) => x.cust_id.Trim().ToString() == textBox1.Text);
                instance.tb_custs.Remove(temp);

                instance.Save();
                DataLoad();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
