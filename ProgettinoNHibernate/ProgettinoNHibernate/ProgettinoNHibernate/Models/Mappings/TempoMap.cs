using ProgettinoNHibernate.Models.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ProgettinoNHibernate.Models.Mappings
{
    public class TempoMap : IAutoMappingOverride<Tempo>
    {
        public void Override(AutoMapping<Tempo> mapping)
        {
            mapping.Table("tempo");
            mapping.Id(x => x.Id, "idData");
            mapping.Map(x => x.Gg, "gg").Nullable().Length(45);
            mapping.Map(x => x.Mm, "mm").Nullable().Length(45);
            mapping.Map(x => x.Aaaa, "aaaa").Nullable().Length(45);
        }
    }
}