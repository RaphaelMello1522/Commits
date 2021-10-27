// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
                SubTitulo = "Não é possível inserir uma vaga já existente";

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
                SubTitulo = "Não é possível inserir uma tecnologia já existente";

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