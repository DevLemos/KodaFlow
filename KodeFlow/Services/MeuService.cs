namespace KodeFlow.Services
{
    public class MeuService : IMeuService
    {
        public string Saudacoes(string nome)
        {
            return $"Bem-vindo(a) {nome} \n\n {DateTime.UtcNow}";
        }
    }
}
