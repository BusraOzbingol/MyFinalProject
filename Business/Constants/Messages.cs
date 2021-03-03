using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
            
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameİnvalid = "Geçersiz ürün adı girildi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün girilir.";
        public static string ProductNameAlreadExists = "Bu isimde başka ürün var";
        public static string CategoryLimitExceded = "Kategori limit aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok";
        
    }
}
