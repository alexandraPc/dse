//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tiendaElectronica
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int id_proveedor { get; set; }
        public string imagen { get; set; }
        public byte[] Imagen { get; internal set; }
        public string status { get; set; }
    }
}