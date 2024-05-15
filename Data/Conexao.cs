using OficinaApp.Models;
using SQLite;
using static Android.Graphics.ColorSpace;

namespace OficinaApp.Data;

public class Conexao
{
  private SQLiteAsyncConnection _conexao;

  public Conexao(SQLiteAsyncConnection conexao)
  {
    _conexao = conexao;
  }

  public async Task<List<Usuario>> RetornaUsuarios()
  {
    List<Usuario> usuarios = await _conexao.Table<Usuario>().ToListAsync();
    return usuarios;
  }

  public async Task<Usuario> RetornaUsuario(string email, string senha)
  {
    Usuario usuario = await _conexao.Table<Usuario>()
      .FirstOrDefaultAsync(x => x.Email.Equals(email) && x.Senha.Equals(senha));
    return usuario;
  }

  public async Task<Usuario> RetornaUsuario(int id)
  {
    Usuario usuario = await _conexao.Table<Usuario>()
      .FirstOrDefaultAsync(x => x.Id == id);
    return usuario;
  }

  public async Task<int> CadastraUsuario(Usuario model)
  {
    var usuarioExiste = await RetornaUsuario(model.Id);

    if (usuarioExiste is null)
      return await _conexao.InsertAsync(model);
    return await _conexao.UpdateAsync(model);
  }

  public async Task<int> DeletaUsuario(int id)
  {
    var usuarioExiste = await RetornaUsuario(id);

    if (usuarioExiste is null)
      return await _conexao.DeleteAsync(id);
    return 0;
  }

}
