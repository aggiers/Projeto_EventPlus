namespace ProjetoEvent_.Utils
{
    public class Criptografia
    {
        public static string GerarHash(string Senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(Senha);
        }

        public static bool CompararHash(string senhaInformada, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaInformada, senhaBanco);
        }
    }
}
