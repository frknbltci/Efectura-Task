using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CategoryLimitError="Kategori Limiti Aşıldı";
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";

        public static string ProductCountOfCategoryError = "Kategori ürün sayısı aşıldı";
        public static string ProductSameNameError = "Aynı isimde ürün eklenemez";
        public static string AuthorizationDenied = "Yetkin yok";
        public static string UserRegistered = "Kullanıcı Kayıtlı";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Zaten kayıtlı kullanıcı";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string UserAddErr = "Kullanıcı Eklenirken Hata Oluştu";
    }
}
