using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalApp.RouteMapping
{
    public class RouteValueRequestCultureProvider : RequestCultureProvider
    {
        public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            string cultureCode = null;
            if (httpContext.Request.Path.HasValue && httpContext.Request.Path.Value == "/")
                cultureCode = this.GetDefaultCultureCode();

            else if (httpContext.Request.Path.HasValue && httpContext.Request.Path.Value.Length >= 2 && httpContext.Request.Path.Value[0] == '/' && httpContext.Request.Path.Value[3] == '/')
            {
                cultureCode = httpContext.Request.Path.Value.Substring(1, 2);

                if (!this.CheckCultureCode(cultureCode))
                    cultureCode = this.GetDefaultCultureCode(); //throw new HttpException(HttpStatusCode.NotFound);
            }

            else
                cultureCode = this.GetDefaultCultureCode(); //throw new HttpException(HttpStatusCode.NotFound);

            ProviderCultureResult requestCulture = new ProviderCultureResult(cultureCode);

            return Task.FromResult(requestCulture);
        }

        private bool CheckCultureCode(string cultureCode)
        {
            return this.Options.SupportedCultures.Select(c => c.TwoLetterISOLanguageName).Contains(cultureCode);
        }

        private string GetDefaultCultureCode()
        {
            return this.Options.DefaultRequestCulture.Culture.TwoLetterISOLanguageName.ToString();
        }
    }


}
