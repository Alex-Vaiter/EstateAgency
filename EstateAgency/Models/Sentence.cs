//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstateAgency.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sentence
    {
        public int idSentence { get; set; }
        public int idClient { get; set; }
        public int idAgent { get; set; }
        public int idEstate { get; set; }
        public decimal price { get; set; }
    
        public virtual Agent Agent { get; set; }
        public virtual Client Client { get; set; }
        public virtual EstateObject EstateObject { get; set; }
    }
}
