using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Competition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int questionNo = 0, dogru = 0, yanlis = 0;


        private void BtnA_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }


        }

        private void BtnC_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void BtnD_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }


        private void BtnNext_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnNext.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            questionNo++;
            LblQuestion.Text = questionNo.ToString();

            if (questionNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kac yilinda ilan edilmistir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }

            if (questionNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege Bolgemizde bulunmaz?";
                BtnA.Text = "Izmir";
                BtnB.Text = "Balikesir";
                BtnC.Text = "Aydin";
                BtnD.Text = "Manisa";
                label4.Text = "Balikesir";
            }

            if (questionNo == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarimiza aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Attila İlhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
            }

            if (questionNo == 4)
            {
                richTextBox1.Text = "Java’da bir dizi bildirmek için hangisi kullanılır?";
                BtnA.Text = " {} ";
                BtnB.Text = " [] ";
                BtnC.Text = " () ";
                BtnD.Text = " <> ";
                label4.Text = " [] ";
            }

            if (questionNo == 5)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi tip günveliğini garanti eder?";
                BtnA.Text = "Generics";
                BtnB.Text = "Abstract classes";
                BtnC.Text = "Interfaces";
                BtnD.Text = "Collection";
                label4.Text = "Generics";
            }

            if (questionNo == 6)
            {
                richTextBox1.Text = "Kodun ekran çıktısı nedir?" +
                    "\r\nimport java.util.HashMap;\r\nimport java.util.Map;\r\nclass Main {\r\n  public static void main(String args[])\r\n  {\r\n    Map hashMap = new HashMap();\r\n    hashMap.put(new String(\"a\"),\"audi\");\r\n    hashMap.put(new String(\"a\"),\"ferrari\");\r\n    System.out.println(hashMap);\r\n  }\r\n}\r\n ";
                BtnA.Text = "Runtime exception";
                BtnB.Text = " [1] ";
                BtnC.Text = " [null, 1] ";
                BtnD.Text = " {a=ferrari} ";
                label4.Text = " {a=ferrari} ";
            }

            if (questionNo == 7)
            {
                richTextBox1.Text = "Aşağıdaki kodun ekran çıktısı nedir?" +
                    "\r\nimport java.util.ArrayList;\r\nimport java.util. Iterator;\r\nimport java.util. List;\r\nclass Main {\r\n  public static void main(String args[])\r\n  {\r\n    List arrayList = new ArrayList();\r\n \r\n    arrayList.add(\"a\");\r\n    arrayList.add(\"b\");\r\n \r\n    Iterator iterator = arrayList.iterator();\r\n \r\n    while (iterator.hasNext())\r\n    {\r\n    System.out.println(iterator.next());\r\n    arrayList.add(\"c\");\r\n    }\r\n  }\r\n} ";
                BtnA.Text = "a ardından ConcurrentModificationException";
                BtnB.Text = "a b c";
                BtnC.Text = "a b";
                BtnD.Text = "a c";
                label4.Text = "a ardından ConcurrentModificationException";

            }

            if (questionNo == 8)
            {
                richTextBox1.Text = "C# hakkında aşağıdakilerden hangisi doğrudur ?";
                BtnA.Text = "Çeşitli bilgisayar platformlarında derlenebilir.";
                BtnB.Text = ".Net Framework'ün bir parçasıdır.";
                BtnC.Text = "Bileşen yönelimlidir (component oriented).";
                BtnD.Text = "Hepsi";
                label4.Text = "Hepsi";
            }

            if (questionNo == 9)
            {
                richTextBox1.Text = "X ve Y değişkenlerine ilişkin değer atama hangisinde doğru yapılmıştır ?";
                BtnA.Text = "int X = Y = 40;";
                BtnB.Text = "int X = 35; int Y = 40;";
                BtnC.Text = "int X = 45; Y = 140;";
                BtnD.Text = "int X = 32, Y = 16.6;";
                label4.Text = "int X = 35; int Y = 40;";
            }

            if (questionNo == 10)
            {
                richTextBox1.Text = "Uzun veri türü olarak C#.Net içinde kaç Bayt saklanır ?";
                BtnA.Text = "8";
                BtnB.Text = "4";
                BtnC.Text = "2";
                BtnD.Text = "1";
                label4.Text = "8";

                
            }


            if (questionNo == 11)
            {

                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;

                BtnNext.Enabled = false;

                BtnNext.Text = "Results";

                MessageBox.Show("True:" + dogru +"\n" + "False:" + yanlis);
                
            }


        }
    }
}
