using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Model
{
    public class Post
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public DateTime? Data { get; set; }

        public ICollection <Comentarios> Comentarios { get; set; }
    }
}
