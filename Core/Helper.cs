using System.Reflection;

namespace Core
{
    public static class Helper
    {
        public static void CopyProperty(object fromObj, object toObj)
        {
            if (fromObj != null && toObj != null)
            {
                var fromType = fromObj.GetType();
                var toType = toObj.GetType();
                foreach (PropertyInfo prop in fromType.GetProperties())
                {
                    if (prop.PropertyType.Namespace == "System")
                        toType.GetProperty(prop.Name)?.SetValue(toObj, prop.GetValue(fromObj, null), null);
                }
            }
        }
    }
}
