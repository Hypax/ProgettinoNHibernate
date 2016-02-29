using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using FluentNHibernate.Testing.Values;

namespace ProgettinoNHibernate.Models.Entities
{
    [Serializable]
    public class Prodotti : IdentifiedEntity
    {
        public virtual int IdProdotto { get; set; }
        public virtual string Descrizione { get; set; }
        public virtual string Tipo { get; set; }
    }
}