namespace OPPSample.Sales.Domain.Model.Aggregates;

public class SalesOrderItem
{
    public SalesOrderItem(Guid salesOrderId, int productId, int quantity, double unitPrice)
    {
        if (salesOrderId == Guid.Empty)
        {
            throw new ArgumentException("Sales Order ID is required");
        }

        if (productId <= 0)
        {
            throw new ArgumentException("Product ID is required and must be greater than zeto");
        }

        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity must greater than zero");
        }

        if (unitPrice <= 0)
        {
            throw new ArgumentException("Unit Price must be greater than zero");
        }
        
        SalesOrderId = salesOrderId;
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
    // public section

    public Guid Id { get; private set; } = GenerateOrdenItemId();
    
    public Guid SalesOrderId { get; }

    public int ProductId { get; }

    public int Quantity { get;}

    public double UnitPrice { get; }

    public double CalculateItemPrice() => Quantity * UnitPrice;
    
    // private section
    private static Guid GenerateOrdenItemId()
    {
        return Guid.NewGuid();
    }
}