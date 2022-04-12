namespace ConceptsPOO_Ej2
{
    public abstract class Product : IPay
    {
        public string? Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal ValueToPay();
        public override string ToString()
        {
            return $"  {Id}  {Description}" +
                $"\n\tPrice......: {$"{Price:C2}",25}" +
                $"\n\tTax........: {$"{Tax:0.00#%}",25 + 1}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",25}"
                ;
        }

    }
}