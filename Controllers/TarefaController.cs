namespace TarefaWeb.Controllers
{
    public class TarefaController: Controller
    {
        private static List<Tarefa> lista = new List<Tarefa>();

        public TarefaController
        {
            if(lista.Count == 0)
            {
                this.lista.Add(new Tarefa{Id = 1, Nome = "Lavar o carro", Concluida = false});
                this.lista.Add(new Tarefa{Id = 1, Nome = "Estudar para a prova", Concluida = false});
                this.lista.Add(new Tarefa{Id = 1, Nome = "Passear com o cachorro", Concluida = false});
                this.lista.Add(new Tarefa{Id = 1, Nome = "Comprar leite", Concluida = false});
            }
        }

        public IActionResult Index()
        {
            return View(lista);
        }

        public IActionResult Delete(int id)
        {
            // TODO: Prova 1: Realizar a exclusão da tarefa, pelo id, e redirecionar para Index.
            return null;
        }

        public IActionResult Concluir(int id)
        {
            // TODO: Prova 2: Realizar a alteração da tarefa para concluida=true, pelo id, e redirecionar para Index.
            return null;
        }
    }
}