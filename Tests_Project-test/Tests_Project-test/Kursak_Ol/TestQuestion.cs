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
    
    public partial class TestQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestQuestion()
        {
            this.IsActual = 1;
            this.TestQuestionAnswer = new HashSet<TestQuestionAnswer>();
            this.UserTestAnswer = new HashSet<UserTestAnswer>();
        }
    
        public int Id { get; set; }
        public string Question { get; set; }
        public byte IsActual { get; set; }
        public int TestId { get; set; }
    
        public virtual Test Test { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestQuestionAnswer> TestQuestionAnswer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTestAnswer> UserTestAnswer { get; set; }
    }
}
