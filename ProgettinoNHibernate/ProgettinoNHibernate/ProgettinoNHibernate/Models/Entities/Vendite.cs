using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using FluentNHibernate.Testing.Values;

namespace ProgettinoNHibernate.Models.Entities
{
    [Serializable]
    public class Vendite : IdentifiedEntity
    {
        public virtual int IdVendita { get; set; }
        public virtual int IdProdotto { get; set; }
        public virtual int IdNegozio { get; set; }
        public virtual int IdData { get; set; }
        public virtual string Prezzo { get; set; }
        public virtual int Quantita { get; set; }
    }
}