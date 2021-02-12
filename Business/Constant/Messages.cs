using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
    public class Messages
    {
        //Car CRUD
        public static string CarAdded = "Araç eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarsListed = "Araçlar Listelendi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";

        //Brand CRUD
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz,2 harften fazla olmalıdır";

        //Color CRUD
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorsListed = "Renkler Listelendi";

        //User CRUD
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";

        //Customer CRUD
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerCompanyNameInvalid = "Müşteri şirket ismi geçersiz";


        public static string GetCarDetails = "Araç Detayları";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string DailyPriceError = "Araç günlük bedeli 0 dan büyük olmalıdır.";
        

    }
}
