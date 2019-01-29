using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPP.Fasade
{
    class DbConnection
    {
        private static volatile DbConnection instance;
        private volatile SqlConnection connection;
        private static object syncRoot = new object();

        private DbConnection(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public static DbConnection GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new DbConnection(Configuration.personsConnectionString);
                    }
                }

                return instance;
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
