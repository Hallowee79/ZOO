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
    
    public partial class Animals
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SpiciesID { get; set; }
        public int Age { get; set; }
        public int GenderID { get; set; }
        public int HabitatID { get; set; }
        public int FeedsID { get; set; }
    
        public virtual Feeds Feeds { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Habitats Habitats { get; set; }
        public virtual Species Species { get; set; }
    }
}