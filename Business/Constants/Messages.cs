using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string Listed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Aynı kategoride 10'dan fazla ürün bulunamaz.";
        public static string ProductNameAlreadyExist = "Bu isimli ürün zaten bulunmakta.";
        public static string CategoryLimitExceded = "Kategori sayısı 15'i aşamaz!";
    }
}
