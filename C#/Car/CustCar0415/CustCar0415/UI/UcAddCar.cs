using CustCar0415.Controll;
using CustCar0415.Model;
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
    partial class UcAddCar : UserControl
    {
        string model;
        string company;
        string color;
        string price;
        UnionController uHandler;
        AddData ad;
        public delegate void AddCarConfirmEventHandler(
            object sender, EventArgs e);
        public event AddCarConfirmEventHandler addCarConfirmEvent;

        public UcAddCar()
        {
            InitializeComponent();
        }
        public UcAddCar(UnionController uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }
        public UcAddCar(UnionController uHandler, AddData ad)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }

        private void ucComboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = showCarCombo(sender);
            ucInfoModel.Text = model;
            ucInfoModel.ForeColor = Color.Red;
            switch (model)
            {
                case "그랜저":
                    ucPictureBox1.Image = Properties.Resources.gran;
                    ucPictureBox2.Image = Properties.Resources.gran_side;
                    ucPictureBox3.Image = Properties.Resources.gran_back;
                    ucPictureBox4.Image = Properties.Resources.gran_in;
                    break;
                case "우루스":
                    ucPictureBox1.Image = Properties.Resources.urus;
                    ucPictureBox2.Image = Properties.Resources.urus_side;
                    ucPictureBox3.Image = Properties.Resources.urus_back;
                    ucPictureBox4.Image = Properties.Resources.urus_in;
                    break;
                case "제네시스":
                    ucPictureBox1.Image = Properties.Resources.g90;
                    ucPictureBox2.Image = Properties.Resources.g90_side;
                    ucPictureBox3.Image = Properties.Resources.g90_back;
                    ucPictureBox4.Image = Properties.Resources.g90_in;
                    break;
                case "K8":
                    ucPictureBox1.Image = Properties.Resources.k8;
                    ucPictureBox2.Image = Properties.Resources.k8_side;
                    ucPictureBox3.Image = Properties.Resources.k8_back;
                    ucPictureBox4.Image = Properties.Resources.k8_in;
                    break;
                case "K7":
                    ucPictureBox1.Image = Properties.Resources.k7;
                    ucPictureBox2.Image = Properties.Resources.k7_side;
                    ucPictureBox3.Image = Properties.Resources.k7_back;
                    ucPictureBox4.Image = Properties.Resources.k7_in;
                    break;
            }
        }

        private void ucComboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = showCarCombo(sender);
            ucInfoColor.Text = color;
            ucInfoColor.ForeColor = Color.Red;
        }

        private void ucComboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            company = showCarCombo(sender);
            ucInfoCompany.Text = company;
            ucInfoCompany.ForeColor = Color.Red;
        }

        private void ucComboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            price = showCarCombo(sender);
            ucInfoPrice.Text = price;
            ucInfoPrice.ForeColor = Color.Red;
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

        private void ucAddCarOk_Click(object sender, EventArgs e)
        {
            if (model == null)
            {
                MessageBox.Show("모델을 선택하세요.");
                ucComboModel.Select();
                return;
            }

            if (color == null)
            {
                MessageBox.Show("색상을 선택하세요.");
                ucComboModel.Select();
                return;
            }

            if (company == null)
            {
                MessageBox.Show("회사을 선택하세요.");
                ucComboModel.Select();
                return;
            }

            if (price == null)
            {
                MessageBox.Show("가격을 선택하세요.");
                ucComboModel.Select();
                return;
            }

            uHandler.CarHandle.addItem(new Car(model, color, company, price));
            MessageBox.Show("구매할 차량 정보가 저장되었습니다.");
            ucAddCarOk.Enabled = false;
            //ad.setStatusInfo("차량 정보가 등록되었습니다.");
            if (addCarConfirmEvent != null)
            {
                addCarConfirmEvent(this, new EventArgs());
            }
        }

        private void ucAddCarInit_Click(object sender, EventArgs e)
        {

        }
    }
}
