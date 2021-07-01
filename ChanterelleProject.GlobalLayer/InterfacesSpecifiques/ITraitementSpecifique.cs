using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.GlobalServices.InterfacesSpecifiques
{
    public interface ITraitementSpecifique : ITraitement<int, TraitementGlobal, TraitementViewGlobal>
    {
        IEnumerable<TraitementViewGlobal> GetAllTraitementByEleveId(int key);
    }
}
