//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exercise.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tMembers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tMembers()
        {
            this.tArticle = new HashSet<tArticle>();
            this.tArticleLove = new HashSet<tArticleLove>();
            this.tReArticle = new HashSet<tReArticle>();
            this.tReArticleLove = new HashSet<tReArticleLove>();
        }
    
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> RegisteredDate { get; set; }
        public string Authority { get; set; }
        public Nullable<int> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tArticle> tArticle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tArticleLove> tArticleLove { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tReArticle> tReArticle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tReArticleLove> tReArticleLove { get; set; }
    }
}
