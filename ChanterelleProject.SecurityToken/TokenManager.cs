using ChanterelleProject.Models.Global.ModelsGlobalForViews;
using ChanterelleProject.SecurityToken.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanterelleProject.SecurityToken
{
    public class TokenManager : ITokenManager
    {
        public static string secret = "LES FRAMBOISIERS SONT PERCHES SUR LE TABOURET DE MON GRAND PERE";
        public static string issuer = "mysite.com"; //Le site qui héberge l'api
        public static string audience = "mysite.com"; //le/les domaines qui la consomme

        public UtilisateurViewGlobal Authenticate(UtilisateurViewGlobal user)
        {
            if (user.Mail is null) throw new ArgumentNullException();

            //Récupérer ma clé sous forme de tableau de bytes
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            //crypter avec du Sha512
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

            //Claims = Information sur le user à mettre dans le token
            string[] roles = { "Directeur", "Assistant", "Professeur" };
            Claim[] claims = new[]
            {
                new Claim("UserId", user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, roles[] (user.IsAdmin ? "admin" : "user" ))
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
            user.Token = handler.WriteToken(token);

            return user;
        }
    }
}
