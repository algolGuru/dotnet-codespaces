public class Product{
    public Product(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id{ get; private set; }
    public string Name{ get; private set; }
}