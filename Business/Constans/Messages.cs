using Core.Entities.Concreat;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MainintenanceTime = "Sistem bakımda";
        public static string ProductsListed= "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride 10 fazla ürün olamaz ";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string  AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kayıt oldu.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Parola hatası.";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten var.";
        public static string AccessTokenCreated="Token Oluşturuldu.";
    }
}
