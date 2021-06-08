using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Extensions
{
    public class PermissaoNecessaria : IAuthorizationRequirement
    {
        public string Permissao { get; }

        public PermissaoNecessaria(string permissao)
        {
            Permissao = permissao;
        }
    }

    public class PermissaoNecessariaHandler : AuthorizationHandler<PermissaoNecessaria>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext contexto, PermissaoNecessaria requisito)
        {
            if(contexto.User.HasClaim(claim => claim.Type == "Permissao" && claim.Value.Contains(requisito.Permissao)))
            {
                contexto.Succeed(requisito);
            }

            return Task.CompletedTask;
        }
    }
}
