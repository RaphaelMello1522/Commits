#pragma checksum "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b0b205167aee87fac51accb7c055af41236b662"
// <auto-generated/>
#pragma warning disable 1591
namespace Prova.Client.Pages.Vagas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Prova.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Prova.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\rapha\source\repos\Prova\Prova\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
using Prova.Client.Pages.Modals.Modal_Error;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
using Prova.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
using Prova.Client.Pages.Modals.ModalCad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
using Prova.Client.Pages.Modals.ModalEdit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vagas/lista")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/vagas")]
    public partial class ListaVagas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Prova.Client.Pages.Modals.ModalCad.ModalCadVagas>(0);
            __builder.AddAttribute(1, "vagas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Prova.Shared.Models.Vagas>(
#nullable restore
#line 13 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                      vaga

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "tecnologias", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Prova.Shared.Models.Tecnologias>>(
#nullable restore
#line 13 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                         tecnologias

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Titulo", "Cadastrar nova Vaga");
            __builder.AddAttribute(4, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 13 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                                                              onCancelCad

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 13 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                                                                                      onConfirmCad

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(6, (__value) => {
#nullable restore
#line 13 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                                          RefModal = (Prova.Client.Pages.Modals.ModalCad.ModalCadVagas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<Prova.Client.Pages.Modals.ModalEdit.ModalEditVagas>(8);
            __builder.AddAttribute(9, "vagas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Prova.Shared.Models.Vagas>(
#nullable restore
#line 16 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                       vagaEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "tecnologias", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Prova.Shared.Models.Tecnologias>>(
#nullable restore
#line 16 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                              tecnologias

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Titulo", "Editar");
            __builder.AddAttribute(12, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                                                         onCancelEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                                                                                  onConfirmEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(14, (__value) => {
#nullable restore
#line 16 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                                 RefModalEdit = (Prova.Client.Pages.Modals.ModalEdit.ModalEditVagas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenComponent<Prova.Client.Shared.ModalForms>(16);
            __builder.AddAttribute(17, "Titulo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                     Titulo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Subtitulo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                         SubTitulo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                               onCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(20, (__value) => {
#nullable restore
#line 19 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                          RefModals = (Prova.Client.Shared.ModalForms)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.AddMarkupContent(22, "<h2 align=\"center\">Lista de Vagas</h2>\r\n\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "align", "center");
#nullable restore
#line 25 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
     if (vagas == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "Carregando...");
#nullable restore
#line 27 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                  
    }
    else if (vagas.Count == 0)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "table");
            __builder.AddAttribute(27, "id", "tablevagas");
            __builder.AddAttribute(28, "class", "display");
            __builder.AddAttribute(29, "style", "width:auto");
            __builder.OpenElement(30, "thead");
            __builder.OpenElement(31, "tr");
            __builder.AddAttribute(32, "align", "center");
            __builder.AddMarkupContent(33, "<th>Vaga</th>\r\n                    ");
            __builder.AddMarkupContent(34, "<th>Valor</th>\r\n                    ");
            __builder.OpenElement(35, "th");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                    () => CadNewVaga()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Nova Vaga");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<tbody><tr align=\"center\"><th align=\"center\" colspan=\"2\"><h3>N??o h?? nenhuma vaga cadastrada no sistema.</h3></th></tr></tbody>");
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "table");
            __builder.AddAttribute(43, "id", "tablevagas");
            __builder.AddAttribute(44, "class", "display");
            __builder.OpenElement(45, "thead");
            __builder.OpenElement(46, "tr");
            __builder.AddAttribute(47, "align", "center");
            __builder.AddMarkupContent(48, "<th>Vaga</th>\r\n                    ");
            __builder.AddMarkupContent(49, "<th>Valor</th>\r\n                    ");
            __builder.OpenElement(50, "th");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                    () => CadNewVaga()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Nova Vaga");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenElement(56, "tbody");
#nullable restore
#line 58 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                 foreach (var vaga in vagas)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "tr");
            __builder.AddAttribute(58, "align", "center");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 61 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                             vaga.Vaga

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 62 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                             vaga.ValorTecnologias

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "td");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "class", "btn btn-success");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                        () => EditVaga(vaga)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(69, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "class", "btn btn-danger");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                                                                       () => ExcluirVaga(vaga.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Excluir");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Vagas\ListaVagas.razor"
       

    List<Vagas> vagas;
    List<Tecnologias> tecnologias;

    Vagas vaga = new Vagas();

    ModalCadVagas RefModal;

    Vagas vagaEdit;

    ModalEditVagas RefModalEdit;

    ModalForms RefModals;

    string Titulo;
    string SubTitulo;

    protected override async Task OnInitializedAsync()
    {
        await LoadVagas();
        await LoadTecnologias();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#tablevagas");
    }


    async Task LoadVagas()
    {
        vagas = await http.GetFromJsonAsync<List<Vagas>>($"api/vagas");
    }

    async Task LoadTecnologias()
    {
        tecnologias = await http.GetFromJsonAsync<List<Tecnologias>>($"api/tecnologias");
    }

    async Task CriarVaga()
    {
        await http.PostAsJsonAsync("api/vagas", vaga);
    }

    async Task onConfirmCad()
    {
        await Uniques(vaga, vagas);
        await CriarVaga();
        RefModal.Hide();
        await LoadVagas();

    }

    public void onCancelCad()
    {
        RefModal.Hide();
    }

    async Task onConfirmEdit()
    {
        RefModalEdit.Hide();
        await EditUniques(vaga, vagas);
        await LoadVagas();
    }

    public void onCancelEdit()
    {
        RefModalEdit.Hide();
    }

    public void onCancel()
    {
        RefModals.Hide();
    }

    public void ShowErrorModal()
    {
        RefModals.Show();
    }

    public void CadNewVaga()
    {
        RefModal.Show();
    }

    public void EditVaga(Vagas vagas)
    {
        vagaEdit = vagas;
        RefModalEdit.Show();
    }

    async Task EditarVaga()
    {
        await http.PutAsJsonAsync($"api/vagas", vagaEdit);
        await LoadVagas();
    }

    async Task ExcluirVaga(int id)
    {
        await http.DeleteAsync($"api/vagas/{id}");
        await LoadVagas();
    }

    async Task Uniques(Vagas vagas, List<Vagas> lista)
    {
        foreach (Vagas s in lista)
        {
            if (vagas.Vaga == s.Vaga)
            {

                Titulo = "Erro ao Editar";
                SubTitulo = "N??o ?? poss??vel inserir uma vaga j?? existente";

                ShowErrorModal();
                return;
            }
        }
        await CriarVaga();
        await LoadVagas();
    }

    async Task EditUniques(Vagas vagas, List<Vagas> lista)
    {
        foreach (Vagas s in lista)
        {
            if (vagas.Vaga == s.Vaga)
            {
                Titulo = "Erro ao Editar";
                SubTitulo = "N??o ?? poss??vel inserir uma tecnologia j?? existente";

                ShowErrorModal();
                return;
            }
        }
        await EditarVaga();
        await LoadVagas();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
