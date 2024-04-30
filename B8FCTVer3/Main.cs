using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text.RegularExpressions;
using B8FCTVer3.Printer;
using System.Printing;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace B8FCTVer3
{
    public partial class Main : Form
    {
        public AyarForm AyarFrm;
        public Sifre SifreFrm;
        public ProgAyarForm ProgAyarFrm;
        public ProcessForm ProcessFrm;
        public ProgramlamaForm ProgramlamaFrm;
        private IntPtr ShellHwnd;
        private DateTime lastDateTime = DateTime.Now;

        private string customMessageBoxTitle;
        string printerName;
        string[] cozunurluk = new string[2];

        int step = 0;
        int stepState = 0;
        int stepStateMax = 0;
        int stepJob = 0;
        int serialTx1TimerCounter = 0;
        int serialTx2TimerCounter = 0;
        int serialTx3TimerCounter = 0;
        int serialTx4TimerCounter = 0;
        int adminTimerCounter = 0;
        int timeoutTimerCounter = 0;
        int saniyeTimerCounter = 0;

        byte[] byteArray = new byte[8];
        int byteLenght = 0;
        byte[] feedback = new byte[256];
        byte[,] feedbackInterval = new byte[10,40];
        byte[] arrayRx = new byte[256];
        int counterRxByte = 0;
        int internalNum = 0;

        int totalCard = 0;
        int errorCard = 0;
        int fctSaniye = 0;
        public int yetki;
        string logDosyaPath = "";
        int safirSleepTime = 0;

        public Main()
        {
            this.AyarFrm = new AyarForm();
            this.AyarFrm.MainFrm = this;
            this.SifreFrm = new Sifre();
            this.SifreFrm.MainFrm = this;
            this.ProgAyarFrm = new ProgAyarForm();
            this.ProgAyarFrm.MainFrm = this;
            this.ProcessFrm = new ProcessForm();
            this.ProcessFrm.MainFrm = this;
            this.ProgramlamaFrm = new ProgramlamaForm();
            this.ProgramlamaFrm.MainFrm = this;
            InitializeComponent();
        }

        public class INIKaydet
        {
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            public INIKaydet(string dosyaYolu)
            {
                DOSYAYOLU = dosyaYolu;
            }
            private string DOSYAYOLU = String.Empty;
            public string Varsayilan { get; set; }
            public string Oku(string bolum, string ayaradi)
            {
                Varsayilan = Varsayilan ?? string.Empty;
                StringBuilder StrBuild = new StringBuilder(256);
                GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 255, DOSYAYOLU);
                return StrBuild.ToString();
            }
            public long Yaz(string bolum, string ayaradi, string deger)
            {
                return WritePrivateProfileString(bolum, ayaradi, deger, DOSYAYOLU);
            }
        }

        [DllImport("user32.dll")]
        public static extern byte ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string ClassName, string WindowName);

        private void Main_Load(object sender, EventArgs e)
        {
            this.ShellHwnd = Main.FindWindow("Shell TrayWnd", (string)null);
            IntPtr shellHwnd = this.ShellHwnd;
            int num1 = (int)Main.ShowWindow(this.ShellHwnd, 0);

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Control.CheckForIllegalCrossThreadCalls = false;
            /*
            cozunurluk = Ayarlar.Default.cozunurluk.Split('x');
            double cozunurlukW = Convert.ToDouble(cozunurluk[0]);
            double cozunurlukH = Convert.ToDouble(cozunurluk[1]);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Rectangle Cozunurluk = new Rectangle();
            Cozunurluk = Screen.GetBounds(Cozunurluk);
            float OranWidth = ((float)Cozunurluk.Width / (float)cozunurlukW);
            float OranHeight = ((float)Cozunurluk.Height / (float)cozunurlukH);
            this.Scale(new SizeF(OranWidth, OranHeight));
            */
            this.customMessageBoxTitle = Ayarlar.Default.projectName;
            this.printerName = Ayarlar.Default.printerName;
            this.projectNameTxt.Text = customMessageBoxTitle;
            this.Text = customMessageBoxTitle;

            this.cardPicture.ImageLocation = Ayarlar.Default.PNGdosyayolu;

            foreach (string portName in SerialPort.GetPortNames())
            {
                this.AyarFrm.SerialPort1Com.Items.Add((object)portName);
                this.AyarFrm.SerialPort2Com.Items.Add((object)portName);
                this.AyarFrm.SerialPort3Com.Items.Add((object)portName);
                this.AyarFrm.SerialPort4Com.Items.Add((object)portName);
            }
            if (Ayarlar.Default.chBoxProgramlama)
            {
                btnStartProgramming.Enabled = false;
                btnFCTInit.Enabled = false;
            }

            this.logDosyaPath = Ayarlar.Default.txtLogDosya;
            this.serialPort1.PortName = Ayarlar.Default.SerialPort1Com;
            this.serialPort1.BaudRate = Ayarlar.Default.SerialPort1Baud;
            this.serialPort1.DataBits = Ayarlar.Default.SerialPort1dataBits;
            this.serialPort1.StopBits = Ayarlar.Default.SerialPort1stopBit;
            this.serialPort1.Parity = Ayarlar.Default.SerialPort1Parity;
            this.serialPort1.ReceivedBytesThreshold = 1;
            this.serialPort2.PortName = Ayarlar.Default.SerialPort2Com;
            this.serialPort2.BaudRate = Ayarlar.Default.SerialPort2Baud;
            this.serialPort2.DataBits = Ayarlar.Default.SerialPort2dataBits;
            this.serialPort2.StopBits = Ayarlar.Default.SerialPort2stopBit;
            this.serialPort2.Parity = Ayarlar.Default.SerialPort2Parity;
            this.serialPort2.ReceivedBytesThreshold = 1;
            this.serialPort3.PortName = Ayarlar.Default.SerialPort3Com;
            this.serialPort3.BaudRate = Ayarlar.Default.SerialPort3Baud;
            this.serialPort3.DataBits = Ayarlar.Default.SerialPort3dataBits;
            this.serialPort3.StopBits = Ayarlar.Default.SerialPort3stopBits;
            this.serialPort3.Parity = Ayarlar.Default.SerialPort3Parity;
            this.serialPort3.ReceivedBytesThreshold = 1;
            this.serialPort4.PortName = Ayarlar.Default.SerialPort4Com;
            this.serialPort4.BaudRate = Ayarlar.Default.SerialPort4Baud;
            this.serialPort4.DataBits = Ayarlar.Default.SerialPort4dataBits;
            this.serialPort4.StopBits = Ayarlar.Default.SerialPort4stopBits;
            this.serialPort4.Parity = Ayarlar.Default.SerialPort4Parity;
            this.serialPort4.ReceivedBytesThreshold = 1;

            this.serialTx1timer.Interval = Ayarlar.Default.SerialTx1Timer;
            this.serialTx2timer.Interval = Ayarlar.Default.SerialTx2Timer;
            this.serialTx3timer.Interval = Ayarlar.Default.SerialTx3Timer;
            this.serialTx4timer.Interval = Ayarlar.Default.SerialTx4Timer;
            safirSleepTime = Ayarlar.Default.SerialTx4Timer; ;
            this.timerAdmin.Interval = Ayarlar.Default.timerAdmin;
            this.serialRxTimeout.Interval = Ayarlar.Default.serialRxTimeout;

            this.ProgramlamaFrm.programlamaInit();
           
            this.yetki = 0;
            this.yetkidegistir();
      
            if (Ayarlar.Default.chBoxSerial1)
            {
                try
                {
                    this.serialPort1.DtrEnable = true;
                    this.serialPort1.Open();
                    lblStatusCom1.Text = "ON";
                    lblStatusCom1.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    int num2 = (int)MessageBox.Show("Com1 Port Hatası: " + ex.ToString());
                    lblStatusCom1.Text = "OFF";
                    lblStatusCom1.BackColor = Color.Red;
                }
            }
            if (Ayarlar.Default.chBoxSerial2)
            {
                try
                {
                    this.serialPort2.Open();
                    lblStatusCom2.Text = "ON";
                    lblStatusCom2.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    int num2 = (int)MessageBox.Show("Com2 Port Hatası: " + ex.ToString());
                    lblStatusCom2.Text = "OFF";
                    lblStatusCom2.BackColor = Color.Red;
                }
            }
            if (Ayarlar.Default.chBoxSerial3)
            {
                try
                {
                    this.serialPort3.Open();
                    lblStatusCom3.Text = "ON";
                    lblStatusCom3.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    int num2 = (int)MessageBox.Show("Com3 Port Hatası: " + ex.ToString());
                    lblStatusCom3.Text = "OFF";
                    lblStatusCom3.BackColor = Color.Red;
                }
            }
            if (Ayarlar.Default.chBoxSerial4)
            {
                try
                {
                    this.serialPort4.Open();
                    lblStatusCom4.Text = "ON";
                    lblStatusCom4.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    int num2 = (int)MessageBox.Show("Com4 Port Hatası: " + ex.ToString());
                    lblStatusCom4.Text = "OFF";
                    lblStatusCom4.BackColor = Color.Red;
                }
            }
            
            stepStateMax = 23;
            /*//Deneme Amaçlı
            ProcessCountinueStepState();
            ProcessCountinueStep();*/
        }

        /****************************************************SERİAL*******************************************************************/
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort1.BytesToRead > 0)
            {
                arrayRx[counterRxByte] = Convert.ToByte(serialPort1.ReadByte());
                counterRxByte++;
                Thread.Sleep(100);
            }
            this.Invoke(new EventHandler(ShowData1));
        }

        private void ShowData1(object sender, EventArgs e)
        {
            for (int i = 0; i < counterRxByte; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(arrayRx[i]) + "' ", Color.Green);
            }
            ConsoleAppendLine("COM1'den geldi.", Color.Green);
            ConsoleNewLine();
            justFeedbackCheck();
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort2.BytesToRead > 0)
            {
                arrayRx[counterRxByte] = Convert.ToByte(serialPort2.ReadByte());
                counterRxByte++;
            }
            this.Invoke(new EventHandler(ShowData2));
        }

        private void ShowData2(object sender, EventArgs e)
        {
            for (int i = 0; i < counterRxByte; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(arrayRx[i]) + "' ", Color.Green);
            }
            ConsoleAppendLine("COM2'den geldi.", Color.Green);
            ConsoleNewLine();


            if (Ayarlar.Default.chBoxProgramlama && stepState == 0)
            {
                lblStep1.Text = "1     FCT PROGRAMLAMA";
                this.Invoke(new EventHandler(btnStartProgramming_Click));
            }
            else
            {
                justFeedbackCheck();
            }
        }

        private void serialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort3.BytesToRead > 0)
            {
                arrayRx[counterRxByte] = Convert.ToByte(serialPort3.ReadByte());
                counterRxByte++;
            }
            this.Invoke(new EventHandler(ShowData3));
        }

        private void ShowData3(object sender, EventArgs e)
        {
            for (int i = 0; i < counterRxByte; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(arrayRx[i]) + "' ", Color.Green);
            }
            ConsoleAppendLine("COM3'den geldi.", Color.Green);
            ConsoleNewLine();
            justFeedbackCheck();
        }

        private void serialPort4_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort4.BytesToRead > 0)
            {
                arrayRx[counterRxByte] = Convert.ToByte(serialPort4.ReadByte());
                counterRxByte++;
            }
            this.Invoke(new EventHandler(ShowData4));
        }

        private void ShowData4(object sender, EventArgs e)
        {
            for (int i = 0; i < counterRxByte; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(arrayRx[i]) + "' ", Color.Green);
            }
            ConsoleAppendLine("COM4'den geldi.", Color.Green);
            ConsoleNewLine();
            justFeedbackCheck();
        }

        private void serialWriteByte1()
        {
            for (int i = 0; i < byteLenght; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(byteArray[i]) + " '", Color.Orange);
            }
            ConsoleAppendLine("COM1'den gitti.", Color.Orange);
            serialPort1.Write(byteArray, 0, byteLenght);
        }

        private void serialWriteByte2()
        {
            for (int i = 0; i < byteLenght; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(byteArray[i]) + " '", Color.Orange);
            }
            ConsoleAppendLine("COM2'den gitti.", Color.Orange);
            serialPort2.Write(byteArray, 0, byteLenght);
        }

        private void serialWriteByte3()
        {
            for (int i = 0; i < byteLenght; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(byteArray[i]) + " '", Color.Orange);
            }
            ConsoleAppendLine("COM3'den gitti.", Color.Orange);
            serialPort3.Write(byteArray, 0, byteLenght);
        }

        private void serialWriteByte4()
        {
            for (int i = 0; i < byteLenght; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(byteArray[i]) + " '", Color.Orange);
            }
            ConsoleAppendLine("COM4'den gitti.", Color.Orange);
            serialPort4.Write(byteArray, 0, byteLenght);
        }

        private void serialBufferClear()
        {
            for (int i = 0; i <= counterRxByte; i++)
            {
                arrayRx[i] = 0x0;
            }
            counterRxByte = 0;
            internalNum = 0;
            if (Ayarlar.Default.chBoxSerial1)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
            if (Ayarlar.Default.chBoxSerial2)
            {
                serialPort2.DiscardInBuffer();
                serialPort2.DiscardOutBuffer();
            }
            if (Ayarlar.Default.chBoxSerial3)
            {
                serialPort3.DiscardInBuffer();
                serialPort3.DiscardOutBuffer();
            }
            if (Ayarlar.Default.chBoxSerial4)
            {
                serialPort4.DiscardInBuffer();
                serialPort4.DiscardOutBuffer();
            }
        }

        /****************************************************FCT*******************************************************************/
        public void btnFCTInit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)  //Birşeyler Eklenebilir.
            {
                stepState++;
                step++;
                ProcessFCT();
                saniyeTimer.Start();
            }
        }

        public void ProcessCountinueStepState()
        {
            stepState++;
        }

        public void ProcessCountinueStep()
        {
            step++;
            ProcessFCT();
        }

        private void ProcessFCT()
        {
            ProcessFrm.ProcessStart(stepState + 1, stepStateMax);
            ConsoleAppendLine(stepState + "'de.", Color.Orange);
            if (stepState == 1) //Adım1 1'li Paket
            {
                if (step == 1)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 49;
                    byteLenght = 1;
                    feedback[0] = 65;
                    serialTx2timer.Start();
                }
            }
            else if (stepState == 2) //Adım2 2'li Paket
            {
                if (step == 2)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 67;
                    byteArray[4] = 185;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 3)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 1;
                    byteArray[4] = 251;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 4)  //Sadece Onayla
                {
                    if (CustomMessageBox.ShowMessage("Tüm Ledler Yandımı", customMessageBoxTitle, MessageBoxButtons.YesNo, CustomMessageBoxIcon.Question, Color.Yellow) == DialogResult.Yes)
                    {
                        ProcessCountinueStepState();
                        ProcessFrm.ProcessSuccess(stepState);
                        ProcessCountinueStep();
                    }
                    else
                    {
                        ProcessFrm.ProcessFailed(stepState);
                    }
                }
            }
            else if (stepState == 3) //Adım3 2'li Paket
            {
                if (step == 5)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 6;
                    byteArray[4] = 246;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 6) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen 1 Nolu Buton'a Basınız. Display'de 0:00 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 6;
                    byteArray[3] = 0;
                    byteArray[4] = 247;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 4) //Adım4 2'li Paket
            {
                if (step == 7)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 7;
                    byteArray[4] = 245;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 8) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen P1 Nolu Buton'a Basınız. Display'de 1:11 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 7;
                    byteArray[3] = 0;
                    byteArray[4] = 246;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 5) //Adım5 2'li Paket
            {
                if (step == 9)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 8;
                    byteArray[4] = 244;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 10) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen P2 Nolu Buton'a Basınız. Display'de 2:22 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 8;
                    byteArray[3] = 0;
                    byteArray[4] = 245;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 6) //Adım6 2'li Paket
            {
                if (step == 11)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 9;
                    byteArray[4] = 243;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 12) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen P3 Nolu Buton'a Basınız. Display'de 3:33 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 9;
                    byteArray[3] = 0;
                    byteArray[4] = 244;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 7) //Adım7 2'li Paket
            {
                if (step == 13)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 10;
                    byteArray[4] = 242;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 14) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen P4 Nolu Buton'a Basınız. Display'de 4:44 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 10;
                    byteArray[3] = 0;
                    byteArray[4] = 243;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 8) //Adım8 2'li Paket
            {
                if (step == 15)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 11;
                    byteArray[4] = 241;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 16) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen P5 Nolu Buton'a Basınız. Display'de 5:55 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 11;
                    byteArray[3] = 0;
                    byteArray[4] = 242;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 9) //Adım9 2'li Paket
            {
                if (step == 17)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 12;
                    byteArray[4] = 240;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 18) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen P6 Nolu Buton'a Basınız. Display'de 6:66 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 12;
                    byteArray[3] = 0;
                    byteArray[4] = 241;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 10) //Adım10 2'li Paket
            {
                if (step == 19)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 13;
                    byteArray[4] = 239;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 20) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen F1 Nolu Buton'a Basınız. Display'de 7:77 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 13;
                    byteArray[3] = 0;
                    byteArray[4] = 240;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 11) //Adım11 2'li Paket
            {
                if (step == 21)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 14;
                    byteArray[4] = 238;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 22) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen F2 Nolu Buton'a Basınız. Display'de 8:88 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 14;
                    byteArray[3] = 0;
                    byteArray[4] = 239;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 12) //Adım12 2'li Paket
            {
                if (step == 23)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 15;
                    byteArray[4] = 237;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 24) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen F3 Nolu Buton'a Basınız. Display'de 9:99 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 15;
                    byteArray[3] = 0;
                    byteArray[4] = 238;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 13) //Adım13 2'li Paket
            {
                if (step == 25)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 16;
                    byteArray[4] = 236;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 26) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen F4 Nolu Buton'a Basınız. Display'de 1:11 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 16;
                    byteArray[3] = 0;
                    byteArray[4] = 237;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 14) //Adım14 2'li Paket
            {
                if (step == 27)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 17;
                    byteArray[4] = 235;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 28) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen F5 Nolu Buton'a Basınız. Display'de 2:22 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 17;
                    byteArray[3] = 0;
                    byteArray[4] = 236;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 15) //Adım15 2'li Paket
            {
                if (step == 29)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 18;
                    byteArray[4] = 234;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 30) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen F6 Nolu Buton'a Basınız. Display'de 3:33 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 18;
                    byteArray[3] = 0;
                    byteArray[4] = 235;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 16) //Adım16 2'li Paket
            {
                if (step == 31)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 19;
                    byteArray[4] = 233;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 32) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen 8 Nolu Buton'a Basınız. Display'de 4:44 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 19;
                    byteArray[3] = 0;
                    byteArray[4] = 234;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 17) //Adım17 2'li Paket
            {
                if (step == 33)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 2;
                    byteArray[4] = 250;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 34) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen G1 Nolu Buton'a Basınız. Display'de 8:88 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 2;
                    byteArray[3] = 0;
                    byteArray[4] = 251;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 18) //Adım18 2'li Paket
            {
                if (step == 35)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 3;
                    byteArray[4] = 249;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 36) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen G2 Nolu Buton'a Basınız. Display'de 1:11 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 3;
                    byteArray[3] = 0;
                    byteArray[4] = 250;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 19) //Adım19 2'li Paket
            {
                if (step == 37)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 4;
                    byteArray[4] = 248;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 38) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen G3 Nolu Buton'a Basınız. Display'de 7:77 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 4;
                    byteArray[3] = 0;
                    byteArray[4] = 249;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 20) //Adım20 2'li Paket
            {
                if (step == 39)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 5;
                    byteArray[4] = 247;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 40) //Görev Yaptır - Onayla- Veri Gönder - Feedback Al
                {
                    CustomMessageBox.ShowMessage("Lütfen G4 Nolu Buton'a Basınız. Display'de 0:00 Yandığını Kontrol Ediniz", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 5;
                    byteArray[3] = 0;
                    byteArray[4] = 248;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else if (stepState == 21) //Adım22 1'li Paket
            {
                if (step == 41)  //Veri Gönder FeedbackAl
                {
                    stepJob = 1;     //Sadece Feedback
                    byteArray[0] = 3;
                    byteArray[1] = 0;
                    byteArray[2] = 0;
                    byteArray[3] = 20;
                    byteArray[4] = 232;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
                else if (step == 42)  //Veri Gönder FeedbackAl
                {
                    Thread.Sleep(3000);
                    stepJob = 1;      //Sadece Feedback
                    byteArray[0] = 2;
                    byteArray[1] = 0;
                    byteArray[2] = 20;
                    byteArray[3] = 0;
                    byteArray[4] = 233;
                    byteLenght = 5;
                    feedback[0] = 170;
                    feedback[1] = 85;
                    serialTx1timer.Start();
                }
            }
            else
            {
                CustomMessageBox.ShowMessage("FCT Testi Sonlandı. Lütfen Tekrar Başlayın!", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Information, Color.Green);
                All_FCT_Success();
                FCT_Finish();
            }

        }

        private void justFeedbackCheck()
        {
            int trueRX = 0;
            serialRxTimeout.Stop();
            serialRxTimeout.Enabled = false;

            if (stepJob == 1)  //Feedback Al
            {
                for (int i = 0; i < counterRxByte; i++)
                {
                    if (arrayRx[i] == feedback[i])
                    {
                        trueRX++;
                    }
                    else
                    {
                        ProcessFrm.ProcessFailed(stepState);
                        break;
                    }
                }
                if (trueRX == counterRxByte)
                {
                    if (step == 1 || step == 4 || step == 6 || step == 8 ||
                        step == 10 || step == 12 || step == 14 || step == 16 ||
                        step == 18 || step == 20 || step == 22 || step == 24 ||
                        step == 26 || step == 28 || step == 30 || step == 32 ||
                        step == 34 || step == 36 || step == 38 || step == 40 ||
                        step == 42)
                    {
                        ProcessCountinueStepState();
                        ProcessFrm.ProcessSuccess(stepState);
                    }
                    ProcessCountinueStep();
                }
            }

            serialBufferClear();  //Yeni
        }

        private void All_FCT_Success()
        {
            byteArray[0] = 49;
            ConsoleAppendLine("COM2'DEN TÜM FCT BAŞARILI GİTTİ.", Color.Orange);
            serialPort2.Write(byteArray, 0, 1);
            logTut(1);
        }

        public void All_FCT_Fail()
        {
            byteArray[0] = 48;
            ConsoleAppendLine("COM2'den TÜM FCT BAŞARISIZ GİTTİ.", Color.Orange);
            serialPort2.Write(byteArray, 0, 1);
            logTut(0);
            errorCardTxt.Text = Convert.ToString(++errorCard);
        }

        public void FCT_Finish()
        {
            FCT_Clear();
            Verim();
            saniyeTimer.Stop();
            fctSaniye = 0;
            serialRxTimeout.Stop();
            serialRxTimeout.Enabled = false;
        }

        private void FCT_Clear()
        {
          //  btnFCTInit.Enabled = true;
            stepState = 0;
            step = 0;
            btnFCTInit.Text = "BUTONLARA BASARAK FCT TESTİNİ BAŞLAT";
            progressBarFCT.Value = 0;

            if (Ayarlar.Default.chBoxProgramlama)
            {
                btnStartProgramming.Enabled = false;
            }

            ProcessFrm.Process_Clear();
            serialBufferClear();
            ConsoleClean();
        }

        /****************************************************OTHER*******************************************************************/
        private void Verim()
        {
            totalCardTxt.Text = Convert.ToString(++totalCard);
            verimTxt.Text = Convert.ToString(100 - ((float)((float)errorCard / totalCard)) * 100);
        }

        private void logTut(int state)
        {
            if (logDosyaPath != "")
            {
                INIKaydet ini = new INIKaydet(logDosyaPath);  // @"\Ayarlar.ini"
                if (state == 1)
                {
                    ini.Yaz(tbBarcodeLast.Text + "   " + DateTime.Now.ToString(), "", "PASSED");
                }
                else if (state == 0)
                {
                    ini.Yaz(tbBarcodeLast.Text + "   " + DateTime.Now.ToString(), "", "FAILED");
                }

              //  CustomMessageBox.ShowMessage("Log Kaydedildi.", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Information, Color.Yellow);
            }
            else
            {
                CustomMessageBox.ShowMessage("Log için Dosya Yolu Boş Kalamaz", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
        }

        /****************************************************CONSOLE TEXT*******************************************************************/
        private void rtbConsole_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            rtb.SelectionStart = rtb.Text.Length;
            rtb.ScrollToCaret();
        }
        
        /*Kullanıcı Arayüzüne Yazı Yazılır*/
        public void ConsoleAppendLine(string text, Color color)
        {
            if (rtbConsole.InvokeRequired)
            {
                rtbConsole.Invoke(new Action(delegate ()
                {
                    rtbConsole.Select(rtbConsole.TextLength, 0);
                    rtbConsole.SelectionColor = color;
                    rtbConsole.AppendText(text + Environment.NewLine);
                    rtbConsole.Select(rtbConsole.TextLength, 0);
                    rtbConsole.SelectionColor = Color.White;
                }));
            }
            else
            {
                rtbConsole.Select(rtbConsole.TextLength, 0);
                rtbConsole.SelectionColor = color;
                rtbConsole.AppendText(text + Environment.NewLine);
                rtbConsole.Select(rtbConsole.TextLength, 0);
                rtbConsole.SelectionColor = Color.White;
            }
        }

        /*Kullanıcı Arayüzünde Bir Satır Boşluk Bırakılır*/
        public void ConsoleNewLine()
        {
            if (rtbConsole.InvokeRequired)
            {
                rtbConsole.Invoke(new Action(delegate ()
                {
                    rtbConsole.AppendText(Environment.NewLine);
                }));
            }
            else
            {
                rtbConsole.AppendText(Environment.NewLine);
            }
        }

        public void ConsoleClean()
        {
            if (rtbConsole.InvokeRequired)
            {
                rtbConsole.Invoke(new Action(delegate ()
                {
                    rtbConsole.Text = "";
                    rtbConsole.Select(rtbConsole.TextLength, 0);
                    rtbConsole.SelectionColor = Color.White;
                }));
            }
            else
            {
                rtbConsole.Text = "";
                rtbConsole.Select(rtbConsole.TextLength, 0);
                rtbConsole.SelectionColor = Color.White;
            }
        }

        /****************************************************PAGE CHANGE*******************************************************************/
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            int num = (int)this.AyarFrm.ShowDialog();
        }

        private void btnProgAyar_Click(object sender, EventArgs e)
        {
            int num = (int)this.ProgAyarFrm.ShowDialog();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                tbUserLogin.Enabled = true;
            }
            else
            {
                tbUserLogin.Enabled = false;
            }
        }

        private void tbUserLogin_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.L)
                return;
            if (this.yetki != 0)
            {
                timerAdmin.Stop();
                this.yetki = 0;
                this.yetkidegistir();
            }
            else
            {
                int num = (int)this.SifreFrm.ShowDialog();
                tbUserLogin.Clear();
            }
        }

        public void yetkidegistir()
        {
            if (this.yetki == 0)
            {
                this.btnCikis.Enabled = false;
                this.btnAyar.Enabled = false;
                this.btnProgAyar.Enabled = false;
                this.btnCikis.BackColor = Color.Beige;
                this.btnAyar.BackColor = Color.Beige;
                this.btnProgAyar.BackColor = Color.Beige;
            }
            if (this.yetki == 1)
            {
                this.btnCikis.Enabled = true;
                this.btnAyar.Enabled = true;
                this.btnProgAyar.Enabled = true;
                this.btnCikis.BackColor = Color.Red;
                this.btnAyar.BackColor = Color.Red;
                this.btnProgAyar.BackColor = Color.Red;
                timerAdmin.Start();
            }
            if (this.yetki == 2)
            {
                this.btnCikis.Enabled = true;
                this.btnCikis.BackColor = Color.Red;
                this.btnAyar.BackColor = Color.Beige;
                this.btnProgAyar.BackColor = Color.Beige;
                timerAdmin.Start();
            }
        }

        /****************************************************TIMER*******************************************************************/
        private void serialTx1timer_Tick(object sender, EventArgs e)
        {
            serialTx1TimerCounter++;
            if (serialTx1TimerCounter == 1)
            {
                serialTx1TimerCounter = 0;
                serialTx1timer.Stop();
                serialWriteByte1();
            }
        }

        private void serialTx2timer_Tick(object sender, EventArgs e)
        {
            serialTx2TimerCounter++;
            if (serialTx2TimerCounter == 1)
            {
                serialTx2TimerCounter = 0;
                serialTx2timer.Stop();
                serialWriteByte2();
            }
        }

        private void serialTx3timer_Tick(object sender, EventArgs e)
        {
            serialTx3TimerCounter++;
            if (serialTx3TimerCounter == 1)
            {
                serialTx3TimerCounter = 0;
                serialTx3timer.Stop();
                serialWriteByte3();
            }
        }

        private void serialTx4timer_Tick(object sender, EventArgs e)
        {
            serialTx4TimerCounter++;
            if (serialTx4TimerCounter == 1)
            {
                serialTx4TimerCounter = 0;
                serialTx4timer.Stop();
                serialWriteByte4();
            }
        }

        private void timerAdmin_Tick_1(object sender, EventArgs e)
        {
            adminTimerCounter++;
            if (adminTimerCounter == 1)
            {
                adminTimerCounter = 0;
                timerAdmin.Stop();
                this.yetki = 0;
                this.yetkidegistir();
            }
        }

        private void serialRxTimeout_Tick(object sender, EventArgs e)
        {
            timeoutTimerCounter++;
            if (timeoutTimerCounter == 1)
            {
                timeoutTimerCounter = 0;
                serialRxTimeout.Stop();
                serialRxTimeout.Enabled = false;
                ProcessFrm.ProcessFailed(stepState);
            }
        }

        private void saniyeTimer_Tick(object sender, EventArgs e)
        {
            saniyeTimerCounter++;
            if (saniyeTimerCounter == 1)
            {
                saniyeTimerCounter = 0;
                fctTimerTxt.Text = Convert.ToString(++fctSaniye);
            }
        }
        /*************************************************PROGRAMING**********************************************************************/
        private void btnStartProgramming_Click(object sender, EventArgs e)
        {
            serialBufferClear();
            string barcode = tbBarcodeCurrent.Text;
            ProgramlamaFrm.programlamaStart(barcode);
        }

        private void tbBarcodeCurrent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnStartProgramming_Click(sender, e);
            }
        }


    }
}

