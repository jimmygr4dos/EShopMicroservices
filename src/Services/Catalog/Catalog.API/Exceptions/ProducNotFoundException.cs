namespace Catalog.API.Exceptions;

public class ProducNotFoundException: Exception
{
    public ProducNotFoundException(): base("Product not found!")
    {
    }
}
