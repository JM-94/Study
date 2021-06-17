using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }
        private void button_api_Click(object sender, EventArgs e)
        {
            string url = "https://api.odcloud.kr/api/15067156/v1/uddi:4f293dcb-a55b-4f64-b7d1-dab5b0ba56bb?page=1&perPage=10&serviceKey=2SeuYMWYdxsLIy4uYI%2FnPK3SHArlIpjqQ7B4vlnEm0PiIBmznlriKbVOyoYRwS21G3H0DgS%2BQxBcRhrRUa8uxQ%3D%3D";
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                var json = wc.DownloadString(url);
                var jArray = JObject.Parse(json);

                foreach (var item in jArray)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine(item.Value);
                }
                ShowCar();
            }
        }
        public void ShowCar()
        {
            chart1.Series[0].Name = "사용전력량(kw)";
            List<Car> cars = new List<Car>();
            //int a = 0;
            //while (true)
            {
                using (WebClient wc = new WebClient())
                {
                    //.Encoding = System.Text.Encoding.UTF8;
                    var jsonbytes = wc.DownloadData("https://api.odcloud.kr/api/15067156/v1/uddi:4f293dcb-a55b-4f64-b7d1-dab5b0ba56bb?page=1&perPage=10&serviceKey=2SeuYMWYdxsLIy4uYI%2FnPK3SHArlIpjqQ7B4vlnEm0PiIBmznlriKbVOyoYRwS21G3H0DgS%2BQxBcRhrRUa8uxQ%3D%3D");
                    var json = Encoding.UTF8.GetString(jsonbytes);
                    var jArray = JObject.Parse(json);
                    //if (jArray["충전소명칭"].ToString() == "(달성군)하빈면 사무소")
                    //    break;// while에 대한 break;

                    foreach (var item in jArray["data"])
                    {

                        cars.Add(new Car(
                            item["경도"].ToString(),
                            item["사용전력량(kW)"].ToString(),
                            item["사용횟수"].ToString(),
                            item["위도"].ToString(),
                            item["일자"].ToString(),
                            item["충전기ID"].ToString(),
                            item["충전기타입"].ToString(),
                            item["충전소ID"].ToString(),
                            item["충전소명칭"].ToString()
                            ));
                    }
                    

                }
                foreach (var item in cars)
                {
                    chart1.Series["사용전력량(kw)"].Points.AddXY(item.일자, item.사용횟수);
                }
                
                  
                

            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cars;
        }
    }
}

