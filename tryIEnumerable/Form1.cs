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

namespace tryIEnumerable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        /// IEnumerable
        /// 分割視窗(容器SplitContainer)
        ///Orientation 改變分割視窗方向(垂直->水平)
        ///listBox放入分割的其中視窗(可以用Dock填滿視窗)
        ///pictureBox放入分割的其中視窗(可以用Dock填滿視窗; sizeMode的zoom調整圖片與視窗大小"高寬比例不變")

     
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(listBox1.Text); 
            //Image.FromFile的語法來控制給檔名用pictureBox1打開
            //上述開檔後不會關,更改後無法存取        (有資源占用問題)
            //下述開檔後等於唯讀檔案,更改後可以存取
            pictureBox1.ImageLocation = listBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string Filename in Directory.EnumerateFiles(@"C:\Screen", "*.*", SearchOption.TopDirectoryOnly))
            //@表示字串中'/'不是控制字元; *.* 表示所有檔案;TopDirectoryOnly 指搜尋第一層/AllDirectories 所有資料夾
            {
                listBox1.Items.Add(Filename); //用listBox1顯示所有資料}
            }
        }
    }
}
