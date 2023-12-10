using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ConcertService : Service<Concert>, IServiceConcert
    {
        public ConcertService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Concert> GetConcertsAvecStyleMusical(List<Concert> concerts, StyleMusical styleMusical)
        {
            return concerts
                .Where(c =>c.Artiste.Chansons.Any(chanson => chanson.StyleMusical == styleMusical))
                .ToList();
        }
    }
}
