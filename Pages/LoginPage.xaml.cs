namespace OficinaApp.Pages;

public partial class LoginPage : ContentPage
{
  public LoginPage()
  {
    InitializeComponent();
  }

  private void btnEntrar_Clicked(object sender, EventArgs e)
  {

  }

  private void btnRegistrar_Clicked(object sender, EventArgs e)
  {
    Navigation.PushAsync(new UsuarioCadastroPage());
  }
}