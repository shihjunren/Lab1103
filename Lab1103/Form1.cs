using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Lab1103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnerrol_Click(object sender, EventArgs e)
        {
            //int x = 100;
            //int y = 0;
            //int z = x/y;       //用執行但不偵錯

            
        }

        private void btncheck1_Click(object sender, EventArgs e)
        {
            int n = int.MaxValue;
            n++;
            Console.WriteLine(n);
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            foreach(CheckBox cb in groupBox1.Controls)
            {
                cb.Checked = checkBox5.Checked;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach(Control x in Controls)
            {
                if(x is TextBox)
                {
                    x.Text = "";
                }
                
            }
           
        }

               

        private void btnMax_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 70;
            int c = (a >= b) ? a : b;
            Console.WriteLine(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a =new int[] {100,20,50,80};
            int m = a.Max();
            double avg =a.Average();
            int n = a.Min();
            int add = a.Sum();
            int l = a.GetLength(0);
            
            
            Console.WriteLine(m);
            Console.WriteLine(avg);
            Console.WriteLine(n);
            Console.WriteLine(add);
            Console.WriteLine(l);
            Console.WriteLine(a);
            MessageBox.Show($@"最大值:{m.ToString()},平均值:{avg.ToString()},最小值:{n.ToString()},累加:{add.ToString()},陣列個數:{l.ToString()}");
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string a =null;
            for (int i=0;i<10;i++)
            {
                int k = r.Next(1,101);
                Console.WriteLine(k);
                a += k.ToString()+"/";
                            
            }
            MessageBox.Show(a.TrimEnd('/'));  
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sex = textSex.Text;
            if (sex == "F" || sex == "M")
            {
                if (sex == "F")
                {
                    MessageBox.Show("性別:女");
                }
                else
                {
                    MessageBox.Show("性別:男");
                }
            }
            else
            {
                MessageBox.Show("請重新輸入");
            }
        }

        private void btnstruct_Click(object sender, EventArgs e)
        {
            structspace emp;
            emp.name = "王曉明";
            emp.age = 20;
            emp.sex = enumspace.male;
            Console.WriteLine("Name:" + emp.name); //單行單項顯示
            Console.WriteLine("Age:" + emp.age);   //單行單項顯示
            Console.WriteLine("Sex:" + emp.sex);   //單行單項顯示
            MessageBox.Show($"姓名:{emp.name},年齡:{emp.age},性別:{emp.sex}");

        }

        private void btnva_Click(object sender, EventArgs e)
        {
            //float f = 12.3f;  //最後的f是表示 12.3用float來表示
            //double d = f;
            double d = 5.2;
            //float f = d; 無法轉型
            float f = (float)d;  //強制轉型
            MessageBox.Show($"{f}");
        }

        private void btndate_Click(object sender, EventArgs e)
        {
            string Date = textdate.Text;
            DateTime Day = DateTime.ParseExact(Date, "yyyy/MM/dd", CultureInfo.InvariantCulture);
            if (Day.DayOfWeek == DayOfWeek.Saturday || Day.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("假日");
            }
            else
            {
                MessageBox.Show("非假日");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Age = 0;
            if (int.TryParse(textage.Text, out Age)) //TryParse成功(T)直接放入age，TryParse失敗(F)
            {
                if (Age > 20 && Age <= 55)     //TryParse成功(T)
                { MessageBox.Show("合法"); }
                else
                { MessageBox.Show("不符合"); }
            }
            else                              //TryParseg失敗(F)
            { MessageBox.Show("年齡必須是整數!!"); }
        }

        private void button4_Click(object sender, EventArgs e)     //Math 類別
        {
            Console.WriteLine(Math.Abs(10));  //abs 為絕對值
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Abs(-5.5));
            Console.WriteLine(Math.Abs(-5m));
            Console.WriteLine(Math.Abs(-5.54f));
        }

        private void btnerroe_Click(object sender, EventArgs e)
        {
            int x = -100;
            if (x > 10) ; //多加分號 把if的判斷當敘述
            {
                Console.WriteLine("x>0");   //故隨意數都是會顯示
            }
            //else                            //+else會顯示語法錯誤顯示(邏輯沒錯)
            //{ }
        }

        private void btnif_Click(object sender, EventArgs e)
        {
            int Score = 65;
            if (Score == 100)
            { Console.WriteLine("A++"); }
            else if (Score >= 90 && Score <= 99)
            { Console.WriteLine("A+"); }
            else if (Score >= 80 && Score <= 89)
            { Console.WriteLine("A"); }
            else if (Score >= 70 && Score <= 79)
            { Console.WriteLine("B++"); }
            else if (Score >= 60 && Score <= 99)
            { Console.WriteLine("B+"); }
            else
            { Console.WriteLine("重修"); }
            //int Score;
            //if (int.TryParse(textScore.Text, out Score))
            //{
            //    if (Score == 100)
            //    { MessageBox.Show("A++"); }
            //    else if (Score >= 90 && Score <= 99)
            //    { MessageBox.Show("A+"); }
            //    else if (Score >= 80 && Score <= 89)
            //    { MessageBox.Show("A"); }
            //    else if (Score >= 70 && Score <= 79)
            //    { MessageBox.Show("B++"); }
            //    else if (Score >= 60 && Score <= 99)
            //    { MessageBox.Show("B+"); }
            //    else
            //    { MessageBox.Show("重修"); }
            //}
        }

        private void btnswitch_Click(object sender, EventArgs e)
        {
            int Score = 65;
            switch (Score / 10)        //分數除10產生級距
            {
                case 10: Console.WriteLine("A++"); break;
                case 9: Console.WriteLine("A+"); break;
                case 8: Console.WriteLine("A"); break;
                case 7: Console.WriteLine("B++"); break;
                case 6: Console.WriteLine("B+"); break;
                default: Console.WriteLine("重修"); break;
            }
            //int Score;
            //if (int.TryParse(textScore.Text, out Score))
            //{
            //    switch (Score / 10)
            //    {
            //        case 10: MessageBox.Show("A++"); break;
            //         case 9: MessageBox.Show("A+");  break;
            //         case 8: MessageBox.Show("A");   break;
            //         case 7: MessageBox.Show("B++"); break;
            //         case 6: MessageBox.Show("B+");  break;
            //        default: MessageBox.Show("重修"); break;
            //    }
            //}
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                //Console.WriteLine(i++);
            }
        }

        private void btndo_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i++);
            } while (i < 10);
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            //for (int i = 0, j = 0; i < 10; i++, j++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(j);
            //}

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        private void btnforeach_Click(object sender, EventArgs e)
        {
            int[] numbers = { 10, 230, 45, 6, 19 };

            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n); 
            //}

            for (int n = 0; n < numbers.Length; n++)  //陣列個數 = numbers.Length (數量為五 0~4)
            {
                Console.WriteLine(numbers[n]); //取陣列第n個數 numbers[0],numbers[1],numbers[2],numbers[3],numbers[4]  ;正的取陣列元素
            }

            for (int n = numbers.Length - 1; n >= 0; n--)  //陣列個數 = numbers.Length (數量為五 0~4)
            {
                Console.WriteLine(numbers[n]); //取陣列第n個數 numbers[4],numbers[3],numbers[2],numbers[1],numbers[0]  ;反的取陣列元素
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Image img1 = pictureBox1.Image;
            Debug.Assert(img1 != null);    //確認img1是否為空值:T繼續執行 / F提供錯誤資訊
            Image img2 = pictureBox2.Image;
            Debug.Assert(img2 != null);    //確認img2是否為空值:T繼續執行 / F提供錯誤資訊
            //try
            //{
            //    Image img1 = pictureBox1.Image;
            //    Image img2 = pictureBox2.Image;
            //}
            //catch (ArgumentException caught)
            //{
            //    Console.WriteLine(caught.Message);
            //}
        }

        private void textdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
