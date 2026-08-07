using System.Text.Json;

namespace KodeFlow.Models.Entities
{
    public class DetalhesErro
    {
        public int StatusCode { get; set; }
        public string? Mensagem { get; set; }
        public string? Rastreio { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
