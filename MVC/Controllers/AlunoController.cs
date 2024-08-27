using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Ítalo Francesco", "italo.francesco@aluno.senai.br", 123456);
            Aluno a2 = new Aluno(2, "Emanuelly Lima", "emanuelly.lima@aluno.senai.br", 789123);
            Aluno a3 = new Aluno(3, "Rayssa Nanclares", "rayssa.nanclares@aluno.senai.br", 324581);
            Aluno a4 = new Aluno(4, "Bruno Martins", "bruno.martins@aluno.senai.br", 926378);
            Aluno a5 = new Aluno(5, "Cristiano de Paula", "cris@sp.senai.br", 527829);

            //Criar uma lista de Alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            //Adicionar os Objetos Alunos na Lista Alunos
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);

            // Enviando a lista de Alunos por parametro na View Index
            return View(listaAlunos);

        }
        public IActionResult Cadastrar()

        {
            return View();

        }
    }
}

