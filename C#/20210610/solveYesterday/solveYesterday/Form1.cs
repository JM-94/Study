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

namespace solveYesterday
{
    public partial class Form1 : Form
    {
        const int NAME = 0;
        const int AGE = 1;
        const int HAKBEON = 2;
        const int HAKGWA = 3;
        const int GENDER = 4;

        //열거형
        enum Student_Data
        {
            NAME, AGE, HAKBEON, HAKGWA, GENDER

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_readCSV_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("test.csv", Encoding.GetEncoding("UTF-8"));

            //가장 첫번째 줄 데이터는 필요 없음
            reader.ReadLine(); //가장 첫번째 줄 읽기

            List<Student> students = new List<Student>();

            while (!reader.EndOfStream)
            {
                string[] temp = reader.ReadLine().Split(',');

                //Student st = new Student(temp[NAME], int.Parse(temp[AGE]), temp[HAKBEON], temp[HAKGWA], temp[GENDER]);

                //student.Add(new Student(
                //    temp[(int)Student_Data.NAME],
                //    int.Parse(temp[(int)Student_Data.AGE]),
                //    temp[(int)Student_Data.HAKBEON],
                //    temp[(int)Student_Data.HAKGWA],
                //    temp[(int)Student_Data.GENDER]));

                Student st = new Student(
                    temp[(int)Student_Data.NAME],
                    int.Parse(temp[(int)Student_Data.AGE]),
                    temp[(int)Student_Data.HAKBEON],
                    temp[(int)Student_Data.HAKGWA],
                    temp[(int)Student_Data.GENDER]);

                students.Add(st);

                
            }
            dataGridView_students.DataSource = students;
            reader.Dispose();
        }

        private void dataGridView_students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Student temp = dataGridView_students.CurrentRow.DataBoundItem as Student;
            textBox_name.Text = temp.name;
            textBox_age.Text = temp.age.ToString();
            textBox_hakbeon.Text = temp.hakbeon;
            textBox_hakgwa.Text = temp.hakgwa;


            // 자바의 instanceof랑 같은 것
            // is 왼쪽에 있는 것이 is 오른쪽에 있는 것이면
            // combobox_gender가 ComboBox 타입이면 true를 반환
            //if(comboBox_gender is ComboBox)
            //{
            //    MessageBox.Show("이것은 콤보 박스");
            //}
            
        }

        private void button_writeCSV_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("test.csv", true);
            writer.WriteLine($"{textBox_name.Text}," +
                $"{textBox_age.Text}," +
                $"{textBox_hakbeon.Text}," +
                $"{textBox_hakgwa.Text}," +
                $"{comboBox_gender.Text}");
            writer.Dispose(); //수동으로 메모리 해제
        }

        private void button_open_daegu_Click(object sender, EventArgs e)
        {
            // Modal(모달)
            // ex : ShowDialog()
            // 창 뜨면 코드가 그 줄에서 멈춤
            // 그 뒤에꺼 클릭 못함
            // Modeless(모달리스)
            // ex : Show()
            // 창 띄우고 그 다음 코드 진행함
            // 그 뒤에꺼 클릭 가능


            // 인스턴스 바로 생성하고 띄우기(1번)
            new Form2().ShowDialog();
            //MessageBox.Show("Test");

            // 변수 선언하고 그 변수 띄우기(2번)
            //Form2 temp = new Form2();
            //temp.ShowDialog();

        }
    }
}
