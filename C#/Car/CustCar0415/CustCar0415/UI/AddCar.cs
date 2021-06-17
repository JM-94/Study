using CustCar0415.Controll;
using CustCar0415.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustCar0415.UI
{
    partial class AddCar : MaterialForm
    {
        string model;
        string company;
        string color;
        string price;
        UnionController uHandler;

        public AddCar()
        {
            InitializeComponent();
        }
        public AddCar(UnionController uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }

        private void addCarOk_Click(object sender, EventArgs e)
        {
            if(model == null)
            {
                MessageBox.Show("모델을 선택하세요.");
                comboModel.Select();
                return;
            }

            if (color == null)
            {
                MessageBox.Show("색상을 선택하세요.");
                comboModel.Select();
                return;
            }

            if (company == null)
            {
                MessageBox.Show("회사을 선택하세요.");
                comboModel.Select();
                return;
            }

            if (price == null)
            {
                MessageBox.Show("가격을 선택하세요.");
                comboModel.Select();
                return;
            }

            uHandler.CarHandle.addItem(new Car(
                model, color, company, price));
            MessageBox.Show("구매할 차량 정보가 저장되었습니다.");
            Close();
        }

        private void addCarCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = showCarCombo(sender);
            infoModel.Text = model;
            infoModel.ForeColor = Color.Red;
            switch(model)
            {                
                case "그랜저":
                    pictureBox1.Image = Properties.Resources.gran;
                    pictureBox2.Image = Properties.Resources.gran_side;
                    pictureBox3.Image = Properties.Resources.gran_back;
                    pictureBox4.Image = Properties.Resources.gran_in;
                    break;
                case "우루스":
                    pictureBox1.Image = Properties.Resources.urus;
                    pictureBox2.Image = Properties.Resources.urus_side;
                    pictureBox3.Image = Properties.Resources.urus_back;
                    pictureBox4.Image = Properties.Resources.urus_in;
                    break;
                case "제네시스":
                    pictureBox1.Image = Properties.Resources.g90;
                    pictureBox2.Image = Properties.Resources.g90_side;
                    pictureBox3.Image = Properties.Resources.g90_back;
                    pictureBox4.Image = Properties.Resources.g90_in;
                    break;
                case "K8":
                    pictureBox1.Image = Properties.Resources.k8;
                    pictureBox2.Image = Properties.Resources.k8_side;
                    pictureBox3.Image = Properties.Resources.k8_back;
                    pictureBox4.Image = Properties.Resources.k8_in;
                    break;
                case "K7":
                    pictureBox1.Image = Properties.Resources.k7;
                    pictureBox2.Image = Properties.Resources.k7_side;
                    pictureBox3.Image = Properties.Resources.k7_back;
                    pictureBox4.Image = Properties.Resources.k7_in;
                    break;                
            }
        }

        private void comboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            company = showCarCombo(sender);
            infoCompany.Text = company;
            infoCompany.ForeColor = Color.Red;
        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            color =  showCarCombo(sender);
            infoColor.Text = color;
            infoColor.ForeColor = Color.Red;
        }

        private void comboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            price = showCarCombo(sender);
            infoPrice.Text = price;
            infoPrice.ForeColor = Color.Red;
        }

        private string showCarCombo(object obj)
        {
            Sunny.UI.UIComboBox cb = obj as Sunny.UI.UIComboBox;
            Console.WriteLine("index : " + cb.SelectedIndex);
            string item = cb.SelectedItem.ToString();
            if (cb.SelectedIndex > -1)
            {
                Console.WriteLine("선택 : " + item);
            }

            return item;
        }
       
    }
}
