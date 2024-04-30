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
    public class ProcessForm
    {
        public Main MainFrm;
        public void ProcessStart(int stepState, int stepStateMax)
        {
            this.MainFrm.ConsoleNewLine();
            double value = stepState;
            this.MainFrm.progressBarFCT.Value = Convert.ToInt32(value / stepStateMax * 100);
            this.MainFrm.btnFCTInit.Text = System.Convert.ToString(stepState);

            switch (stepState)
            {
                case 1:
                    this.MainFrm.lblStep1.Text = "1     FCT PROGRAMLAMA";
                    break;

                case 2:
                    this.MainFrm.lblStep2.Text = "2     ANALOG ÖLÇÜM ";
                    break;

                case 3:
                    this.MainFrm.lblStep3.Text = "3     TÜM LEDLERİ YAK ";
                    break;

                case 4:
                    this.MainFrm.lblStep4.Text = "4     1 NOLU TUŞ TESTİ";
                    break;

                case 5:
                    this.MainFrm.lblStep5.Text = "5     P1 NOLU TUŞ TESTİ";
                    break;

                case 6:
                    this.MainFrm.lblStep6.Text = "6     P2 NOLU TUŞ TESTİ";
                    break;

                case 7:
                    this.MainFrm.lblStep7.Text = "7     P3 NOLU TUŞ TESTİ";
                    break;

                case 8:
                    this.MainFrm.lblStep8.Text = "8     P4 NOLU TUŞ TESTİ";
                    break;

                case 9:
                    this.MainFrm.lblStep9.Text = "9     P5 NOLU TUŞ TESTİ";
                    break;

                case 10:
                    this.MainFrm.lblStep10.Text = "10    P6 NOLU TUŞ TESTİ";
                    break;

                case 11:
                    this.MainFrm.lblStep11.Text = "11    F1 NOLU TUŞ TESTİ";
                    break;

                case 12:
                    this.MainFrm.lblStep12.Text = "12    F2 NOLU TUŞ TESTİ";
                    break;

                case 13:
                    this.MainFrm.lblStep13.Text = "13    F3 NOLU TUŞ TESTİ";
                    break;

                case 14:
                    this.MainFrm.lblStep14.Text = "14    F4 NOLU TUŞ TESTİ";
                    break;

                case 15:
                    this.MainFrm.lblStep15.Text = "15    F5 NOLU TUŞ TESTİ";
                    break;

                case 16:
                    this.MainFrm.lblStep16.Text = "16    F6 NOLU TUŞ TESTİ";
                    break;

                case 17:
                    this.MainFrm.lblStep17.Text = "17    8 NOLU TUŞ TESTİ";
                    break;

                case 18:
                    this.MainFrm.lblStep18.Text = "18    G1 NOLU TUŞ TESTİ";
                    break;

                case 19:
                    this.MainFrm.lblStep19.Text = "19    G2 NOLU TUŞ TESTİ";
                    break;

                case 20:
                    this.MainFrm.lblStep20.Text = "20    G3 NOLU TUŞ TESTİ";
                    break;

                case 21:
                    this.MainFrm.lblStep21.Text = "21    G4 NOLU TUŞ TESTİ";
                    break;

                case 22:
                    this.MainFrm.lblStep22.Text = "22    SAFİR TESTİ BİTTİ";
                    break;

                case 24:
                    this.MainFrm.lblStep25.Text = "";
                    break;

                case 25: 
                    this.MainFrm.lblStep25.Text = "";
                    break;

                case 26:
                    this.MainFrm.lblStep26.Text = "";
                    break;

                case 27:
                    this.MainFrm.lblStep27.Text = "";
                    break;

                case 28:
                    this.MainFrm.lblStep28.Text = "";
                    break;

                case 29:
                    this.MainFrm.lblStep29.Text = "";
                    break;

                case 30:
                    this.MainFrm.lblStep30.Text = "";
                    break;

                case 31:
                    this.MainFrm.lblStep31.Text = "";
                    break;

                case 32:
                    this.MainFrm.lblStep32.Text = "";
                    break;

                case 33:
                    this.MainFrm.lblStep33.Text = "";
                    break;

                case 34:
                    this.MainFrm.lblStep34.Text = "";
                    break;

                case 35:
                    this.MainFrm.lblStep35.Text = "";
                    break;

                case 36:
                    this.MainFrm.lblStep36.Text = "";
                    break;

                case 37:
                    this.MainFrm.lblStep37.Text = "";
                    break;

                case 38:
                    this.MainFrm.lblStep38.Text = "";
                    break;

                case 39:
                    this.MainFrm.lblStep39.Text = "";
                    break;

                case 40:
                    this.MainFrm.lblStep40.Text = "";
                    break;
            }
            this.MainFrm.btnFCTInit.Enabled = false;
        }

        public void ProcessSuccess(int stepState)
        {
            switch (stepState)
            {
                case 1:
                    this.MainFrm.lblStep1.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed1.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed1.Text = "PASSED";
                    break;

                case 2:
                    this.MainFrm.lblStep2.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed2.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed2.Text = "PASSED";
                    break;

                case 3:
                    this.MainFrm.lblStep3.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed3.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed3.Text = "PASSED";
                    break;

                case 4:
                    this.MainFrm.lblStep4.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed4.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed4.Text = "PASSED";
                    break;

                case 5:
                    this.MainFrm.lblStep5.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed5.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed5.Text = "PASSED";
                    break;

                case 6:
                    this.MainFrm.lblStep6.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed6.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed6.Text = "PASSED";
                    break;

                case 7:
                    this.MainFrm.lblStep7.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed7.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed7.Text = "PASSED";
                    break;

                case 8:
                    this.MainFrm.lblStep8.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed8.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed8.Text = "PASSED";
                    break;

                case 9:
                    this.MainFrm.lblStep9.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed9.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed9.Text = "PASSED";
                    break;

                case 10:
                    this.MainFrm.lblStep10.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed10.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed10.Text = "PASSED";
                    break;

                case 11:
                    this.MainFrm.lblStep11.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed11.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed11.Text = "PASSED";
                    break;

                case 12:
                    this.MainFrm.lblStep12.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed12.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed12.Text = "PASSED";
                    break;

                case 13:
                    this.MainFrm.lblStep13.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed13.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed13.Text = "PASSED";
                    break;

                case 14:
                    this.MainFrm.lblStep14.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed14.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed14.Text = "PASSED";
                    break;

                case 15:
                    this.MainFrm.lblStep15.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed15.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed15.Text = "PASSED";
                    break;

                case 16:
                    this.MainFrm.lblStep16.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed16.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed16.Text = "PASSED";
                    break;

                case 17:
                    this.MainFrm.lblStep17.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed17.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed17.Text = "PASSED";
                    break;

                case 18:
                    this.MainFrm.lblStep18.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed18.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed18.Text = "PASSED";
                    break;

                case 19:
                    this.MainFrm.lblStep19.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed19.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed19.Text = "PASSED";
                    break;

                case 20:
                    this.MainFrm.lblStep20.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed20.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed20.Text = "PASSED";
                    break;

                case 21:
                    this.MainFrm.lblStep21.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed21.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed21.Text = "PASSED";
                    break;

                case 22:
                    this.MainFrm.lblStep22.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed22.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed22.Text = "PASSED";
                    break;

                case 23:
                    this.MainFrm.lblStep23.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed23.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed23.Text = "PASSED";
                    break;

                case 24:
                    this.MainFrm.lblStep24.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed24.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed24.Text = "PASSED";
                    break;

                case 25:
                    this.MainFrm.lblStep25.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed25.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed25.Text = "PASSED";
                    break;

                case 26:
                    this.MainFrm.lblStep26.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed26.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed26.Text = "PASSED";
                    break;

                case 27:
                    this.MainFrm.lblStep27.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed27.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed27.Text = "PASSED";
                    break;

                case 28:
                    this.MainFrm.lblStep28.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed28.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed28.Text = "PASSED";
                    break;

                case 29:
                    this.MainFrm.lblStep29.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed29.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed29.Text = "PASSED";
                    break;

                case 30:
                    this.MainFrm.lblStep30.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed30.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed30.Text = "PASSED";
                    break;

                case 31:
                    this.MainFrm.lblStep31.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed31.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed31.Text = "PASSED";
                    break;

                case 32:
                    this.MainFrm.lblStep32.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed32.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed32.Text = "PASSED";
                    break;

                case 33:
                    this.MainFrm.lblStep33.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed33.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed33.Text = "PASSED";
                    break;

                case 34:
                    this.MainFrm.lblStep34.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed34.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed34.Text = "PASSED";
                    break;

                case 35:
                    this.MainFrm.lblStep35.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed35.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed35.Text = "PASSED";
                    break;

                case 36:
                    this.MainFrm.lblStep36.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed36.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed36.Text = "PASSED";
                    break;

                case 37:
                    this.MainFrm.lblStep37.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed37.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed37.Text = "PASSED";
                    break;

                case 38:
                    this.MainFrm.lblStep38.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed38.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed38.Text = "PASSED";
                    break;

                case 39:
                    this.MainFrm.lblStep39.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed39.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed39.Text = "PASSED";
                    break;

                case 40:
                    this.MainFrm.lblStep40.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed40.BackColor = Color.Lime;
                    this.MainFrm.tBoxPassed40.Text = "PASSED";
                    break;
            }
        }

        public void ProcessFailed(int stepState)
        {
            switch (stepState)
            {
                case 1:
                    this.MainFrm.lblStep1.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed1.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed1.Text = "FAILED";
                    break;

                case 2:
                    this.MainFrm.lblStep2.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed2.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed2.Text = "FAILED";
                    break;

                case 3:
                    this.MainFrm.lblStep3.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed3.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed3.Text = "FAILED";
                    break;

                case 4:
                    this.MainFrm.lblStep4.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed4.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed4.Text = "FAILED";
                    break;

                case 5:
                    this.MainFrm.lblStep5.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed5.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed5.Text = "FAILED";
                    break;

                case 6:
                    this.MainFrm.lblStep6.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed6.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed6.Text = "FAILED";
                    break;

                case 7:
                    this.MainFrm.lblStep7.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed7.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed7.Text = "FAILED";
                    break;

                case 8:
                    this.MainFrm.lblStep8.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed8.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed8.Text = "FAILED";
                    break;

                case 9:
                    this.MainFrm.lblStep9.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed9.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed9.Text = "FAILED";
                    break;

                case 10:
                    this.MainFrm.lblStep10.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed10.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed10.Text = "FAILED";
                    break;

                case 11:
                    this.MainFrm.lblStep11.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed11.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed11.Text = "FAILED";
                    break;

                case 12:
                    this.MainFrm.lblStep12.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed12.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed12.Text = "FAILED";
                    break;

                case 13:
                    this.MainFrm.lblStep13.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed13.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed13.Text = "FAILED";
                    break;

                case 14:
                    this.MainFrm.lblStep14.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed14.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed14.Text = "FAILED";
                    break;

                case 15:
                    this.MainFrm.lblStep15.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed15.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed15.Text = "FAILED";
                    break;

                case 16:
                    this.MainFrm.lblStep16.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed16.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed16.Text = "FAILED";
                    break;

                case 17:
                    this.MainFrm.lblStep17.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed17.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed17.Text = "FAILED";
                    break;

                case 18:
                    this.MainFrm.lblStep18.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed18.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed18.Text = "FAILED";
                    break;

                case 19:
                    this.MainFrm.lblStep19.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed19.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed19.Text = "FAILED";
                    break;

                case 20:
                    this.MainFrm.lblStep20.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed20.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed20.Text = "FAILED";
                    break;

                case 21:
                    this.MainFrm.lblStep21.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed21.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed21.Text = "FAILED";
                    break;

                case 22:
                    this.MainFrm.lblStep22.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed22.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed22.Text = "FAILED";
                    break;

                case 23:
                    this.MainFrm.lblStep23.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed23.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed23.Text = "FAILED";
                    break;

                case 24:
                    this.MainFrm.lblStep24.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed24.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed24.Text = "FAILED";
                    break;

                case 25:
                    this.MainFrm.lblStep25.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed25.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed25.Text = "FAILED";
                    break;

                case 26:
                    this.MainFrm.lblStep26.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed26.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed26.Text = "FAILED";
                    break;

                case 27:
                    this.MainFrm.lblStep27.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed27.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed27.Text = "FAILED";
                    break;

                case 28:
                    this.MainFrm.lblStep28.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed28.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed28.Text = "FAILED";
                    break;

                case 29:
                    this.MainFrm.lblStep29.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed29.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed29.Text = "FAILED";
                    break;

                case 30:
                    this.MainFrm.lblStep30.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed30.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed30.Text = "FAILED";
                    break;

                case 31:
                    this.MainFrm.lblStep31.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed31.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed31.Text = "FAILED";
                    break;

                case 32:
                    this.MainFrm.lblStep32.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed32.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed32.Text = "FAILED";
                    break;

                case 33:
                    this.MainFrm.lblStep33.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed33.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed33.Text = "FAILED";
                    break;

                case 34:
                    this.MainFrm.lblStep34.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed34.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed34.Text = "FAILED";
                    break;

                case 35:
                    this.MainFrm.lblStep35.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed35.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed35.Text = "FAILED";
                    break;

                case 36:
                    this.MainFrm.lblStep36.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed36.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed36.Text = "FAILED";
                    break;

                case 37:
                    this.MainFrm.lblStep37.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed37.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed37.Text = "FAILED";
                    break;

                case 38:
                    this.MainFrm.lblStep38.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed38.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed38.Text = "FAILED";
                    break;

                case 39:
                    this.MainFrm.lblStep39.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed39.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed39.Text = "FAILED";
                    break;

                case 40:
                    this.MainFrm.lblStep40.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed40.BackColor = Color.Red;
                    this.MainFrm.tBoxPassed40.Text = "FAILED";
                    break;
            }
            if (stepState < 39)
            {
                CustomMessageBox.ShowMessage("Kart Hatalı.Lütfen Kutuya Ayırınız!", this.MainFrm.projectNameTxt.Text, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
            else
            {
                CustomMessageBox.ShowMessage("Kart Daha Önce Cloud'a Eklenmeştir. Lütfen Ayrı Kutuya Ayırınız", this.MainFrm.projectNameTxt.Text, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
            
            this.MainFrm.All_FCT_Fail();
            this.MainFrm.FCT_Finish();
        }

        public void Process_Clear()
        {
            this.MainFrm.lblStep1.BackColor = Color.White;
            this.MainFrm.lblStep2.BackColor = Color.White;
            this.MainFrm.lblStep3.BackColor = Color.White;
            this.MainFrm.lblStep4.BackColor = Color.White;
            this.MainFrm.lblStep5.BackColor = Color.White;
            this.MainFrm.lblStep6.BackColor = Color.White;
            this.MainFrm.lblStep7.BackColor = Color.White;
            this.MainFrm.lblStep8.BackColor = Color.White;
            this.MainFrm.lblStep9.BackColor = Color.White;
            this.MainFrm.lblStep10.BackColor = Color.White;
            this.MainFrm.lblStep11.BackColor = Color.White;
            this.MainFrm.lblStep12.BackColor = Color.White;
            this.MainFrm.lblStep13.BackColor = Color.White;
            this.MainFrm.lblStep14.BackColor = Color.White;
            this.MainFrm.lblStep15.BackColor = Color.White;
            this.MainFrm.lblStep16.BackColor = Color.White;
            this.MainFrm.lblStep17.BackColor = Color.White;
            this.MainFrm.lblStep18.BackColor = Color.White;
            this.MainFrm.lblStep19.BackColor = Color.White;
            this.MainFrm.lblStep20.BackColor = Color.White;
            this.MainFrm.lblStep21.BackColor = Color.White;
            this.MainFrm.lblStep22.BackColor = Color.White;
            this.MainFrm.lblStep23.BackColor = Color.White;
            this.MainFrm.lblStep24.BackColor = Color.White;
            this.MainFrm.lblStep25.BackColor = Color.White;
            this.MainFrm.lblStep26.BackColor = Color.White;
            this.MainFrm.lblStep27.BackColor = Color.White;
            this.MainFrm.lblStep28.BackColor = Color.White;
            this.MainFrm.lblStep29.BackColor = Color.White;
            this.MainFrm.lblStep30.BackColor = Color.White;
            this.MainFrm.lblStep31.BackColor = Color.White;
            this.MainFrm.lblStep32.BackColor = Color.White;
            this.MainFrm.lblStep33.BackColor = Color.White;
            this.MainFrm.lblStep34.BackColor = Color.White;
            this.MainFrm.lblStep35.BackColor = Color.White;
            this.MainFrm.lblStep36.BackColor = Color.White;
            this.MainFrm.lblStep37.BackColor = Color.White;
            this.MainFrm.lblStep38.BackColor = Color.White;
            this.MainFrm.lblStep39.BackColor = Color.White;
            this.MainFrm.lblStep40.BackColor = Color.White;

            this.MainFrm.lblStep1.Text = "";
            this.MainFrm.lblStep2.Text = "";
            this.MainFrm.lblStep3.Text = "";
            this.MainFrm.lblStep4.Text = "";
            this.MainFrm.lblStep5.Text = "";
            this.MainFrm.lblStep6.Text = "";
            this.MainFrm.lblStep7.Text = "";
            this.MainFrm.lblStep8.Text = "";
            this.MainFrm.lblStep9.Text = "";
            this.MainFrm.lblStep10.Text = "";
            this.MainFrm.lblStep11.Text = "";
            this.MainFrm.lblStep12.Text = "";
            this.MainFrm.lblStep13.Text = "";
            this.MainFrm.lblStep14.Text = "";
            this.MainFrm.lblStep15.Text = "";
            this.MainFrm.lblStep16.Text = "";
            this.MainFrm.lblStep17.Text = "";
            this.MainFrm.lblStep18.Text = "";
            this.MainFrm.lblStep19.Text = "";
            this.MainFrm.lblStep20.Text = "";
            this.MainFrm.lblStep21.Text = "";
            this.MainFrm.lblStep22.Text = "";
            this.MainFrm.lblStep23.Text = "";
            this.MainFrm.lblStep24.Text = "";
            this.MainFrm.lblStep25.Text = "";
            this.MainFrm.lblStep26.Text = "";
            this.MainFrm.lblStep27.Text = "";
            this.MainFrm.lblStep28.Text = "";
            this.MainFrm.lblStep29.Text = "";
            this.MainFrm.lblStep30.Text = "";
            this.MainFrm.lblStep31.Text = "";
            this.MainFrm.lblStep32.Text = "";
            this.MainFrm.lblStep33.Text = "";
            this.MainFrm.lblStep34.Text = "";
            this.MainFrm.lblStep35.Text = "";
            this.MainFrm.lblStep36.Text = "";
            this.MainFrm.lblStep37.Text = "";
            this.MainFrm.lblStep38.Text = "";
            this.MainFrm.lblStep39.Text = "";
            this.MainFrm.lblStep40.Text = "";

            this.MainFrm.tBoxPassed1.BackColor = Color.White;
            this.MainFrm.tBoxPassed2.BackColor = Color.White;
            this.MainFrm.tBoxPassed3.BackColor = Color.White;
            this.MainFrm.tBoxPassed4.BackColor = Color.White;
            this.MainFrm.tBoxPassed5.BackColor = Color.White;
            this.MainFrm.tBoxPassed6.BackColor = Color.White;
            this.MainFrm.tBoxPassed7.BackColor = Color.White;
            this.MainFrm.tBoxPassed8.BackColor = Color.White;
            this.MainFrm.tBoxPassed9.BackColor = Color.White;
            this.MainFrm.tBoxPassed10.BackColor = Color.White;
            this.MainFrm.tBoxPassed11.BackColor = Color.White;
            this.MainFrm.tBoxPassed12.BackColor = Color.White;
            this.MainFrm.tBoxPassed13.BackColor = Color.White;
            this.MainFrm.tBoxPassed14.BackColor = Color.White;
            this.MainFrm.tBoxPassed15.BackColor = Color.White;
            this.MainFrm.tBoxPassed16.BackColor = Color.White;
            this.MainFrm.tBoxPassed17.BackColor = Color.White;
            this.MainFrm.tBoxPassed18.BackColor = Color.White;
            this.MainFrm.tBoxPassed19.BackColor = Color.White;
            this.MainFrm.tBoxPassed20.BackColor = Color.White;
            this.MainFrm.tBoxPassed21.BackColor = Color.White;
            this.MainFrm.tBoxPassed22.BackColor = Color.White;
            this.MainFrm.tBoxPassed23.BackColor = Color.White;
            this.MainFrm.tBoxPassed24.BackColor = Color.White;
            this.MainFrm.tBoxPassed25.BackColor = Color.White;
            this.MainFrm.tBoxPassed26.BackColor = Color.White;
            this.MainFrm.tBoxPassed27.BackColor = Color.White;
            this.MainFrm.tBoxPassed28.BackColor = Color.White;
            this.MainFrm.tBoxPassed29.BackColor = Color.White;
            this.MainFrm.tBoxPassed30.BackColor = Color.White;
            this.MainFrm.tBoxPassed31.BackColor = Color.White;
            this.MainFrm.tBoxPassed32.BackColor = Color.White;
            this.MainFrm.tBoxPassed33.BackColor = Color.White;
            this.MainFrm.tBoxPassed34.BackColor = Color.White;
            this.MainFrm.tBoxPassed35.BackColor = Color.White;
            this.MainFrm.tBoxPassed36.BackColor = Color.White;
            this.MainFrm.tBoxPassed37.BackColor = Color.White;
            this.MainFrm.tBoxPassed38.BackColor = Color.White;
            this.MainFrm.tBoxPassed39.BackColor = Color.White;
            this.MainFrm.tBoxPassed40.BackColor = Color.White;

            this.MainFrm.tBoxPassed1.Text = "";
            this.MainFrm.tBoxPassed2.Text = "";
            this.MainFrm.tBoxPassed3.Text = "";
            this.MainFrm.tBoxPassed4.Text = "";
            this.MainFrm.tBoxPassed5.Text = "";
            this.MainFrm.tBoxPassed6.Text = "";
            this.MainFrm.tBoxPassed7.Text = "";
            this.MainFrm.tBoxPassed8.Text = "";
            this.MainFrm.tBoxPassed9.Text = "";
            this.MainFrm.tBoxPassed10.Text = "";
            this.MainFrm.tBoxPassed11.Text = "";
            this.MainFrm.tBoxPassed12.Text = "";
            this.MainFrm.tBoxPassed13.Text = "";
            this.MainFrm.tBoxPassed14.Text = "";
            this.MainFrm.tBoxPassed15.Text = "";
            this.MainFrm.tBoxPassed16.Text = "";
            this.MainFrm.tBoxPassed17.Text = "";
            this.MainFrm.tBoxPassed18.Text = "";
            this.MainFrm.tBoxPassed19.Text = "";
            this.MainFrm.tBoxPassed20.Text = "";
            this.MainFrm.tBoxPassed21.Text = "";
            this.MainFrm.tBoxPassed22.Text = "";
            this.MainFrm.tBoxPassed23.Text = "";
            this.MainFrm.tBoxPassed24.Text = "";
            this.MainFrm.tBoxPassed25.Text = "";
            this.MainFrm.tBoxPassed26.Text = "";
            this.MainFrm.tBoxPassed27.Text = "";
            this.MainFrm.tBoxPassed28.Text = "";
            this.MainFrm.tBoxPassed29.Text = "";
            this.MainFrm.tBoxPassed30.Text = "";
            this.MainFrm.tBoxPassed31.Text = "";
            this.MainFrm.tBoxPassed32.Text = "";
            this.MainFrm.tBoxPassed33.Text = "";
            this.MainFrm.tBoxPassed34.Text = "";
            this.MainFrm.tBoxPassed35.Text = "";
            this.MainFrm.tBoxPassed36.Text = "";
            this.MainFrm.tBoxPassed37.Text = "";
            this.MainFrm.tBoxPassed38.Text = "";
            this.MainFrm.tBoxPassed39.Text = "";
            this.MainFrm.tBoxPassed40.Text = "";

            this.MainFrm.tbState.Text = "";
            this.MainFrm.tbState.BackColor = Color.Ivory;
        }

    }
}
