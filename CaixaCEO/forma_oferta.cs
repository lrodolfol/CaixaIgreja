//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaixaCEO
{
    using System;
    using System.Collections.Generic;
    
    public partial class forma_oferta
    {
        public forma_oferta()
        {
            this.dizimos = new HashSet<dizimos>();
            this.doacoes = new HashSet<doacoes>();
            this.ofertas = new HashSet<ofertas>();
            this.primicias = new HashSet<primicias>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string detalhes { get; set; }
    
        public virtual ICollection<dizimos> dizimos { get; set; }
        public virtual ICollection<doacoes> doacoes { get; set; }
        public virtual ICollection<ofertas> ofertas { get; set; }
        public virtual ICollection<primicias> primicias { get; set; }
    }
}
