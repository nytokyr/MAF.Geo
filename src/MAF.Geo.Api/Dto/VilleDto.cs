﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAF.Geo.Api.Dto
{
    public class VilleDto
    {
        public int VilleId { get; set; }
        public int PaysId { get; set; }
        public int? RegionAdministrativeId { get; set; }
        public int? DepartementId { get; set; }
        public int? RisqueId { get; set; }
        public int NiveauSismiciteId { get; set; }
        public string CodeInsee { get; set; }
        public string CodePostal { get; set; }
        public string NomVille { get; set; }
        public string SimpleVille { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
    }
}