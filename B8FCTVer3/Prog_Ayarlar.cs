// Decompiled with JetBrains decompiler
// Type: EsdTurnikesi.Ayarlar
// Assembly: EsdTurnikesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C8099926-BBEB-495E-ADF6-36B4F5F75BE8
// Assembly location: C:\Users\serkan.baki\Desktop\esd-rar\ESD\Release\EsdTurnikesi.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO.Ports;
using System.Runtime.CompilerServices;

namespace B8FCTVer3
{
    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed class Prog_Ayarlar : ApplicationSettingsBase
    {
        private static Prog_Ayarlar defaultInstance = (Prog_Ayarlar)SettingsBase.Synchronized((SettingsBase)new Prog_Ayarlar());

        private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
        {
        }

        private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
        {
        }

        public static Prog_Ayarlar Default
        {
            get
            {
                return Prog_Ayarlar.defaultInstance;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string iniDosyaYolu
        {
            get
            {
                return (string)this[nameof(iniDosyaYolu)];
            }
            set
            {
                this[nameof(iniDosyaYolu)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("C:\\Users\\serkan.baki\\Desktop\\MIND-BATCH-FILES\\")]
        public string Logdosyayolu
        {
            get
            {
                return (string)this[nameof(Logdosyayolu)];
            }
            set
            {
                this[nameof(Logdosyayolu)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("91")]
        public string companyNo
        {
            get
            {
                return (string)this[nameof(companyNo)];
            }
            set
            {
                this[nameof(companyNo)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("167000")]
        public string productNo
        {
            get
            {
                return (string)this[nameof(productNo)];
            }
            set
            {
                this[nameof(productNo)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("3585310100")]
        public string SAPNo
        {
            get
            {
                return (string)this[nameof(SAPNo)];
            }
            set
            {
                this[nameof(SAPNo)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("05")]
        public string cardNo
        {
            get
            {
                return (string)this[nameof(cardNo)];
            }
            set
            {
                this[nameof(cardNo)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("06")]
        public string gerberVer
        {
            get
            {
                return (string)this[nameof(gerberVer)];
            }
            set
            {
                this[nameof(gerberVer)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("03")]
        public string BOMVer
        {
            get
            {
                return (string)this[nameof(BOMVer)];
            }
            set
            {
                this[nameof(BOMVer)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("01")]
        public string ICTRev
        {
            get
            {
                return (string)this[nameof(ICTRev)];
            }
            set
            {
                this[nameof(ICTRev)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("01")]
        public string FCTRev
        {
            get
            {
                return (string)this[nameof(FCTRev)];
            }
            set
            {
                this[nameof(FCTRev)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("01")]
        public string softwareVer
        {
            get
            {
                return (string)this[nameof(softwareVer)];
            }
            set
            {
                this[nameof(softwareVer)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("04")]
        public string softwareRev
        {
            get
            {
                return (string)this[nameof(softwareRev)];
            }
            set
            {
                this[nameof(softwareRev)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string barcodeNum
        {
            get
            {
                return (string)this[nameof(barcodeNum)];
            }
            set
            {
                this[nameof(barcodeNum)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step1Job
        {
            get
            {
                return (string)this[nameof(step1Job)];
            }
            set
            {
                this[nameof(step1Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step2Job
        {
            get
            {
                return (string)this[nameof(step2Job)];
            }
            set
            {
                this[nameof(step2Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step3Job
        {
            get
            {
                return (string)this[nameof(step3Job)];
            }
            set
            {
                this[nameof(step3Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step4Job
        {
            get
            {
                return (string)this[nameof(step4Job)];
            }
            set
            {
                this[nameof(step4Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step5Job
        {
            get
            {
                return (string)this[nameof(step5Job)];
            }
            set
            {
                this[nameof(step5Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step6Job
        {
            get
            {
                return (string)this[nameof(step6Job)];
            }
            set
            {
                this[nameof(step6Job)] = (object)value;
            }
        }


        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step7Job
        {
            get
            {
                return (string)this[nameof(step7Job)];
            }
            set
            {
                this[nameof(step7Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step8Job
        {
            get
            {
                return (string)this[nameof(step8Job)];
            }
            set
            {
                this[nameof(step8Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step9Job
        {
            get
            {
                return (string)this[nameof(step9Job)];
            }
            set
            {
                this[nameof(step9Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step10Job
        {
            get
            {
                return (string)this[nameof(step10Job)];
            }
            set
            {
                this[nameof(step10Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step11Job
        {
            get
            {
                return (string)this[nameof(step11Job)];
            }
            set
            {
                this[nameof(step11Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step12Job
        {
            get
            {
                return (string)this[nameof(step12Job)];
            }
            set
            {
                this[nameof(step12Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step13Job
        {
            get
            {
                return (string)this[nameof(step13Job)];
            }
            set
            {
                this[nameof(step13Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step14Job
        {
            get
            {
                return (string)this[nameof(step14Job)];
            }
            set
            {
                this[nameof(step14Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step15Job
        {
            get
            {
                return (string)this[nameof(step15Job)];
            }
            set
            {
                this[nameof(step15Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step16Job
        {
            get
            {
                return (string)this[nameof(step16Job)];
            }
            set
            {
                this[nameof(step16Job)] = (object)value;
            }
        }


        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step17Job
        {
            get
            {
                return (string)this[nameof(step17Job)];
            }
            set
            {
                this[nameof(step17Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step18Job
        {
            get
            {
                return (string)this[nameof(step18Job)];
            }
            set
            {
                this[nameof(step18Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step19Job
        {
            get
            {
                return (string)this[nameof(step19Job)];
            }
            set
            {
                this[nameof(step19Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string step20Job
        {
            get
            {
                return (string)this[nameof(step20Job)];
            }
            set
            {
                this[nameof(step20Job)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode1
        {
            get
            {
                return (string)this[nameof(barcode1)];
            }
            set
            {
                this[nameof(barcode1)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode2
        {
            get
            {
                return (string)this[nameof(barcode2)];
            }
            set
            {
                this[nameof(barcode2)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode3
        {
            get
            {
                return (string)this[nameof(barcode3)];
            }
            set
            {
                this[nameof(barcode3)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode4
        {
            get
            {
                return (string)this[nameof(barcode4)];
            }
            set
            {
                this[nameof(barcode4)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode5
        {
            get
            {
                return (string)this[nameof(barcode5)];
            }
            set
            {
                this[nameof(barcode5)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode6
        {
            get
            {
                return (string)this[nameof(barcode6)];
            }
            set
            {
                this[nameof(barcode6)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode7
        {
            get
            {
                return (string)this[nameof(barcode7)];
            }
            set
            {
                this[nameof(barcode7)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode8
        {
            get
            {
                return (string)this[nameof(barcode8)];
            }
            set
            {
                this[nameof(barcode8)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode9
        {
            get
            {
                return (string)this[nameof(barcode9)];
            }
            set
            {
                this[nameof(barcode9)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode10
        {
            get
            {
                return (string)this[nameof(barcode10)];
            }
            set
            {
                this[nameof(barcode10)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode11
        {
            get
            {
                return (string)this[nameof(barcode11)];
            }
            set
            {
                this[nameof(barcode11)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode12
        {
            get
            {
                return (string)this[nameof(barcode12)];
            }
            set
            {
                this[nameof(barcode12)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode13
        {
            get
            {
                return (string)this[nameof(barcode13)];
            }
            set
            {
                this[nameof(barcode13)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode14
        {
            get
            {
                return (string)this[nameof(barcode14)];
            }
            set
            {
                this[nameof(barcode14)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode15
        {
            get
            {
                return (string)this[nameof(barcode15)];
            }
            set
            {
                this[nameof(barcode15)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode16
        {
            get
            {
                return (string)this[nameof(barcode16)];
            }
            set
            {
                this[nameof(barcode16)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode17
        {
            get
            {
                return (string)this[nameof(barcode17)];
            }
            set
            {
                this[nameof(barcode17)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode18
        {
            get
            {
                return (string)this[nameof(barcode18)];
            }
            set
            {
                this[nameof(barcode18)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode19
        {
            get
            {
                return (string)this[nameof(barcode19)];
            }
            set
            {
                this[nameof(barcode19)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string barcode20
        {
            get
            {
                return (string)this[nameof(barcode20)];
            }
            set
            {
                this[nameof(barcode20)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode1
        {
            get
            {
                return (string)this[nameof(Sbarcode1)];
            }
            set
            {
                this[nameof(Sbarcode1)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode2
        {
            get
            {
                return (string)this[nameof(Sbarcode2)];
            }
            set
            {
                this[nameof(Sbarcode2)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode3
        {
            get
            {
                return (string)this[nameof(Sbarcode3)];
            }
            set
            {
                this[nameof(Sbarcode3)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode4
        {
            get
            {
                return (string)this[nameof(Sbarcode4)];
            }
            set
            {
                this[nameof(Sbarcode4)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode5
        {
            get
            {
                return (string)this[nameof(Sbarcode5)];
            }
            set
            {
                this[nameof(Sbarcode5)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode6
        {
            get
            {
                return (string)this[nameof(Sbarcode6)];
            }
            set
            {
                this[nameof(Sbarcode6)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode7
        {
            get
            {
                return (string)this[nameof(Sbarcode7)];
            }
            set
            {
                this[nameof(Sbarcode7)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode8
        {
            get
            {
                return (string)this[nameof(Sbarcode8)];
            }
            set
            {
                this[nameof(Sbarcode8)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode9
        {
            get
            {
                return (string)this[nameof(Sbarcode9)];
            }
            set
            {
                this[nameof(Sbarcode9)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode10
        {
            get
            {
                return (string)this[nameof(Sbarcode10)];
            }
            set
            {
                this[nameof(Sbarcode10)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode11
        {
            get
            {
                return (string)this[nameof(Sbarcode11)];
            }
            set
            {
                this[nameof(Sbarcode11)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode12
        {
            get
            {
                return (string)this[nameof(Sbarcode12)];
            }
            set
            {
                this[nameof(Sbarcode12)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode13
        {
            get
            {
                return (string)this[nameof(Sbarcode13)];
            }
            set
            {
                this[nameof(Sbarcode13)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode14
        {
            get
            {
                return (string)this[nameof(Sbarcode14)];
            }
            set
            {
                this[nameof(Sbarcode14)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode15
        {
            get
            {
                return (string)this[nameof(Sbarcode15)];
            }
            set
            {
                this[nameof(Sbarcode15)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode16
        {
            get
            {
                return (string)this[nameof(Sbarcode16)];
            }
            set
            {
                this[nameof(Sbarcode16)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode17
        {
            get
            {
                return (string)this[nameof(Sbarcode17)];
            }
            set
            {
                this[nameof(Sbarcode17)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode18
        {
            get
            {
                return (string)this[nameof(Sbarcode18)];
            }
            set
            {
                this[nameof(Sbarcode18)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode19
        {
            get
            {
                return (string)this[nameof(Sbarcode19)];
            }
            set
            {
                this[nameof(Sbarcode19)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public string Sbarcode20
        {
            get
            {
                return (string)this[nameof(Sbarcode20)];
            }
            set
            {
                this[nameof(Sbarcode20)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxSuccess
        {
            get
            {
                return (bool)this[nameof(chBoxSuccess)];
            }
            set
            {
                this[nameof(chBoxSuccess)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxError1
        {
            get
            {
                return (bool)this[nameof(chBoxError1)];
            }
            set
            {
                this[nameof(chBoxError1)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxError2
        {
            get
            {
                return (bool)this[nameof(chBoxError2)];
            }
            set
            {
                this[nameof(chBoxError2)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxError3
        {
            get
            {
                return (bool)this[nameof(chBoxError3)];
            }
            set
            {
                this[nameof(chBoxError3)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string successBatch
        {
            get
            {
                return (string)this[nameof(successBatch)];
            }
            set
            {
                this[nameof(successBatch)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string error1Batch
        {
            get
            {
                return (string)this[nameof(error1Batch)];
            }
            set
            {
                this[nameof(error1Batch)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string error2Batch
        {
            get
            {
                return (string)this[nameof(error2Batch)];
            }
            set
            {
                this[nameof(error2Batch)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string error3Batch
        {
            get
            {
                return (string)this[nameof(error3Batch)];
            }
            set
            {
                this[nameof(error3Batch)] = (object)value;
            }
        }
    }
}
