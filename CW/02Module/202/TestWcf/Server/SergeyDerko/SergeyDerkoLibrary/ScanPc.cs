using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace SergeyDerkoLibrary
{
    public class ScanPc : IScanPc
    {
        public List<StringBuilder> Info()
        {
            var info = new List<StringBuilder>();
            var disc = new StringBuilder();

            ManagementObjectSearcher scan1 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");

            foreach (var o in scan1.Get())
            {
                disc.Append("-----------Информация о жостком диске-------------------\n");
                disc.Append(" \n");
                disc.Append("Размер диска : " + Math.Round(Convert.ToDouble(o["Size"]) / 1024 / 1024 / 1024, 2) + " Gb \n");
                disc.Append("--------------------------------------------------------\n");
            }

            ManagementObjectSearcher scan2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Volume");

            foreach (var o in scan2.Get())
            {

                disc.Append("Раздел          :    " + o["Caption"] + "\n");
                disc.Append("Файловая система:    " + o["FileSystem"] + "\n");
                disc.Append("Свободное место :    " + Math.Round(Convert.ToDouble(o["FreeSpace"]) / 1024 / 1024 / 1024, 2) + " Gb\n");
                disc.Append("-------------------------------------------------------- \n");
            }
            ManagementObjectSearcher scan3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            var processor = new StringBuilder();
            foreach (var o in scan3.Get())
            {
                processor.Append(" \n");
                processor.Append("-----------Информация о процессоре----------------------\n");
                processor.Append(" \n");
                processor.Append("Параметры     : " + o["Name"] + " \n");
                processor.Append("количество яиц: " + o["NumberOfCores"] + "  \n");
                processor.Append(" \n");

            }

            ManagementObjectSearcher scan4 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            var video = new StringBuilder();
            foreach (var o in scan4.Get())
            {
                video.Append("----------- Информация о видеокарте --------------------\n");
                video.Append(" \n");
                video.Append("Модель           : " + o["Caption"] + " \n");
                video.Append("Количество памяти: " + Math.Round(Convert.ToDouble(o["AdapterRAM"]) / 1024 / 1024 / 1024, 2) + " Gb \n");
                video.Append(" \n");

            }

            ManagementObjectSearcher scan5 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            var memory = new StringBuilder();
            memory.Append("------------- Инфо о планках памяти --------------------\n");
            foreach (var o in scan5.Get())
            {
                memory.Append("Размер: " + Math.Round(Convert.ToDouble(o["Capacity"]) / 1024 / 1024 / 1024, 2) + " Gb  " + "Скорость: " + o["Speed"] + " \n");
            }
            info.Add(disc);
            info.Add(processor);
            info.Add(video);
            info.Add(memory);
            return info;
        }
    }
}
