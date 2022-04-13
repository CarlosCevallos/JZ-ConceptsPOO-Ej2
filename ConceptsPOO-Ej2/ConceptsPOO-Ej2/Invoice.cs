namespace ConceptsPOO_Ej2
{
    internal class Invoice : IPay
    {
        private List<Product> _products;

        public Invoice()
        {
            if (_products != null) { _products.Clear(); }
        }

        //--- Methods ----------------------------------
        public decimal ValueToPay()
        {
            return -99;
        }
        public void AddProduct(List<Product> listProduct) { _products.Add(listProduct); }
        public override string ToString()
        {
            return $"RECEIPT" +
                $"\n-------------------------------------------------" +
                $"{base.ToString()}"
                ;
        }
    }
}
