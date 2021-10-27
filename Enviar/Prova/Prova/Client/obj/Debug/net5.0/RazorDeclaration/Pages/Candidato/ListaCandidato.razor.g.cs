// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Prova.Client.Pages.Candidato
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
#line 6 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Candidato\ListaCandidato.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Candidato\ListaCandidato.razor"
using Prova.Client.Pages.Modals.Modal_Error;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Candidato\ListaCandidato.razor"
using Prova.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Candidato\ListaCandidato.razor"
using Prova.Client.Pages.Modals.ModalCad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Candidato\ListaCandidato.razor"
using Prova.Client.Pages.Modals.ModalEdit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Candidato\ListaCandidato.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/candidato/lista")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/candidato")]
    public partial class ListaCandidato : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\rapha\source\repos\Prova\Prova\Client\Pages\Candidato\ListaCandidato.razor"
       

    List<Candidato> candidatos;

    List<Vagas> vagas;

    List<Tecnologias> tecnologias;

    Candidato candidato = new Candidato();

    ModalCadCandidato RefModal;

    ModalEditCandidato RefModalEdit;

    Candidato candidatoEdit;

    ModalForms RefModals;

    string Titulo;
    string SubTitulo;

    protected override async Task OnInitializedAsync()
    {
        await LoadCandidatos();
        await LoadVagas();
        await LoadTecnologias();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#candidato");
    }

    async Task LoadCandidatos()
    {
        candidatos = await http.GetFromJsonAsync<List<Candidato>>($"api/candidato");
    }

    async Task LoadVagas()
    {
        vagas = await http.GetFromJsonAsync<List<Vagas>>($"api/vagas");

    }

    async Task LoadTecnologias()
    {
        tecnologias = await http.GetFromJsonAsync<List<Tecnologias>>($"api/tecnologias");

    }

    async Task CriarCandidato()
    {
        await http.PostAsJsonAsync("api/candidato", candidato);
    }

    async Task onConfirmCad()
    {
        await Uniques(candidato, candidatos);
        RefModal.Hide();

    }

    public void onCancelCad()
    {
        RefModal.Hide();
    }

    public void onCancel()
    {
        RefModals.Hide();
    }

    async Task onConfirmEdit()
    {
        RefModalEdit.Hide();
        await EditUniques(candidato, candidatos);
        await LoadCandidatos();
    }

    public void onCancelEdit()
    {
        RefModalEdit.Hide();
    }

    public void ShowErrorModal()
    {
        RefModals.Show();
    }

    public void CadNewCandidato()
    {
        RefModal.Show();
    }

    public void EditCandidato(Candidato candidato)
    {
        candidatoEdit = candidato;
        RefModalEdit.Show();
    }

    async Task EditarCandidato()
    {
        await http.PutAsJsonAsync($"api/candidato", candidatoEdit);
        await LoadCandidatos();
    }

    async Task ExcluirCandidato(int id)
    {
        await http.DeleteAsync($"api/candidato/{id}");
        await LoadCandidatos();
    }

    async Task Uniques(Candidato candidato, List<Candidato> lista)
    {
        foreach (Candidato s in lista)
        {
            if (candidato.email == s.email)
            {
                Titulo = "Erro ao Cadastrar";
                SubTitulo = "Email já registrado";
                ShowErrorModal();
                return;
            }


        }
        await CriarCandidato();
        await LoadCandidatos();
    }

    async Task EditUniques(Candidato candidato, List<Candidato> lista)
    {
        foreach (Candidato s in lista)
        {
            if (candidato.email == s.email)
            {
                Titulo = "Erro ao Editar";
                SubTitulo = "Email já registrado";
                ShowErrorModal();
                return;
            }
        }
        await EditarCandidato();
        await LoadCandidatos();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
