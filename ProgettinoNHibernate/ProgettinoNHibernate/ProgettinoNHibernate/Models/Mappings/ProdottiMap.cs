using ProgettinoNHibernate.Models.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ProgettinoNHibernate.Models.Mappings
{
    public class ProdottiMap : IAutoMappingOverride<Prodotti>
    {
        public void Override(AutoMapping<Prodotti> mapping)
        {
            mapping.Table("prodotti");
            mapping.Id(x => x.Id, "idProdotto");
            mapping.Map(x => x.Descrizione, "descrizione").Nullable().Length(45);
            mapping.Map(x => x.Tipo, "tipo").Nullable().Length(45);
        }
    }

}