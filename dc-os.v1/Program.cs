using System;
using dc_os.v1.dao;

namespace dc_os.v1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GenericDAO dao = new GenericDAO();
            var select = dao.SQLselect("SELECT* FROM dcos.turnos");
            Console.WriteLine(select);


        }
    }
}
