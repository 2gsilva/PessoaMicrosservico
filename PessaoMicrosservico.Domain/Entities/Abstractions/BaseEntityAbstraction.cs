namespace PessaoMicrosservico.Domain.Entities.Abstractions
{
    public abstract class  BaseEntityAbstraction <T>
    {
        public T Id { get; set; }
    }
}
