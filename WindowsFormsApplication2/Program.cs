﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    // ------------------------------------
    // Classe estática de variáveis globais (necessito usar em diversos Forms)
    //-------------------------------------
    public class variaveis
    {
        public static Form CurrentForm = Form.ActiveForm;
        public  static string utiliz ;
    }

    static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
      
        static void Main()
        {
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
