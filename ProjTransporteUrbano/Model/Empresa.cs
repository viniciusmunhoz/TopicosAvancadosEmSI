using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Empresa
    {
        public string NomeEmpresa { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
        public int id_Cidade { get; set; }



        public const string INSERT = "INSERT INTO Empresa (NomeEmpresa, Endereco, Telefone, Site, id_Cidade) VALUES ('{0}', '{1}', '{2}', '{3}', {4})";
        public const string GETALL = "SELECT * FROM Empresa";

        public const string GETALLNOME = "SELECT * FROM Empresa where NomeEmpresa like '%{0}%'";


    }
}
