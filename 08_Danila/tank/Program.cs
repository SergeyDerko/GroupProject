﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
       [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Panzer());
        }
    }
}
