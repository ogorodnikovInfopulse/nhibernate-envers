using NHibernate.Envers.Configuration.Attributes;

namespace NHibernate.Envers.Tests.Entities
{
	public class StrTestEntity
	{
		public virtual int Id { get; set; }
		[Audited]
		public virtual string Str { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as StrTestEntity;
			if (other == null)
				return false;
			if (Id != other.Id)
				return false;
			return Str == null ? other.Str == null : Str.Equals(other.Str);
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode() ^ (Str == null ? 0 : Str.GetHashCode());
		}
	}
}