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
    
    public partial class Question
    {
        public System.Guid QuiestionID { get; set; }
        public int DifficultyLevel { get; set; }
        public string Question1 { get; set; }
        public string Answer { get; set; }
        public System.Guid QuizID { get; set; }
        public string Choices { get; set; }
        public int Marks { get; set; }
    
        public virtual Quizze Quizze { get; set; }
    }
}
