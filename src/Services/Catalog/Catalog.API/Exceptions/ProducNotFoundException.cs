namespace Catalog.API.Exceptions;

public class ProducNotFoundException: NotFoundException
{
    public ProducNotFoundException(Guid Id): base("Product", Id)
    {
    }
}
