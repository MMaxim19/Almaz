//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Almaz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ювелир
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ювелир()
        {
            this.Изготовление = new HashSet<Изготовление>();
        }
    
        public int ID_ювелира { get; set; }
        public string ФИО_ювелира { get; set; }
        public string Разряд { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Изготовление> Изготовление { get; set; }
    }
}
