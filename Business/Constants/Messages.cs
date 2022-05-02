using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductCountOfCategoryError = "Ilgili kategorinin kapasitesi dolu!";
        public static string ProductNameAlreadyExists = "Böyle bir ürün ismi halihazırda bulunmakta";
        public static string CategoryLimitExceeded = "Kategori sayısı aşıldığı için ürün eklenemiyor";
    }
}
