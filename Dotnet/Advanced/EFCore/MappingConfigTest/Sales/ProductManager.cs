namespace Sales;

public static class ProductManager
{
    public static decimal GetTotalSales(this Product item)
    {
            return item.Orders
                .Select(e => e.Id)
                .Sum() * item.Price;
    }
}