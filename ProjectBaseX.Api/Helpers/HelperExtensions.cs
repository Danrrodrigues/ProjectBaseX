using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;

namespace ProjectBaseX.Api.Helpers
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static class HelperExtensions
    {
        // Adiciona todos os erros em uma variável só chamda Erros
        public static ModelStateDictionary ConfigErros(this ModelStateDictionary modelState)
        {
            var msgs = modelState.Keys.Where(m => m != "Erros").SelectMany(k => modelState[k].Errors).Select(m => m.ErrorMessage).ToArray();

            foreach (var msg in msgs)
            {
                modelState.AddModelError("Erros", msg);
            }

            return modelState;
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
