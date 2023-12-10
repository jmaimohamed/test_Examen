using ApplicationCore.Domain;
using ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IServiceConcert : IService<Concert>
    {
        IEnumerable<Concert> GetConcertsAvecStyleMusical(List<Concert> concerts, StyleMusical styleMusical);
    }
}
