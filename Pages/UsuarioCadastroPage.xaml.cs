using OficinaApp.Models;

namespace OficinaApp.Pages;

public partial class UsuarioCadastroPage : ContentPage
{
  private Usuario _usuario;

  public UsuarioCadastroPage()
  {
    InitializeComponent();
    _usuario = new Usuario();

    this.BindingContext = _usuario;
  }

  private void btnCadastrar_Clicked(object sender, EventArgs e)
  {
    _usuario.Nome = txtNome.Text;
    _usuario.Email = txtEmail.Text;
    _usuario.Senha = txtSenha.Text;
  }
}