using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.Extensions;
using BasePageObjectModel;
using System.IO;
using System.Collections.ObjectModel;
using System.Globalization;

namespace wsb724
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            textBoxUrl.Text = Global.GlobalUrl;
            textBoxViewer.Text = "Web Scraper version beta 1 Author TT \r\n";
            textBoxViewer.Text += "Please write login, pass and periode Ex. Dat1 17/01/2020  Dat2 19/01/2020  \r\n";
            textBoxViewer.Text += "Push Start to launch Scraper ...\r\n";


        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //MessageBox.Show("Start Scraper");
            Console.WriteLine("Start Scraper");
            string AssemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            textBoxViewer.Text += "Geckodriver path " + AssemblyPath + "\r\n";
            Console.WriteLine("Geckodriver path " + AssemblyPath);

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@AssemblyPath);

            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            textBoxViewer.Text += "Firefox path "+service.FirefoxBinaryPath +" \r\n";
            Console.WriteLine("Firefox path " + service.FirefoxBinaryPath);

            IWebDriver driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl(textBoxUrl.Text);
            driver.Manage().Window.Size = new Size(1100, 800);
            driver.Manage().Window.Position = new Point(800, 300);

            Thread.Sleep(TimeSpan.FromMilliseconds(2000));
            driver.FindElement(By.XPath("//div[contains(@class, 'hm-MainHeaderRHSLoggedOutWide_Login')]")).Click();
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));

            driver.FindElement(By.XPath("//div[contains(@class, 'lms-StandardLogin_InputsContainer')]/input")).SendKeys(textBoxUser.Text);
            textBoxViewer.Text += "User " + textBoxUser.Text + "\r\n";
            Global.GlobalUser = textBoxUser.Text;
            Console.WriteLine("Login");
            Thread.Sleep(TimeSpan.FromMilliseconds(2000));

            driver.FindElement(By.XPath("//div[contains(@class, 'lms-StandardLogin_InputsContainer-password')]/input")).SendKeys(textBoxPass.Text);


            textBoxViewer.Text += "Pass ****** \r\n";
            Global.GlobalPass = textBoxPass.Text;

            Thread.Sleep(TimeSpan.FromMilliseconds(2000));
            //String expectedresult = (String)((IJavaScriptExecutor)driver).ExecuteScript("return document.getElementsByClassName('lms-StandardLogin_Password')[2].value = '" + textBoxPass.Text + "';", null);
          


            driver.FindElement(By.ClassName("lms-StandardLogin_LoginButtonText")).Click();
            Thread.Sleep(TimeSpan.FromMilliseconds(4000));


            var saldo = driver.FindElement(By.XPath("//div[contains(@class, 'hm-Balance')]")).Text;       
            textBoxViewer.Text += "Saldo "+ saldo  +"\r\n";
            string saldoclean = saldo.Remove(saldo.Length - 1);
            textBoxSaldo.Text = saldoclean;
            float saldo_dec = float.Parse(saldoclean, CultureInfo.GetCultureInfo("en-US").NumberFormat);
            Global.GlobalSaldo = saldo_dec;


            Thread.Sleep(TimeSpan.FromMilliseconds(2000)); 
            var abiertas = driver.FindElement(By.XPath("//span[contains(@class, 'hm-HeaderMenuItemMyBets_MyBetsCount')]")).Text;
            textBoxViewer.Text += "Abiertas " + abiertas + "\r\n";
            textBoxOpens.Text = abiertas;
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));

            driver.FindElement(By.ClassName("hm-MainHeaderMembersWide_MembersMenuIcon")).Click();
            Thread.Sleep(TimeSpan.FromMilliseconds(4000));


           new WebDriverWait(driver, TimeSpan.FromSeconds(2000)).
           Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.XPath("//div[contains(@class, 'um-MembersLinkRow')][4]"))));
           driver.FindElement(By.XPath("//div[contains(@class, 'um-MembersLinkRow')][4]")).Click();



            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(TimeSpan.FromMilliseconds(2000));


            var date_A = textBoxDate1.Text; // fecha1 manual
            var date_B = textBoxDate2.Text;  // fecha2 manual
            Global.GlobalDat1 = date_A;
            Global.GlobalDat2 = date_B;

            var urlhistory = "https://members.bet365.es/members/Services/History/SportsHistory/HistorySearch/?BetStatus=0&SearchScope=3&datefrom=" +
                      date_A + "%2000:00:00&dateto=" + 
                      date_B + "%2023:59:59&displaymode=Mobile";

            Global.GlobalUrlHistory = urlhistory;

            Console.WriteLine("Url " + urlhistory);
            driver.Navigate().GoToUrl(urlhistory);
            Thread.Sleep(TimeSpan.FromMilliseconds(2000));


            new WebDriverWait(driver, TimeSpan.FromSeconds(1000)).
                 Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.Id("show-more-button"))));

            driver.FindElement(By.Id("show-more-button")).Click();
            Console.WriteLine("Display more");

            var displayedmore = driver.FindElement(By.Id("show-more-button")).IsDisplayed();
 

            while (displayedmore == true)
            {
                try { 

                new WebDriverWait(driver, TimeSpan.FromSeconds(2000)).
                    Until(ExpectedConditions.PresenceOfAllElementsLocatedBy((By.Id("show-more-button"))));

                driver.FindElement(By.Id("show-more-button")).Click();
               // Thread.Sleep(TimeSpan.FromMilliseconds(3000));


                }

                catch (Exception)
                {
                   // continue;
                    break;

                    //    Console.WriteLine("Version demo");
                    //    driver.Quit();
                }

                continue;

               // break;

            }
 
            Console.WriteLine("Display more end");

            ////////////////////////////////////////////////////////////

            try
            { 

            IReadOnlyCollection<IWebElement> rows = driver.FindElements(By.ClassName("bet-summary-detail"));
            IReadOnlyCollection<IWebElement> rtns = driver.FindElements(By.ClassName("bet-summary-detail-amounts-return-value"));
            IReadOnlyCollection<IWebElement> stks = driver.FindElements(By.ClassName("bet-summary-detail-amounts-total-stake-value"));

                float total_rtn = 0;
                float total_stk = 0;
                float profit = 0;
                int betwins = 0;
                int betloses = 0;
                int bets = 0;
                for (int i = 0; i < rows.Count; i++)
                   {
                    bets = bets + 1;
                    string row = rows.ElementAt(i).Text;
                    string rtn = rtns.ElementAt(i).Text;
                    string stk = stks.ElementAt(i).Text;

                    //string sub Ganancia + espacio // 
                    rtn = rtn.Replace("Ganancia ", "");
                    stk = stk.Replace("Apuesta ", "");
                    //string sub simbol euro //         
                    rtn = rtn.Remove(rtn.Length - 1);
                    stk = stk.Remove(stk.Length - 1);
                    //cambiamos comas por puntos         
                    rtn = rtn.Replace(",", ".");
                    stk = stk.Replace(",", ".");
                    //convertimos a comaflotante      
                    float rtn_dec = float.Parse(rtn, CultureInfo.GetCultureInfo("en-US").NumberFormat);
                    float stk_dec = float.Parse(stk, CultureInfo.GetCultureInfo("en-US").NumberFormat);
                    //wins loses
                    if (rtn_dec > 0) { betwins += 1; }
                    if (rtn_dec == 0) { betloses += 1; }
                    //total
                    total_rtn += rtn_dec;
                    total_stk += stk_dec;
                    //profit
                    profit = total_rtn - total_stk;
                    // viewer results 

                    Console.WriteLine("Total Stake " + total_stk);
                    Console.WriteLine("Total Return " + total_rtn);
                    Console.WriteLine("Profit " + profit);

                    if (checkBoxShowAll.Checked)
                    {
                             textBoxViewer.Text += "Bet " + bets + "  ";
                             textBoxViewer.Text += "Wins " + betwins + "  ";
                             textBoxViewer.Text += "Loses " + betloses + "  ";
                             textBoxViewer.Text += "Stake " + stk_dec + "€  ";
                             textBoxViewer.Text += "Total Stake " + total_stk + "€  ";
                             textBoxViewer.Text += "Total Return " + total_rtn + "€ ";
                             textBoxViewer.Text += "Profit " + profit + "€ \r\n";
                    }

                    string boxi = bets.ToString("0.##");
                    string boxwins = betwins.ToString("0");
                    string boxloses = betloses.ToString("0");
                    string boxstk = total_stk.ToString("0.##");
                    string boxrtn = total_rtn.ToString("0.##");
                    string boxprof = profit.ToString("0.##");

                    textBoxBets.Text = boxi ;
                    textBoxWins.Text = boxwins;
                    textBoxLoses.Text = boxloses;
                    textBoxStakes.Text = boxstk;
                    textBoxReturns.Text = boxrtn;
                    textBoxProfit.Text = boxprof;

                    Global.GlobalBets = bets;
                    Global.GlobalWins = betwins;
                    Global.GlobalLoses = betloses;
                    Global.GlobalStakes = total_stk;
                    Global.GlobalReturns = total_rtn;
                    Global.GlobalProfit = profit;

                }

            }
            catch
            {
            }

             textBoxViewer.Text += "Bets " + Global.GlobalBets + "\r\n";
            textBoxViewer.Text += "Wins " + Global.GlobalWins + "\r\n";
            textBoxViewer.Text += "Loses " + Global.GlobalLoses + "\r\n";
            textBoxViewer.Text += "Stakes " + Global.GlobalStakes + "\r\n";
             textBoxViewer.Text += "Returns " + Global.GlobalReturns + "\r\n";
             textBoxViewer.Text += "Profit " + Global.GlobalProfit + "\r\n";
            ////////////////////////////////////////////////////////////

            driver.Quit();
            textBoxViewer.Text += "Script Finished OK! \r\n";

  //          Console.WriteLine("Cash " + saldo + "Opens " + abiertas);
            Console.WriteLine("Script Finished OK!");

        }
 

        private void btnStop_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Please confirm before proceed" + "\n" + "Do you want to Continue ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                //do something if YES

               // MessageBox.Show("RESET", "You Want Reset All Values from Scraper ?", "yes / no");
                Console.WriteLine("Reset All Values Scraper");
                textBoxSaldo.Clear();
                textBoxOpens.Clear();
                textBoxViewer.Clear();
                textBoxBets.Clear();
                textBoxLoses.Clear();
                textBoxWins.Clear();
                textBoxStakes.Clear();
                textBoxReturns.Clear();
                textBoxProfit.Clear();

                Global.GlobalUser = "";
                Global.GlobalPass = "";
                Global.GlobalDat1 = "";
                Global.GlobalDat2 = "";
                Global.GlobalAbiertas = 0;
                Global.GlobalSaldo = 0;
                Global.GlobalBets = 0;
                Global.GlobalWins = 0;
                Global.GlobalLoses = 0;
                Global.GlobalStakes = 0;
                Global.GlobalReturns = 0;
                Global.GlobalProfit = 0;

            }

            else

            {
                //do something if NO
                return;
            }



        }

        
    }
}
