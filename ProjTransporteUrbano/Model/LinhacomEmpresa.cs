using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LinhacomEmpresa
    {
        public int id_Empresa   { get; set; }
        public string    NomeEmpresa  { get; set; }
        public string Endereco     { get; set; }
        public string Telefone     { get; set; }
        public string Site         { get; set; }
        public int id_Cidade    { get; set; }
        public int    id_Linha     { get; set; }
        public string NomeLinha    { get; set; }
        public int id_Itinerario { get; set; }

        public const string GETALLNOME = "SELECT * FROM Empresa E inner join Linha L on e.id_linha = l.id_Linha where E.NomeEmpresa like '%{0}%'";
    }
}
