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
    
    public partial class bookingreversal
    {
        public int id { get; set; }
        public int booking_id { get; set; }
        public int portaluser_id { get; set; }
        public string reason { get; set; }
    
        public virtual booking booking { get; set; }
        public virtual Benutzer portaluser { get; set; }
    }
}
