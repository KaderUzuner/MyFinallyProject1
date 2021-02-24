using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MainintenanceTime = "Sistem bakımda";
        internal static string ProductsListed= "Ürünler listelendi";
        internal static string ProductCountOfCategoryError = "Bir kategoride 10 fazla ürün olamaz ";
        internal static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
