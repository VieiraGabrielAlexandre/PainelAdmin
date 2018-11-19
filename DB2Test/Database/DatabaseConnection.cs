using System;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;


namespace DB2Test
{
    public class DatabaseConnection
    {
        public String db2ConnectionString { get; set; }
        public OdbcDataReader MyDb2DataReader { get; set; }
        public String valorRecebido { get; set; }
        public OdbcConnection MyDb2Connection { get; set; }
        public OdbcCommand db2Query { get; set; }
        public ArrayList arrayListDebug = new ArrayList();



        ~DatabaseConnection()
        {
            if(MyDb2Connection.State == ConnectionState.Open)
            {
                MyDb2Connection.Close();
            }
        }

        // Gera a conexão e deixa ativa em myDb2Connection e mantem ativa para outras operações

        public DatabaseConnection(String strAlias, String strLogin, String strPassword)
        {
            db2ConnectionString = "DSN="+strAlias + ";user="+strLogin+";PWD="+strPassword+";";

            arrayListDebug.Add("Conectando-se a " + strAlias + "...\n");
            arrayListDebug.Add("Connection string -> " + db2ConnectionString + "\n");

            MyDb2Connection = new OdbcConnection(db2ConnectionString);

            try
            {
                MyDb2Connection.Open();
                arrayListDebug.Add("Conectado.");
            }
            catch(OdbcException e)
            {
                arrayListDebug.Add(e.ToString() + " \n CÓDIGO: " + e.ErrorCode.ToString());
            }
        }

        // SELECT - FAZER RETORNO DE STRING 
        public void ExecuteSelectQuery(String inputSelectQuery, ArrayList arraySelectList)
        {
            arraySelectList.Clear(); // Limpa a lista antes de utilizar
            db2Query = MyDb2Connection.CreateCommand();
            db2Query.CommandText = inputSelectQuery;
            arrayListDebug.Add("\n> " + db2Query.CommandText + "\n");

            try
            {
                MyDb2DataReader = db2Query.ExecuteReader();

                while (MyDb2DataReader.Read())
                {
                     for (int i = 0; i <= MyDb2DataReader.FieldCount-1; i++)
                    {
                        try
                        {
                            if (MyDb2DataReader.IsDBNull(i)) // Para campos sem valor
                            {
                                arrayListDebug.Add("NULL");
                                arraySelectList.Add("NULL");
                            }
                            else
                            {
                                switch (MyDb2DataReader.GetDataTypeName(i)) // Verifica o tipo do valor recebido e faz a conversão do valor
                                {
                                    case "CHAR":
                                    case "VARCHAR":
                                        valorRecebido = MyDb2DataReader.GetString(i);
                                        break;
                                    case "DATE":
                                    case "TIMESTAMP":
                                        valorRecebido = MyDb2DataReader.GetDateTime(i).ToString();
                                        break;
                                    case "SMALLINT":
                                        valorRecebido = MyDb2DataReader.GetInt16(i).ToString();
                                        break;
                                    case "DECIMAL":
                                        valorRecebido = MyDb2DataReader.GetDecimal(i).ToString();
                                        break;
                                    case "INTEGER":
                                        valorRecebido = MyDb2DataReader.GetInt32(i).ToString();
                                        break;
                                    default:
                                        MessageBox.Show("Não reconhecido! Tipo " + MyDb2DataReader.GetDataTypeName(i));
                                        arrayListDebug.Add("Não reconhecido: Tipo " + MyDb2DataReader.GetDataTypeName(i) + " com valor " + valorRecebido + "\n");
                                        break;
                                } 
                                arraySelectList.Add(valorRecebido);
                                arrayListDebug.Add(valorRecebido);

                            }
                        }
                        catch (OdbcException e)
                        {
                            arrayListDebug.Add(e.ToString());
                        }
                        arrayListDebug.Add("\t");

                    }
                    arrayListDebug.Add("\n");
                }
                arrayListDebug.Add("\n");
                MyDb2DataReader.Close();
            }
            catch (OdbcException e)
            {
                arrayListDebug.Add(e.ToString() + " \n CÓDIGO: "+ e.ErrorCode);
            }
            db2Query.Dispose();
        }
    }
}
