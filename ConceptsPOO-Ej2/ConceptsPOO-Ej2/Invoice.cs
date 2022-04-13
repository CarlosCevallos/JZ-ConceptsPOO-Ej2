namespace ConceptsPOO_Ej2
{
    internal class Invoice : IPay
    {
        //private ICollection<Product> _products = new HashSet<Product>();
        private ICollection<Product> _products = new List<Product>();

        public Invoice()
        {
            if (_products.Count > 0 != null) { _products.Clear(); }
        }

        //--- Methods ----------------------------------
        public decimal ValueToPay()
        {
            return -99;
        }
        public void AddProduct(Product product) { _products.Add(product); }
        public override string ToString()
        {
            decimal ProductsValTotal = 0M;
            string textResult = "";

            foreach (Product itemProduc in _products)
            {
                ProductsValTotal += itemProduc.ValueToPay();
                textResult += $"\n{itemProduc}";
            }
            textResult = $"RECEIPT" +
                $"\n-------------------------------------------------" +
                $"{textResult}" +
                $"\n                                 =============" +
                $"\n{ProductsValTotal,46:C2}";

            return textResult;
        }
    }
}
