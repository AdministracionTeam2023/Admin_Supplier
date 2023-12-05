using AdminSuppliers.Core;
using AdminSuppliers.Core.Contratos;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AdminSupplier.Persistence
{

    public class DBContext : IDisposable
    {
        private string? _ServerName = ConfigurationManager.AppSettings["serverName"];
        private string? _DataBase = ConfigurationManager.AppSettings["dataBase"];
        private SqlConnection _MySqlConection;
        public DBContext()
        {
            _MySqlConection = new SqlConnection(
                                            $"Data Source={_ServerName};" +
                                            $"Initial Catalog={_DataBase};" +
                                            "Integrated Security=true;");


        }
        public DBContext(string serverName, string dataBase)
        {
            _MySqlConection = new SqlConnection(
                                            $"Data Source={serverName};" +
                                            $"Initial Catalog={dataBase};" +
                                            "Integrated Security=true;");


        }

        public void Dispose()
        {
            _MySqlConection.Close();
        }

        public SqlDataReader GetAll<T>(string clasName) where T : class
        {
            using (SqlCommand mySqlCommad = _MySqlConection.CreateCommand())
            {
                mySqlCommad.CommandText = $"Execute Get_{clasName}s";
                //mySqlCommad.Parameters.Add("@edad", System.Data.SqlDbType.Int)
                //                      .Value = 10;

                _MySqlConection.Open();
                return mySqlCommad.ExecuteReader();
            }
        }

        public int CreateTecnico(Tecnico tecnico)
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tecnico>));
            using (StreamWriter writer = new StreamWriter("tecnicos.xml"))
            {
                using (SqlCommand mySqlCommad = _MySqlConection.CreateCommand())
                {
                    StringBuilder xmlBuilder = new StringBuilder();
                    string xmlString = xmlBuilder.ToString();
                    serializer.Serialize(writer, tecnico);
                    mySqlCommad.CommandText = "CreateTecnicos";
                    mySqlCommad.CommandType = CommandType.StoredProcedure;
                    mySqlCommad.Parameters.Add("@xmlData", System.Data.SqlDbType.Xml)
                        .Value = xmlString;
                    _MySqlConection.Open();
                    //mySqlCommad.ExecuteNonQuery();
                    var result = mySqlCommad.ExecuteReader();
                }
            }
            return 1;
        }
        public int Eliminar(string clasName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SqlDataReader));
            using (StreamWriter writer = new StreamWriter($"Execute Delete{clasName}"))
            {
                // serializar la lista de personas y escribir en el archivo
                serializer.Serialize(writer, GetAll<Tecnico>);
            }
            return 1;
        }

        public SqlDataReader GetReportResults<T>(DateTime dateInit, DateTime? dateEnd) where T : class, IReport
        {
            using (SqlCommand mySqlCommad = _MySqlConection.CreateCommand())
            {
                mySqlCommad.CommandText = $"Execute Get_Reports @dateInit @dateEnd";

                mySqlCommad.Parameters.Add("@DateInit", System.Data.SqlDbType.DateTime)
                                      .Value = dateInit;
                mySqlCommad.Parameters.Add("@DateEnd", System.Data.SqlDbType.DateTime)
                                      .Value = dateEnd ?? DateTime.Now;

                _MySqlConection.Open();
                return mySqlCommad.ExecuteReader();
            }
        }
        public void Calificar<T>(int id, long calification) where T : Tecnico
        {
            using (SqlCommand mySqlCommad = _MySqlConection.CreateCommand())
            {
                mySqlCommad.CommandText = $"Execute CalificarTecnico @Calification";
                mySqlCommad.Parameters.Add("@id", System.Data.SqlDbType.Int)
                                      .Value = id;
                mySqlCommad.Parameters.Add("@Calification", System.Data.SqlDbType.BigInt)
                                      .Value = calification;

                _MySqlConection.Open();
                mySqlCommad.ExecuteNonQuery();
            }
        }
    }
}

