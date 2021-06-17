using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_API_Click(object sender, EventArgs e)
        {
            string url = $"http://apis.data.go.kr/1130000/MMktInfoService/getMMktPuYearInfo";
            string myKey = "2SeuYMWYdxsLIy4uYI%2FnPK3SHArlIpjqQ7B4vlnEm0PiIBmznlriKbVOyoYRwS21G3H0DgS%2BQxBcRhrRUa8uxQ%3D%3D";
            //?serviceKey=2SeuYMWYdxsLIy4uYI%2FnPK3SHArlIpjqQ7B4vlnEm0PiIBmznlriKbVOyoYRwS21G3H0DgS%2BQxBcRhrRUa8uxQ%3D%3D&fromYmd=20110525&toYmd=20150525
            url += "?serviceKey=" + myKey;
            url += "&fromYmd=20110525&toYmd=20150525";
            XElement api = XElement.Load(url);
            List<Deal> deals = new List<Deal>();
            foreach (var item in api.Descendants("item"))
            {
                deals.Add(new Deal(item.Element("apvYmd").Value,
                    item.Element("bupNm").Value,
                    item.Element("repNm").Value));
            }
            dataGridView1.DataSource = deals;
        }
    }
}
