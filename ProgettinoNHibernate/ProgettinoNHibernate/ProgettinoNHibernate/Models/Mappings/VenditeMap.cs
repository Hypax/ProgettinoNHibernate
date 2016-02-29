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
            mapping.HasMany<Tempo>(x => x.IdData).KeyColumn("idData").Inverse();
            mapping.HasMany<Negozi>(x => x.IdNegozio).KeyColumn("idNegozio").Inverse();
            mapping.HasMany<Prodotti>(x => x.IdProdotto).KeyColumn("idProdotto").Inverse();
            mapping.Map(x => x.Prezzo, "prezzo").Nullable().Length(45);
            mapping.Map(x => x.Quantita, "quantita").Nullable().Length(45);
        }
    }

}