using System;
using dc_os.v1.dao;
using dc_os.v1.model.entidades;
using System.Linq;
using Deedle;
using dc_os.v1.model.services;
using Npgsql;
using System.Windows.Forms;
using view;


namespace dc_os.v1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new view.MainMenu());



        }
    }
}
