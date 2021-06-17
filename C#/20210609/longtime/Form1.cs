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

namespace longtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 라벨 숨기기
            label_contents.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // mbox 치고 tab 키 두 번
            MessageBox.Show("안녕");
            MessageBox.Show("안녕");
            MessageBox.Show("안녕");
        }

        private void button_output_Click(object sender, EventArgs e)
        {
            int 이한글 = 100;
            MessageBox.Show(textBox_contents.Text);
            MessageBox.Show(10+"안녕"+100+이한글);
            int 이재문 = 1000;
            MessageBox.Show(이재문.ToString());


            // string.format
            string contents = string.Format("{0}+{1}={2}", 이한글, 이재문, 이한글 + 이재문);
            Console.WriteLine(contents);

            // $
            contents = $"{이한글}+{이재문}={이한글 + 이재문 + 9999}";
            Console.WriteLine(contents);

            contents = "안녕 내 이름은 안준모고 내 나이는 "+28+"이야";
            contents = $"안녕 내 이름은 안준모고 내 나이는 {28}이야";
            contents = string.Format("안녕 내 이름은 안준모고 내 나이는 {0}이야",28);
            Console.WriteLine(contents);

        }

        

        private void button_txtWrite_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./test.txt","안녕하세요");
            File.WriteAllText("./test2.txt", textBox_memo.Text);
            File.WriteAllText("D:\\a\\test.txt", textBox_memo.Text);
            File.WriteAllText(@"D:\a\test2.txt", textBox_memo.Text);
        }

        private void button_readText_Click(object sender, EventArgs e)
        {
            label_contents.Text =  File.ReadAllText("./test2.txt");
        }

        private void button_continueWrite_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("./test2.txt",true))
            {
                writer.WriteLine(textBox_memo.Text);
                writer.Write("한줄안띈다");
                writer.Write("한줄안띈다");
            }
        }

       

        private void button2_usingRead_Click(object sender, EventArgs e)
        {
            label_from_using.Text = "";
            using (StreamReader reader = new StreamReader("./test2.txt", true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    label_from_using.Text += line + Environment.NewLine;
                    // "\n"

                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

