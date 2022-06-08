using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotrecaJoia.Models.Entities
{
    public abstract class EntidadeBase
    {
        public string Id { get; set; }

        public EntidadeBase ()
        {
            Id = Guid.NewGuid ().ToString ();       //  struct Guid representa um identificador único global: um valor de 16 bytes que, se gerado randomicamente, irá gerar um identificador (quase) único.
        }
    }
}
