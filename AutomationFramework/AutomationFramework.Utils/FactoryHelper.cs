using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utils
{
    public static class FactoryHelper
    {
        public static Dictionary<string, Type> LoadTypesToReturn<T>()
        {
            var stepTypes = Assembly.GetCallingAssembly().GetTypes().Where(x => x.IsSubclassOf(typeof(T)) && !x.IsAbstract);
            return stepTypes.ToDictionary(x => x.Name, x => x);
        }
    }
}
