//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursak_Ol
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestQuestionAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestQuestionAnswer()
        {
            this.IsAnswer = 0;
            this.UserTestAnswer = new HashSet<UserTestAnswer>();
        }
    
        public int Id { get; set; }
        public string Answer { get; set; }
        public byte IsAnswer { get; set; }
        public int TestQuestionId { get; set; }
    
        public virtual TestQuestion TestQuestion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTestAnswer> UserTestAnswer { get; set; }
    }
}
