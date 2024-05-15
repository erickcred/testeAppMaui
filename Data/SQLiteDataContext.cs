using OficinaApp.Models;
using SQLite;

namespace OficinaApp.Data;

public class SQLiteDataContext : ISQLiteDbContext
{
  private SQLiteAsyncConnection _conexao;
  public Conexao Conexao { get; set; }

  public SQLiteDataContext(string path)
  {
    _conexao = new SQLiteAsyncConnection(path);
    _conexao.CreateTableAsync<Usuario>().Wait();

    Conexao = new Conexao(_conexao);
  }

  public string SQLiteLocalPath(string connectionString)
  {
    throw new NotImplementedException();
  }
}
