using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ILinhacomEmpresaCadastroDB
    {
        bool Insert(LinhacomEmpresa linhacomEmpresa);
        bool Update(LinhacomEmpresa linhacomEmpresa);
        bool Delete(int id);
        LinhacomEmpresa SelectById(int id);
        List<LinhacomEmpresa> GetAll();
    }
}
