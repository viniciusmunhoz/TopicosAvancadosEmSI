using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IQuadroHorarioCadastroDB
    {
        bool Insert(QuadroHorario quadroHorario);
        bool Update(QuadroHorario quadroHorario);
        bool Delete(int id);
        QuadroHorario SelectById(int id);
        List<QuadroHorario> GetAll();
    }
}
