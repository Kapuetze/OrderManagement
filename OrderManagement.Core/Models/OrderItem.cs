namespace OrderManagement.Core.Models;
public class OrderItem : BaseModel
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int PriceGroupDetailId { get; set; }
    public decimal Price { get; set; }
    public decimal Total { get; set; }
    public decimal Shipping { get; set; }
    public decimal ServiceFee { get; set; }
    public decimal Tax { get; set; }
    public decimal TaxRate { get; set; }
    public decimal ShippingTax { get; set; }
    public decimal ShippingTaxRate { get; set; }
    public decimal ServiceFeeTax { get; set; }
    public decimal ServiceFeeTaxRate { get; set; }
}