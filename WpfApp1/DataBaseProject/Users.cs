//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.DataBaseProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int id_user { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronomic { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int id_role { get; set; }

        public string nameFull
        {
            get
            {
                return name + " " + surname + " " + patronomic;
            }
            set { }
        }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        public virtual Role Role { get; set; }
    }
}