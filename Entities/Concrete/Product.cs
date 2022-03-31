using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity    //public ekleyerek diğer katmanların bu classa erişimini sağladık.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //int'in bir küçüğüdür. Veri tabanında smallInt olarak tutulur.
        public decimal UnitPrice { get; set; }

    }
}
