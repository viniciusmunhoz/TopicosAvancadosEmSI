using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ILinhaCadastroDB
    {
        bool Insert(Linha linha);
        bool Update(Linha linha);
        bool Delete(int id);
        Linha SelectById(int id);
        List<Linha> GetAll();
    }
}
