﻿using System.Collections.Generic;
using NHibernate.Envers.Configuration.Attributes;

namespace NHibernate.Envers.Tests.NetSpecific.Integration.BidirectionalSameColumn
{
	public class Model
	{
		public virtual int Id { get; set; }

		[Audited(TargetAuditMode = RelationTargetAuditMode.NotAudited)]
		public virtual ISet<ModelConfigurationShared> ModelConfigurations { get; set; }
	}
}
