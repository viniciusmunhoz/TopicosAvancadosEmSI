using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ItinerariocomLinha
    {
        public int     id_Linha        { get; set; }
        public string     NomeLinha       { get; set; }
        public int     id_Itinerario  { get; set; }
        public string  itinerario     { get; set; }
        public string    Sentido        { get; set; }

        public const string GETALL = "select * from Linha l inner join Itinerario i on l.id_Itinerario = i.id_Itinerario where l.NomeLinha like '%{0}%'";
        public const string GETALLLOGRADOURO = "select * from Linha l  inner join Itinerario i on l.id_Itinerario = i.id_Itinerario where Itinerario like '%{0}%'";

    }
}
