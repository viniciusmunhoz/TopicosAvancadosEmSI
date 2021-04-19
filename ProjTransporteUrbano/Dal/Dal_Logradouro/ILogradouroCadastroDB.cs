using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ILogradouroCadastroDB
    {
        bool Insert(Logradouro logradouro);
        bool Update(Logradouro logradouro);
        bool Delete(int id);
        Logradouro SelectById(int id);
        List<Logradouro> GetAll();
    }
}
