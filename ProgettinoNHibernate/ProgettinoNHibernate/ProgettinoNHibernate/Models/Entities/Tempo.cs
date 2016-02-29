using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using FluentNHibernate.Testing.Values;

namespace ProgettinoNHibernate.Models.Entities
{
    [Serializable]
    public class Tempo : IdentifiedEntity
    {
        public virtual int IdData { get; set; }
        public virtual string Gg { get; set; }
        public virtual string Mm { get; set; }
        public virtual string Aaaa { get; set; }
    }
}