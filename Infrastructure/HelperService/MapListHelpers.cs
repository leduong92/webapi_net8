using Newtonsoft.Json;
using System.Dynamic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Dynamic.Core;
namespace Infrastructure.HelperService
{
    public static class MapListHelpers
    {
        public static string MapListObjectToString<T>(List<T> listInputValue)
        {
            string selectString = "new(";
            var properties = listInputValue.GetType().GetGenericArguments()[0].GetProperties();
            foreach (var prop in properties)
            {
                if (prop.Equals(properties.Last()))
                {
                    selectString += prop.Name;
                }
                else
                {
                    selectString += prop.Name + ",";
                }
            }
            selectString += ")";
            var dynamicResult = listInputValue.AsQueryable().Select(selectString).ToDynamicList();
            var jsonSetting = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            return JsonConvert.SerializeObject(dynamicResult, Formatting.None, jsonSetting);
        }
        public static T MapObjectToString<T>(this object value) //T is output type
        {
            if (value == null) return default(T);

            IDictionary<string, object> expando = new ExpandoObject();

            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(value.GetType()))
            {
                string newColumName = "";

                newColumName = property.Name;

                if (!string.IsNullOrEmpty(newColumName))
                    expando.Add(newColumName, property.GetValue(value));
            }
            var dynamicResult = expando as ExpandoObject;
            var jsonSetting = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            T result = JsonConvert.DeserializeObject<T>(
                JsonConvert.SerializeObject(dynamicResult, Formatting.None, jsonSetting)
                , jsonSetting);
            return result;
        }

        public static bool IsGuid(string value)
        {
            Guid x;
            return Guid.TryParse(value, out x);
        }
    }
}
