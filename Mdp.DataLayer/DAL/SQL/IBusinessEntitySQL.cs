using System;
using System.Data;
using System.Data.SqlClient;

namespace Mdp.DataLayer.DAL.SQL
{
    public interface IBusinessEntity
    {
        void Fill(SqlDataReader reader);
    }
}
