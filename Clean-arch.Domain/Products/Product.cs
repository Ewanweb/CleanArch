using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.Products;

public class Product
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public Mony Price { get; private set; }

    public Product(string title, Mony price)
    {
        Guard(title);
        Title = title;
        Price = price;
        Id = Guid.NewGuid();
    }

    public void Edit(string title, Mony price)
    {
        Guard(title);
        Title = title;
        Price = price;
    }

   
    private void Guard(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentNullException("title");

    }
}