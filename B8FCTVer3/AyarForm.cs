// Decompiled with JetBrains decompiler
// Type: EsdTurnikesi.AyarForm
// Assembly: EsdTurnikesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C8099926-BBEB-495E-ADF6-36B4F5F75BE8
// Assembly location: C:\Users\serkan.baki\Desktop\esd-rar\ESD\Release\EsdTurnikesi.exe

using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text;

namespace B8FCTVer3
{
    public class AyarForm : Form
    {
        public Main MainFrm;
        private IContainer components;

        public ComboBox SerialPort1Com;
        public ComboBox SerialPort1Parity;
        public ComboBox SerialPort1Stop;
        public ComboBox SerialPort1Data;
        public ComboBox SerialPort1Baud;
        public ComboBox SerialPort3Com;
        public ComboBox SerialPort3Parity;
        public ComboBox SerialPort3Stop;
        public ComboBox SerialPort3Data;
        public ComboBox SerialPort3Baud;
        public ComboBox SerialPort2Com;
        public ComboBox SerialPort2Parity;
        public ComboBox SerialPort2Stop;
        public ComboBox SerialPort2Data;
        public ComboBox SerialPort2Baud;

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox11;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private GroupBox groupBox3;

        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label33;
        private Label label32;
        private Label label25;
        private Label label23;
        private Label label21;
        private Label label24;
        private Label label22;
        private Label label20;
        private Label label27;
        private Label label26;
        private Label label31;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;

        private Button btnKaydet;
        private Button btnPNGsec;
        private TextBox txtPNGdosya;
        private TextBox txtSerialTx3Timer;
        private TextBox txtSerialTx1Timer;
        private TextBox txtSerialTx2Timer;
        private TextBox txtKaliteSifre;
        private TextBox txtAdminSifre;
        private TextBox txtTimerAdmin;
        private CheckBox chBoxSerial1;
        private CheckBox chBoxSerial2;
        private CheckBox chBoxSerial3;
        private TextBox txtTimerTimeout;
        private Label label13;
        private Label label14;
        private TextBox projectName;
        private Label label29;
        private Label label12;
        private ComboBox cozunurluk;
        private GroupBox groupBox5;
        private Label label220;
        private Button btnOkuIni;
        private Button btnINIsec;
        private Button btnKaydetIni;
        private TextBox txtINIdosya;
        private GroupBox groupBox8;
        private Label label15;
        private Button btnLogSec;
        private TextBox txtLogDosya;
        private GroupBox groupBox9;
        private Label label16;
        private ComboBox printerName;
        private CheckBox chBoxSerial4;
        private GroupBox groupBox4;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label28;
        private Label label30;
        public ComboBox SerialPort4Parity;
        public ComboBox SerialPort4Stop;
        public ComboBox SerialPort4Data;
        public ComboBox SerialPort4Baud;
        public ComboBox SerialPort4Com;
        private Label label38;
        private TextBox txtSerialTx4Timer;
        private Label label39;
        private CheckBox chBoxProgramlama;
        private CheckBox checkBox2;

        public AyarForm()
        {
            this.InitializeComponent();
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

        private void AyarForm_Load(object sender, EventArgs e)
        {
            this.chBoxProgramlama.Checked = Ayarlar.Default.chBoxProgramlama;
            this.projectName.Text = Ayarlar.Default.projectName;
            this.printerName.Text = Ayarlar.Default.printerName;

            this.chBoxSerial1.Checked = Ayarlar.Default.chBoxSerial1;
            this.chBoxSerial2.Checked = Ayarlar.Default.chBoxSerial2;
            this.chBoxSerial3.Checked = Ayarlar.Default.chBoxSerial3;
            this.chBoxSerial4.Checked = Ayarlar.Default.chBoxSerial4;

            if (chBoxSerial1.Checked == true)
                groupBox1.Enabled = true;
            else
                groupBox1.Enabled = false;

            if (chBoxSerial2.Checked == true)
                groupBox2.Enabled = true;
            else
                groupBox2.Enabled = false;

            if (chBoxSerial3.Checked == true)
                groupBox3.Enabled = true;
            else
                groupBox3.Enabled = false;

            if (chBoxSerial4.Checked == true)
                groupBox4.Enabled = true;
            else
                groupBox4.Enabled = false;

            this.SerialPort1Com.Text = Ayarlar.Default.SerialPort1Com;
            this.SerialPort1Baud.Text = Ayarlar.Default.SerialPort1Baud.ToString();
            this.SerialPort1Data.Text = Ayarlar.Default.SerialPort1dataBits.ToString();
            this.SerialPort1Stop.Text = Ayarlar.Default.SerialPort1stopBit.ToString();
            this.SerialPort1Parity.Text = Ayarlar.Default.SerialPort1Parity.ToString();

            this.SerialPort2Com.Text = Ayarlar.Default.SerialPort2Com;
            this.SerialPort2Baud.Text = Ayarlar.Default.SerialPort2Baud.ToString();
            this.SerialPort2Data.Text = Ayarlar.Default.SerialPort2dataBits.ToString();
            this.SerialPort2Stop.Text = Ayarlar.Default.SerialPort2stopBit.ToString();
            this.SerialPort2Parity.Text = Ayarlar.Default.SerialPort2Parity.ToString();

            this.SerialPort3Com.Text = Ayarlar.Default.SerialPort3Com;
            this.SerialPort3Baud.Text = Ayarlar.Default.SerialPort3Baud.ToString();
            this.SerialPort3Data.Text = Ayarlar.Default.SerialPort3dataBits.ToString();
            this.SerialPort3Stop.Text = Ayarlar.Default.SerialPort3stopBits.ToString();
            this.SerialPort3Parity.Text = Ayarlar.Default.SerialPort3Parity.ToString();

            this.SerialPort4Com.Text = Ayarlar.Default.SerialPort4Com;
            this.SerialPort4Baud.Text = Ayarlar.Default.SerialPort4Baud.ToString();
            this.SerialPort4Data.Text = Ayarlar.Default.SerialPort4dataBits.ToString();
            this.SerialPort4Stop.Text = Ayarlar.Default.SerialPort4stopBits.ToString();
            this.SerialPort4Parity.Text = Ayarlar.Default.SerialPort4Parity.ToString();

            this.txtPNGdosya.Text = Ayarlar.Default.PNGdosyayolu;
            this.cozunurluk.Text = Ayarlar.Default.cozunurluk;

            this.txtINIdosya.Text = Ayarlar.Default.txtINIdosya;
            this.txtLogDosya.Text = Ayarlar.Default.txtLogDosya;

            this.txtSerialTx1Timer.Text = Ayarlar.Default.SerialTx1Timer.ToString();
            this.txtSerialTx2Timer.Text = Ayarlar.Default.SerialTx2Timer.ToString();
            this.txtSerialTx3Timer.Text = Ayarlar.Default.SerialTx3Timer.ToString();
            this.txtSerialTx4Timer.Text = Ayarlar.Default.SerialTx4Timer.ToString();
            this.txtTimerAdmin.Text = Ayarlar.Default.timerAdmin.ToString();
            this.txtTimerTimeout.Text = Ayarlar.Default.serialRxTimeout.ToString();

            this.txtAdminSifre.Text = Ayarlar.Default.adminSifre.ToString();
            this.txtKaliteSifre.Text = Ayarlar.Default.kaliteSifre.ToString();

            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                printerName.Items.Add(printer);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Ayarlar.Default.chBoxProgramlama = this.chBoxProgramlama.Checked;
                Ayarlar.Default.projectName = this.projectName.Text;
                Ayarlar.Default.printerName = this.printerName.Text;

                Ayarlar.Default.chBoxSerial1 = this.chBoxSerial1.Checked;
                Ayarlar.Default.chBoxSerial2 = this.chBoxSerial2.Checked;
                Ayarlar.Default.chBoxSerial3 = this.chBoxSerial3.Checked;
                Ayarlar.Default.chBoxSerial4 = this.chBoxSerial4.Checked;

                this.MainFrm.serialPort1.Close();
                this.MainFrm.serialPort2.Close();
                this.MainFrm.serialPort3.Close();
                this.MainFrm.serialPort4.Close();

                Ayarlar.Default.SerialPort1Com = this.SerialPort1Com.Text;
                Ayarlar.Default.SerialPort1Baud = Convert.ToInt32(this.SerialPort1Baud.Text);
                Ayarlar.Default.SerialPort1dataBits = Convert.ToInt32(this.SerialPort1Data.Text);
                switch (this.SerialPort1Stop.SelectedIndex)
                {
                    case 0:
                        Ayarlar.Default.SerialPort1stopBit = StopBits.None;
                        break;
                    case 1:
                        Ayarlar.Default.SerialPort1stopBit = StopBits.One;
                        break;
                    case 2:
                        Ayarlar.Default.SerialPort1stopBit = StopBits.Two;
                        break;
                    case 3:
                        Ayarlar.Default.SerialPort1stopBit = StopBits.OnePointFive;
                        break;
                    default:
                        Ayarlar.Default.SerialPort1stopBit = StopBits.One;
                        break;
                }
                switch (this.SerialPort1Parity.SelectedIndex)
                {
                    case 0:
                        Ayarlar.Default.SerialPort1Parity = Parity.None;
                        break;
                    case 1:
                        Ayarlar.Default.SerialPort1Parity = Parity.Odd;
                        break;
                    case 2:
                        Ayarlar.Default.SerialPort1Parity = Parity.Even;
                        break;
                    case 3:
                        Ayarlar.Default.SerialPort1Parity = Parity.Mark;
                        break;
                    case 4:
                        Ayarlar.Default.SerialPort1Parity = Parity.Space;
                        break;
                    default:
                        Ayarlar.Default.SerialPort1Parity = Parity.None;
                        break;
                }
                Ayarlar.Default.SerialPort2Com = this.SerialPort2Com.Text;
                Ayarlar.Default.SerialPort2Baud = Convert.ToInt32(this.SerialPort2Baud.Text);
                Ayarlar.Default.SerialPort2dataBits = Convert.ToInt32(this.SerialPort2Data.Text);
                switch (this.SerialPort2Stop.SelectedIndex)
                {
                    case 0:
                        Ayarlar.Default.SerialPort2stopBit = StopBits.None;
                        break;
                    case 1:
                        Ayarlar.Default.SerialPort2stopBit = StopBits.One;
                        break;
                    case 2:
                        Ayarlar.Default.SerialPort2stopBit = StopBits.Two;
                        break;
                    case 3:
                        Ayarlar.Default.SerialPort2stopBit = StopBits.OnePointFive;
                        break;
                    default:
                        Ayarlar.Default.SerialPort2stopBit = StopBits.One;
                        break;
                }
                switch (this.SerialPort2Parity.SelectedIndex)
                {
                    case 0:
                        Ayarlar.Default.SerialPort2Parity = Parity.None;
                        break;
                    case 1:
                        Ayarlar.Default.SerialPort2Parity = Parity.Odd;
                        break;
                    case 2:
                        Ayarlar.Default.SerialPort2Parity = Parity.Even;
                        break;
                    case 3:
                        Ayarlar.Default.SerialPort2Parity = Parity.Mark;
                        break;
                    case 4:
                        Ayarlar.Default.SerialPort2Parity = Parity.Space;
                        break;
                    default:
                        Ayarlar.Default.SerialPort2Parity = Parity.None;
                        break;
                }
                Ayarlar.Default.SerialPort3Com = this.SerialPort3Com.Text;
                Ayarlar.Default.SerialPort3Baud = Convert.ToInt32(this.SerialPort3Baud.Text);
                Ayarlar.Default.SerialPort3dataBits = Convert.ToInt32(this.SerialPort3Data.Text);
                switch (this.SerialPort3Stop.SelectedIndex)
                {
                    case 0:
                        Ayarlar.Default.SerialPort3stopBits = StopBits.None;
                        break;
                    case 1:
                        Ayarlar.Default.SerialPort3stopBits = StopBits.One;
                        break;
                    case 2:
                        Ayarlar.Default.SerialPort3stopBits = StopBits.Two;
                        break;
                    case 3:
                        Ayarlar.Default.SerialPort3stopBits = StopBits.OnePointFive;
                        break;
                    default:
                        Ayarlar.Default.SerialPort3stopBits = StopBits.One;
                        break;
                }
                switch (this.SerialPort3Parity.SelectedIndex)
                {
                    case 0:
                        Ayarlar.Default.SerialPort3Parity = Parity.None;
                        break;
                    case 1:
                        Ayarlar.Default.SerialPort3Parity = Parity.Odd;
                        break;
                    case 2:
                        Ayarlar.Default.SerialPort3Parity = Parity.Even;
                        break;
                    case 3:
                        Ayarlar.Default.SerialPort3Parity = Parity.Mark;
                        break;
                    case 4:
                        Ayarlar.Default.SerialPort3Parity = Parity.Space;
                        break;
                    default:
                        Ayarlar.Default.SerialPort3Parity = Parity.None;
                        break;
                }
                Ayarlar.Default.SerialPort4Com = this.SerialPort4Com.Text;
                Ayarlar.Default.SerialPort4Baud = Convert.ToInt32(this.SerialPort4Baud.Text);
                Ayarlar.Default.SerialPort4dataBits = Convert.ToInt32(this.SerialPort4Data.Text);
                switch (this.SerialPort4Stop.SelectedIndex)
                {
                    case 0:
                        Ayarlar.Default.SerialPort4stopBits = StopBits.None;
                        break;
                    case 1:
                        Ayarlar.Default.SerialPort4stopBits = StopBits.One;
                        break;
                    case 2:
                        Ayarlar.Default.SerialPort4stopBits = StopBits.Two;
                        break;
                    case 3:
                        Ayarlar.Default.SerialPort4stopBits = StopBits.OnePointFive;
                        break;
                    default:
                        Ayarlar.Default.SerialPort4stopBits = StopBits.One;
                        break;
                }
                switch (this.SerialPort4Parity.SelectedIndex)
                {
                    case 0:
                        Ayarlar.Default.SerialPort4Parity = Parity.None;
                        break;
                    case 1:
                        Ayarlar.Default.SerialPort4Parity = Parity.Odd;
                        break;
                    case 2:
                        Ayarlar.Default.SerialPort4Parity = Parity.Even;
                        break;
                    case 3:
                        Ayarlar.Default.SerialPort4Parity = Parity.Mark;
                        break;
                    case 4:
                        Ayarlar.Default.SerialPort4Parity = Parity.Space;
                        break;
                    default:
                        Ayarlar.Default.SerialPort4Parity = Parity.None;
                        break;
                }

                Ayarlar.Default.PNGdosyayolu = this.txtPNGdosya.Text;
                Ayarlar.Default.cozunurluk = this.cozunurluk.Text;
                Ayarlar.Default.txtINIdosya = this.txtINIdosya.Text;
                Ayarlar.Default.txtLogDosya = this.txtLogDosya.Text;

                Ayarlar.Default.SerialTx1Timer = Convert.ToInt32(this.txtSerialTx1Timer.Text);
                Ayarlar.Default.SerialTx2Timer = Convert.ToInt32(this.txtSerialTx2Timer.Text);
                Ayarlar.Default.SerialTx3Timer = Convert.ToInt32(this.txtSerialTx3Timer.Text);
                Ayarlar.Default.SerialTx4Timer = Convert.ToInt32(this.txtSerialTx4Timer.Text);
                Ayarlar.Default.timerAdmin = Convert.ToInt32(this.txtTimerAdmin.Text);
                Ayarlar.Default.serialRxTimeout = Convert.ToInt32(this.txtTimerTimeout.Text);

                Ayarlar.Default.adminSifre = this.txtAdminSifre.Text;
                Ayarlar.Default.kaliteSifre = this.txtKaliteSifre.Text;
                Ayarlar.Default.Save();

                CustomMessageBox.ShowMessage("Bütün Ayarlar Başarıyla Kaydedildi.", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Information, Color.Yellow);
                this.Close();

                Application.Restart();
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowMessage("Ayarlar Kayıt Hatası: " + ex.ToString(), Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
        }

        private void chBoxSerial1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxSerial1.Checked == true)
                groupBox1.Enabled = true;
            else
                groupBox1.Enabled = false;
        }

        private void chBoxSerial2_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxSerial2.Checked == true)
                groupBox2.Enabled = true;
            else
                groupBox2.Enabled = false;
        }

        private void chBoxSerial3_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxSerial3.Checked == true)
                groupBox3.Enabled = true;
            else
                groupBox3.Enabled = false;
        }

        private void chBoxSerial4_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxSerial4.Checked == true)
                groupBox4.Enabled = true;
            else
                groupBox4.Enabled = false;
        }

        private void btnIDsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.png||*.jpg|Tüm Dosyalar|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtPNGdosya.Text = openFileDialog.FileName;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.txtAdminSifre.Enabled = true;
                this.txtKaliteSifre.Enabled = true;
                this.txtAdminSifre.PasswordChar = char.MinValue;
                this.txtKaliteSifre.PasswordChar = char.MinValue;
            }
            else
            {
                this.txtAdminSifre.Enabled = false;
                this.txtKaliteSifre.Enabled = false;
                this.txtAdminSifre.PasswordChar = '*';
                this.txtKaliteSifre.PasswordChar = '*';
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyarForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialPort1Parity = new System.Windows.Forms.ComboBox();
            this.SerialPort1Stop = new System.Windows.Forms.ComboBox();
            this.SerialPort1Data = new System.Windows.Forms.ComboBox();
            this.SerialPort1Baud = new System.Windows.Forms.ComboBox();
            this.SerialPort1Com = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SerialPort2Parity = new System.Windows.Forms.ComboBox();
            this.SerialPort2Stop = new System.Windows.Forms.ComboBox();
            this.SerialPort2Data = new System.Windows.Forms.ComboBox();
            this.SerialPort2Baud = new System.Windows.Forms.ComboBox();
            this.SerialPort2Com = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cozunurluk = new System.Windows.Forms.ComboBox();
            this.btnPNGsec = new System.Windows.Forms.Button();
            this.txtPNGdosya = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtSerialTx4Timer = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtTimerTimeout = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTimerAdmin = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSerialTx2Timer = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSerialTx1Timer = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtSerialTx3Timer = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtKaliteSifre = new System.Windows.Forms.TextBox();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.SerialPort3Parity = new System.Windows.Forms.ComboBox();
            this.SerialPort3Stop = new System.Windows.Forms.ComboBox();
            this.SerialPort3Data = new System.Windows.Forms.ComboBox();
            this.SerialPort3Baud = new System.Windows.Forms.ComboBox();
            this.SerialPort3Com = new System.Windows.Forms.ComboBox();
            this.chBoxSerial1 = new System.Windows.Forms.CheckBox();
            this.chBoxSerial2 = new System.Windows.Forms.CheckBox();
            this.chBoxSerial3 = new System.Windows.Forms.CheckBox();
            this.projectName = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label220 = new System.Windows.Forms.Label();
            this.btnOkuIni = new System.Windows.Forms.Button();
            this.btnINIsec = new System.Windows.Forms.Button();
            this.btnKaydetIni = new System.Windows.Forms.Button();
            this.txtINIdosya = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLogSec = new System.Windows.Forms.Button();
            this.txtLogDosya = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.printerName = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chBoxSerial4 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.SerialPort4Parity = new System.Windows.Forms.ComboBox();
            this.SerialPort4Stop = new System.Windows.Forms.ComboBox();
            this.SerialPort4Data = new System.Windows.Forms.ComboBox();
            this.SerialPort4Baud = new System.Windows.Forms.ComboBox();
            this.SerialPort4Com = new System.Windows.Forms.ComboBox();
            this.chBoxProgramlama = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SerialPort1Parity);
            this.groupBox1.Controls.Add(this.SerialPort1Stop);
            this.groupBox1.Controls.Add(this.SerialPort1Data);
            this.groupBox1.Controls.Add(this.SerialPort1Baud);
            this.groupBox1.Controls.Add(this.SerialPort1Com);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(185, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port1 Com Ayar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "StopBit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "DataBits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "BaudRate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "FCT:";
            // 
            // SerialPort1Parity
            // 
            this.SerialPort1Parity.FormattingEnabled = true;
            this.SerialPort1Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.SerialPort1Parity.Location = new System.Drawing.Point(81, 145);
            this.SerialPort1Parity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort1Parity.Name = "SerialPort1Parity";
            this.SerialPort1Parity.Size = new System.Drawing.Size(94, 23);
            this.SerialPort1Parity.TabIndex = 2;
            // 
            // SerialPort1Stop
            // 
            this.SerialPort1Stop.FormattingEnabled = true;
            this.SerialPort1Stop.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.SerialPort1Stop.Location = new System.Drawing.Point(81, 115);
            this.SerialPort1Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort1Stop.Name = "SerialPort1Stop";
            this.SerialPort1Stop.Size = new System.Drawing.Size(94, 23);
            this.SerialPort1Stop.TabIndex = 2;
            // 
            // SerialPort1Data
            // 
            this.SerialPort1Data.FormattingEnabled = true;
            this.SerialPort1Data.Items.AddRange(new object[] {
            "8",
            "7"});
            this.SerialPort1Data.Location = new System.Drawing.Point(81, 85);
            this.SerialPort1Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort1Data.Name = "SerialPort1Data";
            this.SerialPort1Data.Size = new System.Drawing.Size(94, 23);
            this.SerialPort1Data.TabIndex = 2;
            // 
            // SerialPort1Baud
            // 
            this.SerialPort1Baud.FormattingEnabled = true;
            this.SerialPort1Baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "7200",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.SerialPort1Baud.Location = new System.Drawing.Point(81, 55);
            this.SerialPort1Baud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort1Baud.Name = "SerialPort1Baud";
            this.SerialPort1Baud.Size = new System.Drawing.Size(94, 23);
            this.SerialPort1Baud.TabIndex = 2;
            // 
            // SerialPort1Com
            // 
            this.SerialPort1Com.FormattingEnabled = true;
            this.SerialPort1Com.Location = new System.Drawing.Point(81, 25);
            this.SerialPort1Com.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort1Com.Name = "SerialPort1Com";
            this.SerialPort1Com.Size = new System.Drawing.Size(94, 23);
            this.SerialPort1Com.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.SerialPort2Parity);
            this.groupBox2.Controls.Add(this.SerialPort2Stop);
            this.groupBox2.Controls.Add(this.SerialPort2Data);
            this.groupBox2.Controls.Add(this.SerialPort2Baud);
            this.groupBox2.Controls.Add(this.SerialPort2Com);
            this.groupBox2.Location = new System.Drawing.Point(224, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(215, 177);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port2 Com Ayar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "StopBit:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "DataBits:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "BaudRate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "PLC:";
            // 
            // SerialPort2Parity
            // 
            this.SerialPort2Parity.FormattingEnabled = true;
            this.SerialPort2Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.SerialPort2Parity.Location = new System.Drawing.Point(81, 145);
            this.SerialPort2Parity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort2Parity.Name = "SerialPort2Parity";
            this.SerialPort2Parity.Size = new System.Drawing.Size(94, 23);
            this.SerialPort2Parity.TabIndex = 2;
            // 
            // SerialPort2Stop
            // 
            this.SerialPort2Stop.FormattingEnabled = true;
            this.SerialPort2Stop.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.SerialPort2Stop.Location = new System.Drawing.Point(81, 115);
            this.SerialPort2Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort2Stop.Name = "SerialPort2Stop";
            this.SerialPort2Stop.Size = new System.Drawing.Size(94, 23);
            this.SerialPort2Stop.TabIndex = 2;
            // 
            // SerialPort2Data
            // 
            this.SerialPort2Data.FormattingEnabled = true;
            this.SerialPort2Data.Location = new System.Drawing.Point(81, 85);
            this.SerialPort2Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort2Data.Name = "SerialPort2Data";
            this.SerialPort2Data.Size = new System.Drawing.Size(94, 23);
            this.SerialPort2Data.TabIndex = 2;
            // 
            // SerialPort2Baud
            // 
            this.SerialPort2Baud.FormattingEnabled = true;
            this.SerialPort2Baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "7200",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.SerialPort2Baud.Location = new System.Drawing.Point(81, 55);
            this.SerialPort2Baud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort2Baud.Name = "SerialPort2Baud";
            this.SerialPort2Baud.Size = new System.Drawing.Size(94, 23);
            this.SerialPort2Baud.TabIndex = 2;
            // 
            // SerialPort2Com
            // 
            this.SerialPort2Com.FormattingEnabled = true;
            this.SerialPort2Com.Location = new System.Drawing.Point(81, 25);
            this.SerialPort2Com.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort2Com.Name = "SerialPort2Com";
            this.SerialPort2Com.Size = new System.Drawing.Size(94, 23);
            this.SerialPort2Com.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Aqua;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKaydet.Location = new System.Drawing.Point(428, 281);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(429, 511);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Ayarları Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.cozunurluk);
            this.groupBox11.Controls.Add(this.btnPNGsec);
            this.groupBox11.Controls.Add(this.txtPNGdosya);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Location = new System.Drawing.Point(14, 275);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Size = new System.Drawing.Size(408, 81);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Diğer Ayarlar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Çözünürlük:";
            // 
            // cozunurluk
            // 
            this.cozunurluk.FormattingEnabled = true;
            this.cozunurluk.Items.AddRange(new object[] {
            "3840x2160",
            "2560x1440",
            "2560x1280",
            "1920x1080",
            "1900x1200",
            "1680x1050",
            "1600x1200",
            "1600x900",
            "1440x900",
            "1440x1050",
            "1366x768",
            "1360x768",
            "1280x1024",
            "1280x960",
            "1280x800",
            "1280x768",
            "1280x720",
            "1280x600",
            "1152x864",
            "1024x768",
            "800x600"});
            this.cozunurluk.Location = new System.Drawing.Point(138, 47);
            this.cozunurluk.Name = "cozunurluk";
            this.cozunurluk.Size = new System.Drawing.Size(185, 23);
            this.cozunurluk.TabIndex = 3;
            // 
            // btnPNGsec
            // 
            this.btnPNGsec.BackColor = System.Drawing.Color.Aqua;
            this.btnPNGsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPNGsec.Location = new System.Drawing.Point(329, 16);
            this.btnPNGsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPNGsec.Name = "btnPNGsec";
            this.btnPNGsec.Size = new System.Drawing.Size(66, 28);
            this.btnPNGsec.TabIndex = 2;
            this.btnPNGsec.Text = "Seç";
            this.btnPNGsec.UseVisualStyleBackColor = false;
            this.btnPNGsec.Click += new System.EventHandler(this.btnIDsec_Click);
            // 
            // txtPNGdosya
            // 
            this.txtPNGdosya.Location = new System.Drawing.Point(138, 16);
            this.txtPNGdosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPNGdosya.Name = "txtPNGdosya";
            this.txtPNGdosya.Size = new System.Drawing.Size(185, 24);
            this.txtPNGdosya.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Resim Dosya Yolu:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.txtSerialTx4Timer);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.txtTimerTimeout);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.txtTimerAdmin);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.txtSerialTx2Timer);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.txtSerialTx1Timer);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.txtSerialTx3Timer);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Location = new System.Drawing.Point(12, 596);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(208, 194);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Timer Ayarları:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(162, 108);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(25, 17);
            this.label38.TabIndex = 9;
            this.label38.Text = "mS";
            // 
            // txtSerialTx4Timer
            // 
            this.txtSerialTx4Timer.Location = new System.Drawing.Point(109, 105);
            this.txtSerialTx4Timer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerialTx4Timer.Name = "txtSerialTx4Timer";
            this.txtSerialTx4Timer.Size = new System.Drawing.Size(47, 24);
            this.txtSerialTx4Timer.TabIndex = 7;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(8, 108);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 17);
            this.label39.TabIndex = 8;
            this.label39.Text = "SerialTx4Timer:";
            // 
            // txtTimerTimeout
            // 
            this.txtTimerTimeout.Location = new System.Drawing.Point(109, 163);
            this.txtTimerTimeout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimerTimeout.Name = "txtTimerTimeout";
            this.txtTimerTimeout.Size = new System.Drawing.Size(47, 24);
            this.txtTimerTimeout.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "mS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "TimeoutRx:";
            // 
            // txtTimerAdmin
            // 
            this.txtTimerAdmin.Location = new System.Drawing.Point(109, 134);
            this.txtTimerAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimerAdmin.Name = "txtTimerAdmin";
            this.txtTimerAdmin.Size = new System.Drawing.Size(47, 24);
            this.txtTimerAdmin.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(162, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 17);
            this.label23.TabIndex = 2;
            this.label23.Text = "mS";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(162, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 17);
            this.label21.TabIndex = 2;
            this.label21.Text = "mS";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(162, 134);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 17);
            this.label25.TabIndex = 2;
            this.label25.Text = "mS";
            // 
            // txtSerialTx2Timer
            // 
            this.txtSerialTx2Timer.Location = new System.Drawing.Point(109, 49);
            this.txtSerialTx2Timer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerialTx2Timer.Name = "txtSerialTx2Timer";
            this.txtSerialTx2Timer.Size = new System.Drawing.Size(47, 24);
            this.txtSerialTx2Timer.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "SerialTx2Timer.:";
            // 
            // txtSerialTx1Timer
            // 
            this.txtSerialTx1Timer.Location = new System.Drawing.Point(109, 20);
            this.txtSerialTx1Timer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerialTx1Timer.Name = "txtSerialTx1Timer";
            this.txtSerialTx1Timer.Size = new System.Drawing.Size(47, 24);
            this.txtSerialTx1Timer.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "SerialTx1Timer:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(162, 80);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(25, 17);
            this.label33.TabIndex = 2;
            this.label33.Text = "mS";
            // 
            // txtSerialTx3Timer
            // 
            this.txtSerialTx3Timer.Location = new System.Drawing.Point(109, 77);
            this.txtSerialTx3Timer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerialTx3Timer.Name = "txtSerialTx3Timer";
            this.txtSerialTx3Timer.Size = new System.Drawing.Size(47, 24);
            this.txtSerialTx3Timer.TabIndex = 0;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(8, 80);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 17);
            this.label32.TabIndex = 1;
            this.label32.Text = "SerialTx3Timer:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "T. Admin:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 24);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 21);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Şifre Değiştir";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtKaliteSifre
            // 
            this.txtKaliteSifre.Enabled = false;
            this.txtKaliteSifre.Location = new System.Drawing.Point(9, 154);
            this.txtKaliteSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKaliteSifre.Name = "txtKaliteSifre";
            this.txtKaliteSifre.PasswordChar = '*';
            this.txtKaliteSifre.Size = new System.Drawing.Size(89, 24);
            this.txtKaliteSifre.TabIndex = 0;
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Enabled = false;
            this.txtAdminSifre.Location = new System.Drawing.Point(9, 88);
            this.txtAdminSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.PasswordChar = '*';
            this.txtAdminSifre.Size = new System.Drawing.Size(89, 24);
            this.txtAdminSifre.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 129);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 17);
            this.label27.TabIndex = 1;
            this.label27.Text = "Kalite Şifre:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 63);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 17);
            this.label26.TabIndex = 1;
            this.label26.Text = "Adm. Şifre:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox2);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.txtAdminSifre);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.txtKaliteSifre);
            this.groupBox7.Location = new System.Drawing.Point(234, 596);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(180, 194);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Şifre Ayarları:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.SerialPort3Parity);
            this.groupBox3.Controls.Add(this.SerialPort3Stop);
            this.groupBox3.Controls.Add(this.SerialPort3Data);
            this.groupBox3.Controls.Add(this.SerialPort3Baud);
            this.groupBox3.Controls.Add(this.SerialPort3Com);
            this.groupBox3.Location = new System.Drawing.Point(461, 82);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(185, 177);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serial Port3 Com Ayar:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 147);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(45, 17);
            this.label31.TabIndex = 3;
            this.label31.Text = "Parity:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(7, 117);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 17);
            this.label34.TabIndex = 3;
            this.label34.Text = "StopBit:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(7, 87);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(61, 17);
            this.label35.TabIndex = 3;
            this.label35.Text = "DataBits:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(7, 57);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(68, 17);
            this.label36.TabIndex = 3;
            this.label36.Text = "BaudRate:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(7, 27);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(59, 17);
            this.label37.TabIndex = 3;
            this.label37.Text = "OTHER1:";
            // 
            // SerialPort3Parity
            // 
            this.SerialPort3Parity.FormattingEnabled = true;
            this.SerialPort3Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.SerialPort3Parity.Location = new System.Drawing.Point(81, 145);
            this.SerialPort3Parity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort3Parity.Name = "SerialPort3Parity";
            this.SerialPort3Parity.Size = new System.Drawing.Size(94, 23);
            this.SerialPort3Parity.TabIndex = 2;
            // 
            // SerialPort3Stop
            // 
            this.SerialPort3Stop.FormattingEnabled = true;
            this.SerialPort3Stop.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.SerialPort3Stop.Location = new System.Drawing.Point(81, 115);
            this.SerialPort3Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort3Stop.Name = "SerialPort3Stop";
            this.SerialPort3Stop.Size = new System.Drawing.Size(94, 23);
            this.SerialPort3Stop.TabIndex = 2;
            // 
            // SerialPort3Data
            // 
            this.SerialPort3Data.FormattingEnabled = true;
            this.SerialPort3Data.Items.AddRange(new object[] {
            "8",
            "7"});
            this.SerialPort3Data.Location = new System.Drawing.Point(81, 85);
            this.SerialPort3Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort3Data.Name = "SerialPort3Data";
            this.SerialPort3Data.Size = new System.Drawing.Size(94, 23);
            this.SerialPort3Data.TabIndex = 2;
            // 
            // SerialPort3Baud
            // 
            this.SerialPort3Baud.FormattingEnabled = true;
            this.SerialPort3Baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "7200",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.SerialPort3Baud.Location = new System.Drawing.Point(81, 55);
            this.SerialPort3Baud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort3Baud.Name = "SerialPort3Baud";
            this.SerialPort3Baud.Size = new System.Drawing.Size(94, 23);
            this.SerialPort3Baud.TabIndex = 2;
            // 
            // SerialPort3Com
            // 
            this.SerialPort3Com.FormattingEnabled = true;
            this.SerialPort3Com.Location = new System.Drawing.Point(81, 25);
            this.SerialPort3Com.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort3Com.Name = "SerialPort3Com";
            this.SerialPort3Com.Size = new System.Drawing.Size(94, 23);
            this.SerialPort3Com.TabIndex = 2;
            // 
            // chBoxSerial1
            // 
            this.chBoxSerial1.AutoSize = true;
            this.chBoxSerial1.Location = new System.Drawing.Point(12, 52);
            this.chBoxSerial1.Name = "chBoxSerial1";
            this.chBoxSerial1.Size = new System.Drawing.Size(125, 21);
            this.chBoxSerial1.TabIndex = 15;
            this.chBoxSerial1.Text = "Serial1 Aktif/Pasif";
            this.chBoxSerial1.UseVisualStyleBackColor = true;
            this.chBoxSerial1.CheckedChanged += new System.EventHandler(this.chBoxSerial1_CheckedChanged);
            // 
            // chBoxSerial2
            // 
            this.chBoxSerial2.AutoSize = true;
            this.chBoxSerial2.Location = new System.Drawing.Point(224, 51);
            this.chBoxSerial2.Name = "chBoxSerial2";
            this.chBoxSerial2.Size = new System.Drawing.Size(125, 21);
            this.chBoxSerial2.TabIndex = 16;
            this.chBoxSerial2.Text = "Serial2 Aktif/Pasif";
            this.chBoxSerial2.UseVisualStyleBackColor = true;
            this.chBoxSerial2.CheckedChanged += new System.EventHandler(this.chBoxSerial2_CheckedChanged);
            // 
            // chBoxSerial3
            // 
            this.chBoxSerial3.AutoSize = true;
            this.chBoxSerial3.Location = new System.Drawing.Point(463, 52);
            this.chBoxSerial3.Name = "chBoxSerial3";
            this.chBoxSerial3.Size = new System.Drawing.Size(125, 21);
            this.chBoxSerial3.TabIndex = 17;
            this.chBoxSerial3.Text = "Serial3 Aktif/Pasif";
            this.chBoxSerial3.UseVisualStyleBackColor = true;
            this.chBoxSerial3.CheckedChanged += new System.EventHandler(this.chBoxSerial3_CheckedChanged);
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(117, 11);
            this.projectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(567, 24);
            this.projectName.TabIndex = 64;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 17);
            this.label29.TabIndex = 63;
            this.label29.Text = "Project Name:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label220);
            this.groupBox5.Controls.Add(this.btnOkuIni);
            this.groupBox5.Controls.Add(this.btnINIsec);
            this.groupBox5.Controls.Add(this.btnKaydetIni);
            this.groupBox5.Controls.Add(this.txtINIdosya);
            this.groupBox5.Location = new System.Drawing.Point(12, 435);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(410, 92);
            this.groupBox5.TabIndex = 589;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ini Dosyası Ayarları:";
            // 
            // label220
            // 
            this.label220.AutoSize = true;
            this.label220.Location = new System.Drawing.Point(9, 22);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(116, 17);
            this.label220.TabIndex = 585;
            this.label220.Text = "Ayarlar Dosya Yolu:";
            // 
            // btnOkuIni
            // 
            this.btnOkuIni.BackColor = System.Drawing.Color.Aqua;
            this.btnOkuIni.Location = new System.Drawing.Point(245, 56);
            this.btnOkuIni.Name = "btnOkuIni";
            this.btnOkuIni.Size = new System.Drawing.Size(80, 30);
            this.btnOkuIni.TabIndex = 584;
            this.btnOkuIni.Text = "Oku";
            this.btnOkuIni.UseVisualStyleBackColor = false;
            this.btnOkuIni.Click += new System.EventHandler(this.btnOkuIni_Click);
            // 
            // btnINIsec
            // 
            this.btnINIsec.BackColor = System.Drawing.Color.Aqua;
            this.btnINIsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnINIsec.Location = new System.Drawing.Point(332, 22);
            this.btnINIsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnINIsec.Name = "btnINIsec";
            this.btnINIsec.Size = new System.Drawing.Size(66, 28);
            this.btnINIsec.TabIndex = 587;
            this.btnINIsec.Text = "Seç";
            this.btnINIsec.UseVisualStyleBackColor = false;
            this.btnINIsec.Click += new System.EventHandler(this.btnINIsec_Click);
            // 
            // btnKaydetIni
            // 
            this.btnKaydetIni.BackColor = System.Drawing.Color.Aqua;
            this.btnKaydetIni.Location = new System.Drawing.Point(140, 56);
            this.btnKaydetIni.Name = "btnKaydetIni";
            this.btnKaydetIni.Size = new System.Drawing.Size(80, 30);
            this.btnKaydetIni.TabIndex = 583;
            this.btnKaydetIni.Text = "Kaydet";
            this.btnKaydetIni.UseVisualStyleBackColor = false;
            this.btnKaydetIni.Click += new System.EventHandler(this.btnKaydetIni_Click);
            // 
            // txtINIdosya
            // 
            this.txtINIdosya.Location = new System.Drawing.Point(140, 22);
            this.txtINIdosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtINIdosya.Name = "txtINIdosya";
            this.txtINIdosya.Size = new System.Drawing.Size(185, 24);
            this.txtINIdosya.TabIndex = 586;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.btnLogSec);
            this.groupBox8.Controls.Add(this.txtLogDosya);
            this.groupBox8.Location = new System.Drawing.Point(12, 361);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(410, 68);
            this.groupBox8.TabIndex = 590;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Log Dosyası Ayarları:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 17);
            this.label15.TabIndex = 585;
            this.label15.Text = "Log Dosya Yolu:";
            // 
            // btnLogSec
            // 
            this.btnLogSec.BackColor = System.Drawing.Color.Aqua;
            this.btnLogSec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogSec.Location = new System.Drawing.Point(332, 22);
            this.btnLogSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogSec.Name = "btnLogSec";
            this.btnLogSec.Size = new System.Drawing.Size(66, 28);
            this.btnLogSec.TabIndex = 587;
            this.btnLogSec.Text = "Seç";
            this.btnLogSec.UseVisualStyleBackColor = false;
            this.btnLogSec.Click += new System.EventHandler(this.btnLogSec_Click);
            // 
            // txtLogDosya
            // 
            this.txtLogDosya.Location = new System.Drawing.Point(140, 22);
            this.txtLogDosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogDosya.Name = "txtLogDosya";
            this.txtLogDosya.Size = new System.Drawing.Size(185, 24);
            this.txtLogDosya.TabIndex = 586;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.printerName);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Location = new System.Drawing.Point(12, 535);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(410, 56);
            this.groupBox9.TabIndex = 591;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Yazıcı Ayarları:";
            // 
            // printerName
            // 
            this.printerName.FormattingEnabled = true;
            this.printerName.Location = new System.Drawing.Point(140, 19);
            this.printerName.Name = "printerName";
            this.printerName.Size = new System.Drawing.Size(185, 23);
            this.printerName.TabIndex = 586;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 585;
            this.label16.Text = "Yazıcı Adı:";
            // 
            // chBoxSerial4
            // 
            this.chBoxSerial4.AutoSize = true;
            this.chBoxSerial4.Location = new System.Drawing.Point(672, 51);
            this.chBoxSerial4.Name = "chBoxSerial4";
            this.chBoxSerial4.Size = new System.Drawing.Size(125, 21);
            this.chBoxSerial4.TabIndex = 593;
            this.chBoxSerial4.Text = "Serial4 Aktif/Pasif";
            this.chBoxSerial4.UseVisualStyleBackColor = true;
            this.chBoxSerial4.CheckedChanged += new System.EventHandler(this.chBoxSerial4_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.SerialPort4Parity);
            this.groupBox4.Controls.Add(this.SerialPort4Stop);
            this.groupBox4.Controls.Add(this.SerialPort4Data);
            this.groupBox4.Controls.Add(this.SerialPort4Baud);
            this.groupBox4.Controls.Add(this.SerialPort4Com);
            this.groupBox4.Location = new System.Drawing.Point(672, 82);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(185, 177);
            this.groupBox4.TabIndex = 592;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serial Port4 Com Ayar:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "Parity:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "StopBit:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "DataBits:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 57);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 17);
            this.label28.TabIndex = 3;
            this.label28.Text = "BaudRate:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 27);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 17);
            this.label30.TabIndex = 3;
            this.label30.Text = "OTHER2:";
            // 
            // SerialPort4Parity
            // 
            this.SerialPort4Parity.FormattingEnabled = true;
            this.SerialPort4Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.SerialPort4Parity.Location = new System.Drawing.Point(81, 145);
            this.SerialPort4Parity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort4Parity.Name = "SerialPort4Parity";
            this.SerialPort4Parity.Size = new System.Drawing.Size(94, 23);
            this.SerialPort4Parity.TabIndex = 2;
            // 
            // SerialPort4Stop
            // 
            this.SerialPort4Stop.FormattingEnabled = true;
            this.SerialPort4Stop.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.SerialPort4Stop.Location = new System.Drawing.Point(81, 115);
            this.SerialPort4Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort4Stop.Name = "SerialPort4Stop";
            this.SerialPort4Stop.Size = new System.Drawing.Size(94, 23);
            this.SerialPort4Stop.TabIndex = 2;
            // 
            // SerialPort4Data
            // 
            this.SerialPort4Data.FormattingEnabled = true;
            this.SerialPort4Data.Items.AddRange(new object[] {
            "8",
            "7"});
            this.SerialPort4Data.Location = new System.Drawing.Point(81, 85);
            this.SerialPort4Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort4Data.Name = "SerialPort4Data";
            this.SerialPort4Data.Size = new System.Drawing.Size(94, 23);
            this.SerialPort4Data.TabIndex = 2;
            // 
            // SerialPort4Baud
            // 
            this.SerialPort4Baud.FormattingEnabled = true;
            this.SerialPort4Baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "7200",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.SerialPort4Baud.Location = new System.Drawing.Point(81, 55);
            this.SerialPort4Baud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort4Baud.Name = "SerialPort4Baud";
            this.SerialPort4Baud.Size = new System.Drawing.Size(94, 23);
            this.SerialPort4Baud.TabIndex = 2;
            // 
            // SerialPort4Com
            // 
            this.SerialPort4Com.FormattingEnabled = true;
            this.SerialPort4Com.Location = new System.Drawing.Point(81, 25);
            this.SerialPort4Com.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPort4Com.Name = "SerialPort4Com";
            this.SerialPort4Com.Size = new System.Drawing.Size(94, 23);
            this.SerialPort4Com.TabIndex = 2;
            // 
            // chBoxProgramlama
            // 
            this.chBoxProgramlama.AutoSize = true;
            this.chBoxProgramlama.Location = new System.Drawing.Point(690, 12);
            this.chBoxProgramlama.Name = "chBoxProgramlama";
            this.chBoxProgramlama.Size = new System.Drawing.Size(160, 21);
            this.chBoxProgramlama.TabIndex = 594;
            this.chBoxProgramlama.Text = "Programlama Otomatik";
            this.chBoxProgramlama.UseVisualStyleBackColor = true;
            // 
            // AyarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(868, 807);
            this.Controls.Add(this.chBoxProgramlama);
            this.Controls.Add(this.chBoxSerial4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.chBoxSerial3);
            this.Controls.Add(this.chBoxSerial2);
            this.Controls.Add(this.chBoxSerial1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AyarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.AyarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnINIsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.ini";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtINIdosya.Text = openFileDialog.FileName;
        }


        private void btnLogSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.ini";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtLogDosya.Text = openFileDialog.FileName;
        }

        private void btnKaydetIni_Click(object sender, EventArgs e)
        {
            if (txtINIdosya.Text != "")
            {
                INIKaydet ini = new INIKaydet(txtINIdosya.Text);  // @"\Ayarlar.ini"
                ini.Yaz("programlamaChecked", "Metin Kutusu", Convert.ToString(chBoxProgramlama.Checked));
                ini.Yaz("projectName", "Metin Kutusu", Convert.ToString(projectName.Text));
                ini.Yaz("printerName", "Metin Kutusu", Convert.ToString(printerName.Text));

                ini.Yaz("chBoxSerial1Checked", "Metin Kutusu", Convert.ToString(chBoxSerial1.Checked));
                ini.Yaz("chBoxSerial2Checked", "Metin Kutusu", Convert.ToString(chBoxSerial2.Checked));
                ini.Yaz("chBoxSerial3Checked", "Metin Kutusu", Convert.ToString(chBoxSerial3.Checked));
                ini.Yaz("chBoxSerial4Checked", "Metin Kutusu", Convert.ToString(chBoxSerial4.Checked));

                ini.Yaz("SerialPort1Com", "Metin Kutusu", Convert.ToString(SerialPort1Com.Text));
                ini.Yaz("SerialPort1Baud", "Metin Kutusu", Convert.ToString(SerialPort1Baud.Text));
                ini.Yaz("SerialPort1Data", "Metin Kutusu", Convert.ToString(SerialPort1Data.Text));
                ini.Yaz("SerialPort1Stop", "Metin Kutusu", Convert.ToString(SerialPort1Stop.Text));
                ini.Yaz("SerialPort1Parity", "Metin Kutusu", Convert.ToString(SerialPort1Parity.Text));

                ini.Yaz("SerialPort2Com", "Metin Kutusu", Convert.ToString(SerialPort2Com.Text));
                ini.Yaz("SerialPort2Baud", "Metin Kutusu", Convert.ToString(SerialPort2Baud.Text));
                ini.Yaz("SerialPort2Data", "Metin Kutusu", Convert.ToString(SerialPort2Data.Text));
                ini.Yaz("SerialPort2Stop", "Metin Kutusu", Convert.ToString(SerialPort2Stop.Text));
                ini.Yaz("SerialPort2Parity", "Metin Kutusu", Convert.ToString(SerialPort2Parity.Text));

                ini.Yaz("SerialPort3Com", "Metin Kutusu", Convert.ToString(SerialPort3Com.Text));
                ini.Yaz("SerialPort3Baud", "Metin Kutusu", Convert.ToString(SerialPort3Baud.Text));
                ini.Yaz("SerialPort3Data", "Metin Kutusu", Convert.ToString(SerialPort3Data.Text));
                ini.Yaz("SerialPort3Stop", "Metin Kutusu", Convert.ToString(SerialPort3Stop.Text));
                ini.Yaz("SerialPort3Parity", "Metin Kutusu", Convert.ToString(SerialPort3Parity.Text));

                ini.Yaz("SerialPort4Com", "Metin Kutusu", Convert.ToString(SerialPort4Com.Text));
                ini.Yaz("SerialPort4Baud", "Metin Kutusu", Convert.ToString(SerialPort4Baud.Text));
                ini.Yaz("SerialPort4Data", "Metin Kutusu", Convert.ToString(SerialPort4Data.Text));
                ini.Yaz("SerialPort4Stop", "Metin Kutusu", Convert.ToString(SerialPort4Stop.Text));
                ini.Yaz("SerialPort4Parity", "Metin Kutusu", Convert.ToString(SerialPort4Parity.Text));

                ini.Yaz("txtPNGdosya", "Metin Kutusu", Convert.ToString(txtPNGdosya.Text));
                ini.Yaz("cozunurluk", "Metin Kutusu", Convert.ToString(cozunurluk.Text));

                ini.Yaz("txtINIdosya", "Metin Kutusu", Convert.ToString(txtINIdosya.Text));

                ini.Yaz("txtSerialTx1Timer", "Metin Kutusu", Convert.ToString(txtSerialTx1Timer.Text));
                ini.Yaz("txtSerialTx2Timer", "Metin Kutusu", Convert.ToString(txtSerialTx2Timer.Text));
                ini.Yaz("txtSerialTx3Timer", "Metin Kutusu", Convert.ToString(txtSerialTx3Timer.Text));
                ini.Yaz("txtSerialTx4Timer", "Metin Kutusu", Convert.ToString(txtSerialTx4Timer.Text));
                ini.Yaz("txtTimerAdmin", "Metin Kutusu", Convert.ToString(txtTimerAdmin.Text));
                ini.Yaz("txtTimerTimeout", "Metin Kutusu", Convert.ToString(txtTimerTimeout.Text));

                ini.Yaz("txtAdminSifre", "Metin Kutusu", Convert.ToString(txtAdminSifre.Text));
                ini.Yaz("txtKaliteSifre", "Metin Kutusu", Convert.ToString(txtKaliteSifre.Text));

                CustomMessageBox.ShowMessage("Bütün Ayarlar Dosyaya Başarıyla Kaydedildi.", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Information, Color.Yellow);
            }
            else
            {
                CustomMessageBox.ShowMessage("Dosya Yolu Boş Kalamaz", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
        }

        private void btnOkuIni_Click(object sender, EventArgs e)
        {
            if (txtINIdosya.Text != "")
            {
                try
                {
                    if (File.Exists(txtINIdosya.Text))
                    {
                        INIKaydet ini = new INIKaydet(txtINIdosya.Text);
                        if (ini.Oku("programlamaChecked", "Metin Kutusu") == "True")
                            chBoxProgramlama.Checked = true;
                        else if (ini.Oku("programlamaChecked", "Metin Kutusu") == "False")
                            chBoxProgramlama.Checked = false;

                        projectName.Text = ini.Oku("projectName", "Metin Kutusu");
                        printerName.Text = ini.Oku("printerName", "Metin Kutusu");
                        if (ini.Oku("chBoxSerial1Checked", "Metin Kutusu") == "True")
                            chBoxSerial1.Checked = true;
                        else if (ini.Oku("chBoxSerial1Checked", "Metin Kutusu") == "False")
                            chBoxSerial1.Checked = false;

                        if (ini.Oku("chBoxSerial2Checked", "Metin Kutusu") == "True")
                            chBoxSerial2.Checked = true;
                        else if (ini.Oku("chBoxSerial2Checked", "Metin Kutusu") == "False")
                            chBoxSerial2.Checked = false;

                        if (ini.Oku("chBoxSerial3Checked", "Metin Kutusu") == "True")
                            chBoxSerial3.Checked = true;
                        else if (ini.Oku("chBoxSerial3Checked", "Metin Kutusu") == "False")
                            chBoxSerial3.Checked = false;

                        if (ini.Oku("chBoxSerial4Checked", "Metin Kutusu") == "True")
                            chBoxSerial4.Checked = true;
                        else if (ini.Oku("chBoxSerial4Checked", "Metin Kutusu") == "False")
                            chBoxSerial4.Checked = false;

                        SerialPort1Com.Text = ini.Oku("SerialPort1Com", "Metin Kutusu");
                        SerialPort1Baud.Text = ini.Oku("SerialPort1Baud", "Metin Kutusu");
                        SerialPort1Data.Text = ini.Oku("SerialPort1Data", "Metin Kutusu");
                        SerialPort1Stop.Text = ini.Oku("SerialPort1Stop", "Metin Kutusu");
                        SerialPort1Parity.Text = ini.Oku("SerialPort1Parity", "Metin Kutusu");

                        SerialPort2Com.Text = ini.Oku("SerialPort2Com", "Metin Kutusu");
                        SerialPort2Baud.Text = ini.Oku("SerialPort2Baud", "Metin Kutusu");
                        SerialPort2Data.Text = ini.Oku("SerialPort2Data", "Metin Kutusu");
                        SerialPort2Stop.Text = ini.Oku("SerialPort2Stop", "Metin Kutusu");
                        SerialPort2Parity.Text = ini.Oku("SerialPort2Parity", "Metin Kutusu");

                        SerialPort3Com.Text = ini.Oku("SerialPort3Com", "Metin Kutusu");
                        SerialPort3Baud.Text = ini.Oku("SerialPort3Baud", "Metin Kutusu");
                        SerialPort3Data.Text = ini.Oku("SerialPort3Data", "Metin Kutusu");
                        SerialPort3Stop.Text = ini.Oku("SerialPort3Stop", "Metin Kutusu");
                        SerialPort3Parity.Text = ini.Oku("SerialPort3Parity", "Metin Kutusu");

                        SerialPort4Com.Text = ini.Oku("SerialPort4Com", "Metin Kutusu");
                        SerialPort4Baud.Text = ini.Oku("SerialPort4Baud", "Metin Kutusu");
                        SerialPort4Data.Text = ini.Oku("SerialPort4Data", "Metin Kutusu");
                        SerialPort4Stop.Text = ini.Oku("SerialPort4Stop", "Metin Kutusu");
                        SerialPort4Parity.Text = ini.Oku("SerialPort4Parity", "Metin Kutusu");

                        txtPNGdosya.Text = ini.Oku("txtPNGdosya", "Metin Kutusu");
                        cozunurluk.Text = ini.Oku("cozunurluk", "Metin Kutusu");

                        txtINIdosya.Text = ini.Oku("txtINIdosya", "Metin Kutusu");

                        txtSerialTx1Timer.Text = ini.Oku("txtSerialTx1Timer", "Metin Kutusu");
                        txtSerialTx2Timer.Text = ini.Oku("txtSerialTx2Timer", "Metin Kutusu");
                        txtSerialTx3Timer.Text = ini.Oku("txtSerialTx3Timer", "Metin Kutusu");
                        txtSerialTx4Timer.Text = ini.Oku("txtSerialTx4Timer", "Metin Kutusu");
                        txtTimerAdmin.Text = ini.Oku("txtTimerAdmin", "Metin Kutusu");
                        txtTimerTimeout.Text = ini.Oku("txtTimerTimeout", "Metin Kutusu");

                        txtAdminSifre.Text = ini.Oku("txtAdminSifre", "Metin Kutusu");
                        txtKaliteSifre.Text = ini.Oku("txtKaliteSifre", "Metin Kutusu");

                        CustomMessageBox.ShowMessage("Bütün Ayarlar Dosyadan Başarıyla Okundu.", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Information, Color.Yellow);
                    }
                }
                catch (Exception hata)
                {
                    CustomMessageBox.ShowMessage("ini Dosyası Hasarlı", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
                }
            }
            else
            {
                CustomMessageBox.ShowMessage("Dosya Yolu Boş Kalamaz", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
        }


    }
}
