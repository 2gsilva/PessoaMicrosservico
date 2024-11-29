using PessaoMicrosservico.Domain.Entities.Abstractions;

namespace PessaoMicrosservico.Domain.Entities
{
    public class Pessoa : BaseEntityAbstraction<int>
    {
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
    }
}
