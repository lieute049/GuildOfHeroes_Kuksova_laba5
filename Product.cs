public class Product
{
    public string Name;
    public int Quantity { get; private set; }

    public Product(string name, int quantity)
    {
        Name = name;
        if (quantity < 0)
        {
            Quantity = 0;
        }
        else
        {
            Quantity = quantity;
        }
    }

    public void Restock(int amount)
    {
        if (amount <= 0)
        {
            return;
        }
        Quantity += amount;
    }
}