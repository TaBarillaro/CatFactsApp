using CatFactsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactsApp.Services
{
    internal interface ICatFactService
    {
        Task<CatFact> GetCatFactAsync();
    }
}
