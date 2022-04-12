using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO_Ej2
{
    public class VariablePriceProduct : Product
    {
        public string? Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity * (1 + (decimal)Tax);
        }
        public override string ToString()
        {
            return $"  {Id}  {Description}" +
                $"\n\tMeasurement: {Measurement}" +
                $"\n\tQuantity...: {$"{Quantity:N2}",25}" +
                $"\n\tPrice......: {$"{Price:C2}",25}" +
                $"\n\tTax........: {$"{Tax:0.00#%}",25 + 1}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",25}"
                ;
        }
    }
}
