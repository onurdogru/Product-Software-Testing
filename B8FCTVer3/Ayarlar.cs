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
    internal sealed class Ayarlar : ApplicationSettingsBase
    {
        private static Ayarlar defaultInstance = (Ayarlar)SettingsBase.Synchronized((SettingsBase)new Ayarlar());

        public static Ayarlar Default
        {
            get
            {
                return Ayarlar.defaultInstance;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxProgramlama
        {
            get
            {
                return (bool)this[nameof(chBoxProgramlama)];
            }
            set
            {
                this[nameof(chBoxProgramlama)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string projectName
        {
            get
            {
                return (string)this[nameof(projectName)];
            }
            set
            {
                this[nameof(projectName)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string printerName
        {
            get
            {
                return (string)this[nameof(printerName)];
            }
            set
            {
                this[nameof(printerName)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string txtINIdosya
        {
            get
            {
                return (string)this[nameof(txtINIdosya)];
            }
            set
            {
                this[nameof(txtINIdosya)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string txtLogDosya
        {
            get
            {
                return (string)this[nameof(txtLogDosya)];
            }
            set
            {
                this[nameof(txtLogDosya)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1920/1080")]
        public string cozunurluk
        {
            get
            {
                return (string)this[nameof(cozunurluk)];
            }
            set
            {
                this[nameof(cozunurluk)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1299")]
        public string adminSifre
        {
            get
            {
                return (string)this[nameof(adminSifre)];
            }
            set
            {
                this[nameof(adminSifre)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1453")]
        public string kaliteSifre
        {
            get
            {
                return (string)this[nameof(kaliteSifre)];
            }
            set
            {
                this[nameof(kaliteSifre)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("Kitaplıklar\\Belgeler\\logpersonel.accdb")]
        public string PNGdosyayolu
        {
            get
            {
                return (string)this[nameof(PNGdosyayolu)];
            }
            set
            {
                this[nameof(PNGdosyayolu)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxSerial1
        {
            get
            {
                return (bool)this[nameof(chBoxSerial1)];
            }
            set
            {
                this[nameof(chBoxSerial1)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxSerial2
        {
            get
            {
                return (bool)this[nameof(chBoxSerial2)];
            }
            set
            {
                this[nameof(chBoxSerial2)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxSerial3
        {
            get
            {
                return (bool)this[nameof(chBoxSerial3)];
            }
            set
            {
                this[nameof(chBoxSerial3)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxSerial4
        {
            get
            {
                return (bool)this[nameof(chBoxSerial4)];
            }
            set
            {
                this[nameof(chBoxSerial4)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1000")]
        public int SerialTx1Timer
        {
            get
            {
                return (int)this[nameof(SerialTx1Timer)];
            }
            set
            {
                this[nameof(SerialTx1Timer)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1000")]
        public int SerialTx2Timer
        {
            get
            {
                return (int)this[nameof(SerialTx2Timer)];
            }
            set
            {
                this[nameof(SerialTx2Timer)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("5000")]
        public int SerialTx3Timer
        {
            get
            {
                return (int)this[nameof(SerialTx3Timer)];
            }
            set
            {
                this[nameof(SerialTx3Timer)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("5000")]
        public int SerialTx4Timer
        {
            get
            {
                return (int)this[nameof(SerialTx4Timer)];
            }
            set
            {
                this[nameof(SerialTx4Timer)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("5000")]
        public int serialRxTimeout
        {
            get
            {
                return (int)this[nameof(serialRxTimeout)];
            }
            set
            {
                this[nameof(serialRxTimeout)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1000")]
        public int timerAdmin
        {
            get
            {
                return (int)this[nameof(timerAdmin)];
            }
            set
            {
                this[nameof(timerAdmin)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("COM8")]
        public string SerialPort1Com
        {
            get
            {
                return (string)this[nameof(SerialPort1Com)];
            }
            set
            {
                this[nameof(SerialPort1Com)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("9600")]
        public int SerialPort1Baud
        {
            get
            {
                return (int)this[nameof(SerialPort1Baud)];
            }
            set
            {
                this[nameof(SerialPort1Baud)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("8")]
        public int SerialPort1dataBits
        {
            get
            {
                return (int)this[nameof(SerialPort1dataBits)];
            }
            set
            {
                this[nameof(SerialPort1dataBits)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("One")]
        public StopBits SerialPort1stopBit
        {
            get
            {
                return (StopBits)this[nameof(SerialPort1stopBit)];
            }
            set
            {
                this[nameof(SerialPort1stopBit)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("None")]
        public Parity SerialPort1Parity
        {
            get
            {
                return (Parity)this[nameof(SerialPort1Parity)];
            }
            set
            {
                this[nameof(SerialPort1Parity)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("COM4")]
        public string SerialPort2Com
        {
            get
            {
                return (string)this[nameof(SerialPort2Com)];
            }
            set
            {
                this[nameof(SerialPort2Com)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("9600")]
        public int SerialPort2Baud
        {
            get
            {
                return (int)this[nameof(SerialPort2Baud)];
            }
            set
            {
                this[nameof(SerialPort2Baud)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("8")]
        public int SerialPort2dataBits
        {
            get
            {
                return (int)this[nameof(SerialPort2dataBits)];
            }
            set
            {
                this[nameof(SerialPort2dataBits)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("One")]
        public StopBits SerialPort2stopBit
        {
            get
            {
                return (StopBits)this[nameof(SerialPort2stopBit)];
            }
            set
            {
                this[nameof(SerialPort2stopBit)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("None")]
        public Parity SerialPort2Parity
        {
            get
            {
                return (Parity)this[nameof(SerialPort2Parity)];
            }
            set
            {
                this[nameof(SerialPort2Parity)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("COM7")]
        public string SerialPort3Com
        {
            get
            {
                return (string)this[nameof(SerialPort3Com)];
            }
            set
            {
                this[nameof(SerialPort3Com)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("9600")]
        public int SerialPort3Baud
        {
            get
            {
                return (int)this[nameof(SerialPort3Baud)];
            }
            set
            {
                this[nameof(SerialPort3Baud)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("8")]
        public int SerialPort3dataBits
        {
            get
            {
                return (int)this[nameof(SerialPort3dataBits)];
            }
            set
            {

                this[nameof(SerialPort3dataBits)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("One")]
        public StopBits SerialPort3stopBits
        {
            get
            {
                return (StopBits)this[nameof(SerialPort3stopBits)];
            }
            set
            {
                this[nameof(SerialPort3stopBits)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("None")]
        public Parity SerialPort3Parity
        {
            get
            {
                return (Parity)this[nameof(SerialPort3Parity)];
            }
            set
            {
                this[nameof(SerialPort3Parity)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("COM7")]
        public string SerialPort4Com
        {
            get
            {
                return (string)this[nameof(SerialPort4Com)];
            }
            set
            {
                this[nameof(SerialPort4Com)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("9600")]
        public int SerialPort4Baud
        {
            get
            {
                return (int)this[nameof(SerialPort4Baud)];
            }
            set
            {
                this[nameof(SerialPort4Baud)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("8")]
        public int SerialPort4dataBits
        {
            get
            {
                return (int)this[nameof(SerialPort4dataBits)];
            }
            set
            {

                this[nameof(SerialPort4dataBits)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("One")]
        public StopBits SerialPort4stopBits
        {
            get
            {
                return (StopBits)this[nameof(SerialPort4stopBits)];
            }
            set
            {
                this[nameof(SerialPort4stopBits)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("None")]
        public Parity SerialPort4Parity
        {
            get
            {
                return (Parity)this[nameof(SerialPort4Parity)];
            }
            set
            {
                this[nameof(SerialPort4Parity)] = (object)value;
            }
        }
    }
}
