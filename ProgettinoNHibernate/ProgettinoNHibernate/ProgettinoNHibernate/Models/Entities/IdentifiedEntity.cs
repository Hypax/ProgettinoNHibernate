using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProgettinoNHibernate.Models.Entities
{
    [Serializable]
    public abstract class IdentifiedEntity : EntityBase
    {
        [Editable(false)]
        [Key]
        public virtual int Id { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public virtual bool Equals(IdentifiedEntity other)
        {
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            var o = obj as IdentifiedEntity;
            if (o != null)
            {
                return Equals(o);
            }
            return false;
        }
    }
}