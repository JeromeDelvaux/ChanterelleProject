using ChanterelleProject.Api.Infrasctructure.SecurityToken.Interface;
using ChanterelleProject.Models.Client.ModelClientForViews;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ChanterelleProject.Api.Infrasctructure.SecurityToken
{
    public class TokenManager : ITokenManager
    {
        public static string secret = "Le coq est dans l'océan";
        public static string issuer = "localhost:44316"; //Le site qui héberge l'api
        public static string audience = "localhost:4200"; //le/les domaines qui la consomme

        public UtilisateurViewClient Authenticate(UtilisateurViewClient utilisateurViewGLobal)
        {
            if (utilisateurViewGLobal.Mail is null) throw new ArgumentNullException();

            //Récupérer ma clé sous forme de tableau de bytes
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            //crypter avec du Sha512
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

            //Claims = Information sur le user à mettre dans le token
            IEnumerable<string> roles = new List<string>{ "Directrice", "AssistanteSocial", "EquipePluridisciplinaire" };
            Claim[] claims = new[]
            {
                new Claim("UtilisateurId", utilisateurViewGLobal.Id.ToString()),
                new Claim(ClaimTypes.Email, utilisateurViewGLobal.Mail),
                new Claim(ClaimTypes.Role, roles.FirstOrDefault(r=>r.Contains(utilisateurViewGLobal.IntituleTypeUtilisateur))) // Me permet de recuperer l'intitule du type utilisateur
            };


            //Remplissage du token avec tout ce qui est nécéssaire à sa validation
            JwtSecurityToken token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials,
                issuer: issuer,
                audience: audience
                );

            // On écrit le token dans l'objet
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            utilisateurViewGLobal.Token = handler.WriteToken(token);

            return utilisateurViewGLobal;
        }
    }
}
