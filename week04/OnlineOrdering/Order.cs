namespace OnlineOrdering;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
      _customer = customer;  
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public void SetProducts(List<Product> products)
    {
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string packing = "";
        foreach (Product product in _products)
        {
            packing += product.GetPackingInfo() + "\n";
        }
        return packing;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetDisplayAddress()}";
    }

    public double GetTotalPrice()
    {
        int shippingCostUsa = 5;
        int shippingCostOutsideUsa = 35;
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }

        if (_customer.IsInUsa())
        {
            totalPrice += shippingCostUsa;
        }
        else
        {
            totalPrice += shippingCostOutsideUsa;
        }
        
        return totalPrice;
    }
    
}