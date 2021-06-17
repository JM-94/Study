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
using System.Xml.Linq;

namespace ReadWriteXML
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button_readXML_Click(object sender, EventArgs e)
        {
            try
            {

                //List<int> temps = new List<int>();
                //temps.Add(10);
                //temps.Add(5);
                //temps.Add(500);
                //foreach (var item in temps)
                //{
                //    Console.WriteLine(item);
                //}

                // parse
                // 문자열을 숫자 변환하는 방법
                // 1.
                //int num1 = int.Parse("123");
                // 2.
                //int num2 = 0;
                //int.TryParse("123", out num2);
                // 3. 1번 방법으로 하되, try catch로 감싼다


                string xmlfile = File.ReadAllText("Student.xml");
                XElement student_xml = XElement.Parse(xmlfile);

                //int[] temp = new int[10];
                //foreach (int item : temps)
                //{
                //    
                //}
                // 읽기 누를때마다 그리드뷰 늘어나는 이슈 수정
                students.Clear();
                foreach (var item in student_xml.Descendants("student"))
                {
                    string name = item.Element("name").Value;
                    int age = int.Parse(item.Element("age").Value);
                    string hakbeon = item.Element("hakbeon").Value;
                    string hakgwa = item.Element("hakgwa").Value;
                    string gender = item.Element("gender").Value;

                    students.Add(new Student(name, age, hakbeon, hakgwa, gender));
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = students;
            }
            catch (Exception ee)
            {

            }
        }

        private void button_writeXML_Click(object sender, EventArgs e)
        {
            students.Add(new Student(textBox_name.Text, int.Parse(textBox_age.Text), textBox_hakbeon.Text, textBox_hakgwa.Text, comboBox_gender.Text));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;

            string input = "<students>";
            foreach (var item in students)
            {
                input += "  <student>"+Environment.NewLine;
                input += $" <name>{item.name}</name>{Environment.NewLine}";
                input += $" <age>{item.age}</age>{Environment.NewLine}";
                input += $" <hakbeon>{item.hakbeon}</hakbeon>{Environment.NewLine}";
                input += $" <hakgwa>{item.hakgwa}</hakgwa>{Environment.NewLine}";
                input += $" <gender>{item.gender}</gender>{Environment.NewLine}";
                input += "  </student>\n";
            }
            input += "</students>";
            File.WriteAllText("Student.xml", input);
        }

        private void button_api_Click(object sender, EventArgs e)
        {
            string url = $"http://apis.data.go.kr/1470000/DURPrdlstInfoService/getUsjntTabooInfoList";
            string myKey = "2SeuYMWYdxsLIy4uYI%2FnPK3SHArlIpjqQ7B4vlnEm0PiIBmznlriKbVOyoYRwS21G3H0DgS%2BQxBcRhrRUa8uxQ%3D%3D";
            //?ServiceKey=서비스키(URL Encode)&numOfRows=3&pageNo=1
            url += "?ServiceKey=" + myKey;
            url += "&numOfRows=3";
            XElement api = XElement.Load(url);
            List<Drug> drugs = new List<Drug>();
            foreach (var item in api.Descendants("item"))
            {
                //string name = item.Element("ITEM_NAME").Value;
                //string seq = item.Element("ITEM_SEQ").Value;
                //string comp = item.Element("ENTP_NAME").Value;
                //drugs.Add(new Drug(name, seq, comp));
                drugs.Add(new Drug(item.Element("ITEM_NAME").Value,
                    item.Element("ITEM_SEQ").Value,
                    item.Element("ENTP_NAME").Value));
            }
            dataGridView_api.DataSource = drugs;
        }
    }
}
