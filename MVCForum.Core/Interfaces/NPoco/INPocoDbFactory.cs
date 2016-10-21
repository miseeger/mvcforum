using System;
using MVCForum.Domain.DomainModel;

namespace MVCForum.Domain.Interfaces.Five01st
{

	public interface INPocoDbFactory
    {
        INPocoDb CreateDb();
    }

}
