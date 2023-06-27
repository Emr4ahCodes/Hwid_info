using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Management;
using System.Security.Cryptography;


namespace Hwid_changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string MachineName1 = Environment.MachineName;
            string OS = Environment.OSVersion.ToString();
            pcid.Text = MachineName1;
            sisteminfo.Text = OS;
            string hwid_id = GetHWID();
            string mac = GetMACAddress().ToString();
            macid.Text = mac;
            hwidid.Text = hwid_id;
            string hddSerialNumber = GetHDDSerialNumber();
            hddno.Text = hddSerialNumber;
            cpuno.Text = GetCpuSerialNumber();

        }
        public static string GetHDDSerialNumber()
        {
            string query = "SELECT SerialNumber FROM Win32_DiskDrive WHERE MediaType='Fixed hard disk media'";
            string serialNumber = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                ManagementObjectCollection results = searcher.Get();
                foreach (ManagementObject obj in results)
                {
                    serialNumber = obj["SerialNumber"].ToString();
                    break; // İlk bulunan seri numarasını alır.
                }
            }
            return serialNumber;
        }
        public static string GetHWID()
        {
            // Ana kart seri numarasını almak için WMI (Windows Management Instrumentation) kullanılır.
            string baseboardSerial = GetBaseboardSerialNumber();

            // BIOS seri numarasını almak için WMI kullanılır.
            string biosSerial = GetBiosSerialNumber();

            // CPU seri numarasını almak için WMI kullanılır.
            string cpuSerial = GetCpuSerialNumber();

            // Alınan tüm seri numaraları birleştirilerek HWID oluşturulur.
            string hwid = baseboardSerial + biosSerial + cpuSerial;

            return hwid;
        }
        private static string GetBaseboardSerialNumber()
        {
            string query = "SELECT SerialNumber FROM Win32_BaseBoard";
            string serialNumber = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                ManagementObjectCollection results = searcher.Get();
                foreach (ManagementObject obj in results)
                {
                    serialNumber = obj["SerialNumber"].ToString();
                    break; // İlk bulunan seri numarasını alır.
                }
            }
            return serialNumber;
        }

        private static string GetBiosSerialNumber()
        {
            string query = "SELECT SerialNumber FROM Win32_BIOS";
            string serialNumber = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                ManagementObjectCollection results = searcher.Get();
                foreach (ManagementObject obj in results)
                {
                    serialNumber = obj["SerialNumber"].ToString();
                    break; // İlk bulunan seri numarasını alır.
                }
            }
            return serialNumber;
        }

        private static string GetCpuSerialNumber()
        {
            string query = "SELECT ProcessorId FROM Win32_Processor";
            string serialNumber = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                ManagementObjectCollection results = searcher.Get();
                foreach (ManagementObject obj in results)
                {
                    serialNumber = obj["ProcessorId"].ToString();
                    break; // İlk bulunan seri numarasını alır.
                }
            }
            return serialNumber;
        }

        private void pcid_Click(object sender, EventArgs e)
        {

        }

        private void Bilgi_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static string GetMACAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                    return AddressBytesToString(nic.GetPhysicalAddress().GetAddressBytes());
            }

            return string.Empty;
        }

        private static string AddressBytesToString(byte[] addressBytes)
        {
            return string.Join(":", (from b in addressBytes
                                     select b.ToString("X2")).ToArray());
        }
    }
}
