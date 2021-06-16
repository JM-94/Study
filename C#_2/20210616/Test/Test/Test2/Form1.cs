using Newtonsoft.Json.Linq;
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

namespace Test2
{
    public partial class Form1 : Form
    {
        const string FILENAME = "Coffees.json";
        public List<Coffee> coffees = new List<Coffee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            string source = File.ReadAllText(FILENAME);
            JObject jsonObjectCoffee = JObject.Parse(source);

            coffees = (from item in jsonObjectCoffee["coffees"]["coffee"]
                        select new Coffee()
                        {
                            menu = item["menu"].ToString().Replace("{", "").Replace("}", ""),
                            price = int.Parse(item["price"].ToString().Replace("{", "").Replace("}", ""))
                        }).ToList<Coffee>();
            dataGridView1.DataSource = coffees;
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            var jCoffeeArray = new JArray();
            var jCoffeeObject = new JObject();

            if (coffees.Count > 0)
            {
                foreach (var item in coffees)
                {
                    jCoffeeObject = new JObject();
                    jCoffeeObject.Add("menu", item.menu);
                    jCoffeeObject.Add("price", item.price);
                    jCoffeeArray.Add(jCoffeeObject);
                }
            }

            jCoffeeObject = new JObject();
            jCoffeeObject.Add("menu", textBox_menu.Text);
            jCoffeeObject.Add("price", textBox_price.Text);


            jCoffeeArray.Add(jCoffeeObject);


            var jCoffeeArray_object = new JObject();
            jCoffeeArray_object.Add("coffee", jCoffeeArray);

            var jCoffees_object = new JObject();
            jCoffees_object.Add("coffees", jCoffeeArray_object);

            File.WriteAllText(@"./Coffees.json", jCoffees_object.ToString());
        }
    }
}

