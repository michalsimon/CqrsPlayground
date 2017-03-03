namespace CqrsPlayground.Common.System
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Reflection;

    public static class AppDomainExtensions
    {
        public static Assembly[] GetAppAssemblies(this AppDomain @this)
        {
            return @this.GetAssemblies()
                .Where(x => x.FullName.StartsWith("ProcentCqrs."))
                .ToArray();
        }

        public static IEnumerable<Type> GetAppTypes(this AppDomain @this)
        {
            return @this.GetAssemblies()
                .Where(x => x.FullName.StartsWith("ProcentCqrs."))
                .SelectMany(x => x.GetTypes());
        }
    }
}