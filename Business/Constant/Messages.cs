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
        public static string BrandNameInvalid = "Girilen değer geçersiz.Marka ismi 2 karakterden fazla olmalıdır";

        //Color CRUD
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorsListed = "Renkler Listelendi";

        //User CRUD
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcılar Listelendi";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";

        //Customer CRUD
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomersListed = "Müşteriler Listelendi";
        

        //Rental CRUD
        public static string RentalAddedError = "Araç teslim edilmeden kiralanamaz!";
        public static string RentalAdded = "Kiralama işlemi tamamlandı";
        public static string RentalDelete = "Kiralama işlemi silindi";
        public static string RentalUpdate = "Kiralama işlemi güncellendi";
        public static string GetRentalDetails = "Kiralama Detayları";


        public static string GetCarDetails = "Araç Detayları";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string DailyPriceError = "Girilen değer geçersiz.Araç günlük bedeli 0 dan büyük olmalıdır!";
        

    }
}
