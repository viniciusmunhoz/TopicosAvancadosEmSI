using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IEmpresaCadastroDB
    {
        bool Insert(Empresa empresa);
        bool Update(Empresa empresa);
        bool Delete(int id);
        Empresa SelectById(int id);
        List<Empresa> GetAll();
    }
}
