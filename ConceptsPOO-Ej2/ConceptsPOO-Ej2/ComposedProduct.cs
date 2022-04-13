namespace ConceptsPOO_Ej2
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product>? Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal ProductsValTotal = 0M;
            foreach (Product itemProduc in Products)
            {
                ProductsValTotal += itemProduc.ValueToPay();
            }
            return (ProductsValTotal * (1 - (decimal)Discount));
        }
        public override string ToString()
        {
            string? ProductsDescTodos = "";
            foreach (Product itemProduc in Products)
            {
                ProductsDescTodos += $"{itemProduc.Description}, ";
            }

            return $"  {Id}  {Description}" +
                $"\n\tProducts...: {ProductsDescTodos.Remove(ProductsDescTodos.Length - 2)}" +
                $"\n\tDiscount...: {$"{Discount:0.00#%}",25 + 1}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",25}"
                ;
        }
    }
}
