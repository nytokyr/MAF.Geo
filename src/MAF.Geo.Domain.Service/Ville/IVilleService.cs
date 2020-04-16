﻿using MAF.Geo.Domain.Model.RefMaf;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MAF.Geo.Domain.Service
{
    public interface IVilleService
    {
        Task<ReadOnlyCollection<Ville>> GetVillesByAutocomplete(int paysId, string autocomplete);
    }
}
