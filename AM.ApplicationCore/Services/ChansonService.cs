using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ChansonService : Service<Chanson>, IChansonService
    {
        public ChansonService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<string> GetTitresChansonsPlusVues(string nomArtiste, IEnumerable<Artiste> artistes)
        {
            
            
           
            return artistes.Where(a => a.Nom == nomArtiste)
            .SelectMany(a => a.Chansons)
            .Where(c => (DateTime.Now - c.DateSortie).TotalDays <= 365 * 2)
            .OrderByDescending(c => c.VuesYoutube)
            .Take(5)
            .Select(c => c.Titre);

        }
    }
}
