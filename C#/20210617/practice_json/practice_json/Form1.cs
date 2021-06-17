using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            // 차트에 데이터 넣기
            chart1.Series[0].Name = "성적";
            for (int i = 1; i <= 10; i++)
            {
                //chart1.Series[0].Points.AddXY(i, i * 10);
                chart1.Series["성적"].Points.AddXY(i, i * 10);
            }
            chart1.Series.Add("나이");
            for (int i = 1; i <= 10; i++)
            {
                chart1.Series[1].Points.AddXY(i, i * 10) ;
            }
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            var jDoctorArray = new JArray();
            var jDoctorObject = new JObject();

            try
            {
                // 방법1 버튼 강제 클릭
                //button_read.PerformClick();
                // 방법2 함수 호출
                load();
            }
            catch (Exception)
            {

            }

            // 만약에 doctors안에 아무것도 없다면
            // 이 작업 할 필요 없음
            if(doctors.Count > 0)
            {
                foreach (var item in doctors)
                {
                    jDoctorObject = new JObject();
                    jDoctorObject.Add("name", item.name);
                    jDoctorObject.Add("sabeon", item.sabeon);
                    jDoctorArray.Add(jDoctorObject);
                }

            }
            jDoctorObject = new JObject();  // 값 초기화(새로운 공간할당)
            jDoctorObject.Add("name", textBox_name.Text);
            jDoctorObject.Add("sabeon", textBox_sabeon.Text);

            jDoctorArray.Add(jDoctorObject);

            var jDoctorArray_object = new JObject();
            jDoctorArray_object.Add("doctor", jDoctorArray);

            var jDoctors_object = new JObject();
            jDoctors_object.Add("doctors", jDoctorArray_object);

            // 만약에 이걸 특정한 폴더에 넣고 싶은 데 그게 없는 경우

            DirectoryInfo di = new DirectoryInfo("jsonEx");
            if (!di.Exists)     // 해당 폴더가 없는 경우
                di.Create();    // 폴더를 만든다

            // 파일만 생성하고 싶을 때 쓰는 코드
            StreamWriter writer = File.CreateText("Doctors.json");
            writer.Dispose();   //메모리 해제

            // 참고로 파일만 만드는 거면 WriteAllText만 해줘도
            // 파일 만들어주고 바로 텍스트 적기는 합니다.
            File.WriteAllText(@"jsonEx\Doctors.json", jDoctors_object.ToString());

        }
        const string FILENAME = @"jsonEx\Doctors.json";
        List<Doctor> doctors = new List<Doctor>();
        private void button_read_Click(object sender, EventArgs e)
        {
            doctors.Clear();

            string source = File.ReadAllText(FILENAME);
            JObject jsonObjectDoctor = JObject.Parse(source);

            // 우리가 알던 방법(심플)
            foreach (var item in jsonObjectDoctor["doctors"]["doctor"])
            {
                Doctor temp = new Doctor();
                temp.name = item["name"].ToString();
                temp.sabeon = item["sabeon"].ToString();
                doctors.Add(temp);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = doctors;

            // linq 문법을 쓰는 방법
            // sql 문이랑 유사하고
            // list에 데이터를 한 방에 다 넣는 방법
            doctors.Clear();

            doctors = (from item in jsonObjectDoctor["doctors"]["doctor"]
                       select new Doctor()
                       {
                           name = item["name"].ToString(),
                           sabeon = item["sabeon"].ToString()
                       }).ToList<Doctor>();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = doctors;
        }


        private void load()
        {
            doctors.Clear();

            string source = File.ReadAllText(FILENAME);
            JObject jsonObjectDoctor = JObject.Parse(source);

            // 우리가 알던 방법(심플)
            foreach (var item in jsonObjectDoctor["doctors"]["doctor"])
            {
                Doctor temp = new Doctor();
                temp.name = item["name"].ToString();
                temp.sabeon = item["sabeon"].ToString();
                doctors.Add(temp);
            }
            
        }

        private void button_open_Click(object sender, EventArgs e)
        {

            // 노가다 방식
            //openFileDialog1.InitialDirectory = @"D:\Ai\Study\C#_2\20210617\practice_json\practice_json\bin\Debug";

            // 있어 보이는 방식
            // exe파일이 있는 경로를 찾아서 지정함
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            // 필터 지정 가능
            openFileDialog1.Filter = "json파일 |*.json";

            // 필터 추가시에는 "이름 |*.확장자" 이런식으로 같이 추가해줌
            openFileDialog1.Filter += "| 소스파일 |*.cs";



            string source = File.ReadAllText(FILENAME);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog1.FileName);
                source = File.ReadAllText(openFileDialog1.FileName);
            }

            JObject jsonObjectDoctor = JObject.Parse(source);
            doctors.Clear();
            foreach (var item in jsonObjectDoctor["doctors"]["doctor"])
            {
                Doctor temp = new Doctor();
                temp.name = item["name"].ToString();
                temp.sabeon = item["sabeon"].ToString();
                doctors.Add(temp);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = doctors;

        }

        private void button_json_api_Click(object sender, EventArgs e)
        {
            int count = 860;
            string url = "https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo="+count;

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                var jArray = JObject.Parse(json);

                foreach (var item in jArray)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine(item.Value);
                }

                // 내가 원하는 키값의 값만 가져오고 싶다면
                // 토탈 당첨금만 출력하기
                Console.WriteLine(jArray["totSellamnt"]);

                DisplayLotto();

            }
        }
        private void DisplayLotto()
        {
            List<Lotto> lottos = new List<Lotto>();
            int count = 960;
            while (true)
            {
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo="+count);
                    count++;
                    var jArray = JObject.Parse(json);
                    if (jArray["returnValue"].ToString() == "fail")
                        break;// while에 대한 break;
                    lottos.Add(new Lotto(
                        jArray["drwtNo1"].ToString(),
                        jArray["drwtNo2"].ToString(),
                        jArray["drwtNo3"].ToString(),
                        jArray["drwtNo4"].ToString(),
                        jArray["drwtNo5"].ToString(),
                        jArray["drwtNo6"].ToString(),
                        jArray["bnusNo"].ToString(),
                        jArray["drwNo"].ToString(),
                        jArray["drwNoDate"].ToString()
                        ));
                }
                
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lottos;
        }
    }
}
