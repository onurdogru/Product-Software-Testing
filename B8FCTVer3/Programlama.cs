using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.IO;

namespace B8FCTVer3
{
    public class ProgramlamaForm
    {
        public Main MainFrm;
        public ProcessForm ProcessFrm;

        /*PROGRAMLAMA + BARKOD DEĞİŞKENLERİ*/
        string[] batchFileFeedback = new string[4];
        private bool isProgrammingStarted = false;
        int isProgrammingState = 0;

        int versions_number = 0;
        string[] versionsBarcodName = new string[21];
        string[] versionsSlaveName = new string[21];
        int[] stepProgJob = new int[21];
        string computerBatchFileAdress;

        string companyNo;
        string productNo;

        public void programlamaInit()
        {
            computerBatchFileAdress = Prog_Ayarlar.Default.Logdosyayolu;
            this.companyNo = Prog_Ayarlar.Default.companyNo;
            this.productNo = Prog_Ayarlar.Default.productNo;

            this.versions_number = Convert.ToInt16(Prog_Ayarlar.Default.barcodeNum);
            this.stepProgJob[1] = Convert.ToInt16(Prog_Ayarlar.Default.step1Job);
            this.stepProgJob[2] = Convert.ToInt16(Prog_Ayarlar.Default.step2Job);
            this.stepProgJob[3] = Convert.ToInt16(Prog_Ayarlar.Default.step3Job);
            this.stepProgJob[4] = Convert.ToInt16(Prog_Ayarlar.Default.step4Job);
            this.stepProgJob[5] = Convert.ToInt16(Prog_Ayarlar.Default.step5Job);
            this.stepProgJob[6] = Convert.ToInt16(Prog_Ayarlar.Default.step6Job);
            this.stepProgJob[7] = Convert.ToInt16(Prog_Ayarlar.Default.step7Job);
            this.stepProgJob[8] = Convert.ToInt16(Prog_Ayarlar.Default.step8Job);
            this.stepProgJob[9] = Convert.ToInt16(Prog_Ayarlar.Default.step9Job);
            this.stepProgJob[10] = Convert.ToInt16(Prog_Ayarlar.Default.step10Job);
            this.stepProgJob[11] = Convert.ToInt16(Prog_Ayarlar.Default.step11Job);
            this.stepProgJob[12] = Convert.ToInt16(Prog_Ayarlar.Default.step12Job);
            this.stepProgJob[13] = Convert.ToInt16(Prog_Ayarlar.Default.step13Job);
            this.stepProgJob[14] = Convert.ToInt16(Prog_Ayarlar.Default.step14Job);
            this.stepProgJob[15] = Convert.ToInt16(Prog_Ayarlar.Default.step15Job);
            this.stepProgJob[16] = Convert.ToInt16(Prog_Ayarlar.Default.step16Job);
            this.stepProgJob[17] = Convert.ToInt16(Prog_Ayarlar.Default.step17Job);
            this.stepProgJob[18] = Convert.ToInt16(Prog_Ayarlar.Default.step18Job);
            this.stepProgJob[19] = Convert.ToInt16(Prog_Ayarlar.Default.step19Job);
            this.stepProgJob[20] = Convert.ToInt16(Prog_Ayarlar.Default.step20Job);
            this.versionsBarcodName[1] = Prog_Ayarlar.Default.barcode1;
            this.versionsBarcodName[2] = Prog_Ayarlar.Default.barcode2;
            this.versionsBarcodName[3] = Prog_Ayarlar.Default.barcode3;
            this.versionsBarcodName[4] = Prog_Ayarlar.Default.barcode4;
            this.versionsBarcodName[5] = Prog_Ayarlar.Default.barcode5;
            this.versionsBarcodName[6] = Prog_Ayarlar.Default.barcode6;
            this.versionsBarcodName[7] = Prog_Ayarlar.Default.barcode7;
            this.versionsBarcodName[8] = Prog_Ayarlar.Default.barcode8;
            this.versionsBarcodName[9] = Prog_Ayarlar.Default.barcode9;
            this.versionsBarcodName[10] = Prog_Ayarlar.Default.barcode10;
            this.versionsBarcodName[11] = Prog_Ayarlar.Default.barcode11;
            this.versionsBarcodName[12] = Prog_Ayarlar.Default.barcode12;
            this.versionsBarcodName[13] = Prog_Ayarlar.Default.barcode13;
            this.versionsBarcodName[14] = Prog_Ayarlar.Default.barcode14;
            this.versionsBarcodName[15] = Prog_Ayarlar.Default.barcode15;
            this.versionsBarcodName[16] = Prog_Ayarlar.Default.barcode16;
            this.versionsBarcodName[17] = Prog_Ayarlar.Default.barcode17;
            this.versionsBarcodName[18] = Prog_Ayarlar.Default.barcode18;
            this.versionsBarcodName[19] = Prog_Ayarlar.Default.barcode19;
            this.versionsBarcodName[20] = Prog_Ayarlar.Default.barcode20;
            this.versionsSlaveName[1] = Prog_Ayarlar.Default.Sbarcode1;
            this.versionsSlaveName[2] = Prog_Ayarlar.Default.Sbarcode2;
            this.versionsSlaveName[3] = Prog_Ayarlar.Default.Sbarcode3;
            this.versionsSlaveName[4] = Prog_Ayarlar.Default.Sbarcode4;
            this.versionsSlaveName[5] = Prog_Ayarlar.Default.Sbarcode5;
            this.versionsSlaveName[6] = Prog_Ayarlar.Default.Sbarcode6;
            this.versionsSlaveName[7] = Prog_Ayarlar.Default.Sbarcode7;
            this.versionsSlaveName[8] = Prog_Ayarlar.Default.Sbarcode8;
            this.versionsSlaveName[9] = Prog_Ayarlar.Default.Sbarcode9;
            this.versionsSlaveName[10] = Prog_Ayarlar.Default.Sbarcode10;
            this.versionsSlaveName[11] = Prog_Ayarlar.Default.Sbarcode11;
            this.versionsSlaveName[12] = Prog_Ayarlar.Default.Sbarcode12;
            this.versionsSlaveName[13] = Prog_Ayarlar.Default.Sbarcode13;
            this.versionsSlaveName[14] = Prog_Ayarlar.Default.Sbarcode14;
            this.versionsSlaveName[15] = Prog_Ayarlar.Default.Sbarcode15;
            this.versionsSlaveName[16] = Prog_Ayarlar.Default.Sbarcode16;
            this.versionsSlaveName[17] = Prog_Ayarlar.Default.Sbarcode17;
            this.versionsSlaveName[18] = Prog_Ayarlar.Default.Sbarcode18;
            this.versionsSlaveName[19] = Prog_Ayarlar.Default.Sbarcode19;
            this.versionsSlaveName[20] = Prog_Ayarlar.Default.Sbarcode20;
            batchFileFeedback[0] = Prog_Ayarlar.Default.successBatch;
            batchFileFeedback[1] = Prog_Ayarlar.Default.error1Batch;
            batchFileFeedback[2] = Prog_Ayarlar.Default.error2Batch;
            batchFileFeedback[3] = Prog_Ayarlar.Default.error3Batch;
        }

        public void programlamaStart(string barcode)
        {
            Thread programThread = new Thread(ProgramThreadFunction);
            programThread.Start(barcode);
        }
        public void ProgramThreadFunction(object data)
        {
            bool result = false;
            int stepState = 1;
            // Clean console
            this.MainFrm.ConsoleClean();

            string barcode = (string)data;
            string company_no = string.Empty;
            string product_no = string.Empty;
            string panacim_code = string.Empty;
            string party_no = string.Empty;

            // if barcode is true
            if (BarcodeCheck(barcode))
            {
                // Show message box
                DialogResult dialog_result = DialogResult.None;
                if (Ayarlar.Default.chBoxProgramlama)
                {
                    dialog_result = DialogResult.OK;
                }
                else
                {
                    this.MainFrm.Invoke(new Action(delegate ()
                    {
                        dialog_result = CustomMessageBox.ShowMessage("Programlama kablolarını doğru şekilde karta takınız. Sonra Tamam'a tıklayınız!", this.MainFrm.projectNameTxt.Text, MessageBoxButtons.OKCancel, CustomMessageBoxIcon.Warning, Color.Yellow);
                    }));
                }
                if (dialog_result == DialogResult.OK)
                {
                    // set ProgrammingStarted flag
                    isProgrammingStarted = true;

                    // Disable Programming Button
                    this.MainFrm.btnStartProgramming.Invoke(new Action(delegate () { this.MainFrm.btnStartProgramming.Enabled = false; }));

                    this.MainFrm.ConsoleAppendLine("Barkod: " + barcode, Color.White);
                    this.MainFrm.ConsoleNewLine();
                    this.MainFrm.ConsoleAppendLine("Barkod kriterlere uygun.", Color.Green);
                    this.MainFrm.ConsoleNewLine();

                    company_no = GetStringBetweenTwoSubStrings(barcode, "$01", "$02");
                    product_no = GetStringBetweenTwoSubStrings(barcode, "$02", "$03");
                    panacim_code = GetStringBetweenTwoSubStrings(barcode, "$03", "$04");
                    party_no = GetStringBetweenTwoSubStrings(barcode, "$04", "$05");

                    this.MainFrm.ConsoleAppendLine("Firma No: " + company_no, Color.White);
                    this.MainFrm.ConsoleAppendLine("Ürün No: " + product_no, Color.White);
                    this.MainFrm.ConsoleAppendLine("Panasim Kodu: " + panacim_code, Color.White);
                    this.MainFrm.ConsoleAppendLine("Parti No: " + party_no, Color.White);
                    this.MainFrm.ConsoleNewLine();

                    this.MainFrm.ConsoleAppendLine(panacim_code + " kodlu ürünün programlama işlemi yapılıyor...", Color.Yellow);

                    if (this.MainFrm.cbProgram.Checked == true)
                    {
                        if (ProgramProduct(product_no))
                        {
                            isProgrammingState = 2;
                            this.MainFrm.ConsoleNewLine();
                            this.MainFrm.ConsoleAppendLine(panacim_code + " kodlu ürünün programlama işlemi başarıyla tamamlanmıştır.", Color.Green);
                            this.MainFrm.ConsoleNewLine();
                            result = true;
                        }
                        else
                        {
                            isProgrammingState = 1;
                            this.MainFrm.ConsoleNewLine();
                            this.MainFrm.ConsoleAppendLine(panacim_code + " kodlu ürünün programlama işlemi sırasında bir hata oluşmuştur!", Color.Red);
                            this.MainFrm.ConsoleNewLine();
                            result = false;
                        }
                    }
                    else
                    {
                        result = true;
                    }
                }
                else
                {
                    this.MainFrm.tbBarcodeCurrent.Invoke(new Action(delegate ()
                    {
                        // Focus Barcode textbox
                        this.MainFrm.tbBarcodeCurrent.Focus();
                        // Select all text in textbox
                        this.MainFrm.tbBarcodeCurrent.SelectionStart = 0;
                        this.MainFrm.tbBarcodeCurrent.SelectionLength = this.MainFrm.tbBarcodeCurrent.Text.Length;
                    }));

                    return;
                }
            }
            else
            {
                if (barcode.Equals(""))
                {
                    // Show message box
                    /*
                    DialogResult dialog_result = DialogResult.None;
                    this.Invoke(new Action(delegate ()
                    {
                        dialog_result = CustomMessageBox.ShowMessage("Barkod boş bırakılamaz!", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Yellow);
                    }));
                    if (dialog_result == DialogResult.OK)
                    {
                    */
                    isProgrammingState = 1;
                    this.MainFrm.ConsoleAppendLine("Barkod: " + barcode, Color.White);
                    this.MainFrm.ConsoleNewLine();
                    this.MainFrm.ConsoleAppendLine("Yanlış barkod! Barkod kriterlere uygun değil! Programlama yapılamadı!", Color.Red);
                    this.MainFrm.ConsoleNewLine();
                    ProcessFrm.ProcessFailed(stepState); //stepState = 1
                    result = false;
                    // }
                }
                else
                {
                    // Show message box
                    /*
                    DialogResult dialog_result = DialogResult.None;
                    this.Invoke(new Action(delegate ()
                    {
                        dialog_result = CustomMessageBox.ShowMessage("Yanlış barkod! Barkod kriterlere uygun değil!", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Yellow);
                    }));
                    if (dialog_result == DialogResult.OK)
                    {
                    */
                    isProgrammingState = 1;
                    this.MainFrm.ConsoleAppendLine("Barkod: " + barcode, Color.White);
                    this.MainFrm.ConsoleNewLine();
                    this.MainFrm.ConsoleAppendLine("Yanlış barkod! Barkod kriterlere uygun değil! Programlama yapılamadı!", Color.Red);
                    this.MainFrm.ConsoleNewLine();
                    ProcessFrm.ProcessFailed(stepState); //stepState = 1
                    result = false;
                    //  }
                }
            }

            // Update status bar
            if (result)
            {
                this.MainFrm.tbState.Invoke(new Action(delegate ()
                {
                    this.MainFrm.tbState.BackColor = Color.Green;
                    this.MainFrm.tbState.Text = "PROGRAMLAMA BAŞARILI";
                    stepState = 1;
                    this.MainFrm.ProcessFrm.ProcessSuccess(stepState);
                    stepState = 0;  //Bir Etkisi Yok
                    this.MainFrm.Invoke(new EventHandler(this.MainFrm.btnFCTInit_Click));
                }));
            }
            else
            {
                this.MainFrm.tbState.Invoke(new Action(delegate ()
                {
                    isProgrammingState = 1;
                    this.MainFrm.tbState.BackColor = Color.Red;
                    this.MainFrm.tbState.Text = "PROGRAMLAMA BAŞARISIZ";
                }));

                // Show message box
                /*
                DialogResult dialog_result = DialogResult.None;
                this.Invoke(new Action(delegate ()
                {
                    dialog_result = CustomMessageBox.ShowMessage("PROGRAMLAMA BAŞARISIZ", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Fail, Color.Red);
                }));
                if (dialog_result == DialogResult.OK)
                {
                    // do nothing only information.
                }
                */
                ProcessFrm.ProcessFailed(1);
            }

            // Assign Last Barcode with Current
            this.MainFrm.tbBarcodeLast.Invoke(new Action(delegate () { this.MainFrm.tbBarcodeLast.Text = barcode; }));

            this.MainFrm.tbBarcodeCurrent.Invoke(new Action(delegate ()
            {
                // Clean Current Barcode
                this.MainFrm.tbBarcodeCurrent.Text = "";
                // Focus Barcode textbox
                this.MainFrm.tbBarcodeCurrent.Focus();
                // Select all text in textbox
                this.MainFrm.tbBarcodeCurrent.SelectionStart = 0;
                this.MainFrm.tbBarcodeCurrent.SelectionLength = this.MainFrm.tbBarcodeCurrent.Text.Length;
            }));

            // Enable Programming Button
            this.MainFrm.btnStartProgramming.Invoke(new Action(delegate () { this.MainFrm.btnStartProgramming.Enabled = true; }));

            // set ProgrammingStarted flag
            isProgrammingStarted = false;
        }

        /* Gelen Barcode Kontrol Edilir*/
        private bool BarcodeCheck(String barcode)
        {
            // Barcode length should be between 26-150.
            if (barcode.Length < 26 || barcode.Length > 150) return false;

            // Simple starting contains ending substring check.
            if (!(barcode.StartsWith("$01") && barcode.Contains("$02") && barcode.Contains("$03") && barcode.Contains("$04") && barcode.Contains("$05") && barcode.Contains("$06") && barcode.Contains("$07") && barcode.EndsWith("#")))
            {
                return false;
            }

            // Find the index of the substrings in Barcode. Value is -1, if substring is not exist.
            int[] index = new int[8];
            int count = 150;
            if (barcode.Length < 150) count = barcode.Length;
            index[0] = barcode.IndexOf("$01", 0, count);
            index[1] = barcode.IndexOf("$02", 0, count);
            index[2] = barcode.IndexOf("$03", 0, count);
            index[3] = barcode.IndexOf("$04", 0, count);
            index[4] = barcode.IndexOf("$05", 0, count);
            index[5] = barcode.IndexOf("$06", 0, count);
            index[6] = barcode.IndexOf("$07", 0, count);
            index[7] = barcode.IndexOf("#", 0, count);

            for (int i = 0; i < index.Length; ++i)
            {
                // if substring is not exist
                if (index[i] == -1)
                {
                    return false;
                }

                // if substring position is not correct
                for (int j = i + 1; j < index.Length; ++j)
                {
                    if (index[i] > index[j])
                    {
                        return false;
                    }
                }
            }
            //Karşılaştırma Kısmı
            string company_no = GetStringBetweenTwoSubStrings(barcode, "$01", "$02");
            string product_no = GetStringBetweenTwoSubStrings(barcode, "$02", "$03");
            string panacim_code = GetStringBetweenTwoSubStrings(barcode, "$03", "$04");
            string party_no = GetStringBetweenTwoSubStrings(barcode, "$04", "$05");

            // check company no
            if (!company_no.Equals(companyNo)) return false;

            // check product no
            if (product_no.IndexOf(productNo) != 0) return false;

            // check panacim_code
            if (panacim_code.Equals("")) return false;

            // check party no
            if (party_no.Equals("")) return false;

            // There is no problem
            return true;
        }

        /*Gelen Barkodu Ayıklanır*/
        private String GetStringBetweenTwoSubStrings(String source, String sub1, String sub2)
        {
            int pFrom = source.IndexOf(sub1) + sub1.Length;
            int pTo = source.LastIndexOf(sub2);
            String result = source.Substring(pFrom, pTo - pFrom);
            return result;
        }

        private bool ProgramProduct(string product_no)
        {
            bool result = false;
            String batchPath = String.Empty;

            for (int i = 1; i <= versions_number; i++)
            {

                if (versionsBarcodName[i] == product_no)
                {
                    if (stepProgJob[versions_number] == 1)
                    {
                        batchPath = computerBatchFileAdress + product_no + ".bat";    // C:\Users\serkan.baki\Desktop\MIND-BATCH-FILES\
                        result = RunBatch(batchPath, this.MainFrm.projectNameTxt.Text);
                        if (result == false) return result;
                    }
                    else if (stepProgJob[versions_number] == 2)
                    {
                        batchPath = computerBatchFileAdress + product_no + ".bat";    // C:\Users\serkan.baki\Desktop\MIND-BATCH-FILES\
                        result = RunBatch(batchPath, this.MainFrm.projectNameTxt.Text);
                        if (result == false) return result;
                        if (CustomMessageBox.ShowMessage("Slave Yüklemesi Yapılması İçin Önce Programlama Kablosunu Takınız ve Evet'e Tıklayınız", this.MainFrm.projectNameTxt.Text, MessageBoxButtons.YesNo, CustomMessageBoxIcon.Question, Color.Yellow) == DialogResult.Yes)
                        {
                            batchPath = computerBatchFileAdress + versionsSlaveName[i] + ".bat";    // C:\Users\serkan.baki\Desktop\MIND-BATCH-FILES\
                            result = RunBatch(batchPath, this.MainFrm.projectNameTxt.Text);
                            if (result == false) return result;
                        }
                    }
                    break;
                }
            }
            return result;
        }

        /*Seçilen .bat Çalıştırılır- Kontrol Edilir ve Kapatılır*/
        private bool RunBatch(string batch_path, string batch_name)
        {
            bool result = false;

            Process processBatch = new Process();
            processBatch.StartInfo.UseShellExecute = false;
            processBatch.StartInfo.RedirectStandardOutput = true;
            processBatch.StartInfo.CreateNoWindow = true;
            processBatch.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processBatch.StartInfo.FileName = batch_path;
            //processBatch.StartInfo.Arguments = string.Format("");
            processBatch.Start();

            StreamReader strmReader = processBatch.StandardOutput;
            string batchTempRow = string.Empty;
            // get all lines of batch
            while ((batchTempRow = strmReader.ReadLine()) != null)
            {
                // Write batch operation to the console
                this.MainFrm.ConsoleAppendLine(batchTempRow, Color.White);

                // check programming is successful.
                // if succesfully finished.
                if (Prog_Ayarlar.Default.chBoxSuccess && ((batchTempRow.IndexOf("pause", StringComparison.OrdinalIgnoreCase) >= 0) || (batchTempRow.IndexOf(batchFileFeedback[0], StringComparison.OrdinalIgnoreCase) >= 0)))  // color ae
                {
                    isProgrammingState = 2;
                    this.MainFrm.ConsoleNewLine();
                    this.MainFrm.ConsoleAppendLine(batch_name + " Programlama İşlemi Başarıyla Tamamlanmıştır!", Color.Green);
                    result = true;
                    break;
                }
                else if (Prog_Ayarlar.Default.chBoxError1 && ((batchTempRow.IndexOf("pause", StringComparison.OrdinalIgnoreCase) >= 0) || (batchTempRow.IndexOf(batchFileFeedback[1], StringComparison.OrdinalIgnoreCase) >= 0))) //Could not start CPU core.
                {
                    isProgrammingState = 1;
                    this.MainFrm.ConsoleNewLine();
                    this.MainFrm.ConsoleAppendLine(batch_name + " Programlama İşlemi Başarısız1.", Color.Red);  // Programlama Soketi Düzgün Takılı Değil!
                    this.MainFrm.All_FCT_Fail();
                    result = false;
                    break;
                }
                else if (Prog_Ayarlar.Default.chBoxError2 && ((batchTempRow.IndexOf("pause", StringComparison.OrdinalIgnoreCase) >= 0) || (batchTempRow.IndexOf(batchFileFeedback[2], StringComparison.OrdinalIgnoreCase) >= 0)))  // Cannot connect to target.
                {
                    isProgrammingState = 1;
                    this.MainFrm.ConsoleNewLine();
                    this.MainFrm.ConsoleAppendLine(batch_name + " Programlama İşlemi Başarısız2.", Color.Red); // Programlama Soketi Takılı Değil!
                    this.MainFrm.All_FCT_Fail();
                    result = false;
                    break;
                }
                else if (Prog_Ayarlar.Default.chBoxError3 && ((batchTempRow.IndexOf("pause", StringComparison.OrdinalIgnoreCase) >= 0) || (batchTempRow.IndexOf(batchFileFeedback[3], StringComparison.OrdinalIgnoreCase) >= 0))) //FAILED
                {
                    isProgrammingState = 1;
                    this.MainFrm.ConsoleNewLine();
                    this.MainFrm.ConsoleAppendLine(batch_name + " Programlama İşlemi Başarısız3.", Color.Red);  //  USB Takılı Değil!
                    this.MainFrm.All_FCT_Fail();
                    result = false;
                    break;
                }
            }

            // if batch didn't closed kill it.
            if (!processBatch.HasExited)
            {
                processBatch.Kill();
            }

            return result;
        }
    }
}
