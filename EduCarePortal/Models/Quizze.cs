//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduCarePortal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quizze
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quizze()
        {
            this.Questions = new HashSet<Question>();
            this.QuizResults = new HashSet<QuizResult>();
        }
    
        public System.Guid QuizID { get; set; }
        public string QuizName { get; set; }
        public System.DateTime QuizDate { get; set; }
        public System.Guid SubjectID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuizResult> QuizResults { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
