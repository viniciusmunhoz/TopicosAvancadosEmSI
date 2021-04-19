using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IItinerarioCadastroDB
    {
        bool Insert(Itinerario itinerario);
        bool Update(Linha itinerario);
        bool Delete(int id);
        Linha SelectById(int id);
        List<Itinerario> GetAll();
    }
}
