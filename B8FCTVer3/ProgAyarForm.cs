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
    public class ProgAyarForm : Form
    {
        public Form MainFrm;
        private IContainer components;

        private Button btnKaydet;
        private ComboBox barcodeNum;
        private TextBox barcode1;
        private TextBox barcode2;
        private TextBox barcode4;
        private TextBox barcode3;
        private TextBox barcode8;
        private TextBox barcode7;
        private TextBox barcode6;
        private TextBox barcode5;
        private TextBox barcode10;
        private TextBox barcode9;
        private Label label12;
        private TextBox txtBatchDosya;
        private Button btnLogsec;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox barcode20;
        private TextBox barcode19;
        private TextBox barcode18;
        private TextBox barcode17;
        private TextBox barcode16;
        private TextBox barcode15;
        private TextBox barcode14;
        private TextBox barcode13;
        private TextBox barcode12;
        private TextBox barcode11;
        private TextBox companyNo;
        private Label label23;
        private TextBox SAPNo;
        private Label label28;
        private ToolTip toolTip1;
        private Button btnINIsec;
        private TextBox txtINIdosya;
        private Label label220;
        private Button btnOkuIni;
        private Button btnKaydetIni;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox infoPicture2;
        private ComboBox step20Job;
        private Label label103;
        private ComboBox step19Job;
        private Label label104;
        private ComboBox step18Job;
        private Label label105;
        private ComboBox step17Job;
        private Label label106;
        private ComboBox step16Job;
        private Label label107;
        private ComboBox step15Job;
        private Label label138;
        private ComboBox step14Job;
        private Label label139;
        private ComboBox step13Job;
        private Label label140;
        private ComboBox step12Job;
        private Label label141;
        private ComboBox step11Job;
        private Label label142;
        private ComboBox step10Job;
        private Label label68;
        private ComboBox step9Job;
        private Label label69;
        private ComboBox step8Job;
        private Label label70;
        private ComboBox step7Job;
        private Label label71;
        private ComboBox step6Job;
        private Label label72;
        private ComboBox step5Job;
        private Label label37;
        private ComboBox step4Job;
        private Label label38;
        private ComboBox step3Job;
        private Label label39;
        private ComboBox step2Job;
        private Label label40;
        private ComboBox step1Job;
        private Label label41;
        private ToolTip toolTip2;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private TextBox Sbarcode20;
        private TextBox Sbarcode19;
        private TextBox Sbarcode18;
        private TextBox Sbarcode17;
        private TextBox Sbarcode16;
        private TextBox Sbarcode15;
        private TextBox Sbarcode14;
        private TextBox Sbarcode13;
        private TextBox Sbarcode12;
        private TextBox Sbarcode11;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
        private Label label60;
        private Label label61;
        private TextBox Sbarcode10;
        private TextBox Sbarcode9;
        private TextBox Sbarcode8;
        private TextBox Sbarcode7;
        private TextBox Sbarcode6;
        private TextBox Sbarcode5;
        private TextBox Sbarcode4;
        private TextBox Sbarcode3;
        private TextBox Sbarcode2;
        private TextBox Sbarcode1;
        private PictureBox infoPicture3;
        private PictureBox infoPicture4;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private CheckBox chBoxSuccess;
        private CheckBox chBoxError1;
        private CheckBox chBoxError2;
        private CheckBox chBoxError3;
        private GroupBox groupBox4;
        private TextBox txtError3Batch;
        private TextBox txtError2Batch;
        private TextBox txtError1Batch;
        private GroupBox groupBox1;
        private TextBox softwareRev;
        private Label label31;
        private Label label29;
        private TextBox FCTRev;
        private TextBox softwareVer;
        private Label label30;
        private Label label26;
        private TextBox BOMVer;
        private TextBox ICTRev;
        private Label label27;
        private Label label24;
        private TextBox cardNo;
        private TextBox gerberVer;
        private Label label25;
        private TextBox productNo;
        private Label label32;
        private TextBox txtSuccessBatch;

        public ProgAyarForm()
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
            toolTip_Load();

            this.barcodeNum.Text = Prog_Ayarlar.Default.barcodeNum;

            this.step1Job.Text = Prog_Ayarlar.Default.step1Job;
            this.step2Job.Text = Prog_Ayarlar.Default.step2Job;
            this.step3Job.Text = Prog_Ayarlar.Default.step3Job;
            this.step4Job.Text = Prog_Ayarlar.Default.step4Job;
            this.step5Job.Text = Prog_Ayarlar.Default.step5Job;
            this.step6Job.Text = Prog_Ayarlar.Default.step6Job;
            this.step7Job.Text = Prog_Ayarlar.Default.step7Job;
            this.step8Job.Text = Prog_Ayarlar.Default.step8Job;
            this.step9Job.Text = Prog_Ayarlar.Default.step9Job;
            this.step10Job.Text = Prog_Ayarlar.Default.step10Job;
            this.step11Job.Text = Prog_Ayarlar.Default.step11Job;
            this.step12Job.Text = Prog_Ayarlar.Default.step12Job;
            this.step13Job.Text = Prog_Ayarlar.Default.step13Job;
            this.step14Job.Text = Prog_Ayarlar.Default.step14Job;
            this.step15Job.Text = Prog_Ayarlar.Default.step15Job;
            this.step16Job.Text = Prog_Ayarlar.Default.step16Job;
            this.step17Job.Text = Prog_Ayarlar.Default.step17Job;
            this.step18Job.Text = Prog_Ayarlar.Default.step18Job;
            this.step19Job.Text = Prog_Ayarlar.Default.step19Job;
            this.step20Job.Text = Prog_Ayarlar.Default.step20Job;

            this.barcode1.Text = Prog_Ayarlar.Default.barcode1;
            this.barcode2.Text = Prog_Ayarlar.Default.barcode2;
            this.barcode3.Text = Prog_Ayarlar.Default.barcode3;
            this.barcode4.Text = Prog_Ayarlar.Default.barcode4;
            this.barcode5.Text = Prog_Ayarlar.Default.barcode5;
            this.barcode6.Text = Prog_Ayarlar.Default.barcode6;
            this.barcode7.Text = Prog_Ayarlar.Default.barcode7;
            this.barcode8.Text = Prog_Ayarlar.Default.barcode8;
            this.barcode9.Text = Prog_Ayarlar.Default.barcode9;
            this.barcode10.Text = Prog_Ayarlar.Default.barcode10;
            this.barcode11.Text = Prog_Ayarlar.Default.barcode11;
            this.barcode12.Text = Prog_Ayarlar.Default.barcode12;
            this.barcode13.Text = Prog_Ayarlar.Default.barcode13;
            this.barcode14.Text = Prog_Ayarlar.Default.barcode14;
            this.barcode15.Text = Prog_Ayarlar.Default.barcode15;
            this.barcode16.Text = Prog_Ayarlar.Default.barcode16;
            this.barcode17.Text = Prog_Ayarlar.Default.barcode17;
            this.barcode18.Text = Prog_Ayarlar.Default.barcode18;
            this.barcode19.Text = Prog_Ayarlar.Default.barcode19;
            this.barcode20.Text = Prog_Ayarlar.Default.barcode20;

            this.Sbarcode1.Text = Prog_Ayarlar.Default.Sbarcode1;
            this.Sbarcode2.Text = Prog_Ayarlar.Default.Sbarcode2;
            this.Sbarcode3.Text = Prog_Ayarlar.Default.Sbarcode3;
            this.Sbarcode4.Text = Prog_Ayarlar.Default.Sbarcode4;
            this.Sbarcode5.Text = Prog_Ayarlar.Default.Sbarcode5;
            this.Sbarcode6.Text = Prog_Ayarlar.Default.Sbarcode6;
            this.Sbarcode7.Text = Prog_Ayarlar.Default.Sbarcode7;
            this.Sbarcode8.Text = Prog_Ayarlar.Default.Sbarcode8;
            this.Sbarcode9.Text = Prog_Ayarlar.Default.Sbarcode9;
            this.Sbarcode10.Text = Prog_Ayarlar.Default.Sbarcode10;
            this.Sbarcode11.Text = Prog_Ayarlar.Default.Sbarcode11;
            this.Sbarcode12.Text = Prog_Ayarlar.Default.Sbarcode12;
            this.Sbarcode13.Text = Prog_Ayarlar.Default.Sbarcode13;
            this.Sbarcode14.Text = Prog_Ayarlar.Default.Sbarcode14;
            this.Sbarcode15.Text = Prog_Ayarlar.Default.Sbarcode15;
            this.Sbarcode16.Text = Prog_Ayarlar.Default.Sbarcode16;
            this.Sbarcode17.Text = Prog_Ayarlar.Default.Sbarcode17;
            this.Sbarcode18.Text = Prog_Ayarlar.Default.Sbarcode18;
            this.Sbarcode19.Text = Prog_Ayarlar.Default.Sbarcode19;
            this.Sbarcode20.Text = Prog_Ayarlar.Default.Sbarcode20;

            this.txtBatchDosya.Text = Prog_Ayarlar.Default.Logdosyayolu;
            this.companyNo.Text = Prog_Ayarlar.Default.companyNo;
            this.productNo.Text = Prog_Ayarlar.Default.productNo;
            this.SAPNo.Text = Prog_Ayarlar.Default.SAPNo;
            this.cardNo.Text = Prog_Ayarlar.Default.cardNo;
            this.gerberVer.Text = Prog_Ayarlar.Default.gerberVer;
            this.BOMVer.Text = Prog_Ayarlar.Default.BOMVer;
            this.ICTRev.Text = Prog_Ayarlar.Default.ICTRev;
            this.FCTRev.Text = Prog_Ayarlar.Default.FCTRev;
            this.softwareVer.Text = Prog_Ayarlar.Default.softwareVer;
            this.softwareRev.Text = Prog_Ayarlar.Default.softwareRev;

            this.txtINIdosya.Text = Prog_Ayarlar.Default.iniDosyaYolu;

            this.chBoxSuccess.Checked = Prog_Ayarlar.Default.chBoxSuccess;
            if (chBoxSuccess.Checked == true)
                txtSuccessBatch.Enabled = true;
            else
                txtSuccessBatch.Enabled = false;

            this.chBoxError1.Checked = Prog_Ayarlar.Default.chBoxError1;
            if (chBoxError1.Checked == true)
                txtError1Batch.Enabled = true;
            else
                txtError1Batch.Enabled = false;

            this.chBoxError2.Checked = Prog_Ayarlar.Default.chBoxError2;
            if (chBoxError2.Checked == true)
                txtError2Batch.Enabled = true;
            else
                txtError2Batch.Enabled = false;

            this.chBoxError3.Checked = Prog_Ayarlar.Default.chBoxError3;
            if (chBoxError3.Checked == true)
                txtError3Batch.Enabled = true;
            else
                txtError3Batch.Enabled = false;

            this.txtSuccessBatch.Text = Prog_Ayarlar.Default.successBatch;
            this.txtError1Batch.Text = Prog_Ayarlar.Default.error1Batch;
            this.txtError2Batch.Text = Prog_Ayarlar.Default.error2Batch;
            this.txtError3Batch.Text = Prog_Ayarlar.Default.error3Batch;
        }
        private void toolTip_Load()
        {
            string[] toolTipTitle = new string[10];
            string[] toolTipTool = new string[10];
            toolTipTitle[1] = "Lütfen Gelecek Feedback Verisini Giriniz";
            toolTipTitle[2] = "Lütfen Programlama Türünü Belirleyiniz";
            toolTipTitle[3] = "Lütfen Barcode-Master Verisini Giriniz";
            toolTipTitle[4] = "Lütfen Slave Verisini Giriniz";

            toolTipTool[1] = "Örnek : data[2] = {180,75}; \n2,180,75";
            toolTipTool[2] = "1-) Sadece Master \n2-) Master ve Slave";
            toolTipTool[3] = "Örnek : 167000192 ya da 167000204m \nDikkat Barcode ve Master Batch File Aynı Olmalı";
            toolTipTool[4] = "Örnek : 167000204s";

            toolTip2.Active = true;
            toolTip2.AutoPopDelay = 5000;
            toolTip2.InitialDelay = 1000;
            toolTip2.ReshowDelay = 5000;
            toolTip2.IsBalloon = true;
            toolTip2.UseAnimation = true;
            toolTip2.UseFading = true;
            toolTip2.ShowAlways = true;
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = toolTipTitle[2];
            toolTip2.SetToolTip(infoPicture2, toolTipTool[2]);

            toolTip3.Active = true;
            toolTip3.AutoPopDelay = 5000;
            toolTip3.InitialDelay = 1000;
            toolTip3.ReshowDelay = 5000;
            toolTip3.IsBalloon = true;
            toolTip3.UseAnimation = true;
            toolTip3.UseFading = true;
            toolTip3.ShowAlways = true;
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            toolTip3.ToolTipTitle = toolTipTitle[3];
            toolTip3.SetToolTip(infoPicture3, toolTipTool[3]);

            toolTip4.Active = true;
            toolTip4.AutoPopDelay = 5000;
            toolTip4.InitialDelay = 1000;
            toolTip4.ReshowDelay = 5000;
            toolTip4.IsBalloon = true;
            toolTip4.UseAnimation = true;
            toolTip4.UseFading = true;
            toolTip4.ShowAlways = true;
            toolTip4.ToolTipIcon = ToolTipIcon.Info;
            toolTip4.ToolTipTitle = toolTipTitle[4];
            toolTip4.SetToolTip(infoPicture4, toolTipTool[4]);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Prog_Ayarlar.Default.barcodeNum = this.barcodeNum.Text;

                Prog_Ayarlar.Default.step1Job = this.step1Job.Text;
                Prog_Ayarlar.Default.step2Job = this.step2Job.Text;
                Prog_Ayarlar.Default.step3Job = this.step3Job.Text;
                Prog_Ayarlar.Default.step4Job = this.step4Job.Text;
                Prog_Ayarlar.Default.step5Job = this.step5Job.Text;
                Prog_Ayarlar.Default.step6Job = this.step6Job.Text;
                Prog_Ayarlar.Default.step7Job = this.step7Job.Text;
                Prog_Ayarlar.Default.step8Job = this.step8Job.Text;
                Prog_Ayarlar.Default.step9Job = this.step9Job.Text;
                Prog_Ayarlar.Default.step10Job = this.step10Job.Text;
                Prog_Ayarlar.Default.step11Job = this.step11Job.Text;
                Prog_Ayarlar.Default.step12Job = this.step12Job.Text;
                Prog_Ayarlar.Default.step13Job = this.step13Job.Text;
                Prog_Ayarlar.Default.step14Job = this.step14Job.Text;
                Prog_Ayarlar.Default.step15Job = this.step15Job.Text;
                Prog_Ayarlar.Default.step16Job = this.step16Job.Text;
                Prog_Ayarlar.Default.step17Job = this.step17Job.Text;
                Prog_Ayarlar.Default.step18Job = this.step18Job.Text;
                Prog_Ayarlar.Default.step19Job = this.step19Job.Text;
                Prog_Ayarlar.Default.step20Job = this.step20Job.Text;

                Prog_Ayarlar.Default.barcode1 = this.barcode1.Text;
                Prog_Ayarlar.Default.barcode2 = this.barcode2.Text;
                Prog_Ayarlar.Default.barcode3 = this.barcode3.Text;
                Prog_Ayarlar.Default.barcode4 = this.barcode4.Text;
                Prog_Ayarlar.Default.barcode5 = this.barcode5.Text;
                Prog_Ayarlar.Default.barcode6 = this.barcode6.Text;
                Prog_Ayarlar.Default.barcode7 = this.barcode7.Text;
                Prog_Ayarlar.Default.barcode8 = this.barcode8.Text;
                Prog_Ayarlar.Default.barcode9 = this.barcode9.Text;
                Prog_Ayarlar.Default.barcode10 = this.barcode10.Text;
                Prog_Ayarlar.Default.barcode11 = this.barcode11.Text;
                Prog_Ayarlar.Default.barcode12 = this.barcode12.Text;
                Prog_Ayarlar.Default.barcode13 = this.barcode13.Text;
                Prog_Ayarlar.Default.barcode14 = this.barcode14.Text;
                Prog_Ayarlar.Default.barcode15 = this.barcode15.Text;
                Prog_Ayarlar.Default.barcode16 = this.barcode16.Text;
                Prog_Ayarlar.Default.barcode17 = this.barcode17.Text;
                Prog_Ayarlar.Default.barcode18 = this.barcode18.Text;
                Prog_Ayarlar.Default.barcode19 = this.barcode19.Text;
                Prog_Ayarlar.Default.barcode20 = this.barcode20.Text;

                Prog_Ayarlar.Default.Sbarcode1 = this.Sbarcode1.Text;
                Prog_Ayarlar.Default.Sbarcode2 = this.Sbarcode2.Text;
                Prog_Ayarlar.Default.Sbarcode3 = this.Sbarcode3.Text;
                Prog_Ayarlar.Default.Sbarcode4 = this.Sbarcode4.Text;
                Prog_Ayarlar.Default.Sbarcode5 = this.Sbarcode5.Text;
                Prog_Ayarlar.Default.Sbarcode6 = this.Sbarcode6.Text;
                Prog_Ayarlar.Default.Sbarcode7 = this.Sbarcode7.Text;
                Prog_Ayarlar.Default.Sbarcode8 = this.Sbarcode8.Text;
                Prog_Ayarlar.Default.Sbarcode9 = this.Sbarcode9.Text;
                Prog_Ayarlar.Default.Sbarcode10 = this.Sbarcode10.Text;
                Prog_Ayarlar.Default.Sbarcode11 = this.Sbarcode11.Text;
                Prog_Ayarlar.Default.Sbarcode12 = this.Sbarcode12.Text;
                Prog_Ayarlar.Default.Sbarcode13 = this.Sbarcode13.Text;
                Prog_Ayarlar.Default.Sbarcode14 = this.Sbarcode14.Text;
                Prog_Ayarlar.Default.Sbarcode15 = this.Sbarcode15.Text;
                Prog_Ayarlar.Default.Sbarcode16 = this.Sbarcode16.Text;
                Prog_Ayarlar.Default.Sbarcode17 = this.Sbarcode17.Text;
                Prog_Ayarlar.Default.Sbarcode18 = this.Sbarcode18.Text;
                Prog_Ayarlar.Default.Sbarcode19 = this.Sbarcode19.Text;
                Prog_Ayarlar.Default.Sbarcode20 = this.Sbarcode20.Text;

                Prog_Ayarlar.Default.Logdosyayolu = this.txtBatchDosya.Text;
                Prog_Ayarlar.Default.companyNo = this.companyNo.Text;
                Prog_Ayarlar.Default.productNo = this.productNo.Text;
                Prog_Ayarlar.Default.SAPNo = this.SAPNo.Text;
                Prog_Ayarlar.Default.cardNo = this.cardNo.Text;
                Prog_Ayarlar.Default.gerberVer = this.gerberVer.Text;
                Prog_Ayarlar.Default.BOMVer = this.BOMVer.Text;
                Prog_Ayarlar.Default.ICTRev = this.ICTRev.Text;
                Prog_Ayarlar.Default.FCTRev = this.FCTRev.Text;
                Prog_Ayarlar.Default.softwareVer = this.FCTRev.Text;
                Prog_Ayarlar.Default.softwareRev = this.softwareRev.Text;

                Prog_Ayarlar.Default.iniDosyaYolu = this.txtINIdosya.Text;

                Prog_Ayarlar.Default.chBoxSuccess = this.chBoxSuccess.Checked;
                Prog_Ayarlar.Default.chBoxError1 = this.chBoxError1.Checked;
                Prog_Ayarlar.Default.chBoxError2 = this.chBoxError2.Checked;
                Prog_Ayarlar.Default.chBoxError3 = this.chBoxError3.Checked;
                Prog_Ayarlar.Default.successBatch = this.txtSuccessBatch.Text;
                Prog_Ayarlar.Default.error1Batch = this.txtError1Batch.Text;
                Prog_Ayarlar.Default.error2Batch = this.txtError2Batch.Text;
                Prog_Ayarlar.Default.error3Batch = this.txtError3Batch.Text;
                Prog_Ayarlar.Default.Save();

                CustomMessageBox.ShowMessage("Bütün Ayarlar Başarıyla Kaydedildi.", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Information, Color.Yellow);
                this.Close();

                Application.Restart();
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowMessage("Ayarlar Kayıt Hatası: " + ex.ToString(), Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
        }

        private void barcodeNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            step1Job.Enabled = false;
            step2Job.Enabled = false;
            step3Job.Enabled = false;
            step4Job.Enabled = false;
            step5Job.Enabled = false;
            step6Job.Enabled = false;
            step7Job.Enabled = false;
            step8Job.Enabled = false;
            step9Job.Enabled = false;
            step10Job.Enabled = false;
            step11Job.Enabled = false;
            step12Job.Enabled = false;
            step13Job.Enabled = false;
            step14Job.Enabled = false;
            step15Job.Enabled = false;
            step16Job.Enabled = false;
            step17Job.Enabled = false;
            step18Job.Enabled = false;
            step19Job.Enabled = false;
            step20Job.Enabled = false;
            barcode1.Enabled = false;
            barcode2.Enabled = false;
            barcode3.Enabled = false;
            barcode4.Enabled = false;
            barcode5.Enabled = false;
            barcode6.Enabled = false;
            barcode7.Enabled = false;
            barcode8.Enabled = false;
            barcode9.Enabled = false;
            barcode10.Enabled = false;
            barcode11.Enabled = false;
            barcode12.Enabled = false;
            barcode13.Enabled = false;
            barcode14.Enabled = false;
            barcode15.Enabled = false;
            barcode16.Enabled = false;
            barcode17.Enabled = false;
            barcode18.Enabled = false;
            barcode19.Enabled = false;
            barcode20.Enabled = false;
            Sbarcode1.Enabled = false;
            Sbarcode2.Enabled = false;
            Sbarcode3.Enabled = false;
            Sbarcode4.Enabled = false;
            Sbarcode5.Enabled = false;
            Sbarcode6.Enabled = false;
            Sbarcode7.Enabled = false;
            Sbarcode8.Enabled = false;
            Sbarcode9.Enabled = false;
            Sbarcode10.Enabled = false;
            Sbarcode11.Enabled = false;
            Sbarcode12.Enabled = false;
            Sbarcode13.Enabled = false;
            Sbarcode14.Enabled = false;
            Sbarcode15.Enabled = false;
            Sbarcode16.Enabled = false;
            Sbarcode17.Enabled = false;
            Sbarcode18.Enabled = false;
            Sbarcode19.Enabled = false;
            Sbarcode20.Enabled = false;

            if (Convert.ToInt32(barcodeNum.Text) >= 1)
            {
                step1Job.Enabled = true;
                barcode1.Enabled = true;
                Sbarcode1.Enabled = true;
                this.Invoke(new EventHandler(step1Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 2)
            {
                step2Job.Enabled = true;
                barcode2.Enabled = true;
                Sbarcode2.Enabled = true;
                this.Invoke(new EventHandler(step2Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 3)
            {
                step3Job.Enabled = true;
                barcode3.Enabled = true;
                Sbarcode3.Enabled = true;
                this.Invoke(new EventHandler(step3Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 4)
            {
                step4Job.Enabled = true;
                barcode4.Enabled = true;
                Sbarcode4.Enabled = true;
                this.Invoke(new EventHandler(step4Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 5)
            {
                step5Job.Enabled = true;
                barcode5.Enabled = true;
                Sbarcode5.Enabled = true;
                this.Invoke(new EventHandler(step5Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 6)
            {
                step6Job.Enabled = true;
                barcode6.Enabled = true;
                Sbarcode6.Enabled = true;
                this.Invoke(new EventHandler(step6Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 7)
            {
                step7Job.Enabled = true;
                barcode7.Enabled = true;
                Sbarcode7.Enabled = true;
                this.Invoke(new EventHandler(step7Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 8)
            {
                step8Job.Enabled = true;
                barcode8.Enabled = true;
                Sbarcode8.Enabled = true;
                this.Invoke(new EventHandler(step8Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 9)
            {
                step9Job.Enabled = true;
                barcode9.Enabled = true;
                Sbarcode9.Enabled = true;
                this.Invoke(new EventHandler(step9Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 10)
            {
                step10Job.Enabled = true;
                barcode10.Enabled = true;
                Sbarcode10.Enabled = true;
                this.Invoke(new EventHandler(step10Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 11)
            {
                step11Job.Enabled = true;
                barcode11.Enabled = true;
                Sbarcode11.Enabled = true;
                this.Invoke(new EventHandler(step11Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 12)
            {
                step12Job.Enabled = true;
                barcode12.Enabled = true;
                Sbarcode12.Enabled = true;
                this.Invoke(new EventHandler(step12Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 13)
            {
                step13Job.Enabled = true;
                barcode13.Enabled = true;
                Sbarcode13.Enabled = true;
                this.Invoke(new EventHandler(step13Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 14)
            {
                step14Job.Enabled = true;
                barcode14.Enabled = true;
                Sbarcode14.Enabled = true;
                this.Invoke(new EventHandler(step14Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 15)
            {
                step15Job.Enabled = true;
                barcode15.Enabled = true;
                Sbarcode15.Enabled = true;
                this.Invoke(new EventHandler(step15Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 16)
            {
                step16Job.Enabled = true;
                barcode16.Enabled = true;
                Sbarcode16.Enabled = true;
                this.Invoke(new EventHandler(step16Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 17)
            {
                step17Job.Enabled = true;
                barcode17.Enabled = true;
                Sbarcode17.Enabled = true;
                this.Invoke(new EventHandler(step17Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 18)
            {
                step18Job.Enabled = true;
                barcode18.Enabled = true;
                Sbarcode18.Enabled = true;
                this.Invoke(new EventHandler(step18Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 19)
            {
                step19Job.Enabled = true;
                barcode19.Enabled = true;
                Sbarcode19.Enabled = true;
                this.Invoke(new EventHandler(step19Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(barcodeNum.Text) >= 20)
            {
                step20Job.Enabled = true;
                barcode20.Enabled = true;
                Sbarcode20.Enabled = true;
                this.Invoke(new EventHandler(step20Job_SelectedIndexChanged));
            }
        }


        private void step1Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode1.Enabled = true;
            if (step1Job.Text == "1")
                Sbarcode1.Enabled = false;
        }

        private void step2Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode2.Enabled = true;
            if (step2Job.Text == "1")
                Sbarcode2.Enabled = false;
        }

        private void step3Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode3.Enabled = true;
            if (step3Job.Text == "1")
                Sbarcode3.Enabled = false;
        }

        private void step4Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode4.Enabled = true;
            if (step4Job.Text == "1")
                Sbarcode4.Enabled = false;
        }

        private void step5Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode5.Enabled = true;
            if (step5Job.Text == "1")
                Sbarcode5.Enabled = false;
        }

        private void step6Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode6.Enabled = true;
            if (step6Job.Text == "1")
                Sbarcode6.Enabled = false;
        }

        private void step7Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode7.Enabled = true;
            if (step7Job.Text == "1")
                Sbarcode7.Enabled = false;
        }

        private void step8Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode8.Enabled = true;
            if (step8Job.Text == "1")
                Sbarcode8.Enabled = false;
        }

        private void step9Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode9.Enabled = true;
            if (step9Job.Text == "1")
                Sbarcode9.Enabled = false;
        }

        private void step10Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode10.Enabled = true;
            if (step10Job.Text == "1")
                Sbarcode10.Enabled = false;
        }

        private void step11Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode11.Enabled = true;
            if (step11Job.Text == "1")
                Sbarcode11.Enabled = false;
        }

        private void step12Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode12.Enabled = true;
            if (step12Job.Text == "1")
                Sbarcode12.Enabled = false;
        }

        private void step13Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode13.Enabled = true;
            if (step13Job.Text == "1")
                Sbarcode13.Enabled = false;
        }

        private void step14Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode14.Enabled = true;
            if (step14Job.Text == "1")
                Sbarcode14.Enabled = false;
        }

        private void step15Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode15.Enabled = true;
            if (step15Job.Text == "1")
                Sbarcode15.Enabled = false;
        }

        private void step16Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode16.Enabled = true;
            if (step16Job.Text == "1")
                Sbarcode16.Enabled = false;
        }

        private void step17Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode17.Enabled = true;
            if (step17Job.Text == "1")
                Sbarcode17.Enabled = false;
        }

        private void step18Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode18.Enabled = true;
            if (step18Job.Text == "1")
                Sbarcode18.Enabled = false;
        }

        private void step19Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode19.Enabled = true;
            if (step19Job.Text == "1")
                Sbarcode19.Enabled = false;
        }

        private void step20Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sbarcode20.Enabled = true;
            if (step20Job.Text == "1")
                Sbarcode20.Enabled = false;
        }

        private void chBoxSuccess_CheckedChanged(object sender, EventArgs e)
        {
            txtSuccessBatch.Enabled = chBoxSuccess.Checked;
        }

        private void chBoxError1_CheckedChanged(object sender, EventArgs e)
        {
            txtError1Batch.Enabled = chBoxError1.Checked;
        }

        private void chBoxError2_CheckedChanged(object sender, EventArgs e)
        {
            txtError2Batch.Enabled = chBoxError2.Checked;
        }

        private void chBoxError3_CheckedChanged(object sender, EventArgs e)
        {
            txtError3Batch.Enabled = chBoxError3.Checked;
        }

        private void btnKaydetIni_Click(object sender, EventArgs e)
        {
            if (txtINIdosya.Text != "")
            {
                INIKaydet ini = new INIKaydet(txtINIdosya.Text);  // @"\Programlama.ini"
                ini.Yaz("barcodeNum", "Metin Kutusu", Convert.ToString(barcodeNum.Text));

                ini.Yaz("step1job", "Metin Kutusu", Convert.ToString(step1Job.Text));
                ini.Yaz("step2job", "Metin Kutusu", Convert.ToString(step2Job.Text));
                ini.Yaz("step3job", "Metin Kutusu", Convert.ToString(step3Job.Text));
                ini.Yaz("step4job", "Metin Kutusu", Convert.ToString(step4Job.Text));
                ini.Yaz("step5job", "Metin Kutusu", Convert.ToString(step5Job.Text));
                ini.Yaz("step6job", "Metin Kutusu", Convert.ToString(step6Job.Text));
                ini.Yaz("step7job", "Metin Kutusu", Convert.ToString(step7Job.Text));
                ini.Yaz("step8job", "Metin Kutusu", Convert.ToString(step8Job.Text));
                ini.Yaz("step9job", "Metin Kutusu", Convert.ToString(step9Job.Text));
                ini.Yaz("step10job", "Metin Kutusu", Convert.ToString(step10Job.Text));
                ini.Yaz("step11job", "Metin Kutusu", Convert.ToString(step11Job.Text));
                ini.Yaz("step12job", "Metin Kutusu", Convert.ToString(step12Job.Text));
                ini.Yaz("step13job", "Metin Kutusu", Convert.ToString(step13Job.Text));
                ini.Yaz("step14job", "Metin Kutusu", Convert.ToString(step14Job.Text));
                ini.Yaz("step15job", "Metin Kutusu", Convert.ToString(step15Job.Text));
                ini.Yaz("step16job", "Metin Kutusu", Convert.ToString(step16Job.Text));
                ini.Yaz("step17job", "Metin Kutusu", Convert.ToString(step17Job.Text));
                ini.Yaz("step18job", "Metin Kutusu", Convert.ToString(step18Job.Text));
                ini.Yaz("step19job", "Metin Kutusu", Convert.ToString(step19Job.Text));
                ini.Yaz("step20job", "Metin Kutusu", Convert.ToString(step20Job.Text));

                ini.Yaz("barcode1", "Metin Kutusu", Convert.ToString(barcode1.Text));
                ini.Yaz("barcode2", "Metin Kutusu", Convert.ToString(barcode2.Text));
                ini.Yaz("barcode3", "Metin Kutusu", Convert.ToString(barcode3.Text));
                ini.Yaz("barcode4", "Metin Kutusu", Convert.ToString(barcode4.Text));
                ini.Yaz("barcode5", "Metin Kutusu", Convert.ToString(barcode5.Text));
                ini.Yaz("barcode6", "Metin Kutusu", Convert.ToString(barcode6.Text));
                ini.Yaz("barcode7", "Metin Kutusu", Convert.ToString(barcode7.Text));
                ini.Yaz("barcode8", "Metin Kutusu", Convert.ToString(barcode8.Text));
                ini.Yaz("barcode9", "Metin Kutusu", Convert.ToString(barcode9.Text));
                ini.Yaz("barcode10", "Metin Kutusu", Convert.ToString(barcode10.Text));
                ini.Yaz("barcode11", "Metin Kutusu", Convert.ToString(barcode11.Text));
                ini.Yaz("barcode12", "Metin Kutusu", Convert.ToString(barcode12.Text));
                ini.Yaz("barcode13", "Metin Kutusu", Convert.ToString(barcode13.Text));
                ini.Yaz("barcode14", "Metin Kutusu", Convert.ToString(barcode14.Text));
                ini.Yaz("barcode15", "Metin Kutusu", Convert.ToString(barcode15.Text));
                ini.Yaz("barcode16", "Metin Kutusu", Convert.ToString(barcode16.Text));
                ini.Yaz("barcode17", "Metin Kutusu", Convert.ToString(barcode17.Text));
                ini.Yaz("barcode18", "Metin Kutusu", Convert.ToString(barcode18.Text));
                ini.Yaz("barcode19", "Metin Kutusu", Convert.ToString(barcode19.Text));
                ini.Yaz("barcode20", "Metin Kutusu", Convert.ToString(barcode20.Text));

                ini.Yaz("Sbarcode1", "Metin Kutusu", Convert.ToString(Sbarcode1.Text));
                ini.Yaz("Sbarcode2", "Metin Kutusu", Convert.ToString(Sbarcode2.Text));
                ini.Yaz("Sbarcode3", "Metin Kutusu", Convert.ToString(Sbarcode3.Text));
                ini.Yaz("Sbarcode4", "Metin Kutusu", Convert.ToString(Sbarcode4.Text));
                ini.Yaz("Sbarcode5", "Metin Kutusu", Convert.ToString(Sbarcode5.Text));
                ini.Yaz("Sbarcode6", "Metin Kutusu", Convert.ToString(Sbarcode6.Text));
                ini.Yaz("Sbarcode7", "Metin Kutusu", Convert.ToString(Sbarcode7.Text));
                ini.Yaz("Sbarcode8", "Metin Kutusu", Convert.ToString(Sbarcode8.Text));
                ini.Yaz("Sbarcode9", "Metin Kutusu", Convert.ToString(Sbarcode9.Text));
                ini.Yaz("Sbarcode10", "Metin Kutusu", Convert.ToString(Sbarcode10.Text));
                ini.Yaz("Sbarcode11", "Metin Kutusu", Convert.ToString(Sbarcode11.Text));
                ini.Yaz("Sbarcode12", "Metin Kutusu", Convert.ToString(Sbarcode12.Text));
                ini.Yaz("Sbarcode13", "Metin Kutusu", Convert.ToString(Sbarcode13.Text));
                ini.Yaz("Sbarcode14", "Metin Kutusu", Convert.ToString(Sbarcode14.Text));
                ini.Yaz("Sbarcode15", "Metin Kutusu", Convert.ToString(Sbarcode15.Text));
                ini.Yaz("Sbarcode16", "Metin Kutusu", Convert.ToString(Sbarcode16.Text));
                ini.Yaz("Sbarcode17", "Metin Kutusu", Convert.ToString(Sbarcode17.Text));
                ini.Yaz("Sbarcode18", "Metin Kutusu", Convert.ToString(Sbarcode18.Text));
                ini.Yaz("Sbarcode19", "Metin Kutusu", Convert.ToString(Sbarcode19.Text));
                ini.Yaz("Sbarcode20", "Metin Kutusu", Convert.ToString(Sbarcode20.Text));

                ini.Yaz("batchDosya", "Metin Kutusu", Convert.ToString(txtBatchDosya.Text));
                ini.Yaz("companyNo", "Metin Kutusu", Convert.ToString(companyNo.Text));
                ini.Yaz("productNo", "Metin Kutusu", Convert.ToString(productNo.Text));
                ini.Yaz("SAPNo", "Metin Kutusu", Convert.ToString(SAPNo.Text));
                ini.Yaz("cardNo", "Metin Kutusu", Convert.ToString(cardNo.Text));
                ini.Yaz("gerberVer", "Metin Kutusu", Convert.ToString(gerberVer.Text));
                ini.Yaz("BOMVer", "Metin Kutusu", Convert.ToString(BOMVer.Text));
                ini.Yaz("ICTRev", "Metin Kutusu", Convert.ToString(ICTRev.Text));
                ini.Yaz("FCTRev", "Metin Kutusu", Convert.ToString(FCTRev.Text));
                ini.Yaz("softwareVer", "Metin Kutusu", Convert.ToString(softwareVer.Text));
                ini.Yaz("softwareRev", "Metin Kutusu", Convert.ToString(softwareRev.Text));

                ini.Yaz("successChecked", "Metin Kutusu", Convert.ToString(chBoxSuccess.Checked));
                ini.Yaz("error1Checked", "Metin Kutusu", Convert.ToString(chBoxError1.Checked));
                ini.Yaz("error2Checked", "Metin Kutusu", Convert.ToString(chBoxError2.Checked));
                ini.Yaz("error3Checked", "Metin Kutusu", Convert.ToString(chBoxError3.Checked));
                ini.Yaz("successBatch", "Metin Kutusu", Convert.ToString(txtSuccessBatch.Text));
                ini.Yaz("error1Batch", "Metin Kutusu", Convert.ToString(txtError1Batch.Text));
                ini.Yaz("error2Batch", "Metin Kutusu", Convert.ToString(txtError2Batch.Text));
                ini.Yaz("error3Batch", "Metin Kutusu", Convert.ToString(txtError3Batch.Text));

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
                        barcodeNum.Text = ini.Oku("barcodeNum", "Metin Kutusu");

                        step1Job.Text = ini.Oku("step1job", "Metin Kutusu");
                        step2Job.Text = ini.Oku("step2job", "Metin Kutusu");
                        step3Job.Text = ini.Oku("step3job", "Metin Kutusu");
                        step4Job.Text = ini.Oku("step4job", "Metin Kutusu");
                        step5Job.Text = ini.Oku("step5job", "Metin Kutusu");
                        step6Job.Text = ini.Oku("step6job", "Metin Kutusu");
                        step7Job.Text = ini.Oku("step7job", "Metin Kutusu");
                        step8Job.Text = ini.Oku("step8job", "Metin Kutusu");
                        step9Job.Text = ini.Oku("step9job", "Metin Kutusu");
                        step10Job.Text = ini.Oku("step10job", "Metin Kutusu");
                        step11Job.Text = ini.Oku("step11job", "Metin Kutusu");
                        step12Job.Text = ini.Oku("step12job", "Metin Kutusu");
                        step13Job.Text = ini.Oku("step13job", "Metin Kutusu");
                        step14Job.Text = ini.Oku("step14job", "Metin Kutusu");
                        step15Job.Text = ini.Oku("step15job", "Metin Kutusu");
                        step16Job.Text = ini.Oku("step16job", "Metin Kutusu");
                        step17Job.Text = ini.Oku("step17job", "Metin Kutusu");
                        step18Job.Text = ini.Oku("step18job", "Metin Kutusu");
                        step19Job.Text = ini.Oku("step19job", "Metin Kutusu");
                        step20Job.Text = ini.Oku("step20job", "Metin Kutusu");

                        barcode1.Text = ini.Oku("barcode1", "Metin Kutusu");
                        barcode2.Text = ini.Oku("barcode2", "Metin Kutusu");
                        barcode3.Text = ini.Oku("barcode3", "Metin Kutusu");
                        barcode4.Text = ini.Oku("barcode4", "Metin Kutusu");
                        barcode5.Text = ini.Oku("barcode5", "Metin Kutusu");
                        barcode6.Text = ini.Oku("barcode6", "Metin Kutusu");
                        barcode7.Text = ini.Oku("barcode7", "Metin Kutusu");
                        barcode8.Text = ini.Oku("barcode8", "Metin Kutusu");
                        barcode9.Text = ini.Oku("barcode9", "Metin Kutusu");
                        barcode10.Text = ini.Oku("barcode10", "Metin Kutusu");
                        barcode11.Text = ini.Oku("barcode11", "Metin Kutusu");
                        barcode12.Text = ini.Oku("barcode12", "Metin Kutusu");
                        barcode13.Text = ini.Oku("barcode13", "Metin Kutusu");
                        barcode14.Text = ini.Oku("barcode14", "Metin Kutusu");
                        barcode15.Text = ini.Oku("barcode15", "Metin Kutusu");
                        barcode16.Text = ini.Oku("barcode16", "Metin Kutusu");
                        barcode17.Text = ini.Oku("barcode17", "Metin Kutusu");
                        barcode18.Text = ini.Oku("barcode18", "Metin Kutusu");
                        barcode19.Text = ini.Oku("barcode19", "Metin Kutusu");
                        barcode20.Text = ini.Oku("barcode20", "Metin Kutusu");

                        Sbarcode1.Text = ini.Oku("Sbarcode1", "Metin Kutusu");
                        Sbarcode2.Text = ini.Oku("Sbarcode2", "Metin Kutusu");
                        Sbarcode3.Text = ini.Oku("Sbarcode3", "Metin Kutusu");
                        Sbarcode4.Text = ini.Oku("Sbarcode4", "Metin Kutusu");
                        Sbarcode5.Text = ini.Oku("Sbarcode5", "Metin Kutusu");
                        Sbarcode6.Text = ini.Oku("Sbarcode6", "Metin Kutusu");
                        Sbarcode7.Text = ini.Oku("Sbarcode7", "Metin Kutusu");
                        Sbarcode8.Text = ini.Oku("Sbarcode8", "Metin Kutusu");
                        Sbarcode9.Text = ini.Oku("Sbarcode9", "Metin Kutusu");
                        Sbarcode10.Text = ini.Oku("Sbarcode10", "Metin Kutusu");
                        Sbarcode11.Text = ini.Oku("Sbarcode11", "Metin Kutusu");
                        Sbarcode12.Text = ini.Oku("Sbarcode12", "Metin Kutusu");
                        Sbarcode13.Text = ini.Oku("Sbarcode13", "Metin Kutusu");
                        Sbarcode14.Text = ini.Oku("Sbarcode14", "Metin Kutusu");
                        Sbarcode15.Text = ini.Oku("Sbarcode15", "Metin Kutusu");
                        Sbarcode16.Text = ini.Oku("Sbarcode16", "Metin Kutusu");
                        Sbarcode17.Text = ini.Oku("Sbarcode17", "Metin Kutusu");
                        Sbarcode18.Text = ini.Oku("Sbarcode18", "Metin Kutusu");
                        Sbarcode19.Text = ini.Oku("Sbarcode19", "Metin Kutusu");
                        Sbarcode20.Text = ini.Oku("Sbarcode20", "Metin Kutusu");

                        txtBatchDosya.Text = ini.Oku("batchDosya", "Metin Kutusu");
                        companyNo.Text = ini.Oku("companyNo", "Metin Kutusu");
                        productNo.Text = ini.Oku("productNo", "Metin Kutusu");
                        SAPNo.Text = ini.Oku("SAPNo", "Metin Kutusu");
                        cardNo.Text = ini.Oku("cardNo", "Metin Kutusu");
                        gerberVer.Text = ini.Oku("gerberVer", "Metin Kutusu");
                        BOMVer.Text = ini.Oku("BOMVer", "Metin Kutusu");
                        ICTRev.Text = ini.Oku("ICTRev", "Metin Kutusu");
                        FCTRev.Text = ini.Oku("FCTRev", "Metin Kutusu");
                        softwareVer.Text = ini.Oku("softwareVer", "Metin Kutusu");
                        softwareRev.Text = ini.Oku("softwareRev", "Metin Kutusu");

                        if (ini.Oku("successChecked", "Metin Kutusu") == "True")
                            chBoxSuccess.Checked = true;
                        else if (ini.Oku("successChecked", "Metin Kutusu") == "False")
                            chBoxSuccess.Checked = false;

                        if (ini.Oku("error1Checked", "Metin Kutusu") == "True")
                            chBoxError1.Checked = true;
                        else if (ini.Oku("error1Checked", "Metin Kutusu") == "False")
                            chBoxError1.Checked = false;

                        if (ini.Oku("error2Checked", "Metin Kutusu") == "True")
                            chBoxError2.Checked = true;
                        else if (ini.Oku("error2Checked", "Metin Kutusu") == "False")
                            chBoxError2.Checked = false;

                        if (ini.Oku("error3Checked", "Metin Kutusu") == "True")
                            chBoxError3.Checked = true;
                        else if (ini.Oku("error3Checked", "Metin Kutusu") == "False")
                            chBoxError3.Checked = false;

                        txtSuccessBatch.Text = ini.Oku("successBatch", "Metin Kutusu");
                        txtError1Batch.Text = ini.Oku("error1Batch", "Metin Kutusu");
                        txtError2Batch.Text = ini.Oku("error2Batch", "Metin Kutusu");
                        txtError3Batch.Text = ini.Oku("error3Batch", "Metin Kutusu");

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

        private void btnIDsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.ini";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtINIdosya.Text = openFileDialog.FileName;
        }

        private void btnLogsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Database Dosyaları|*.bat|Tüm Dosyalar|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtBatchDosya.Text = openFileDialog.FileName;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgAyarForm));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.barcodeNum = new System.Windows.Forms.ComboBox();
            this.barcode1 = new System.Windows.Forms.TextBox();
            this.barcode2 = new System.Windows.Forms.TextBox();
            this.barcode4 = new System.Windows.Forms.TextBox();
            this.barcode3 = new System.Windows.Forms.TextBox();
            this.barcode8 = new System.Windows.Forms.TextBox();
            this.barcode7 = new System.Windows.Forms.TextBox();
            this.barcode6 = new System.Windows.Forms.TextBox();
            this.barcode5 = new System.Windows.Forms.TextBox();
            this.barcode10 = new System.Windows.Forms.TextBox();
            this.barcode9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBatchDosya = new System.Windows.Forms.TextBox();
            this.btnLogsec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.barcode20 = new System.Windows.Forms.TextBox();
            this.barcode19 = new System.Windows.Forms.TextBox();
            this.barcode18 = new System.Windows.Forms.TextBox();
            this.barcode17 = new System.Windows.Forms.TextBox();
            this.barcode16 = new System.Windows.Forms.TextBox();
            this.barcode15 = new System.Windows.Forms.TextBox();
            this.barcode14 = new System.Windows.Forms.TextBox();
            this.barcode13 = new System.Windows.Forms.TextBox();
            this.barcode12 = new System.Windows.Forms.TextBox();
            this.barcode11 = new System.Windows.Forms.TextBox();
            this.companyNo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.SAPNo = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnINIsec = new System.Windows.Forms.Button();
            this.txtINIdosya = new System.Windows.Forms.TextBox();
            this.label220 = new System.Windows.Forms.Label();
            this.btnOkuIni = new System.Windows.Forms.Button();
            this.btnKaydetIni = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.softwareRev = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.FCTRev = new System.Windows.Forms.TextBox();
            this.softwareVer = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.BOMVer = new System.Windows.Forms.TextBox();
            this.ICTRev = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cardNo = new System.Windows.Forms.TextBox();
            this.gerberVer = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.step20Job = new System.Windows.Forms.ComboBox();
            this.label103 = new System.Windows.Forms.Label();
            this.step19Job = new System.Windows.Forms.ComboBox();
            this.label104 = new System.Windows.Forms.Label();
            this.step18Job = new System.Windows.Forms.ComboBox();
            this.label105 = new System.Windows.Forms.Label();
            this.step17Job = new System.Windows.Forms.ComboBox();
            this.label106 = new System.Windows.Forms.Label();
            this.step16Job = new System.Windows.Forms.ComboBox();
            this.label107 = new System.Windows.Forms.Label();
            this.step15Job = new System.Windows.Forms.ComboBox();
            this.label138 = new System.Windows.Forms.Label();
            this.step14Job = new System.Windows.Forms.ComboBox();
            this.label139 = new System.Windows.Forms.Label();
            this.step13Job = new System.Windows.Forms.ComboBox();
            this.label140 = new System.Windows.Forms.Label();
            this.step12Job = new System.Windows.Forms.ComboBox();
            this.label141 = new System.Windows.Forms.Label();
            this.step11Job = new System.Windows.Forms.ComboBox();
            this.label142 = new System.Windows.Forms.Label();
            this.step10Job = new System.Windows.Forms.ComboBox();
            this.label68 = new System.Windows.Forms.Label();
            this.step9Job = new System.Windows.Forms.ComboBox();
            this.label69 = new System.Windows.Forms.Label();
            this.step8Job = new System.Windows.Forms.ComboBox();
            this.label70 = new System.Windows.Forms.Label();
            this.step7Job = new System.Windows.Forms.ComboBox();
            this.label71 = new System.Windows.Forms.Label();
            this.step6Job = new System.Windows.Forms.ComboBox();
            this.label72 = new System.Windows.Forms.Label();
            this.step5Job = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.step4Job = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.step3Job = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.step2Job = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.step1Job = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.Sbarcode20 = new System.Windows.Forms.TextBox();
            this.Sbarcode19 = new System.Windows.Forms.TextBox();
            this.Sbarcode18 = new System.Windows.Forms.TextBox();
            this.Sbarcode17 = new System.Windows.Forms.TextBox();
            this.Sbarcode16 = new System.Windows.Forms.TextBox();
            this.Sbarcode15 = new System.Windows.Forms.TextBox();
            this.Sbarcode14 = new System.Windows.Forms.TextBox();
            this.Sbarcode13 = new System.Windows.Forms.TextBox();
            this.Sbarcode12 = new System.Windows.Forms.TextBox();
            this.Sbarcode11 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.Sbarcode10 = new System.Windows.Forms.TextBox();
            this.Sbarcode9 = new System.Windows.Forms.TextBox();
            this.Sbarcode8 = new System.Windows.Forms.TextBox();
            this.Sbarcode7 = new System.Windows.Forms.TextBox();
            this.Sbarcode6 = new System.Windows.Forms.TextBox();
            this.Sbarcode5 = new System.Windows.Forms.TextBox();
            this.Sbarcode4 = new System.Windows.Forms.TextBox();
            this.Sbarcode3 = new System.Windows.Forms.TextBox();
            this.Sbarcode2 = new System.Windows.Forms.TextBox();
            this.Sbarcode1 = new System.Windows.Forms.TextBox();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.chBoxSuccess = new System.Windows.Forms.CheckBox();
            this.chBoxError1 = new System.Windows.Forms.CheckBox();
            this.chBoxError2 = new System.Windows.Forms.CheckBox();
            this.chBoxError3 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtError3Batch = new System.Windows.Forms.TextBox();
            this.txtError2Batch = new System.Windows.Forms.TextBox();
            this.txtError1Batch = new System.Windows.Forms.TextBox();
            this.txtSuccessBatch = new System.Windows.Forms.TextBox();
            this.infoPicture4 = new System.Windows.Forms.PictureBox();
            this.infoPicture3 = new System.Windows.Forms.PictureBox();
            this.infoPicture2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productNo = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Aqua;
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(634, 679);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(379, 98);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Ayarları Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // barcodeNum
            // 
            this.barcodeNum.FormattingEnabled = true;
            this.barcodeNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.barcodeNum.Location = new System.Drawing.Point(249, 22);
            this.barcodeNum.Name = "barcodeNum";
            this.barcodeNum.Size = new System.Drawing.Size(115, 23);
            this.barcodeNum.TabIndex = 12;
            this.barcodeNum.SelectedIndexChanged += new System.EventHandler(this.barcodeNum_SelectedIndexChanged);
            // 
            // barcode1
            // 
            this.barcode1.Location = new System.Drawing.Point(249, 81);
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new System.Drawing.Size(115, 24);
            this.barcode1.TabIndex = 13;
            // 
            // barcode2
            // 
            this.barcode2.Location = new System.Drawing.Point(249, 116);
            this.barcode2.Name = "barcode2";
            this.barcode2.Size = new System.Drawing.Size(115, 24);
            this.barcode2.TabIndex = 14;
            // 
            // barcode4
            // 
            this.barcode4.Location = new System.Drawing.Point(249, 186);
            this.barcode4.Name = "barcode4";
            this.barcode4.Size = new System.Drawing.Size(115, 24);
            this.barcode4.TabIndex = 16;
            // 
            // barcode3
            // 
            this.barcode3.Location = new System.Drawing.Point(249, 151);
            this.barcode3.Name = "barcode3";
            this.barcode3.Size = new System.Drawing.Size(115, 24);
            this.barcode3.TabIndex = 15;
            // 
            // barcode8
            // 
            this.barcode8.Location = new System.Drawing.Point(249, 326);
            this.barcode8.Name = "barcode8";
            this.barcode8.Size = new System.Drawing.Size(115, 24);
            this.barcode8.TabIndex = 20;
            // 
            // barcode7
            // 
            this.barcode7.Location = new System.Drawing.Point(249, 291);
            this.barcode7.Name = "barcode7";
            this.barcode7.Size = new System.Drawing.Size(115, 24);
            this.barcode7.TabIndex = 19;
            // 
            // barcode6
            // 
            this.barcode6.Location = new System.Drawing.Point(249, 256);
            this.barcode6.Name = "barcode6";
            this.barcode6.Size = new System.Drawing.Size(115, 24);
            this.barcode6.TabIndex = 18;
            // 
            // barcode5
            // 
            this.barcode5.Location = new System.Drawing.Point(249, 221);
            this.barcode5.Name = "barcode5";
            this.barcode5.Size = new System.Drawing.Size(115, 24);
            this.barcode5.TabIndex = 17;
            // 
            // barcode10
            // 
            this.barcode10.Location = new System.Drawing.Point(249, 396);
            this.barcode10.Name = "barcode10";
            this.barcode10.Size = new System.Drawing.Size(115, 24);
            this.barcode10.TabIndex = 22;
            // 
            // barcode9
            // 
            this.barcode9.Location = new System.Drawing.Point(249, 361);
            this.barcode9.Name = "barcode9";
            this.barcode9.Size = new System.Drawing.Size(115, 24);
            this.barcode9.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Batch Dosya Yolu:";
            // 
            // txtBatchDosya
            // 
            this.txtBatchDosya.Location = new System.Drawing.Point(126, 22);
            this.txtBatchDosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBatchDosya.Name = "txtBatchDosya";
            this.txtBatchDosya.Size = new System.Drawing.Size(172, 24);
            this.txtBatchDosya.TabIndex = 1;
            // 
            // btnLogsec
            // 
            this.btnLogsec.BackColor = System.Drawing.Color.Aqua;
            this.btnLogsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogsec.Location = new System.Drawing.Point(306, 22);
            this.btnLogsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogsec.Name = "btnLogsec";
            this.btnLogsec.Size = new System.Drawing.Size(65, 24);
            this.btnLogsec.TabIndex = 2;
            this.btnLogsec.Text = "Seç";
            this.btnLogsec.UseVisualStyleBackColor = false;
            this.btnLogsec.Click += new System.EventHandler(this.btnLogsec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Barcode1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Barcode2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Barcode3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Barcode6:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Barcode5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Barcode4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Barcode9:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Barcode8:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Barcode7:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Barcode10:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Barcode Sayısı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 748);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 56;
            this.label13.Text = "Barcode20:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(168, 713);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 55;
            this.label14.Text = "Barcode19:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(168, 678);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 17);
            this.label15.TabIndex = 54;
            this.label15.Text = "Barcode18:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(168, 643);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 53;
            this.label16.Text = "Barcode17:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(168, 608);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 17);
            this.label17.TabIndex = 52;
            this.label17.Text = "Barcode16:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(168, 573);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 17);
            this.label18.TabIndex = 51;
            this.label18.Text = "Barcode15:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(168, 538);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 17);
            this.label19.TabIndex = 50;
            this.label19.Text = "Barcode14:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(168, 503);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 17);
            this.label20.TabIndex = 49;
            this.label20.Text = "Barcode13:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(168, 468);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 17);
            this.label21.TabIndex = 48;
            this.label21.Text = "Barcode12:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(168, 433);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 17);
            this.label22.TabIndex = 47;
            this.label22.Text = "Barcode11:";
            // 
            // barcode20
            // 
            this.barcode20.Location = new System.Drawing.Point(249, 746);
            this.barcode20.Name = "barcode20";
            this.barcode20.Size = new System.Drawing.Size(115, 24);
            this.barcode20.TabIndex = 46;
            // 
            // barcode19
            // 
            this.barcode19.Location = new System.Drawing.Point(249, 711);
            this.barcode19.Name = "barcode19";
            this.barcode19.Size = new System.Drawing.Size(115, 24);
            this.barcode19.TabIndex = 45;
            // 
            // barcode18
            // 
            this.barcode18.Location = new System.Drawing.Point(249, 676);
            this.barcode18.Name = "barcode18";
            this.barcode18.Size = new System.Drawing.Size(115, 24);
            this.barcode18.TabIndex = 44;
            // 
            // barcode17
            // 
            this.barcode17.Location = new System.Drawing.Point(249, 641);
            this.barcode17.Name = "barcode17";
            this.barcode17.Size = new System.Drawing.Size(115, 24);
            this.barcode17.TabIndex = 43;
            // 
            // barcode16
            // 
            this.barcode16.Location = new System.Drawing.Point(249, 606);
            this.barcode16.Name = "barcode16";
            this.barcode16.Size = new System.Drawing.Size(115, 24);
            this.barcode16.TabIndex = 42;
            // 
            // barcode15
            // 
            this.barcode15.Location = new System.Drawing.Point(249, 571);
            this.barcode15.Name = "barcode15";
            this.barcode15.Size = new System.Drawing.Size(115, 24);
            this.barcode15.TabIndex = 41;
            // 
            // barcode14
            // 
            this.barcode14.Location = new System.Drawing.Point(249, 536);
            this.barcode14.Name = "barcode14";
            this.barcode14.Size = new System.Drawing.Size(115, 24);
            this.barcode14.TabIndex = 40;
            // 
            // barcode13
            // 
            this.barcode13.Location = new System.Drawing.Point(249, 501);
            this.barcode13.Name = "barcode13";
            this.barcode13.Size = new System.Drawing.Size(115, 24);
            this.barcode13.TabIndex = 39;
            // 
            // barcode12
            // 
            this.barcode12.Location = new System.Drawing.Point(249, 466);
            this.barcode12.Name = "barcode12";
            this.barcode12.Size = new System.Drawing.Size(115, 24);
            this.barcode12.TabIndex = 38;
            // 
            // barcode11
            // 
            this.barcode11.Location = new System.Drawing.Point(249, 431);
            this.barcode11.Name = "barcode11";
            this.barcode11.Size = new System.Drawing.Size(115, 24);
            this.barcode11.TabIndex = 37;
            // 
            // companyNo
            // 
            this.companyNo.Location = new System.Drawing.Point(125, 57);
            this.companyNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.companyNo.Name = "companyNo";
            this.companyNo.Size = new System.Drawing.Size(172, 24);
            this.companyNo.TabIndex = 58;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(30, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 17);
            this.label23.TabIndex = 57;
            this.label23.Text = "Company No:";
            // 
            // SAPNo
            // 
            this.SAPNo.Location = new System.Drawing.Point(125, 134);
            this.SAPNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SAPNo.Name = "SAPNo";
            this.SAPNo.Size = new System.Drawing.Size(172, 24);
            this.SAPNo.TabIndex = 60;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(58, 137);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 17);
            this.label28.TabIndex = 59;
            this.label28.Text = "SAP No:";
            // 
            // btnINIsec
            // 
            this.btnINIsec.BackColor = System.Drawing.Color.Aqua;
            this.btnINIsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnINIsec.Location = new System.Drawing.Point(306, 23);
            this.btnINIsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnINIsec.Name = "btnINIsec";
            this.btnINIsec.Size = new System.Drawing.Size(65, 24);
            this.btnINIsec.TabIndex = 587;
            this.btnINIsec.Text = "Seç";
            this.btnINIsec.UseVisualStyleBackColor = false;
            this.btnINIsec.Click += new System.EventHandler(this.btnIDsec_Click);
            // 
            // txtINIdosya
            // 
            this.txtINIdosya.Location = new System.Drawing.Point(131, 22);
            this.txtINIdosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtINIdosya.Name = "txtINIdosya";
            this.txtINIdosya.Size = new System.Drawing.Size(167, 24);
            this.txtINIdosya.TabIndex = 586;
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
            this.btnOkuIni.Location = new System.Drawing.Point(217, 55);
            this.btnOkuIni.Name = "btnOkuIni";
            this.btnOkuIni.Size = new System.Drawing.Size(80, 30);
            this.btnOkuIni.TabIndex = 584;
            this.btnOkuIni.Text = "Oku";
            this.btnOkuIni.UseVisualStyleBackColor = false;
            this.btnOkuIni.Click += new System.EventHandler(this.btnOkuIni_Click);
            // 
            // btnKaydetIni
            // 
            this.btnKaydetIni.BackColor = System.Drawing.Color.Aqua;
            this.btnKaydetIni.Location = new System.Drawing.Point(131, 55);
            this.btnKaydetIni.Name = "btnKaydetIni";
            this.btnKaydetIni.Size = new System.Drawing.Size(80, 30);
            this.btnKaydetIni.TabIndex = 583;
            this.btnKaydetIni.Text = "Kaydet";
            this.btnKaydetIni.UseVisualStyleBackColor = false;
            this.btnKaydetIni.Click += new System.EventHandler(this.btnKaydetIni_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label220);
            this.groupBox2.Controls.Add(this.btnOkuIni);
            this.groupBox2.Controls.Add(this.btnINIsec);
            this.groupBox2.Controls.Add(this.btnKaydetIni);
            this.groupBox2.Controls.Add(this.txtINIdosya);
            this.groupBox2.Location = new System.Drawing.Point(634, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 92);
            this.groupBox2.TabIndex = 588;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ini Dosyası Ayarları:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.productNo);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.softwareRev);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.FCTRev);
            this.groupBox3.Controls.Add(this.softwareVer);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.BOMVer);
            this.groupBox3.Controls.Add(this.ICTRev);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.cardNo);
            this.groupBox3.Controls.Add(this.gerberVer);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtBatchDosya);
            this.groupBox3.Controls.Add(this.btnLogsec);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.companyNo);
            this.groupBox3.Controls.Add(this.SAPNo);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Location = new System.Drawing.Point(634, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 441);
            this.groupBox3.TabIndex = 589;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proje Ayarları:";
            // 
            // softwareRev
            // 
            this.softwareRev.Location = new System.Drawing.Point(125, 389);
            this.softwareRev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.softwareRev.Name = "softwareRev";
            this.softwareRev.Size = new System.Drawing.Size(172, 24);
            this.softwareRev.TabIndex = 74;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(14, 392);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(87, 17);
            this.label31.TabIndex = 73;
            this.label31.Text = "Software Rev:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(46, 320);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 17);
            this.label29.TabIndex = 69;
            this.label29.Text = "FCT Rev:";
            // 
            // FCTRev
            // 
            this.FCTRev.Location = new System.Drawing.Point(125, 317);
            this.FCTRev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FCTRev.Name = "FCTRev";
            this.FCTRev.Size = new System.Drawing.Size(172, 24);
            this.FCTRev.TabIndex = 70;
            // 
            // softwareVer
            // 
            this.softwareVer.Location = new System.Drawing.Point(125, 353);
            this.softwareVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.softwareVer.Name = "softwareVer";
            this.softwareVer.Size = new System.Drawing.Size(172, 24);
            this.softwareVer.TabIndex = 72;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(17, 356);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(85, 17);
            this.label30.TabIndex = 71;
            this.label30.Text = "Software Ver:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(43, 247);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 17);
            this.label26.TabIndex = 65;
            this.label26.Text = "BOM Ver:";
            // 
            // BOMVer
            // 
            this.BOMVer.Location = new System.Drawing.Point(125, 244);
            this.BOMVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BOMVer.Name = "BOMVer";
            this.BOMVer.Size = new System.Drawing.Size(172, 24);
            this.BOMVer.TabIndex = 66;
            // 
            // ICTRev
            // 
            this.ICTRev.Location = new System.Drawing.Point(125, 280);
            this.ICTRev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ICTRev.Name = "ICTRev";
            this.ICTRev.Size = new System.Drawing.Size(172, 24);
            this.ICTRev.TabIndex = 68;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(51, 283);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 17);
            this.label27.TabIndex = 67;
            this.label27.Text = "ICT Rev:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(51, 175);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 17);
            this.label24.TabIndex = 61;
            this.label24.Text = "Card No:";
            // 
            // cardNo
            // 
            this.cardNo.Location = new System.Drawing.Point(125, 172);
            this.cardNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardNo.Name = "cardNo";
            this.cardNo.Size = new System.Drawing.Size(172, 24);
            this.cardNo.TabIndex = 62;
            // 
            // gerberVer
            // 
            this.gerberVer.Location = new System.Drawing.Point(125, 208);
            this.gerberVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gerberVer.Name = "gerberVer";
            this.gerberVer.Size = new System.Drawing.Size(172, 24);
            this.gerberVer.TabIndex = 64;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(35, 211);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 17);
            this.label25.TabIndex = 63;
            this.label25.Text = "Gerber Ver:";
            // 
            // step20Job
            // 
            this.step20Job.FormattingEnabled = true;
            this.step20Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step20Job.Location = new System.Drawing.Point(74, 746);
            this.step20Job.Name = "step20Job";
            this.step20Job.Size = new System.Drawing.Size(58, 23);
            this.step20Job.TabIndex = 629;
            this.step20Job.SelectedIndexChanged += new System.EventHandler(this.step20Job_SelectedIndexChanged);
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(13, 748);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(51, 17);
            this.label103.TabIndex = 628;
            this.label103.Text = "Step20:";
            // 
            // step19Job
            // 
            this.step19Job.FormattingEnabled = true;
            this.step19Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step19Job.Location = new System.Drawing.Point(74, 711);
            this.step19Job.Name = "step19Job";
            this.step19Job.Size = new System.Drawing.Size(58, 23);
            this.step19Job.TabIndex = 627;
            this.step19Job.SelectedIndexChanged += new System.EventHandler(this.step19Job_SelectedIndexChanged);
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(13, 713);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(51, 17);
            this.label104.TabIndex = 626;
            this.label104.Text = "Step19:";
            // 
            // step18Job
            // 
            this.step18Job.FormattingEnabled = true;
            this.step18Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step18Job.Location = new System.Drawing.Point(74, 676);
            this.step18Job.Name = "step18Job";
            this.step18Job.Size = new System.Drawing.Size(58, 23);
            this.step18Job.TabIndex = 625;
            this.step18Job.SelectedIndexChanged += new System.EventHandler(this.step18Job_SelectedIndexChanged);
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(13, 678);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(51, 17);
            this.label105.TabIndex = 624;
            this.label105.Text = "Step18:";
            // 
            // step17Job
            // 
            this.step17Job.FormattingEnabled = true;
            this.step17Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step17Job.Location = new System.Drawing.Point(74, 641);
            this.step17Job.Name = "step17Job";
            this.step17Job.Size = new System.Drawing.Size(58, 23);
            this.step17Job.TabIndex = 623;
            this.step17Job.SelectedIndexChanged += new System.EventHandler(this.step17Job_SelectedIndexChanged);
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(13, 643);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(51, 17);
            this.label106.TabIndex = 622;
            this.label106.Text = "Step17:";
            // 
            // step16Job
            // 
            this.step16Job.FormattingEnabled = true;
            this.step16Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step16Job.Location = new System.Drawing.Point(74, 606);
            this.step16Job.Name = "step16Job";
            this.step16Job.Size = new System.Drawing.Size(58, 23);
            this.step16Job.TabIndex = 621;
            this.step16Job.SelectedIndexChanged += new System.EventHandler(this.step16Job_SelectedIndexChanged);
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(13, 608);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(51, 17);
            this.label107.TabIndex = 620;
            this.label107.Text = "Step16:";
            // 
            // step15Job
            // 
            this.step15Job.FormattingEnabled = true;
            this.step15Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step15Job.Location = new System.Drawing.Point(74, 571);
            this.step15Job.Name = "step15Job";
            this.step15Job.Size = new System.Drawing.Size(58, 23);
            this.step15Job.TabIndex = 619;
            this.step15Job.SelectedIndexChanged += new System.EventHandler(this.step15Job_SelectedIndexChanged);
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(13, 573);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(51, 17);
            this.label138.TabIndex = 618;
            this.label138.Text = "Step15:";
            // 
            // step14Job
            // 
            this.step14Job.FormattingEnabled = true;
            this.step14Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step14Job.Location = new System.Drawing.Point(74, 536);
            this.step14Job.Name = "step14Job";
            this.step14Job.Size = new System.Drawing.Size(58, 23);
            this.step14Job.TabIndex = 617;
            this.step14Job.SelectedIndexChanged += new System.EventHandler(this.step14Job_SelectedIndexChanged);
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(13, 538);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(51, 17);
            this.label139.TabIndex = 616;
            this.label139.Text = "Step14:";
            // 
            // step13Job
            // 
            this.step13Job.FormattingEnabled = true;
            this.step13Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step13Job.Location = new System.Drawing.Point(74, 501);
            this.step13Job.Name = "step13Job";
            this.step13Job.Size = new System.Drawing.Size(58, 23);
            this.step13Job.TabIndex = 615;
            this.step13Job.SelectedIndexChanged += new System.EventHandler(this.step13Job_SelectedIndexChanged);
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(13, 503);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(51, 17);
            this.label140.TabIndex = 614;
            this.label140.Text = "Step13:";
            // 
            // step12Job
            // 
            this.step12Job.FormattingEnabled = true;
            this.step12Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step12Job.Location = new System.Drawing.Point(74, 466);
            this.step12Job.Name = "step12Job";
            this.step12Job.Size = new System.Drawing.Size(58, 23);
            this.step12Job.TabIndex = 613;
            this.step12Job.SelectedIndexChanged += new System.EventHandler(this.step12Job_SelectedIndexChanged);
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(13, 468);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(51, 17);
            this.label141.TabIndex = 612;
            this.label141.Text = "Step12:";
            // 
            // step11Job
            // 
            this.step11Job.FormattingEnabled = true;
            this.step11Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step11Job.Location = new System.Drawing.Point(74, 431);
            this.step11Job.Name = "step11Job";
            this.step11Job.Size = new System.Drawing.Size(58, 23);
            this.step11Job.TabIndex = 611;
            this.step11Job.SelectedIndexChanged += new System.EventHandler(this.step11Job_SelectedIndexChanged);
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(13, 433);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(51, 17);
            this.label142.TabIndex = 610;
            this.label142.Text = "Step11:";
            // 
            // step10Job
            // 
            this.step10Job.FormattingEnabled = true;
            this.step10Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step10Job.Location = new System.Drawing.Point(74, 396);
            this.step10Job.Name = "step10Job";
            this.step10Job.Size = new System.Drawing.Size(58, 23);
            this.step10Job.TabIndex = 609;
            this.step10Job.SelectedIndexChanged += new System.EventHandler(this.step10Job_SelectedIndexChanged);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(13, 398);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(51, 17);
            this.label68.TabIndex = 608;
            this.label68.Text = "Step10:";
            // 
            // step9Job
            // 
            this.step9Job.FormattingEnabled = true;
            this.step9Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step9Job.Location = new System.Drawing.Point(74, 361);
            this.step9Job.Name = "step9Job";
            this.step9Job.Size = new System.Drawing.Size(58, 23);
            this.step9Job.TabIndex = 607;
            this.step9Job.SelectedIndexChanged += new System.EventHandler(this.step9Job_SelectedIndexChanged);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(13, 363);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(44, 17);
            this.label69.TabIndex = 606;
            this.label69.Text = "Step9:";
            // 
            // step8Job
            // 
            this.step8Job.FormattingEnabled = true;
            this.step8Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step8Job.Location = new System.Drawing.Point(74, 326);
            this.step8Job.Name = "step8Job";
            this.step8Job.Size = new System.Drawing.Size(58, 23);
            this.step8Job.TabIndex = 605;
            this.step8Job.SelectedIndexChanged += new System.EventHandler(this.step8Job_SelectedIndexChanged);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(13, 328);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(44, 17);
            this.label70.TabIndex = 604;
            this.label70.Text = "Step8:";
            // 
            // step7Job
            // 
            this.step7Job.FormattingEnabled = true;
            this.step7Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step7Job.Location = new System.Drawing.Point(74, 291);
            this.step7Job.Name = "step7Job";
            this.step7Job.Size = new System.Drawing.Size(58, 23);
            this.step7Job.TabIndex = 603;
            this.step7Job.SelectedIndexChanged += new System.EventHandler(this.step7Job_SelectedIndexChanged);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(13, 293);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(44, 17);
            this.label71.TabIndex = 602;
            this.label71.Text = "Step7:";
            // 
            // step6Job
            // 
            this.step6Job.FormattingEnabled = true;
            this.step6Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step6Job.Location = new System.Drawing.Point(74, 256);
            this.step6Job.Name = "step6Job";
            this.step6Job.Size = new System.Drawing.Size(58, 23);
            this.step6Job.TabIndex = 601;
            this.step6Job.SelectedIndexChanged += new System.EventHandler(this.step6Job_SelectedIndexChanged);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(13, 258);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(44, 17);
            this.label72.TabIndex = 600;
            this.label72.Text = "Step6:";
            // 
            // step5Job
            // 
            this.step5Job.FormattingEnabled = true;
            this.step5Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step5Job.Location = new System.Drawing.Point(74, 221);
            this.step5Job.Name = "step5Job";
            this.step5Job.Size = new System.Drawing.Size(58, 23);
            this.step5Job.TabIndex = 599;
            this.step5Job.SelectedIndexChanged += new System.EventHandler(this.step5Job_SelectedIndexChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(13, 223);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(44, 17);
            this.label37.TabIndex = 598;
            this.label37.Text = "Step5:";
            // 
            // step4Job
            // 
            this.step4Job.FormattingEnabled = true;
            this.step4Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step4Job.Location = new System.Drawing.Point(74, 186);
            this.step4Job.Name = "step4Job";
            this.step4Job.Size = new System.Drawing.Size(58, 23);
            this.step4Job.TabIndex = 597;
            this.step4Job.SelectedIndexChanged += new System.EventHandler(this.step4Job_SelectedIndexChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(13, 188);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(44, 17);
            this.label38.TabIndex = 596;
            this.label38.Text = "Step4:";
            // 
            // step3Job
            // 
            this.step3Job.FormattingEnabled = true;
            this.step3Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step3Job.Location = new System.Drawing.Point(74, 151);
            this.step3Job.Name = "step3Job";
            this.step3Job.Size = new System.Drawing.Size(58, 23);
            this.step3Job.TabIndex = 595;
            this.step3Job.SelectedIndexChanged += new System.EventHandler(this.step3Job_SelectedIndexChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(13, 153);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 17);
            this.label39.TabIndex = 594;
            this.label39.Text = "Step3:";
            // 
            // step2Job
            // 
            this.step2Job.FormattingEnabled = true;
            this.step2Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step2Job.Location = new System.Drawing.Point(74, 116);
            this.step2Job.Name = "step2Job";
            this.step2Job.Size = new System.Drawing.Size(58, 23);
            this.step2Job.TabIndex = 593;
            this.step2Job.SelectedIndexChanged += new System.EventHandler(this.step2Job_SelectedIndexChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(13, 118);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(44, 17);
            this.label40.TabIndex = 592;
            this.label40.Text = "Step2:";
            // 
            // step1Job
            // 
            this.step1Job.FormattingEnabled = true;
            this.step1Job.Items.AddRange(new object[] {
            "1",
            "2"});
            this.step1Job.Location = new System.Drawing.Point(74, 81);
            this.step1Job.Name = "step1Job";
            this.step1Job.Size = new System.Drawing.Size(58, 23);
            this.step1Job.TabIndex = 591;
            this.step1Job.SelectedIndexChanged += new System.EventHandler(this.step1Job_SelectedIndexChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(13, 83);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(44, 17);
            this.label41.TabIndex = 590;
            this.label41.Text = "Step1:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(390, 748);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(73, 17);
            this.label42.TabIndex = 670;
            this.label42.Text = "Barcode20:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(390, 713);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(73, 17);
            this.label43.TabIndex = 669;
            this.label43.Text = "Barcode19:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(390, 678);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(73, 17);
            this.label44.TabIndex = 668;
            this.label44.Text = "Barcode18:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(390, 643);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(73, 17);
            this.label45.TabIndex = 667;
            this.label45.Text = "Barcode17:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(390, 608);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(73, 17);
            this.label46.TabIndex = 666;
            this.label46.Text = "Barcode16:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(390, 573);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(73, 17);
            this.label47.TabIndex = 665;
            this.label47.Text = "Barcode15:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(390, 538);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(73, 17);
            this.label48.TabIndex = 664;
            this.label48.Text = "Barcode14:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(390, 503);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(73, 17);
            this.label49.TabIndex = 663;
            this.label49.Text = "Barcode13:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(390, 468);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(73, 17);
            this.label50.TabIndex = 662;
            this.label50.Text = "Barcode12:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(390, 433);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(73, 17);
            this.label51.TabIndex = 661;
            this.label51.Text = "Barcode11:";
            // 
            // Sbarcode20
            // 
            this.Sbarcode20.Location = new System.Drawing.Point(471, 746);
            this.Sbarcode20.Name = "Sbarcode20";
            this.Sbarcode20.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode20.TabIndex = 660;
            // 
            // Sbarcode19
            // 
            this.Sbarcode19.Location = new System.Drawing.Point(471, 711);
            this.Sbarcode19.Name = "Sbarcode19";
            this.Sbarcode19.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode19.TabIndex = 659;
            // 
            // Sbarcode18
            // 
            this.Sbarcode18.Location = new System.Drawing.Point(471, 676);
            this.Sbarcode18.Name = "Sbarcode18";
            this.Sbarcode18.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode18.TabIndex = 658;
            // 
            // Sbarcode17
            // 
            this.Sbarcode17.Location = new System.Drawing.Point(471, 641);
            this.Sbarcode17.Name = "Sbarcode17";
            this.Sbarcode17.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode17.TabIndex = 657;
            // 
            // Sbarcode16
            // 
            this.Sbarcode16.Location = new System.Drawing.Point(471, 606);
            this.Sbarcode16.Name = "Sbarcode16";
            this.Sbarcode16.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode16.TabIndex = 656;
            // 
            // Sbarcode15
            // 
            this.Sbarcode15.Location = new System.Drawing.Point(471, 571);
            this.Sbarcode15.Name = "Sbarcode15";
            this.Sbarcode15.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode15.TabIndex = 655;
            // 
            // Sbarcode14
            // 
            this.Sbarcode14.Location = new System.Drawing.Point(471, 536);
            this.Sbarcode14.Name = "Sbarcode14";
            this.Sbarcode14.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode14.TabIndex = 654;
            // 
            // Sbarcode13
            // 
            this.Sbarcode13.Location = new System.Drawing.Point(471, 501);
            this.Sbarcode13.Name = "Sbarcode13";
            this.Sbarcode13.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode13.TabIndex = 653;
            // 
            // Sbarcode12
            // 
            this.Sbarcode12.Location = new System.Drawing.Point(471, 466);
            this.Sbarcode12.Name = "Sbarcode12";
            this.Sbarcode12.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode12.TabIndex = 652;
            // 
            // Sbarcode11
            // 
            this.Sbarcode11.Location = new System.Drawing.Point(471, 431);
            this.Sbarcode11.Name = "Sbarcode11";
            this.Sbarcode11.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode11.TabIndex = 651;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(390, 398);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(73, 17);
            this.label52.TabIndex = 650;
            this.label52.Text = "Barcode10:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(390, 363);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(66, 17);
            this.label53.TabIndex = 649;
            this.label53.Text = "Barcode9:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(390, 328);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(66, 17);
            this.label54.TabIndex = 648;
            this.label54.Text = "Barcode8:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(390, 293);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(66, 17);
            this.label55.TabIndex = 647;
            this.label55.Text = "Barcode7:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(390, 258);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(66, 17);
            this.label56.TabIndex = 646;
            this.label56.Text = "Barcode6:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(390, 223);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(66, 17);
            this.label57.TabIndex = 645;
            this.label57.Text = "Barcode5:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(390, 188);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(66, 17);
            this.label58.TabIndex = 644;
            this.label58.Text = "Barcode4:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(390, 153);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(66, 17);
            this.label59.TabIndex = 643;
            this.label59.Text = "Barcode3:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(390, 118);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(66, 17);
            this.label60.TabIndex = 642;
            this.label60.Text = "Barcode2:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(390, 83);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(66, 17);
            this.label61.TabIndex = 641;
            this.label61.Text = "Barcode1:";
            // 
            // Sbarcode10
            // 
            this.Sbarcode10.Location = new System.Drawing.Point(471, 396);
            this.Sbarcode10.Name = "Sbarcode10";
            this.Sbarcode10.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode10.TabIndex = 640;
            // 
            // Sbarcode9
            // 
            this.Sbarcode9.Location = new System.Drawing.Point(471, 361);
            this.Sbarcode9.Name = "Sbarcode9";
            this.Sbarcode9.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode9.TabIndex = 639;
            // 
            // Sbarcode8
            // 
            this.Sbarcode8.Location = new System.Drawing.Point(471, 326);
            this.Sbarcode8.Name = "Sbarcode8";
            this.Sbarcode8.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode8.TabIndex = 638;
            // 
            // Sbarcode7
            // 
            this.Sbarcode7.Location = new System.Drawing.Point(471, 291);
            this.Sbarcode7.Name = "Sbarcode7";
            this.Sbarcode7.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode7.TabIndex = 637;
            // 
            // Sbarcode6
            // 
            this.Sbarcode6.Location = new System.Drawing.Point(471, 256);
            this.Sbarcode6.Name = "Sbarcode6";
            this.Sbarcode6.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode6.TabIndex = 636;
            // 
            // Sbarcode5
            // 
            this.Sbarcode5.Location = new System.Drawing.Point(471, 221);
            this.Sbarcode5.Name = "Sbarcode5";
            this.Sbarcode5.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode5.TabIndex = 635;
            // 
            // Sbarcode4
            // 
            this.Sbarcode4.Location = new System.Drawing.Point(471, 186);
            this.Sbarcode4.Name = "Sbarcode4";
            this.Sbarcode4.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode4.TabIndex = 634;
            // 
            // Sbarcode3
            // 
            this.Sbarcode3.Location = new System.Drawing.Point(471, 151);
            this.Sbarcode3.Name = "Sbarcode3";
            this.Sbarcode3.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode3.TabIndex = 633;
            // 
            // Sbarcode2
            // 
            this.Sbarcode2.Location = new System.Drawing.Point(471, 116);
            this.Sbarcode2.Name = "Sbarcode2";
            this.Sbarcode2.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode2.TabIndex = 632;
            // 
            // Sbarcode1
            // 
            this.Sbarcode1.Location = new System.Drawing.Point(471, 81);
            this.Sbarcode1.Name = "Sbarcode1";
            this.Sbarcode1.Size = new System.Drawing.Size(115, 24);
            this.Sbarcode1.TabIndex = 631;
            // 
            // chBoxSuccess
            // 
            this.chBoxSuccess.AutoSize = true;
            this.chBoxSuccess.Location = new System.Drawing.Point(10, 18);
            this.chBoxSuccess.Name = "chBoxSuccess";
            this.chBoxSuccess.Size = new System.Drawing.Size(69, 21);
            this.chBoxSuccess.TabIndex = 673;
            this.chBoxSuccess.Text = "Success";
            this.chBoxSuccess.UseVisualStyleBackColor = true;
            this.chBoxSuccess.CheckedChanged += new System.EventHandler(this.chBoxSuccess_CheckedChanged);
            // 
            // chBoxError1
            // 
            this.chBoxError1.AutoSize = true;
            this.chBoxError1.Location = new System.Drawing.Point(10, 43);
            this.chBoxError1.Name = "chBoxError1";
            this.chBoxError1.Size = new System.Drawing.Size(63, 21);
            this.chBoxError1.TabIndex = 674;
            this.chBoxError1.Text = "Error1";
            this.chBoxError1.UseVisualStyleBackColor = true;
            this.chBoxError1.CheckedChanged += new System.EventHandler(this.chBoxError1_CheckedChanged);
            // 
            // chBoxError2
            // 
            this.chBoxError2.AutoSize = true;
            this.chBoxError2.Location = new System.Drawing.Point(10, 68);
            this.chBoxError2.Name = "chBoxError2";
            this.chBoxError2.Size = new System.Drawing.Size(63, 21);
            this.chBoxError2.TabIndex = 675;
            this.chBoxError2.Text = "Error2";
            this.chBoxError2.UseVisualStyleBackColor = true;
            this.chBoxError2.CheckedChanged += new System.EventHandler(this.chBoxError2_CheckedChanged);
            // 
            // chBoxError3
            // 
            this.chBoxError3.AutoSize = true;
            this.chBoxError3.Location = new System.Drawing.Point(10, 93);
            this.chBoxError3.Name = "chBoxError3";
            this.chBoxError3.Size = new System.Drawing.Size(63, 21);
            this.chBoxError3.TabIndex = 676;
            this.chBoxError3.Text = "Error3";
            this.chBoxError3.UseVisualStyleBackColor = true;
            this.chBoxError3.CheckedChanged += new System.EventHandler(this.chBoxError3_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtError3Batch);
            this.groupBox4.Controls.Add(this.txtError2Batch);
            this.groupBox4.Controls.Add(this.txtError1Batch);
            this.groupBox4.Controls.Add(this.txtSuccessBatch);
            this.groupBox4.Controls.Add(this.chBoxError3);
            this.groupBox4.Controls.Add(this.chBoxSuccess);
            this.groupBox4.Controls.Add(this.chBoxError2);
            this.groupBox4.Controls.Add(this.chBoxError1);
            this.groupBox4.Location = new System.Drawing.Point(634, 548);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 120);
            this.groupBox4.TabIndex = 677;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Batch Error Name";
            // 
            // txtError3Batch
            // 
            this.txtError3Batch.Location = new System.Drawing.Point(85, 90);
            this.txtError3Batch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError3Batch.Name = "txtError3Batch";
            this.txtError3Batch.Size = new System.Drawing.Size(283, 24);
            this.txtError3Batch.TabIndex = 680;
            // 
            // txtError2Batch
            // 
            this.txtError2Batch.Location = new System.Drawing.Point(85, 65);
            this.txtError2Batch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError2Batch.Name = "txtError2Batch";
            this.txtError2Batch.Size = new System.Drawing.Size(283, 24);
            this.txtError2Batch.TabIndex = 679;
            // 
            // txtError1Batch
            // 
            this.txtError1Batch.Location = new System.Drawing.Point(85, 40);
            this.txtError1Batch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError1Batch.Name = "txtError1Batch";
            this.txtError1Batch.Size = new System.Drawing.Size(283, 24);
            this.txtError1Batch.TabIndex = 678;
            // 
            // txtSuccessBatch
            // 
            this.txtSuccessBatch.Location = new System.Drawing.Point(85, 15);
            this.txtSuccessBatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuccessBatch.Name = "txtSuccessBatch";
            this.txtSuccessBatch.Size = new System.Drawing.Size(283, 24);
            this.txtSuccessBatch.TabIndex = 677;
            // 
            // infoPicture4
            // 
            this.infoPicture4.Image = ((System.Drawing.Image)(resources.GetObject("infoPicture4.Image")));
            this.infoPicture4.Location = new System.Drawing.Point(516, 61);
            this.infoPicture4.Name = "infoPicture4";
            this.infoPicture4.Size = new System.Drawing.Size(20, 20);
            this.infoPicture4.TabIndex = 672;
            this.infoPicture4.TabStop = false;
            // 
            // infoPicture3
            // 
            this.infoPicture3.Image = ((System.Drawing.Image)(resources.GetObject("infoPicture3.Image")));
            this.infoPicture3.Location = new System.Drawing.Point(296, 61);
            this.infoPicture3.Name = "infoPicture3";
            this.infoPicture3.Size = new System.Drawing.Size(20, 20);
            this.infoPicture3.TabIndex = 671;
            this.infoPicture3.TabStop = false;
            // 
            // infoPicture2
            // 
            this.infoPicture2.Image = ((System.Drawing.Image)(resources.GetObject("infoPicture2.Image")));
            this.infoPicture2.Location = new System.Drawing.Point(92, 61);
            this.infoPicture2.Name = "infoPicture2";
            this.infoPicture2.Size = new System.Drawing.Size(20, 20);
            this.infoPicture2.TabIndex = 630;
            this.infoPicture2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoPicture3);
            this.groupBox1.Controls.Add(this.barcode1);
            this.groupBox1.Controls.Add(this.infoPicture4);
            this.groupBox1.Controls.Add(this.barcode2);
            this.groupBox1.Controls.Add(this.barcode3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.barcodeNum);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.barcode4);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.barcode5);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.barcode6);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.barcode7);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.barcode8);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.barcode9);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.barcode10);
            this.groupBox1.Controls.Add(this.label49);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label51);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Sbarcode20);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Sbarcode19);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Sbarcode18);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Sbarcode17);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Sbarcode16);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Sbarcode15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Sbarcode14);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Sbarcode13);
            this.groupBox1.Controls.Add(this.barcode11);
            this.groupBox1.Controls.Add(this.Sbarcode12);
            this.groupBox1.Controls.Add(this.barcode12);
            this.groupBox1.Controls.Add(this.Sbarcode11);
            this.groupBox1.Controls.Add(this.barcode13);
            this.groupBox1.Controls.Add(this.label52);
            this.groupBox1.Controls.Add(this.barcode14);
            this.groupBox1.Controls.Add(this.label53);
            this.groupBox1.Controls.Add(this.barcode15);
            this.groupBox1.Controls.Add(this.label54);
            this.groupBox1.Controls.Add(this.barcode16);
            this.groupBox1.Controls.Add(this.label55);
            this.groupBox1.Controls.Add(this.barcode17);
            this.groupBox1.Controls.Add(this.label56);
            this.groupBox1.Controls.Add(this.barcode18);
            this.groupBox1.Controls.Add(this.label57);
            this.groupBox1.Controls.Add(this.barcode19);
            this.groupBox1.Controls.Add(this.label58);
            this.groupBox1.Controls.Add(this.barcode20);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label61);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.Sbarcode10);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.Sbarcode9);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.Sbarcode8);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.Sbarcode7);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.Sbarcode6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.Sbarcode5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Sbarcode4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Sbarcode3);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.Sbarcode2);
            this.groupBox1.Controls.Add(this.step1Job);
            this.groupBox1.Controls.Add(this.Sbarcode1);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.infoPicture2);
            this.groupBox1.Controls.Add(this.step2Job);
            this.groupBox1.Controls.Add(this.step20Job);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.label103);
            this.groupBox1.Controls.Add(this.step3Job);
            this.groupBox1.Controls.Add(this.step19Job);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.label104);
            this.groupBox1.Controls.Add(this.step4Job);
            this.groupBox1.Controls.Add(this.step18Job);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.label105);
            this.groupBox1.Controls.Add(this.step5Job);
            this.groupBox1.Controls.Add(this.step17Job);
            this.groupBox1.Controls.Add(this.label72);
            this.groupBox1.Controls.Add(this.label106);
            this.groupBox1.Controls.Add(this.step6Job);
            this.groupBox1.Controls.Add(this.step16Job);
            this.groupBox1.Controls.Add(this.label71);
            this.groupBox1.Controls.Add(this.label107);
            this.groupBox1.Controls.Add(this.step7Job);
            this.groupBox1.Controls.Add(this.step15Job);
            this.groupBox1.Controls.Add(this.label70);
            this.groupBox1.Controls.Add(this.label138);
            this.groupBox1.Controls.Add(this.step8Job);
            this.groupBox1.Controls.Add(this.step14Job);
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Controls.Add(this.label139);
            this.groupBox1.Controls.Add(this.step9Job);
            this.groupBox1.Controls.Add(this.step13Job);
            this.groupBox1.Controls.Add(this.label68);
            this.groupBox1.Controls.Add(this.label140);
            this.groupBox1.Controls.Add(this.step10Job);
            this.groupBox1.Controls.Add(this.step12Job);
            this.groupBox1.Controls.Add(this.label142);
            this.groupBox1.Controls.Add(this.label141);
            this.groupBox1.Controls.Add(this.step11Job);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 773);
            this.groupBox1.TabIndex = 678;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barkod Ayarları";
            // 
            // productNo
            // 
            this.productNo.Location = new System.Drawing.Point(125, 95);
            this.productNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productNo.Name = "productNo";
            this.productNo.Size = new System.Drawing.Size(172, 24);
            this.productNo.TabIndex = 76;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(38, 98);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(75, 17);
            this.label32.TabIndex = 75;
            this.label32.Text = "Product No:";
            // 
            // ProgAyarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1023, 777);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKaydet);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProgAyarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.AyarForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
