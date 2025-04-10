//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EczaneWebSitesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drug
    {
        public Drug()
        {
            this.Stocks = new HashSet<Stock>();
        }
    
        public int DrugID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public int SupplierID { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
