using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> listStr = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        #region Button
        private void btn_selpath_Click(object sender, EventArgs e) //選擇圖片路徑
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.img_path.Text = path.SelectedPath;
        }

        private void Sel_txt_Click(object sender, EventArgs e) //選擇txt路徑
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (string.IsNullOrEmpty(ofd.InitialDirectory))
                ofd.InitialDirectory = "D:";

            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.Title = "請開啟文字檔案";

            if (ofd.ShowDialog(this) == DialogResult.Cancel)
                return;
            txt_path.Text = ofd.FileName;
            Read_txt();
        }

        private void Btn_change_Click(object sender, EventArgs e) //開始改檔名
        {
            //Read_ALLfile();
            Change_Allfile();
        }
        #endregion

        #region Function
        public void Read_txt() //讀檔
        {
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader(txt_path.Text);
            while ((line = file.ReadLine()) != null)
            {
                listStr.Add(line);
            }

            file.Close();
        }

        public void Read_ALLfile()  // 取得資料夾內所有檔案
        {
            foreach (string fname in System.IO.Directory.GetFiles(img_path.Text))
            {
                string line = "";
                System.IO.StreamReader file = new System.IO.StreamReader(fname);
                while ((line = file.ReadLine()) != null)
                {
                    label1.Text = label1.Text + line.Trim();
                }

                file.Close();
            }

        }
        public void Change_Allfile() //修改檔案名稱
        {
            DirectoryInfo di = new DirectoryInfo(img_path.Text);
            Int32 count = 0;
            foreach (FileInfo fi in di.GetFiles("*.jpg"))
            {
                String NewFileName = listStr[count];
                //重新命名
                fi.MoveTo(Path.Combine(fi.DirectoryName, NewFileName + fi.Extension));
                count++;
            }
            label1.Text = "修改完成";
        } 
        #endregion



    }


}
