using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib;
using System.Configuration;
using RumahScarlett2.CommonComponents;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace RumahScarlett2.Infrastructure.DataAccess.Repositories
{
  public class DbContext : IDisposable
  {
    private IDbConnection _conn;
    private IDbTransaction _transaction;
    private readonly string _connString;

    public IDbConnection Conn
    {
      get { return _conn ?? (_conn = GetOpenConnection(_connString)); }
    }

    public IDbTransaction Transaction
    {
      get { return _transaction; }
    }

    public DbContext()
    {
      _connString = $@"Data Source={Environment.CurrentDirectory}\db_rs.db;";

      if (_conn == null)
      {
        _conn = GetOpenConnection(_connString);
      }
    }

    public DbContext(string location, string file)
    {
      location = !string.IsNullOrWhiteSpace(location) ? location : Environment.CurrentDirectory;
      file = !string.IsNullOrWhiteSpace(file) ? file : "db_rs.db";

      _connString = $@"Data Source={location}\{file};";

      if (_conn == null)
      {
        _conn = GetOpenConnection(_connString);
      }
    }

    private IDbConnection GetOpenConnection(string connString)
    {
      IDbConnection conn = null;
      var dataAccessStatus = new DataAccessStatus();

      try
      {
        //var provider = DbProviderFactories.GetFactory(providerName);
        conn = new SqliteConnection();
        conn.ConnectionString = connString;
        conn.Open();
      }
      catch (SqlException ex)
      {
        dataAccessStatus.SetValues(status: "Error", operationSucceeded: false, exceptionMessage: ex.Message,
                                   customMessage: "Tidak dapat membuka koneksi ke Database.\n" +
                                   "Periksa data Database, Port, User dan Password database.",
                                   helpLink: ex.HelpLink, errorCode: ex.ErrorCode, stackTrace: ex.StackTrace);
        throw new DataAccessException(message: ex.Message, innerException: ex.InnerException,
                                      dataAccessStatus: dataAccessStatus);
      }

      return conn;
    }

    public bool TesKoneksi()
    {
      var isConnected = false;

      try
      {
        using (var conn = GetOpenConnection(_connString))
        {
          isConnected = conn.State == ConnectionState.Open;
        }
      }
      catch
      {
      }

      return isConnected;
    }

    public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Serializable)
    {
      if (_transaction == null)
      {
        _transaction = Conn.BeginTransaction(isolationLevel);
      }
    }

    public void Commit()
    {
      if (_transaction != null)
      {
        _transaction.Commit();
        _transaction = null;
      }
    }

    public void RollBack()
    {
      if (_transaction != null)
      {
        _transaction.Rollback();
        _transaction = null;
      }
    }

    public void Dispose()
    {
      if (_conn != null)
      {
        try
        {
          if (_conn.State == ConnectionState.Open)
          {
            RollBack();
            _conn.Close();
          }
        }
        finally
        {
          _conn.Dispose();
        }
      }

      GC.SuppressFinalize(this);
    }
  }
}
