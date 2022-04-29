using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi !";
        public static string Deleted = "Silindi !";
        public static string Updated = "Güncellendi ! ";
        public static string Listed = "Listelendi !";
        public static string NameInvalid = "Karakter sayısı yetersiz !";
        public static string Error = "Hata !";
        public static string MaintenanceTime = "Sistem bakımda !";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var ";
        public static string CheckIfCategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string UserRegistered = "Kayıt olundu !";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Yanlış parola !";
        public static string SuccessfulLogin = "Başarılı giriş !";
        public static string UserAlreadyExists = "Kullanıcı mevcut !";
        public static string AccessTokenCreated = "Token oluşturuldu !";
        public static string LoggedInDatabase = "Veritabanına loglandı !";
        public static string LoggedInFile = "Dosyaya loglandı !";
    }
}
