usando System.Diagnostics;
usando Microsoft.AspNetCore.Mvc;
usando LHPet.Models;

namespace LHPet.Controllers;

classe pública HomeController : Controlador
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> registrador)
    {
        _logger = registrador;
    }

    public IActionResult Index()
    
    //instância do cliente
    {Cliente cliente1 = novo Cliente(01, "Arthur A.Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br",
"Madruga");
Cliente cliente2 = new Cliente(02, "William HenryGates III", "039.618.250-09", "bill@microsoft.com", "Bug");
Cliente cliente3 = new Cliente(03, "Ada Lovelace",
"800.777.920-50", "ada@ada.language.com", "Byron");
Cliente cliente4 = new Cliente(04, "LinusTorvalds", "933.622.400-03", "torvalds@osdl.org",
"Pinguim");
Cliente cliente5 = new Cliente(05, "Grace Hopper",
"911.702.988-00", "grace.hopper@cobol.com", "Loboc");

//lista de clientes e atribui os clientes
List<Cliente> listaClientes = new List<Cliente>();
listaClientes.Add(cliente1);
listaClientes.Add(cliente2);
listaClientes.Add(cliente3);
listaClientes.Add(cliente4);
listaClientes.Add(cliente5);

ViewBag.listaClientes = listaClientes;
//instância do tipo fornecedor
Fornecedor fornecedor1 = novo Fornecedor(01, "C#PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
Fornecedor fornecedor2 = novo Fornecedor(02, "CtrlAlt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
Fornecedor fornecedor3 = novo Fornecedor(03,
"BootsPet INC", "40.810.224/0001-83",
"boots.pet@gatomania.us");
Fornecedor fornecedor4 = novo Fornecedor(04, "TikTok Dogs", "87.945.350/0001-09",
"noisnamidia@tiktokdogs.uk");
Fornecedor fornecedor5 = novo Fornecedor(05,
"Bifinho Para Sempre", "18.760.614/0001-37",
"contato@bff.us");


//lista de fornecedores e atribui os fornecedores
List<Fornecedor> listaFornecedores = new
List<Fornecedor>();
listaFornecedores.Add(fornecedor1);
listaFornecedores.Add(fornecedor2);
listaFornecedores.Add(fornecedor3);
listaFornecedores.Add(fornecedor4);
listaFornecedores.Add(fornecedor5);
ViewBag.listaFornecedores = listaFornecedores;

        return Visualização();
    }

    public IActionResult Privacy()
    {
        return Visualização();
    }

    [ResponseCache(Duração = 0, Localização = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error ()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
