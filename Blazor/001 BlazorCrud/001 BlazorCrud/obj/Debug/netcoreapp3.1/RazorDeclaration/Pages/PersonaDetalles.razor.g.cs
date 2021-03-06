// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace _001_BlazorCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using _001_BlazorCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using _001_BlazorCrud.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using _001_BlazorCrud.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using _001_BlazorCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using _001_BlazorCrud.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PersonaDetalles")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/PersonaDetalles/{id:int}")]
    public partial class PersonaDetalles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaDetalles.razor"
       
    [Parameter]
    public int id { get; set; }

    Persona p1 = new Persona();

    protected async override Task OnInitializedAsync()
    {
        if (id > 0)
        {
            p1 = await servicio.ObtenerPersonaId(id);
            if (p1 == null)
            {
                manager.NavigateTo("/listaPersonas");
            }
        }
    }
    protected void Cancelar()
    {
        manager.NavigateTo("/listaPersonas");
    }
    protected async Task Guardar()
    {
        if (p1.Id == 0)
        {
            await servicio.AgregarPersona(p1);
        }
        else
        {
            await servicio.ModificarPersona(p1);
        }
        manager.NavigateTo("/listaPersonas");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioPersona servicio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager manager { get; set; }
    }
}
#pragma warning restore 1591
