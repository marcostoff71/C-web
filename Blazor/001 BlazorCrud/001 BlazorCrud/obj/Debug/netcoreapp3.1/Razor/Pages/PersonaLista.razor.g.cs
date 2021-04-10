#pragma checksum "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efea6b751c7bac168b254f9e6feb956bc6ab949b"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/listaPersonas")]
    public partial class PersonaLista : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>PersonaLista</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-success");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
                                              Agregar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Agregar");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
#nullable restore
#line 12 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
 if (lstPersonas.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.AddMarkupContent(10, "<p class=\"text-center text-dark\">Base de datos vacia</p>\r\n");
#nullable restore
#line 15 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "table-responsive");
            __builder.AddMarkupContent(14, "\r\n\r\n        ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-hover");
            __builder.AddAttribute(17, "style", "margin-top:20px;");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, @"<thead class=""thead-dark"">
                <tr>
                    <th>Nombre</th>
                    <th>Apellido Materno</th>
                    <th>Apellido Paterno</th>
                    <th>Edad</th>
                    <th>Fecha de nacimiento</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(20, "tbody");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 33 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
                 foreach (Persona p in lstPersonas)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                    ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 36 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
                             p.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 37 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
                             p.ApellidoMaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 38 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
                             p.ApellidoPaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 39 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
                             p.Edad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 40 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
                             p.FechaNacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "btn btn-warning");
            __builder.AddAttribute(43, "href", "/PersonaDetalles/" + (
#nullable restore
#line 41 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
                                                                               p.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "btn btn-danger");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
                                                                     (()=>Eliminar(p.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 44 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 48 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\lenovo\Cursos\C#\C# Web\Blazor\001 BlazorCrud\001 BlazorCrud\Pages\PersonaLista.razor"
       

    private List<Persona> lstPersonas = new List<Persona>();
    protected async override Task OnInitializedAsync()
    {
        await Refrescar();
    }
    private async Task Refrescar()
    {
        lstPersonas = await Servicio.ObtenerPersonas();
    }
    private void Agregar()
    {
        mana.NavigateTo("/PersonaDetalles");
    }
    private async void Eliminar(int id)
    {


        if (await JSExtension.PreguntarBorrar(runti, "Borrar", "¿Deseas Borras?", IconosSeet.question))
        {

            bool re=await Servicio.EliminarPersona(id);
            if (re)
            {

                object d = await JSExtension.Exito(runti, "Borrado", "Borrado correctamente", IconosSeet.success);

                if (d == null)
                {
                    mana.NavigateTo("/listaPersonas", true);
                }

            }

        }
        else
        {

        }
        //await runti.InvokeAsync<bool>("preguntaBorrar", "Hola","asas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime runti { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager mana { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioPersona Servicio { get; set; }
    }
}
#pragma warning restore 1591
