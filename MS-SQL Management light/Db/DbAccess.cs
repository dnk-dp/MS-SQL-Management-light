using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_SQL_Management_light
{
    class DbAccess
    {

        public static string ConnectionString()
        {
                return Properties.Settings.Default.ConnectionString;   
        }

        public static void SetConnectionString(int authentifizierungMethode, string server, string dataBase, string user, string password)
        {
            StringBuilder connectionString = new StringBuilder();
            connectionString.Append("Data Source={Server};Initial Catalog={DataBase};");
            connectionString.Replace("{Server}", server);
            connectionString.Replace("{DataBase}", dataBase);

            if (authentifizierungMethode == 0)
                connectionString.Append("Integrated Security=true");
            else
            {
                connectionString.Append("UID={User};PWD={Passwort}");
                connectionString.Replace("{User}", user);
                connectionString.Replace("{Passwort}", password);
            }
            Properties.Settings.Default.ConnectionString = connectionString.ToString();
            Properties.Settings.Default.Save();
        }

        public static void ChangeDBinConnectionString(string dataBase)
        {
            Properties.Settings.Default.DataBaseText = dataBase;

            int authentifizierungMethode = Properties.Settings.Default.AuthentifizierungItemIndex;
            string server = Properties.Settings.Default.ServernameText;
            string user = Properties.Settings.Default.BenutzernameText;
            string password = Properties.Settings.Default.Kennwort;
            SetConnectionString(authentifizierungMethode, server, dataBase, user, password);
            
        }



        public static bool TestConnection(int authentifizierungMethode, string server, string dataBase, string user, string password)
        {
            try
            {
                SetConnectionString(authentifizierungMethode, server, dataBase, user, password);
                using (SqlConnection connection =
                        new SqlConnection(ConnectionString()))
                {
                    connection.Open();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
                
        }
        #region TreeView
        public static DataTable GetDBNamen(bool isSystemDB)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(ConnectionString()))
                {
                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;

                    if (isSystemDB)
                        command.CommandText =
                            "select name " +
                            "from sys.databases " +
                            "where name in ('master', 'tempdb', 'model', 'msdb') " +
                            "order by name";
                    else
                        command.CommandText =
                            "select name " +
                            "from sys.databases " +
                            "where name not in ('master', 'tempdb', 'model', 'msdb') " +
                            "order by name";

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dtDBName = new DataTable();

                    adapter.Fill(dtDBName);

                    return dtDBName;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    "GetDBNamen(bool isSys): Fehler: {0} Grund: {1}",
                    ex.GetType(), ex.Message);

                return null;
            }
        }

        public static DataTable GetTables(string nameDB)
        {
            try
            {
                ChangeDBinConnectionString(nameDB);

                using (SqlConnection connection =
                    new SqlConnection(ConnectionString()))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText =
                            "SELECT name "+
                            "FROM sys.objects "+
                            "WHERE type in (N'U') "+
                            "order by name";

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dtDBName = new DataTable();
                    adapter.Fill(dtDBName);

                    return dtDBName;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    "GetDBNamen(bool isSys): Fehler: {0} Grund: {1}",
                    ex.GetType(), ex.Message);

                return null;
            }
        }
        public static DataTable GetFields(string nameDB, string nameTable)
        {
            try
            {
                if (Properties.Settings.Default.DataBaseText != nameDB)
                    ChangeDBinConnectionString(nameDB);

                using (SqlConnection connection =
                    new SqlConnection(ConnectionString()))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText =
                        String.Format(
                            "SELECT "+
                                "c.name 'ColumnName', " +
                                "t.Name 'DataType', " +
                                "c.max_length/2 'MaxLength', " +
                                "c.is_nullable, " +
                                "ISNULL(i.is_primary_key, 0) 'PrimaryKey' " +
                            "FROM sys.columns c " +
                            "INNER JOIN sys.types t ON c.user_type_id = t.user_type_id " +
                            "LEFT OUTER JOIN sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id " +
                            "LEFT OUTER JOIN sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id " +
                            "WHERE c.object_id = OBJECT_ID('{0}') ", nameTable);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dtDBName = new DataTable();
                    adapter.Fill(dtDBName);

                    return dtDBName;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    "GetDBNamen(bool isSys): Fehler: {0} Grund: {1}",
                    ex.GetType(), ex.Message);

                return null;
            }
        }

        #endregion

        public static bool JustExecSQL(string sql, out string mess, out int Count)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString()))
                {
                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandText = sql;
                    command.CommandTimeout = 100500;
                    connection.Open();
                    Count = command.ExecuteNonQuery();
                    mess = "Erfolg!";
                    return true;
                }
            }
            catch (Exception ex)
            {
                Count = 0;
                mess = String.Format("Fehler: {0}\nGrund: {1}", ex.GetType(), ex.Message);
                return false;
            }
        }

        public static bool OpenSQL(string sql, out DataTable DT, out string Mess)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString()))
                {
                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandText = sql;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DT = dt;
                    Mess = "";
                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                DT = null;
                Mess = String.Format(
                "Fehler: {0}\nGrund: {1}",
                    ex.GetType(), ex.Message);
                return false;
            }
        }

        public static bool ExecSQL(string sql, out DataTable DT, out string Mess, out int Count)
        {
            string select = "SELECT";
            if (sql.Trim().Length > select.Length && (sql.Trim().Remove(select.Length)).ToUpper() == select)
            {
                bool isOK = OpenSQL(sql, out DT, out Mess);

                Count = isOK ? DT.Rows.Count : 0;
                return isOK;
            }

            else
            {
                DT = null;
                bool isOK = JustExecSQL(sql, out Mess, out Count);
                return isOK;
            }
        }

        public static string BuldSelectTabGroes()
        {
            string sql =
                "SELECT "+
                "    t.NAME AS TableName, " +
                //"    s.Name AS SchemaName, "+
                "    p.rows AS RowCounts, " +
                //"    SUM(a.total_pages) * 8 AS TotalSpaceKB, "+
                "    CAST(ROUND(((SUM(a.total_pages) * 8) / 1024.00), 2) AS NUMERIC(36, 2)) AS TotalSpaceMB, " +
                //"    SUM(a.used_pages) * 8 AS UsedSpaceKB, "+
                "    CAST(ROUND(((SUM(a.used_pages) * 8) / 1024.00), 2) AS NUMERIC(36, 2)) AS UsedSpaceMB, " +
                //"    (SUM(a.total_pages) - SUM(a.used_pages)) * 8 AS UnusedSpaceKB, "+
                "    CAST(ROUND(((SUM(a.total_pages) - SUM(a.used_pages)) * 8) / 1024.00, 2) AS NUMERIC(36, 2)) AS UnusedSpaceMB " +
                "FROM sys.tables t " +
                "INNER JOIN sys.indexes i ON t.OBJECT_ID = i.object_id " +
                "INNER JOIN sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id " +
                "INNER JOIN sys.allocation_units a ON p.partition_id = a.container_id " +
                "LEFT OUTER JOIN sys.schemas s ON t.schema_id = s.schema_id " +
                "WHERE " +
                "    t.NAME NOT LIKE 'dt%' and " +
                "     t.is_ms_shipped = 0 " +
                "    AND i.OBJECT_ID > 255 " +
                "GROUP BY " +
                "    t.Name, s.Name, p.Rows ";
                //"ORDER BY
                //"TotalSpaceMB desc
                //"    t.Name"

            return sql;
        }
        public static string BuldSelectTop1000Query(string nameTable)
        {
            
            DataTable dtTable = GetFields(Properties.Settings.Default.DataBaseText, nameTable);

            if (dtTable == null) return "";

            StringBuilder sb = new StringBuilder("SELECT TOP (1000) [");


            foreach (DataRow row in dtTable.Rows)
            {
                sb.Append(row["ColumnName"].ToString());
                sb.Append("]\n,[");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append("FROM [" + nameTable + "]");

            return sb.ToString();
        }
        public static bool CreateNewDB(string dBName, string dataPath, string logPath, out string mess)
        {
            string sql = String.Format(
                "CREATE DATABASE[{0}]  ON PRIMARY(NAME = N'{0}_Data', " +
                "FILENAME = N'{1}' , SIZE = 3, FILEGROWTH = 10 %) " +
                "LOG ON(NAME = N'{0}_Log', FILENAME = N'{2}', " +
                "SIZE = 3, FILEGROWTH = 10 %)", dBName, dataPath, logPath);
            return JustExecSQL(sql, out mess, out int i );
        }

        public static bool DropDB(string dBName, out string mess)
        {
            string sql = "DROP DATABASE [" + dBName + "]";
            return JustExecSQL(sql, out mess, out int i);
        }

        public static bool BackupDB(string dBName, string file, out string mess)
        {
            string sql = String.Format("BACKUP DATABASE [{0}] TO " +
                            "DISK = N'{1}' WITH NOINIT, " +
                            "NOUNLOAD, NAME = N'{0} backup',  NOSKIP ,  STATS = 10,  NOFORMAT; ", dBName, file);
            return JustExecSQL(sql, out mess, out int i);
        }
        public static bool RestoreDB(string dBName, string file, out string Mess)
        {
            DataTable dt;
            string sql = String.Format("RESTORE FILELISTONLY FROM  DISK = N'{0}' WITH  NOUNLOAD,  FILE = 1", file);
            if (!OpenSQL(sql, out dt, out Mess)) return false;
            string nameDataFileInBackup = dt.Rows[0][0].ToString();
            string nameLogFileInBackup = dt.Rows[1][0].ToString();

            sql = String.Format("SELECT Physical_Name " +
                      "FROM sys.master_files mf " +
                      "INNER JOIN sys.databases db ON db.database_id = mf.database_id " +
                      "where db.name = '{0}'", dBName);
            if (!OpenSQL(sql, out dt, out Mess)) return false;
            string fileData = dt.Rows[0][0].ToString();
            string fileLog = dt.Rows[1][0].ToString();

            sql = String.Format("RESTORE DATABASE[{0}] FROM DISK = N'{1}' " +
                "WITH FILE = 1, MOVE N'{2}' TO N'{3}',  " +
                "MOVE N'{4}' TO N'{5}',  NOUNLOAD,  REPLACE,  STATS = 5",
                dBName, file, nameDataFileInBackup, fileData, nameLogFileInBackup, fileLog);

            return JustExecSQL(sql, out Mess, out int i);
        }

    }
}
