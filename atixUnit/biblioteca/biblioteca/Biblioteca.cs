using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
    public static class Biblioteca
    {
        private static List<Livro> livros = new List<Livro>();

        public static void AdicionarLivro(Livro livro)
        {
            if (livro != null)
            {
                livros.Add(livro);
            }
        }

        public static List<Livro> ObterLivros()
        {
            return livros;
        }
    }
}
