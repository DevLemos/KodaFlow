using KodeFlow.Models.Entities;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace KodeFlow.Extensions
{
    public static class ApiExceptionMiddlewareExtensions
    {
        //Método de extensão para a interface IApplicationBuilder
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            //Utilizando middleware para capturar erro não tratado
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    //Definir resposta personalizada
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                    if (contextFeature is not null)
                    {
                        await context.Response.WriteAsync(new DetalhesErro()
                        {
                            StatusCode = context.Response.StatusCode,
                            Mensagem = contextFeature.Error.Message,
                            Rastreio = contextFeature.Error.StackTrace
                        }.ToString());
                    }
                });
            });
        }     
    }
}
