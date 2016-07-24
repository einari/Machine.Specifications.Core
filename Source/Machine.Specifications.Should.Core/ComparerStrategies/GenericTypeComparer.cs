using System.Reflection;

namespace Machine.Specifications.ComparerStrategies
{
    class GenericTypeComparer<T> : IComparerStrategy<T>
    {
        public ComparisionResult Compare(T x, T y)
        {
            var type = typeof(T);
            var typeInfo = type.GetTypeInfo();

            if (!typeInfo.IsValueType || (type.GetTypeInfo().IsGenericType && type.IsNullable()))
            {
                if (x.IsEqualToDefault())
                {
                    return new ComparisionResult(y.IsEqualToDefault() ? 0 : -1);
                }

                if (y.IsEqualToDefault())
                {
                    return new ComparisionResult(-1);
                }
            }
            return new NoResult();
        }
    }
}