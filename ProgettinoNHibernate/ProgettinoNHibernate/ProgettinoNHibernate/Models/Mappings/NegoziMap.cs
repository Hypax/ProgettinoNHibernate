using ProgettinoNHibernate.Models.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ProgettinoNHibernate.Models.Mappings
{
    public class NegoziMap : IAutoMappingOverride<Negozi>
    {
        public void Override(AutoMapping<Negozi> mapping)
        {
            mapping.Table("negozi");
            mapping.Id(x => x.Id, "idNegozio");
            mapping.Map(x => x.Descrizione, "descrizione").Nullable().Length(45);
            mapping.Map(x => x.Citta, "citta").Nullable().Length(45);
            mapping.Map(x => x.Indirizzo, "indirizzo").Nullable().Length(45);
        }
    }
}