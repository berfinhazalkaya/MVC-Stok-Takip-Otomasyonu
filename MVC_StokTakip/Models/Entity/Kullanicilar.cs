//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_StokTakip.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Kullanicilar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanicilar()
        {
            this.kullaniciRolleri = new HashSet<kullaniciRolleri>();
            this.Satislar = new HashSet<Satislar>();
            this.Sepet = new HashSet<Sepet>();
        }
    
        public int ıd { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Alanı boş geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Required(ErrorMessage = "Sifre Alanı boş geçilemez")]
        [Display(Name = "Sifre")]
        public string Sifre { get; set; }
        [Required(ErrorMessage = "Adı Soyadı Alanı boş geçilemez")]
        [Display(Name = "Adı Soyadı")]
        public string AdiSoyadi { get; set; }
        [Required(ErrorMessage = "Telefon Alanı boş geçilemez")]
        [Display(Name = "Telefon")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        //           ErrorMessage = "Uygun formatta telefon numarası giriniz.")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Adres Alanı boş geçilemez")]
        [Display(Name = "Adres")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Email Alanı boş geçilemez")]
        [Display(Name = "Email")]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",
        //    ErrorMessage = "Lütfen uygun formatta e-mail adresi giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Tarih Alanı boş geçilemez")]
        [DataType(DataType.Date)]
        [Display(Name = "Tarih")]

        public Nullable<System.DateTime> Tarih { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kullaniciRolleri> kullaniciRolleri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satislar> Satislar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sepet> Sepet { get; set; }
    }
}
