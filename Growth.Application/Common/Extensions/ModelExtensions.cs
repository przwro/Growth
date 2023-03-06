using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace Growth.Application.Common.Extensions;

public static class ModelExtensions
{
	public static string GetDisplayName<T>(Expression<Func<T, object>> expression)
	{
		var memberExpression = (MemberExpression)expression.Body;
		var propertyInfo = (PropertyInfo)memberExpression.Member;
		return propertyInfo.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName;
	}
}

