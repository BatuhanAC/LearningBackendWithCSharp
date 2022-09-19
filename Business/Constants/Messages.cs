using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Böyle bir kullanıcı zaten var.";
        public static string AccessTokenCreated = "Erişim tokeni oluşturuldu.";
    }
}
