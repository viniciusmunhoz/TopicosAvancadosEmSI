//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjControleFilmes
{
    using System;
    using System.Collections.Generic;
    
    public class TB_FAVORITOS
    {
        public int idFavorito { get; set; }
        public Nullable<int> idFilme { get; set; }
    
        public virtual TB_FILMES TB_FILMES { get; set; }
    }
}
