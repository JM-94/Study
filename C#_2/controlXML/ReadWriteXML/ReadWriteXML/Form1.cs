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
    }
}
