using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
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
using System.Xml.Schema;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.Events;
using System.CodeDom.Compiler;
using System.Windows.Forms.VisualStyles;

namespace AutoMatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            lstFolder.Text = "";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            string f = folderBrowserDialog1.SelectedPath;
            ////////Path Đường Dẫn 
            string[] len_F = f.Split('\\');
            /////////////////////////
            
                txtFolder.Text = f;
                string[] arr = Directory.GetFiles(f, "*.jpg");

                for (int i = 0; i < arr.Length; i++)
                {

                    string[] it = arr[i].Split('\\');
                    string[] it2 = it[len_F.Length].Split(' ');
                    string ok = "";
                    for(int q = 1; q < it2.Length;q++)
                    {
                        ok += " " + it2[q];
                    }
                    ok = ok.Replace(".jpg", "");
                    lstFolder.Items.Add(ok);
                }
            
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {

                string mota = @"
+Size S: từ 37-47kg
+Size M: từ 48-57kg
+Size L: từ 58-68kg
+Size XL: từ 69-77kg
+Size XXL: từ 78-88kg
*Các bạn muốn mang ôm body hoặc rộng vui lòng chọn chệch đi 1 size hoặc inbox chúng mình để được tư vấn nha ^^.
    
✈ Form rộng Unisex cho cả nam và nữ 
Nhận THU HỘ ( ship COD ) toàn quốc 

✅Hình thật giống mẫu _ Đảm bảo chất lượng hơn giá tiền bạn bỏ ra .
✅Áo được kiểm tra kỹ càng, cẩn thận và tư vấn nhiệt tình trước khi giao hàng cho Khách
💥Hoàn lại tiền 💯% nếu hàng “ Lỗi Kỹ thuật  - Sai Mẫu - Màu “ 

#aothuntaylo #aothun #aothunnu #aocouple #aothunngantay #aothuncotron #aothunnam #aothunthietke #aodesign
            ";
                FirefoxProfile profile = new FirefoxProfileManager().GetProfile(comboBox1.SelectedItem.ToString());
                FirefoxOptions options = new FirefoxOptions();
                options.Profile = profile;
                FirefoxDriver fd = new FirefoxDriver(options);

                string f = folderBrowserDialog1.SelectedPath;
                string[] arr = Directory.GetFiles(f, "*.jpg");

                for (int i = 0; i < arr.Length; i++)
                {
                    fd.Navigate().GoToUrl("https://banhang.shopee.vn/portal/product/category/");


                    //////
                    Thread.Sleep(2000);
                    fd.FindElementByTagName("html").Click();
                    SendKeys.SendWait(@"^{SUBTRACT}");
                    SendKeys.SendWait(@"^{SUBTRACT}");
                    SendKeys.SendWait(@"^{SUBTRACT}");
                    SendKeys.SendWait(@"^{SUBTRACT}");

                    ////////////
                    Thread.Sleep(1000);
                    fd.FindElement(By.XPath("//p[@class='text-overflow' and text()='Thời Trang Nam']")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("//p[@class='text-overflow' and text()='Áo thun']")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("//p[@class='text-overflow' and text()='Áo ngắn tay không cổ']")).Click();
                    Thread.Sleep(200);
                    var ten_SP = fd.FindElement(By.XPath("//input[@type='text' and @class='shopee-input__input' and @placeholder='Nhập vào']"));
                    ten_SP.SendKeys("Áo Thun Tay Lỡ Nam Nữ ");


                    string[] b = arr[i].Split('\\');
                    string c = b[b.Length - 1];
                    string[] cc = c.Split(' ');
                    string d = "";
                    for (int k = 1; k < cc.Length; k++)
                    {
                        d += " " + cc[k];
                    }
                    string mm = "";
                    for (int k = 0; k < d.Length - 4; k++)
                    {
                        mm += d[k];
                    }
                    ten_SP.SendKeys(mm);
                    Thread.Sleep(500);


                    fd.FindElement(By.XPath("//button[@type='button' and @class='shopee-button shopee-button--primary shopee-button--large']")).Click();
                    Thread.Sleep(2000);
                    /////////

                    ////////////////



                    /////////////////////////////////////////////////////////
                    ///

                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[1]/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[1]/div/div[2]/div/div[1]/div[2]/div/div/div/div[2]/ul/div[2]/li[1]")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[1]/div/div[2]/div/div[2]/div[2]/div/div/div/div[1]")).Click();

                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[1]/div/div[2]/div/div[2]/div[2]/div/div/div/div[2]/ul/div[2]/li[7]")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[1]/div/div[2]/div/div[3]/div[2]/div/div/div/div[1]")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[1]/div/div[2]/div/div[3]/div[2]/div/div/div/div[2]/ul/div[2]/li[1]")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("//textarea[@type='textarea' and @class='shopee-input__inner shopee-input__inner--normal']")).SendKeys(mota);
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[3]/div[1]/ul/li[2]/a")).Click();
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[3]/div[2]/button")).Click();
                    Thread.Sleep(1500);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[1]/div[2]/div/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("Màu Sắc");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[1]/div[2]/div/div[2]/div/div[2]/div/div/div[1]/div/input")).SendKeys("Đen");
                    Thread.Sleep(500);
                    ///
                    /// 
                    /// 
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/button")).Click();
                    Thread.Sleep(1500);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[3]/div[2]/button")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[3]/div[2]/button")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[3]/div[2]/button")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[3]/div[2]/button")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[3]/div[2]/button")).Click();
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("Sizes");

                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[2]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("S");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[2]/div[2]/div[2]/div/div/div[1]/div/input")).SendKeys("M");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[2]/div[3]/div[2]/div/div/div[1]/div/input")).SendKeys("L");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[2]/div[4]/div[2]/div/div/div[1]/div/input")).SendKeys("XL");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[2]/div[5]/div[2]/div/div/div[1]/div/input")).SendKeys("XXL");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[2]/div[6]/div[2]/div/div/div[1]/div/input")).SendKeys("XXXL");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[1]/div[2]/div/div/div/div[1]/div/input")).SendKeys("109000");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[2]/div[2]/div/div/div/div[1]/div/input")).SendKeys("109000");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[3]/div[2]/div/div/div/div[1]/div/input")).SendKeys("109000");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[4]/div[2]/div/div/div/div[1]/div/input")).SendKeys("109000");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[5]/div[2]/div/div/div/div[1]/div/input")).SendKeys("109000");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[6]/div[2]/div/div/div/div[1]/div/input")).SendKeys("109000");
                    ///////
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[1]/div[3]/div/div/div/div/div/div/input")).SendKeys("50");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[2]/div[3]/div/div/div/div/div/div/input")).SendKeys("50");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[3]/div[3]/div/div/div/div/div/div/input")).SendKeys("50");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[4]/div[3]/div/div/div/div/div/div/input")).SendKeys("50");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[5]/div[3]/div/div/div/div/div/div/input")).SendKeys("50");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[2]/div/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/div/div[2]/div[6]/div[3]/div/div/div/div/div/div/input")).SendKeys("50");
                    ///////////////////////////
                    fd.FindElementByXPath("/html/body/div[1]/div[2]/div/div/div/div/div[3]/div[1]/ul/li[3]/a").Click();
                    Thread.Sleep(200);


                   

                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[3]/div/div[1]/div[2]/div[1]/div[1]/div/div[1]/div/div/div")).Click();
                    Thread.Sleep(200);
                    SendKeys.Send(System.Text.RegularExpressions.Regex.Replace(arr[i]+ @"{Enter}", @"[()‘’,.#!%'""//\\:&~`+-=_]", "{$0}"));


                    //SendKeys.SendWait("{Enter}");
                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[3]/div/div[3]/div/div[2]/div[1]/div/div/div")).Click();
                    Thread.Sleep(200);
                    SendKeys.Send(System.Text.RegularExpressions.Regex.Replace(textBox1.Text+ @"{Enter}", @"[:\\]", "{$0}"));

                    //SendKeys.SendWait("{Enter}");

                    Thread.Sleep(200);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[4]/div/div[1]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("300");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[4]/div/div[1]/div[2]/div[2]/div/div[1]/div/div/div/input")).SendKeys("30");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[4]/div/div[1]/div[2]/div[2]/div/div[2]/div/div/div/input")).SendKeys("40");
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[1]/section[4]/div/div[1]/div[2]/div[2]/div/div[3]/div/div/div/input")).SendKeys("10");
                    SendKeys.SendWait(@"^{ADD}");
                    SendKeys.SendWait(@"^{ADD}");
                    SendKeys.SendWait(@"^{ADD}");
                    SendKeys.SendWait(@"^{ADD}");
                    Thread.Sleep(1000);
                    fd.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[2]/div[1]/div/div/button[3]")).Click();
                    Thread.Sleep(5000);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Kiểm tra lại đầy đủ input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult s = openFileDialog1.ShowDialog();
            string result = openFileDialog1.FileName;
            textBox1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string add = @"C:\Users\DM-TRUONG\AppData\Roaming\Mozilla\Firefox\Profiles";
            string[] profiles = Directory.GetDirectories(add);
            
            foreach (var i in profiles)
            {
                string[] ii = i.Split('\\');
                string[] iii = ii.ElementAt(ii.Length-1).Split('.');
                comboBox1.Items.Add(iii.ElementAt(iii.Length-1));
               
            }    


        }
    }
}
