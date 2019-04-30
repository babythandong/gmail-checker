using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace GmailChecker
{

    public partial class frmMain : MetroForm
    {
        private global::System.Windows.Forms.Timer timerMain = new global::System.Windows.Forms.Timer();
        public static string globalLogs = "";
        private ChromeDriver drive;
        private Random rd = new Random();
        public bool isDone;
        public int countView;
        public int currentEmail;
        public int numCheck;

        public frmMain()
        {
            InitializeComponent();
        }

        #region LoginEmail
        public string LoginEmail(string email, string password, string recovery, string city)
        {
            string result;
            try
            {
                this.drive.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fwww.youtube.com%2Fsignin%3Fapp%3Ddesktop%26action_handle_signin%3Dtrue%26next%3D%252Fmy_videos%26hl%3Dvi%26feature%3Dredirect_login&passive=true&hl=en&service=youtube&uilel=3&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
                if (this.drive.Url.Contains("accounts.google.com"))
                {
                    IWebElement webElement = this.drive.FindElement(By.Id("identifierId"));
                    webElement.SendKeys(email);
                    webElement.SendKeys(OpenQA.Selenium.Keys.Enter);
                    Thread.Sleep(5000);
                    this.drive.FindElement(By.Name("password")).SendKeys(password);
                    this.drive.FindElementById("passwordNext").Click();
                    Thread.Sleep(5000);
                    if (this.drive.Url.Contains("newfeatures"))
                    {
                        this.LoginNewFeatures();
                        return "Đăng nhập thành công";
                    }
                    if (this.drive.Url.Contains("recovery-options-collection"))
                    {
                        return "Đăng nhập thành công";
                    }
                    
                    if (this.drive.Url.Contains("accounts.google.com"))
                    {
                        try
                        {
                            ReadOnlyCollection<IWebElement> readOnlyCollection = this.drive.FindElementsByCssSelector("div.TnvOCe.k6Zj8d");
                            if (readOnlyCollection.Count == 0)
                            {
                                return "gmail lỗi sai pass";
                            }
                            foreach (IWebElement webElement2 in readOnlyCollection)
                            {
                                try
                                {
                                    IWebElement webElement3 = webElement2.FindElement(By.ClassName("vdE7Oc"));
                                    if (webElement3.Text.ToLower().Contains("email") && recovery != "")
                                    {
                                        webElement2.Click();
                                        Thread.Sleep(5000);
                                        try
                                        {
                                            IWebElement webElement4 = this.drive.FindElement(By.Id("knowledge-preregistered-email-response"));
                                            webElement4.SendKeys(recovery);
                                            webElement4.SendKeys(OpenQA.Selenium.Keys.Enter);
                                        }
                                        catch (Exception)
                                        {
                                            IWebElement webElement5 = this.drive.FindElement(By.Name("knowledgePreregisteredEmailResponse"));
                                            webElement5.SendKeys(recovery);
                                            webElement5.SendKeys(OpenQA.Selenium.Keys.Enter);
                                        }
                                        Thread.Sleep(5000);
                                        if (this.drive.Url.Contains("newfeatures"))
                                        {
                                            this.LoginNewFeatures();
                                            return "Đăng nhập thành công";
                                        }
                                        if (this.drive.Url.Contains("recovery-options-collection"))
                                        {
                                            return "Đăng nhập thành công";
                                        }
                                        if (this.drive.Url.Contains("changepassword") && recovery != "")
                                        {
                                            string new_password = RandomString();
                                            this.drive.FindElementByName("Passwd").SendKeys(new_password);
                                            this.drive.FindElementByName("ConfirmPasswd").SendKeys(new_password);
                                            this.drive.FindElementByName("ConfirmPasswd").SendKeys(OpenQA.Selenium.Keys.Enter);
                                            ghilog_matkhaumoitruycap(email +" | "+ new_password + " | " + recovery);
                                            return "Đăng nhập thành công. Mật khẩu mới: " + new_password;
                                        }
                                        if (this.drive.Url.Contains("accounts.google.com"))
                                        {
                                            return "gmail lỗi sai mail khôi phục";
                                        }
                                        
                                        break;
                                    }
                                   
                                    else if (this.drive.Url.Contains("challenge") && recovery!="")
                                    {

                                        webElement3.FindElement(By.XPath(@"//*[@id=""view_container""]/form/div[2]/div/div/div/ul/li[4]/div/div[1]/svg/path[2]")).Click();
                                        this.drive.FindElementByXPath(@"//*[@id=""identifierId""]").SendKeys(recovery);
                                        webElement3.SendKeys(OpenQA.Selenium.Keys.Enter);
                                        //this.drive.FindElementByXPath(@"//*[@id=""yDmH0d""]/c-wiz[2]/c-wiz/div/div[1]/div/div/div/div[2]/div[3]/div/div[2]/div/div[2]").Click();
                                        return "Đăng nhập thành công";
                                    }
                                 
                                    else if (webElement3.Text.ToLower().Contains("phone number") && recovery != "")
                                    {
                                        webElement2.Click();
                                        Thread.Sleep(5000);
                                        try
                                        {
                                            IWebElement webElement6 = this.drive.FindElement(By.Id("phoneNumberId"));
                                            webElement6.SendKeys(recovery);
                                            webElement6.SendKeys(OpenQA.Selenium.Keys.Enter);
                                        }
                                        catch
                                        {
                                        }
                                        Thread.Sleep(5000);
                                        if (this.drive.Url.Contains("newfeatures"))
                                        {
                                            this.LoginNewFeatures();
                                            return "Đăng nhập thành công";
                                        }
                                        if (this.drive.Url.Contains("recovery-options-collection"))
                                        {
                                            return "Đăng nhập thành công";
                                        }
                                        if (this.drive.Url.Contains("accounts.google.com"))
                                        {
                                            return "gmail lỗi sai số điện thoại khôi phục";
                                        }
                                        break;
                                    }
                                    else if (webElement3.Text.ToLower().Contains("city"))
                                    {
                                        webElement2.Click();
                                        Thread.Sleep(4000);
                                        string[] array = city.Split(new char[]
                                        {
                                    ','
                                        });
                                        IWebElement webElement7 = this.drive.FindElement(By.Id("knowledgeLoginLocationInput"));
                                        foreach (string text in array)
                                        {
                                            webElement7.Clear();
                                            webElement7.SendKeys(text);
                                            webElement7.SendKeys(OpenQA.Selenium.Keys.Enter);
                                            Thread.Sleep(4000);
                                            if (this.drive.Url.Contains("newfeatures"))
                                            {
                                                this.LoginNewFeatures();
                                                return "Đăng nhập thành công";
                                            }
                                            if (this.drive.Url.Contains("recovery-options-collection"))
                                            {
                                                return "Đăng nhập thành công";
                                            }
                                        }
                                        if (this.drive.Url.Contains("accounts.google.com"))
                                        {
                                            return "gmail lỗi sai thành phố đăng nhập";
                                        }
                                        break;
                                    }
                                }
                                catch (Exception)
                                {
                                }
                            }
                        }
                        catch
                        {
                            return "gmail lỗi không tồn tại  hoặc bị disable";
                        }
                    }
                }
                result = "Đăng nhập thành công";
            }
            catch (Exception ex)
            {
                this.Logs("Đăng nhập mail lỗi: " + ex.Message);
                Thread.Sleep(30000);
                result = ex.Message;
            }
            return result;
        }
        #endregion
        #region LoginNewFeatures
        public void LoginNewFeatures()
        {
            try
            {
                ReadOnlyCollection<IWebElement> readOnlyCollection = this.drive.FindElementsByCssSelector("div[role=\"button\"]");
                readOnlyCollection[0].Click();
                Thread.Sleep(2000);
                readOnlyCollection[0].Click();
                Thread.Sleep(2000);
                readOnlyCollection[1].Click();
                Thread.Sleep(5000);
            }
            catch
            {
            }
        }
        #endregion
        #region WriteLog
        public static void WriteLogs()
        {
            try
            {
                File.WriteAllText(Application.StartupPath + "\\logs.txt", frmMain.globalLogs);
            }
            catch
            {
            }
        }
        public static void ghiEmail9xac(string text)
        {
            string text_current = text;
            string path = Application.StartupPath + "\\maildung.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(text_current + Environment.NewLine);
                }

            }
            else if (File.Exists(path))
            {
                File.AppendAllText(path, text_current + Environment.NewLine);
            }
        }
        public static void ghiEmailSai(string text)
        {
            string text_current = text;
            string path = Application.StartupPath + "\\mailsai.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(text_current + Environment.NewLine);
                }

            }
            else if (File.Exists(path))
            {
                File.AppendAllText(path, text_current + Environment.NewLine);
            }
        }
        public static void recover_Email(string text)
        {
            string text_current = text;
            string path = Application.StartupPath + "\\kqrecover.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(text_current + Environment.NewLine);
                }

            }
            else if (File.Exists(path))
            {
                File.AppendAllText(path, text_current + Environment.NewLine);
            }
        }
        public static void ghilog_changepass(string text)
        {
            string text_current = text;
            string path = Application.StartupPath + "\\ghilog_changepass.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(text_current + Environment.NewLine);
                }

            }
            else if (File.Exists(path))
            {
                File.AppendAllText(path, text_current + Environment.NewLine);
            }
        }
        public static void ghilog_thongtinkenhyt(string text)
        {
            string text_current = text;
            string path = Application.StartupPath + "\\ghilog_kenhyt.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(text_current + Environment.NewLine);
                }

            }
            else if (File.Exists(path))
            {
                File.AppendAllText(path, text_current + Environment.NewLine);
            }
        }
        public static void ghilog_thongtintonghop(string text)
        {
            string text_current = text;
            string path = Application.StartupPath + "\\ghilog_thongtintonghop.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(text_current + Environment.NewLine);
                }

            }
            else if (File.Exists(path))
            {
                File.AppendAllText(path, text_current + Environment.NewLine);
            }
        }
        public static void ghilog_matkhaumoitruycap(string text)
        {
            string text_current = text;
            string path = Application.StartupPath + "\\ghilog_matkhaumoitruycap.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(text_current + Environment.NewLine);
                }

            }
            else if (File.Exists(path))
            {
                File.AppendAllText(path, text_current + Environment.NewLine);
            }
        }
        #endregion
        #region ChangePassWord
        public string ChangePassword(string oldPass)
        {
            this.drive.Navigate().GoToUrl("https://myaccount.google.com/signinoptions/password");
            try
            {
                IWebElement webElement = this.drive.FindElement(By.Name("password"));
                webElement.SendKeys(oldPass);
                IWebElement webElement2 = this.drive.FindElement(By.Id("passwordNext"));
                webElement2.SendKeys(OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(5000);
            }
            catch
            {
            }
            string result;
            try
            {
                string text = this.RandomString();
                IWebElement webElement3 = this.drive.FindElement(By.Name("password"));
                webElement3.SendKeys(text);
                Thread.Sleep(1000);
                IWebElement webElement4 = this.drive.FindElement(By.Name("confirmation_password"));
                webElement4.SendKeys(text);
                Thread.Sleep(1000);
                IWebElement webElement5 = this.drive.FindElementByCssSelector(".qNeFe.RH9rqf>div.O0WRkf");
                webElement5.Click();
                Thread.Sleep(3000);
                result = text;
            }
            catch
            {
                result = oldPass;
            }
            return result;
        }
        public string RandomString()
        {
            int count = 15;
            Random random = new Random();
            return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", count)
                               select s[random.Next(s.Length)]).ToArray<char>());
        }
        #endregion
        #region ChangeEmailRecoverSingle
        public string ChangeEmailRecovery(string email, string password)
        {
            this.drive.Navigate().GoToUrl("https://myaccount.google.com/recovery/email");
            try
            {
                IWebElement webElement = this.drive.FindElement(By.Name("password"));
                webElement.SendKeys(password);
                IWebElement webElement2 = this.drive.FindElement(By.Id("passwordNext"));
                webElement2.SendKeys(OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(5000);
            }
            catch
            {
            }
            string text;
            if (!email.Contains("gmail.com"))
            {
                if (email.Contains("@"))
                {
                    text = email.Split(new char[]
                    {
                '@'
                    })[0] + "@" + this.txtDomainEmail.Text;
                }
                else
                {
                    text = email + "@" + this.txtDomainEmail.Text;
                }
            }
            else
            {
                text = email.Replace("gmail.com", this.txtDomainEmail.Text);
            }
            string result;
            try
            {
                this.drive.FindElementByCssSelector("c-wiz > div > div.hyMrOd > div.Wea5y > div > div").Click();
                Thread.Sleep(1000);
                IWebElement webElement3 = this.drive.FindElementByCssSelector(".whsOnd.zHQkBf");
                webElement3.Clear();
                webElement3.SendKeys(text);
                Thread.Sleep(1000);
                Actions actions = new Actions(this.drive);
                actions.SendKeys(OpenQA.Selenium.Keys.Enter).Perform();
                Thread.Sleep(1000);
                result = text;
            }
            catch
            {
                try
                {
                    this.drive.FindElementByCssSelector("div[aria-label*=\"Edit recovery email\"]").Click();
                    Thread.Sleep(1000);
                    IWebElement webElement4 = this.drive.FindElementByCssSelector(".whsOnd.zHQkBf");
                    webElement4.Clear();
                    webElement4.SendKeys(text);
                    Thread.Sleep(1000);
                    Actions actions2 = new Actions(this.drive);
                    actions2.SendKeys(OpenQA.Selenium.Keys.Enter).Perform();
                    Thread.Sleep(1000);
                    result = text;
                }
                catch
                {
                    result = "";
                }
            }
            return result;
        }
        public string ChangeEmailRecoveryAllinOne(string email, string password)
        {
            this.drive.Navigate().GoToUrl("https://myaccount.google.com/recovery/email");
            try
            {
                IWebElement webElement = this.drive.FindElement(By.Name("password"));
                webElement.SendKeys(password);
                IWebElement webElement2 = this.drive.FindElement(By.Id("passwordNext"));
                webElement2.SendKeys(OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(5000);
            }
            catch
            {
            }
            string text;
            if (!email.Contains("gmail.com"))
            {
                if (email.Contains("@"))
                {
                    text = email.Split(new char[]
                    {
                '@'
                    })[0] + "@" + this.alltxtDomain.Text;
                }
                else
                {
                    text = email + "@" + this.alltxtDomain.Text;
                }
            }
            else
            {
                text = email.Replace("gmail.com", this.alltxtDomain.Text);
            }
            string result;
            try
            {
                this.drive.FindElementByCssSelector("c-wiz > div > div.hyMrOd > div.Wea5y > div > div").Click();
                Thread.Sleep(1000);
                IWebElement webElement3 = this.drive.FindElementByCssSelector(".whsOnd.zHQkBf");
                webElement3.Clear();
                webElement3.SendKeys(text);
                Thread.Sleep(1000);
                Actions actions = new Actions(this.drive);
                actions.SendKeys(OpenQA.Selenium.Keys.Enter).Perform();
                Thread.Sleep(1000);
                result = text;
            }
            catch
            {
                try
                {
                    this.drive.FindElementByCssSelector("div[aria-label*=\"Edit recovery email\"]").Click();
                    Thread.Sleep(1000);
                    IWebElement webElement4 = this.drive.FindElementByCssSelector(".whsOnd.zHQkBf");
                    webElement4.Clear();
                    webElement4.SendKeys(text);
                    Thread.Sleep(1000);
                    Actions actions2 = new Actions(this.drive);
                    actions2.SendKeys(OpenQA.Selenium.Keys.Enter).Perform();
                    Thread.Sleep(1000);
                    result = text;
                }
                catch
                {
                    result = "";
                }
            }
            return result;
        }
        #endregion
        #region Xóa cache
        void ClearCache()
        {
            string path = Environment.GetEnvironmentVariable("userprofile") + "\\AppData\\Local\\Temp";
            if (Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
                {
                    try
                    {
                        if (directoryInfo2.Name.Contains("scoped"))
                        {
                            directoryInfo2.Delete(true);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
        #endregion
        #region Ghi Logs
        public void Logs(string tmpText)
        {
            if (this.txtLogs.InvokeRequired)
            {
                base.Invoke(new Action(delegate ()
                {
                    RichTextBox textBox2 = this.txtLogs;
                    string text3 = textBox2.Text;
                    textBox2.Text = string.Concat(new string[]
                    {
                text3,
                "[",
                DateTime.Now.ToString("hh:mm:ss tt"),
                "] ",
                tmpText,
                "\r\n"
                    });
                    this.txtLogs.SelectionStart = this.txtLogs.Text.Length;
                    this.txtLogs.ScrollToCaret();
                    string text4 = frmMain.globalLogs;
                    frmMain.globalLogs = string.Concat(new string[]
                    {
                text4,
                "[",
                DateTime.Now.ToString("hh:mm:ss tt"),
                "] ",
                tmpText,
                Environment.NewLine
                    });
                    frmMain.WriteLogs();
                }));
                return;
            }
            RichTextBox textBox = this.txtLogs;
            string text = textBox.Text;
            txtLogs.Text = string.Concat(new string[]
            {
        text,
        "[",
        DateTime.Now.ToString("hh:mm:ss tt"),
        "] ",
        tmpText,
        "\r\n"
            });
            this.txtLogs.SelectionStart = this.txtLogs.Text.Length;
            this.txtLogs.ScrollToCaret();
            string text2 = frmMain.globalLogs;
            frmMain.globalLogs = string.Concat(new string[]
            {
        text2,
        "[",
        DateTime.Now.ToString("hh:mm:ss tt"),
        "] ",
        tmpText,
        Environment.NewLine
            });
            frmMain.WriteLogs();
        }
        #endregion
        #region GetHtmlFromUrl
        public string GetHtmlFromUrl(string url)
        {
            string result = "";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
            using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream responseStream = httpWebResponse.GetResponseStream())
                {
                    using (StreamReader streamReader = new StreamReader(responseStream))
                    {
                        result = streamReader.ReadToEnd();
                    }
                }
            }
            return result;
        }

        #endregion
        #region ChangeLanguage
        public void ChangeLanguage()
        {
            try
            {
                this.drive.Navigate().GoToUrl("https://myaccount.google.com/language");
                Thread.Sleep(5000);
                int num = 0;
                do
                {
                    try
                    {
                        IWebElement webElement = this.drive.FindElementByCssSelector(".mUbCce.fKz7Od.M9Bg4d");
                        if (webElement.GetAttribute("aria-label") != "Edit language: English (United States)")
                        {
                            webElement.Click();
                            Thread.Sleep(2000);
                            this.drive.FindElementByCssSelector("div[data-languagecode=\"en\"]").Click();
                            Thread.Sleep(1000);
                            this.drive.FindElementByCssSelector("div[data-languagecode=\"en\"]").Click();
                            Thread.Sleep(1000);
                            ReadOnlyCollection<IWebElement> readOnlyCollection = this.drive.FindElementsByCssSelector(".XfpsVe.J9fJmf>div[role=\"button\"]");
                            readOnlyCollection[1].Click();
                            Thread.Sleep(3000);
                        }
                        break;
                    }
                    catch
                    {
                        num++;
                        Thread.Sleep(1000);
                    }
                }
                while (num != 10);
            }
            catch (Exception ex)
            {
                this.Logs("Lỗi Change Language: " + ex.Message);
            }
        }
        #endregion
        #region LayThongTinKenh
        
        public string LayThongTinKenh(string text_rs)
        {
            string result = "";
            string text = "";
            string str_count_rs_yt = "";
            this.drive.Navigate().GoToUrl("https://www.youtube.com/channel_switcher");
            Thread.Sleep(2000);
            ReadOnlyCollection<IWebElement> readOnlyCollection = this.drive.FindElementsByCssSelector(".channel-switcher-button>.highlight>a");
            List<string> list = new List<string>();
            foreach (IWebElement webElement in readOnlyCollection)
            {
                list.Add(webElement.GetAttribute("href"));
            }
            foreach(string url in list)
            {
                try
                {
                    this.drive.Navigate().GoToUrl(url);
                    this.drive.Navigate().GoToUrl("https://www.youtube.com/features");
                    string attribute = this.drive.FindElementByCssSelector(".account-status-v2-photo>a").GetAttribute("href");
                    string text7 = attribute.Replace("https://www.youtube.com/channel/", "").Trim(new char[]
                    {
                '\n'
                    });
                    text = text + "https://www.youtube.com/channel/" + text7 + "|"; //Link keenh
                    string url2 = "https://www.googleapis.com/youtube/v3/channels?part=snippet%2CcontentDetails%2Cstatistics&id=" + text7 + "&key=AIzaSyDY6wdiaWcMaMrqWtPaU47tlVPb2lwRugc";
                    string htmlFromUrl = this.GetHtmlFromUrl(url2);
                    var arg = (JObject)JsonConvert.DeserializeObject(htmlFromUrl);
                    var str_item_subscriberCount = arg["items"][0]["statistics"]["subscriberCount"].ToString();
                    var str_item_videoCount = arg["items"][0]["statistics"]["videoCount"].ToString();
                    str_count_rs_yt += "Ten kenh:"+arg["items"][0]["snippet"]["title"]+" | PublishAt: "+ arg["items"][0]["snippet"]["publishedAt"] +" | Link kenh:"+text+" | Subcriber: " + str_item_subscriberCount + " | Video:" + str_item_videoCount+Environment.NewLine;
                }
                catch{}
            }
            return result + "  " + str_count_rs_yt;
        }

        #endregion

        /*================ BẮT ĐẦU XỬ LÝ SỰ KIỆN =======================*/
        private void BtnRun_Click(object sender, EventArgs e)
        {
            string listmail_str = txtEmailList.Text;
            string[] ar_listmail = listmail_str.Split('\n');
            int i = 0;

            foreach (string mail in ar_listmail)
            {
                if (i == 0)
                {
                    btnRun.Enabled = false;
                    this.Logs("=============== BAT DAU CHECKING TAI KHOAN ===============");
                }
                string[] ar_mail = mail.Split('|');
                this.ClearCache();
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--start-maximized");
                chromeOptions.AddArgument("--disable-infobars");
                chromeOptions.AddArgument("--disable-notifications");
                this.drive = new ChromeDriver(chromeDriverService, chromeOptions);
                
                try
                {
                    string text = this.LoginEmail(ar_mail[0], ar_mail[1], ar_mail[2], "");
                    if (text != "Đăng nhập thành công")
                    {
                        string text1 = ar_mail[0] + " | " + ar_mail[1] +" | "+ar_mail[2]+ " ~~> " + text;
                        this.Logs(text1);
                        ghiEmailSai(ar_mail[0] + " | " + ar_mail[1] + " | " + ar_mail[2]);
                        this.drive.Close();
                        this.drive.Quit();
                    }
                    else
                    {
                        Thread.Sleep(5000);
                        string text1 = ar_mail[0] + " | " + ar_mail[1] + " ~~> " + text;
                        this.Logs(text1);
                        if (cbCheckTaiKhoan.Checked)
                        {
                            ghiEmail9xac(ar_mail[0] + " | " + ar_mail[1]+" | "+ar_mail[2]);
                        }
                        else if (ckbDoiMailKhoiPhuc.Checked)
                        {
                            string email_recover = ChangeEmailRecovery(ar_mail[0], ar_mail[1]);
                            recover_Email(ar_mail[0] + " | " + ar_mail[1] + " | "+ar_mail[2] +" | " +email_recover);
                        }
                        else if (ckbDoiMatKhau.Checked)
                        {
                            string new_pass = ChangePassword(ar_mail[1]);
                            ghilog_changepass(ar_mail[0] + " | " + ar_mail[1] + " | " + new_pass);
                        }else if (ckbDoiNgonNgu.Checked)
                        {
                            this.Logs("Đổi ngôn ngữ sang EN-US");
                            this.ChangeLanguage();
                        }else if (ckbLayThongTinKenh.Checked)
                        {
                            this.Logs("Lấy thông tin kênh");
                            string rs_getkenhyt = LayThongTinKenh(ar_mail[0] + " | " + ar_mail[1]);
                            this.Logs(rs_getkenhyt);
                            ghilog_thongtinkenhyt(rs_getkenhyt);
                        }
                        this.drive.Close();
                        this.drive.Quit();
                    }
                }
                catch { }
                if (i == ar_listmail.Length - 1)
                {
                    this.Logs("=============== HOAN THANH ===============");
                    btnRun.Enabled = true;
                }
                Thread.Sleep(2000);
                i++;
            }
        }

        private void AllbtnStart_Click(object sender, EventArgs e)
        {
            string listmail_str = txtEmailList.Text;
            string[] ar_listmail = listmail_str.Split('\n');
            int i = 0;

            foreach (string mail in ar_listmail)
            {
                if (i == 0)
                {
                    allbtnStart.Enabled = false;
                    this.Logs("=============== BAT DAU CHECKING TAI KHOAN ===============");
                }
                this.ChangeLanguage();
                string[] ar_mail = mail.Split('|');
                this.ClearCache();
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--start-maximized");
                chromeOptions.AddArgument("--disable-infobars");
                chromeOptions.AddArgument("--disable-notifications");
                this.drive = new ChromeDriver(chromeDriverService, chromeOptions);
               
                try
                {
                    string text = this.LoginEmail(ar_mail[0], ar_mail[1], ar_mail[2], "");
                    if (text != "Đăng nhập thành công")
                    {
                        string text1 = ar_mail[0] + " | " + ar_mail[1] +" | "+ar_mail[2]+ " ~~> " + text;
                        this.Logs(text1);
                        ghiEmailSai(ar_mail[0] + " | " + ar_mail[1]+" | "+ar_mail[2]);
                        this.drive.Close();
                        this.drive.Quit();
                    }
                    else
                    {
                        Thread.Sleep(5000);
                        /*
                         * Xac minh duoc email dang nhap thanh cong
                         * B1 Xác minh email đăng nhập thành công -->xong
                         * B2 Đổi email khôi phục
                        */
                        string new_pass = "";
                        string email_recover = "";
                        string rs_getkenhyt = "";
                        
                        if (allcbDoimailkhoiphuctheodomain.Checked)
                        {
                            email_recover = ChangeEmailRecoveryAllinOne(ar_mail[0], ar_mail[1]);
                        }
                        if (allcbLaythongtinkenhYT.Checked)
                        {
                            rs_getkenhyt = LayThongTinKenh(ar_mail[0] + " | " + ar_mail[1]);
                        }
                        if (allcbDoimatkhau.Checked)
                        {
                            new_pass = ChangePassword(ar_mail[1]);
                        }
                        string resen = ar_mail[0] + " | " + new_pass +" | "+ar_mail[2]+ " | " + email_recover + " | Info YT: " + rs_getkenhyt;
                        this.Logs(resen);
                        ghilog_thongtintonghop(resen);
                        this.drive.Close();
                        this.drive.Quit();
                    }
                }
                catch { }
                if (i == ar_listmail.Length - 1)
                {
                    this.Logs("=============== HOAN THANH ===============");
                    allbtnStart.Enabled = true;
                }
                Thread.Sleep(2000);
                i++;
            }
        }
    }

}
