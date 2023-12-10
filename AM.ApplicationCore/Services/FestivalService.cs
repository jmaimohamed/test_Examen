using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class FestivalService : Service<Festival>, IServiceFestival
    {
        public FestivalService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double GetCachetPlusEleve(List<Festival> festivals,int FestivalId)
        {

           Festival festival = festivals.FirstOrDefault(f => f.FestivalId == FestivalId);

            var concertsPourAnneeEnCours = festival.Concerts.Where(c => c.DateConcert.Year == DateTime.Now.Year);
            double cachetPlusEleve = concertsPourAnneeEnCours.Max(c => c.Cachet);


            return cachetPlusEleve ;
        }
    }
}
