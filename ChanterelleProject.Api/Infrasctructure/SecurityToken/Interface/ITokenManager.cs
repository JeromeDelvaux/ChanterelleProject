using ChanterelleProject.Models.Client.ModelClientForViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Infrasctructure.SecurityToken.Interface
{
    public interface ITokenManager
    {
        UtilisateurViewClient Authenticate(UtilisateurViewClient user);
    }
}
