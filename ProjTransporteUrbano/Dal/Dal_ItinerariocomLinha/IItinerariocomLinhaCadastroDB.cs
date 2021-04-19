using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IItinerariocomLinhaCadastroDB
    {
        bool Insert(ItinerariocomLinha itinerariocomLinha);
        bool Update(ItinerariocomLinha itinerariocomLinha);
        bool Delete(int id);
        ItinerariocomLinha SelectById(int id);
        List<ItinerariocomLinha> GetAll();
    }
}
