//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IkApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> BookingStartData { get; set; }
        public Nullable<System.DateTime> BookingEndData { get; set; }
        public Nullable<int> BookingStatus { get; set; }
        public Nullable<int> IdBook { get; set; }
        public string F { get; set; }
        public string I { get; set; }
        public string O { get; set; }
    
        public virtual Kniga Kniga { get; set; }
        public virtual Status Status { get; set; }
    }
}