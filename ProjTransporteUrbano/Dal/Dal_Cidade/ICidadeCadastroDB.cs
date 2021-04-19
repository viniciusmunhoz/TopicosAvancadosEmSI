using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ICidadeCadastroDB
    {
        bool Insert(Cidade cidade);
        bool Update(Cidade cidade);
        bool Delete(int id);
        Cidade SelectById(int id);
        List<Cidade> GetAll();
    }
}
