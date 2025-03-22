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
    
    public partial class Prescription
    {
        public int PrescriptionID { get; set; }
        public int CustomerID { get; set; }
        public string DoctorName { get; set; }
        public System.DateTime PrescriptionDate { get; set; }
        public string DrugsID { get; set; }
    
        public virtual Customer Customer { get; set; }

        // ilaçların adları veritabanından gelmiyor abi, isimleri buna atacağım.
        public List<string> DrugNames = new List<string>();
    }
}
