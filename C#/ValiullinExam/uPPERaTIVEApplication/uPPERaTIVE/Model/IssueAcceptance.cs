//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uPPERaTIVE.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class IssueAcceptance
    {
        public int id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Issue { get; set; }
    
        public virtual User User { get; set; }
    }
}
