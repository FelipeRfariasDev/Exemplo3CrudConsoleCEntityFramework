using Aula3.Data;
using Aula3.Model;
using Microsoft.EntityFrameworkCore;

namespace Aula3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var Context = new BlogContext();

            /*
            var post = new Post { Titulo = "titulo1", Descricao = "Descrição1", Data = DateTime.Now };
            Context.Posts.Add(post);
            Context.SaveChanges();
            
            Context.Comentarios.Add(new Comentarios { Comentario = "comentario1", PostId = post.Id });
           
            Context.Comentarios.Add(new Comentarios { Comentario = "comentario2", PostId = post.Id });
            Context.SaveChanges();
            */

            //var comentario = Context.Comentarios.Include( x => x.Post).Where(x => x.Id == 1).First();
            //Console.WriteLine(comentario.Comentario + " - " + comentario.Post.Titulo);

            var post = Context.Posts.Include(x => x.Comentarios).Where(x => x.Id == 1).First();
            Console.WriteLine(post.Titulo);

            foreach (var xxx in post.Comentarios) 
            {
                Console.WriteLine(xxx.Comentario);
            }
            /*
            var posts = Context.Posts.ToList();

            foreach (var post in posts) 
            {
                Console.WriteLine(post.Titulo);
            }*/

            /*
            var post = Context.Posts.Where(x => x.Id == 1).First();
          
            post.Titulo = "titulo alterado";
            Context.Posts.Update(post);
            Context.SaveChanges();

            Console.WriteLine(post.Titulo);
            */
            /*
            var post = Context.Posts.Where(x => x.Id == 1).First();
            Context.Posts.Remove(post);
            Context.SaveChanges();
            */

            //Console.WriteLine("Crud com entity framework");
        }
    }
}
