namespace Financas.Negocio.Interfaces
{
    public interface IAuthService
    {
        string GeradorJwtToken(string email, string senha);
    }
}
