using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace WindowsForms_practice.Thread1
{
    class WordsObject
    {
        public string Word { get; protected set; }
        public string Definition { get; protected set; }

        public WordsObject(MySqlDataReader row)
        {
            this.Word = row["word"] == DBNull.Value ? this.Word : (string)row["word"];
            this.Definition = row["definition"] == DBNull.Value ? this.Word : (string)row["definition"];
        }
    }
}
