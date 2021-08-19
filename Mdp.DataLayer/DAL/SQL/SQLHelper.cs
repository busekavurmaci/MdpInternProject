using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Mdp.DataLayer.DAL.SQL
{
    public class SQLDmlOperationResult : DmlOperationResult
    {

    }
    public class DmlOperationResult
    {
        public bool Succefull = false;
        public string ReturnValue = "";
        public string ErrorMessage = "";
    }

    public class SQLHelper
    {
        public static string ConnectionString
        {
            get
            {
                //-- return System.Configuration.ConfigurationSettings.AppSettings["DB_01"];
                //-- connection stringi yukarıdaki gibi web.config'den almayı deneyiniz.
                return "Data Source = localhost; Initial Catalog = efaturatest; Integrated Security=true";


            }
        }


        //public static string GetDataItem(string queryText, string[] parameterNames, object[] parameterValues, CommandType commandType)
        //{
        //    string returnValue = "";
        //    SqlConnection cnn = new SqlConnection(ConnectionString);

        //    SqlCommand cmd = new SqlCommand(queryText, cnn);
        //    cmd.CommandType = commandType;

        //    if (parameterNames != null && parameterNames.Length > 0)
        //    {
        //        for (int i = 0; i < parameterNames.Length; i++)
        //        {
        //            cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
        //        }
        //    }

        //    try
        //    {
        //        cnn.Open();
        //        returnValue = Convert.ToString(cmd.ExecuteScalar());

        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //    }

        //    return returnValue;
        //}

        ////--------------------------------------------------------
        //public static T GetDataItem<T>(string queryText, string[] parameterNames, object[] parameterValues, CommandType commandType) where T : class, IBusinessEntity, new()
        //{

        //    SqlConnection cnn = new SqlConnection(ConnectionString);

        //    SqlCommand cmd = new SqlCommand(queryText, cnn);
        //    cmd.CommandType = commandType;

        //    if (parameterNames != null && parameterNames.Length > 0)
        //    {
        //        for (int i = 0; i < parameterNames.Length; i++)
        //        {
        //            cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
        //        }
        //    }

        //    T dataItem = new T();

        //    try
        //    {
        //        cnn.Open();

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader != null && reader.HasRows)
        //            {
        //                if (reader.Read())
        //                    dataItem.Fill(reader);
        //                else
        //                    dataItem = null;
        //            }
        //            else
        //            {
        //                dataItem = null;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //    }

        //    return dataItem;
        //}

        ////--------------------------------------------------------
        //public static List<T> GetDataItems<T>(string queryText, string[] parameterNames, object[] parameterValues, CommandType commandType) where T : IBusinessEntity, new()
        //{
        //    SqlConnection cnn = new SqlConnection(ConnectionString);

        //    SqlCommand cmd = new SqlCommand(queryText, cnn);
        //    cmd.CommandType = commandType;
        //    cmd.CommandTimeout = 120;

        //    if (parameterNames != null && parameterNames.Length > 0)
        //    {
        //        for (int i = 0; i < parameterNames.Length; i++)
        //        {
        //            if (parameterValues[i]!=null) //-- null parametreleri ekleme 19.12.2016
        //                cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
        //        }
        //    }

        //    List<T> dataItems = new List<T>();

        //    try
        //    {
        //        cnn.Open();

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader != null)
        //            {
        //                while (reader.Read())
        //                {
        //                    T dataItem = new T();
        //                    dataItem.Fill(reader);
        //                    dataItems.Add(dataItem);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("on GetDataItems:"+ex.Message);
        //    }
        //    finally
        //    {
        //        if (cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //    }

        //    return dataItems;
        //}

        ////--------------------------------------------------------
        //public static List<T> GetDataItems<T>(string queryText) where T : IBusinessEntity, new()  // 03.05.2012
        //{
        //    SqlConnection cnn = new SqlConnection(ConnectionString);

        //    SqlCommand cmd = new SqlCommand(queryText, cnn);
        //    cmd.CommandType = CommandType.Text;

        //    List<T> dataItems = new List<T>();

        //    try
        //    {
        //        cnn.Open();

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader != null)
        //            {
        //                while (reader.Read())
        //                {
        //                    T dataItem = new T();
        //                    dataItem.Fill(reader);
        //                    dataItems.Add(dataItem);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //    }

        //    return dataItems;
        //}

        ////--------------------------------------------------------
        //public static DataSet GetDataItems(string queryText)
        //{
        //    SqlConnection cnn = new SqlConnection(ConnectionString);

        //    //MySqlCommand cmd = new MySqlCommand(queryText, cnn);
        //    //cmd.CommandType = CommandType.Text;

        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(queryText, cnn);
        //        da.Fill(ds);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //    }

        //    return ds;
        //}

        ////--------------------------------------------------------
        //public static DataSet GetDataItems(string queryText, string[] parameterNames, object[] parameterValues)
        //{
        //    SqlConnection cnn = new SqlConnection(ConnectionString);

        //    SqlCommand cmd = new SqlCommand(queryText, cnn);
        //    cmd.CommandType = CommandType.Text;

        //    if (parameterNames != null && parameterNames.Length > 0)
        //    {
        //        for (int i = 0; i < parameterNames.Length; i++)
        //        {
        //            cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
        //        }
        //    }
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(ds);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //    }

        //    return ds;
        //}

        ////--------------------------------------------------------

        public static DataTable GetDataTable(string queryText, string[] parameterNames, object[] parameterValues)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand(queryText, cnn);
            cmd.CommandType = CommandType.Text;

            if (parameterNames != null && parameterNames.Length > 0)
            {
                for (int i = 0; i < parameterNames.Length; i++)
                {
                    if (parameterValues[i] != null) //-- null parametreleri ekleme
                        cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
                }
            }
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                if (ex.Data == null)
                {
                    throw;
                }
                
            }


            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return dt;
        }

        //--------------------------------------------------------
        //public static List<string> GetDataItemsString(string queryText, string[] parameterNames, object[] parameterValues, CommandType commandType)
        //{
        //    SqlConnection cnn = new SqlConnection(ConnectionString);

        //    SqlCommand cmd = new SqlCommand(queryText, cnn);
        //    cmd.CommandType = commandType;

        //    if (parameterNames != null && parameterNames.Length > 0)
        //    {
        //        for (int i = 0; i < parameterNames.Length; i++)
        //        {
        //            if (parameterValues[i] != null) //-- null parametreleri ekleme 19.12.2016
        //                cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
        //        }
        //    }

        //    List<string> dataItems = new List<string>();

        //    try
        //    {
        //        cnn.Open();

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader != null)
        //            {
        //                while (reader.Read())
        //                {
        //                    string dataItem = Convert.ToString(reader[0]);
        //                    dataItems.Add(dataItem);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //    }

        //    return dataItems;
        //}

        ////--------------------------------------------------------
        //public static SQLDmlOperationResult InsertDataItem(string queryText, string[] parameterNames, object[] parameterValues, CommandType commandType)
        //{
        //    SQLDmlOperationResult ret = new SQLDmlOperationResult();
        //    SqlConnection cnn = new SqlConnection(ConnectionString);
        //    SqlCommand cmd = new SqlCommand(queryText, cnn);
        //    //MySqlTransaction trans;

        //    cmd.CommandType = commandType;

        //    if (parameterNames != null && parameterNames.Length > 0)
        //    {
        //        for (int i = 0; i < parameterNames.Length; i++)
        //        {
        //            cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
        //            if (cmd.Parameters[i].Value == null || cmd.Parameters[i].Value == null) cmd.Parameters[i].Value = DBNull.Value;
        //        }
        //    }

        //    try
        //    {
        //        cnn.Open();
        //        ret.ReturnValue = cmd.ExecuteNonQuery().ToString();
        //        ret.Succefull = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        //Exception x = new Exception(retStr, ex);
        //        throw ex;
        //        //throw new Exception(ex.Message + ". query=" + queryText);//06.05.2018
        //    }
        //    finally
        //    {
        //        if (cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //    }
        //    return ret;
        //}

        ////--------------------------------------------------------
        //public static SQLDmlOperationResult InsertDataItemScalar(string queryText, string[] parameterNames, object[] parameterValues, CommandType commandType)
        //{
        //    SQLDmlOperationResult ret = new SQLDmlOperationResult();
        //    SqlConnection cnn = new SqlConnection(ConnectionString);
        //    SqlCommand cmd = new SqlCommand(queryText, cnn);

        //    cmd.CommandType = commandType;

        //    if (parameterNames != null && parameterNames.Length > 0)
        //    {
        //        for (int i = 0; i < parameterNames.Length; i++)
        //        {
        //            cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
        //            if (cmd.Parameters[i].Value == null || cmd.Parameters[i].Value == null) cmd.Parameters[i].Value = DBNull.Value;
        //        }
        //    }

        //    try
        //    {
        //        cnn.Open();
        //        ret.ReturnValue = cmd.ExecuteScalar().ToString();
        //        ret.Succefull = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //    }
        //    return ret;
        //}






        //--------------------------------------------------------
    }
}
