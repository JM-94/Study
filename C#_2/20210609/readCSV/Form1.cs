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

namespace readCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_readcsv_Click(object sender, EventArgs e)
        {
            // student s =new student();
            //s._hakgwa = "연금술";
            //Console.WriteLine(s._hakgwa);
            //./test.csv

            StreamReader reader = new StreamReader("test.csv", Encoding.GetEncoding("UTF-8"));
            //Console.ReadLine();

            label_contents.Text = reader.ReadLine() + Environment.NewLine;
            //label_contents.Text += reader.ReadLine();

            List<Student> students = new List<Student>();
            List<Student_Gridview> students_gridview = new List<Student_Gridview>();
            

            while (!reader.EndOfStream) // EndOfStream 아무것도 없을 때까지 읽음
            {

                // 안준모, 28, 130907, 경영, 남
                string[] temp = reader.ReadLine().Split(',');
                string name = temp[0];  // 안준모
                int age = int.Parse(temp[1]);   // "28"
                string hakbeon = temp[2];   // "130907"
                string hakgwa = temp[3];    // 경영
                string gender = temp[4];    // 남
                Student st = new Student(name, age, hakbeon, hakgwa, gender);
                students.Add(st);
                students_gridview.Add(new Student_Gridview(name, age, hakbeon, hakgwa, gender));
            }
            for (int i = 0; i < students.Count; i++)
            {
                label_contents.Text += students[i].name + " " +
                    students[i].age + " " +
                    students[i].hakbeon + " " +
                    students[i]._hakgwa + " " +
                    students[i].getGender() + " " +
                    Environment.NewLine;
            }
            reader.Dispose(); // 내가 직접 해제해줌
            dataGridView1.DataSource = students_gridview;
        }



        private void button_writeCSV_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("./test.csv", true))
            {
                
                writer.WriteLine(textBox_writeCSV_name.Text);
                writer.Write(textBox_writeCSV_name.Text + ","+ textBox_writeCSV_age.Text + ","+ textBox_writeCSV_hakbeon.Text + "," + textBox_writeCSV_hakgwa.Text + "," + textBox_writeCSV_gender.Text);
               
            }
        }

        private void button_daegu_Click(object sender, EventArgs e)
        {
            StreamReader reader2 = new StreamReader("daegu.csv", Encoding.GetEncoding("UTF-8"));
            List<daegu> da = new List<daegu>();
                while (!reader2.EndOfStream) 
                {

                    
                    string[] temp1 = reader2.ReadLine().Split('|');
                    string 상가업소번호 = temp1[0]; 
                    string 상호명 = temp1[1];
                    string 지점명 = temp1[2];
                    string 상권업종대분류코드 = temp1[3];
                    string 상권업종대분류명 = temp1[4];
                    string 상권업종중분류명 = temp1[5];
                    string 상권업종소분류코드 = temp1[6];
                    string 상권업종소분류명 = temp1[7];
                    string 표준산업분류코드 = temp1[8];
                    string 표준산업분류명 = temp1[9];
                    string 시도코드시도명 = temp1[10];
                    string 시군구코드 = temp1[11];
                    string 시군구명 = temp1[12];
                    string 행정동코드 = temp1[13];
                    string 행정동명 = temp1[14];
                    string 법정동코드 = temp1[15];
                    string 법정동명 = temp1[16];
                    string 지번코드 = temp1[17];
                    string 대지구분코드 = temp1[18];
                    string 대지구분명 = temp1[19];
                    string 지번본번지 = temp1[20];
                    string 지번부번지 = temp1[21];
                    string 지번주소 = temp1[22];
                    string 도로명코드 = temp1[23];
                    string 도로명 = temp1[24];
                    string 건물본번지 = temp1[25];
                    string 건물부번지 = temp1[26];
                    string 건물관리번호 = temp1[27];
                    string 건물명 = temp1[28];
                    string 도로명주소 = temp1[29];
                    string 구우편번호 = temp1[30];
                    string 신우편번호 = temp1[31];
                    string 동정보 = temp1[32];
                    string 층정보 = temp1[33];
                    string 호정보 = temp1[34];
                    string 경도 = temp1[35];
                    string 위도 = temp1[36];


                da.Add(new daegu(상가업소번호, 상호명, 지점명, 상권업종대분류코드, 상권업종대분류명, 상권업종중분류명, 상권업종소분류코드, 상권업종소분류명, 표준산업분류코드, 표준산업분류명, 시도코드시도명, 시군구코드, 시군구명, 행정동코드, 행정동명, 법정동코드, 법정동명, 지번코드, 대지구분코드, 대지구분명, 지번본번지, 지번부번지, 지번주소, 도로명코드, 도로명, 건물본번지, 건물부번지, 건물관리번호, 건물명, 도로명주소, 구우편번호, 신우편번호, 동정보, 층정보, 호정보, 경도, 위도));

                }
                reader2.Dispose(); 
                dataGridView2.DataSource = da;
            }

        
    }
    }

