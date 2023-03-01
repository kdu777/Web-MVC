@{
    ViewData["Title"] = "LH Pet";
}

<div class="container">

    <h1> >>> Sistema de Controle Interno - LH Pet <<< </h1>

            <table class="table table-hover table-sm table-bordered table-sm caption-top">
                <caption>Lista de clientes</caption>
                <thead class="table-dark">
                    <tr>
                        <th scope=" col">ID</th>
                        <th scope="col">Nome</th>
                        <th scope="col">CPF</th>
                        <th scope="col">E-mail</th>
                        <th scope="col">Paciente (pet)</th>
                    </tr>
                </thead>
                <corpo>
                    @foreach (var item em @ViewBag.listaClientes)
{
                    
                    <tr>
                        <th scope="row">@item.Id</th>
                        <td>@item.Nome</td>
                        <td>@item.Cpf</td>
                        <td>@item.Email</td>
                        <td>@item.Paciente</td>
                    </tr>
}

                </tbody>
            </table>


            <table class="table table-hover table-sm table-bordered table-sm caption-top">
                <caption>Lista de fornecedores</caption>
                <thead class="table-dark">
                    <tr>
                        <th scope="col">ID</th>
                        <th scope="col">Nome</th>
                        <th scope="col">CNPJ</th>
                        <th scope="col">E-mail</th>
                    </tr>
                </thead>
                <corpo>
                    @foreach (var item em @ViewBag.listaFornecedores)
                    {
                    <tr>
                        <th scope="row">>@item.Id</th>
                        <td>>@item.Nome</td>
                        <td>>@item.Cnpj</td>
                        <td>>@item.Email</td>
                    </tr>
                    }
                </tbody>
            </table>

</div>
