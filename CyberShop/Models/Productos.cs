//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CyberShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> fk_categoria { get; set; }
        public Nullable<double> precio { get; set; }
        public string descripcion { get; set; }
        public string url_img { get; set; }
        public Nullable<int> stock { get; set; }
    }
}
