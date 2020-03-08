using Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Abstractions
{
    public interface IVisitRepository
    {
        IEnumerable<Visit> GetAllVisits();
        void AddVisit(Visit visit);

        Task<Visit> FindVisit(Guid guid);
        void UpdateVisit(Visit visit);

        void RemoveVisit(Visit visit);

    }
}
