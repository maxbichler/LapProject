//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LAP.Logic
{
    using System;
    using System.Collections.Generic;
    
    public partial class furnishing
    {
        public furnishing()
        {
            this.roomfurnishings = new HashSet<roomfurnishing>();
        }
    
        public int id { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<roomfurnishing> roomfurnishings { get; set; }
    }
}
