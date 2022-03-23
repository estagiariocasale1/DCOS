using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    public class TurnosDAO : GenericDAO
    {
        
        public void select()
        {
            string sql = "SELECT* FROM dcos.turnos";
            TurnosDAO dao = new TurnosDAO();
            NpgsqlDataReader reader = dao.SQLselect(sql);

        }       
        

        /*
        Console.WriteLine(reader.FieldCount);
            while (reader.Read())
            {
                Console.WriteLine("{0} {1}", reader.GetInt32(0), reader.GetString(1)); 
                        
            }
        */
    }
}
