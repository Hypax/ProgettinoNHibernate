using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using FluentNHibernate.Testing.Values;

namespace ProgettinoNHibernate.Models.Entities
{
    [Serializable]
    public class Negozi : IdentifiedEntity
    {
        public virtual int IdNegozio { get; set; }
        public virtual string Descrizione { get; set; }
        public virtual string Citta { get; set; }
        public virtual string Indirizzo { get; set; }
    }
}