using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QuadroHorario
    {
        public string DiasUteis { get; set; }
        public string Sabados  { get; set; }
        public string Domingos { get; set; }
        public string Feriados { get; set; }
        public int id_Linha { get; set; }

        public const string INSERT = "INSERT INTO QuadroHorario (DiasUteis, Sabado, Domingo, Feriado, id_Linha) VALUES ('{0}', '{1}', '{2}', '{3}', {4})";
        public const string GETALL = "SELECT * FROM QuadroHorario";
    }
}
