using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Shopping.Data;

[Table("CustomerInfo")]
public class Customer
{
    [Column("UserName")]
    public string Id{set; get;}

    public decimal Credit{set; get;}

    public ICollection<Order> Orders{set; get;} = [];
}