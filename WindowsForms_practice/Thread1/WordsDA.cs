using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace WindowsForms_practice.Thread1
{
    class WordsDA
    {
        public void LoadAll(ICollection<WordsObject> WO)
        {
            string cstr = "Server=localhost;Database=gre;Uid=root;Pwd=nsxr;";
            string sql = "SELECT * FROM words";

            using (MySqlConnection conn = new MySqlConnection(cstr))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = null;

                try
                {
                    conn.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        WO.Add(new WordsObject(rdr));
                    }
                }
                catch (MySqlException e) { throw; }

                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }

            }


        }
    }
}
