using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{

	class TypeNameKeyComparer : System.Collections.Generic.IEqualityComparer<DefaultSerializationBinder.TypeNameKey>
	{

		public bool Equals(DefaultSerializationBinder.TypeNameKey x, DefaultSerializationBinder.TypeNameKey y)
		{
			return x.Equals(y);
		}

		public int GetHashCode(DefaultSerializationBinder.TypeNameKey obj)
		{
			return obj.GetHashCode();
		}

	}


	class ResolverContractKeyComparer : System.Collections.Generic.IEqualityComparer<ResolverContractKey>
	{

		public bool Equals(ResolverContractKey x, ResolverContractKey y)
		{
			return x.Equals(y);
		}

		public int GetHashCode(ResolverContractKey obj)
		{
			return obj.GetHashCode();
		}

	}


	class TypeConvertKeyComparer : System.Collections.Generic.IEqualityComparer<ConvertUtils.TypeConvertKey>
	{

		public bool Equals(ConvertUtils.TypeConvertKey x, ConvertUtils.TypeConvertKey y)
		{
			return x.Equals(y);
		}

		public int GetHashCode(ConvertUtils.TypeConvertKey obj)
		{
			return obj.GetHashCode();
		}

	}

}
