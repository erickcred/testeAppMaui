using Android.Database.Sqlite;
using OficinaApp.Data;
using OficinaApp.Models;
using OficinaApp.Pages;

namespace OficinaApp
{
  public partial class App : Application
  {
    static SQLiteDataContext _bancoDeDados;
    public SQLiteDataContext BancoDeDados
    {
      get
      {
        if (_bancoDeDados == null)
          _bancoDeDados = new SQLiteDataContext(
            DependencyService
            .Get<ISQLiteDbContext>()
            .SQLiteLocalPath("Dados.db3"));

        return _bancoDeDados;
      }
    }

    public static Usuario Usuairo { get; set; }

    public App()
    {
      InitializeComponent();

      MainPage = new NavigationPage(new LoginPage());
    }
  }
}
