using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace _001_BlazorCrud.Util
{
    public static class JSExtension
    {
        public static async Task<bool> PreguntarBorrar(IJSRuntime js,string titulo,string texto,IconosSeet icon)
        {
            return await js.InvokeAsync<bool>("PreguntarBorrar", titulo, texto, icon.ToString());
        }
        public static async Task<object> Exito(IJSRuntime js,string titulo,string texto,IconosSeet icon)
        {
            return await js.InvokeAsync<object>("Exito", titulo, texto, icon.ToString());
        }
    }
    public enum IconosSeet
    {
        warning, error, success, info,question
    }
}
