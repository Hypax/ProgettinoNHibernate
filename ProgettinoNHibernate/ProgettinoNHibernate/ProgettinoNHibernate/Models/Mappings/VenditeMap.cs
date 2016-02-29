using ProgettinoNHibernate.Models.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ProgettinoNHibernate.Models.Mappings
{
    public class VenditeMap : IAutoMappingOverride<Vendite>
    {
        public void Override(AutoMapping<Vendite> mapping)
        {
            mapping.Table("vendite");
            mapping.Id(x => x.Id, "idVendita");
            mapping.Map(x => x.IdData, "idData");
            mapping.Map(x => x.IdNegozio, "idNegozio");
            mapping.Map(x => x.IdProdotto, "idProdotto");
            mapping.Map(x => x.Prezzo, "prezzo").Nullable();
            mapping.Map(x => x.Quantita, "quantita").Nullable();
        }
    }

}