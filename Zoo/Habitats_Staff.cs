//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zoo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Habitats_Staff
    {
        public int ID { get; set; }
        public int HabitatsID { get; set; }
        public int StaffID { get; set; }
    
        public virtual Habitats Habitats { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
