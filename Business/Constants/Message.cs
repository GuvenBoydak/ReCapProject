using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarDescriptionInvalid = "Araç açıklaması geçersiz";
        public static string MaintenanceTime = "**Sistem Bakım Zamanı**";
        public static string CarsListed = "Araçlar Listelendi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarDeleted = "Araç Silindi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorDeleted = "Renk Silindi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandDeleted = "Marka Silindi";

        public static string UserAdded = "Kulanıcı eklendi";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserRegistered="Kayıt olundu";
        public static string UserAlreadyExists = "Kulanıcı mevcut";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerDeleted = "Müşteri Silindi";

        public static string RentalAdded = "Kiralama bilgisi eklendi";
        public static string RentalsListed = "Kiralama bilgileri Listelendi";
        public static string RentalUpdated = "Kiralama bilgisi Güncellendi";
        public static string RentalDeleted = "Kiralama bilgisi Silindi";
        public static string ReturnDateError = "Araç Teslim alınmadı";

        public static string CarImageAdded = "Araç resmi eklendi";
        public static string CarImageDeleted = "Araç resmi silindi";
        public static string CarImageUpdated = "Araç resmi Güncelendi";
        public static string CarImageListed = "Araç resimleri Listelendi";
        public static string CarImageListedById = "Araç resimleri Id göre Listelendi";
        public static string CarImagesLimitExceeded = "Araç resimleri 5 den büyük olamaz";
        public static string CarImagesNotFound = "Araç resimleri bulunamadı";

        public static string AuthorizationDenied="Yetkiniz yok";
        public static string AccessTokenCreated = "Token Oluşturuldu";
        
    }
}
