using System.Collections.Generic;
using System.Linq;

namespace calc
{
    class InMemoryVariableStorage : IVariableStorage
    {
        Dictionary<string, object> internalStorage;
        public InMemoryVariableStorage()
        {
            internalStorage = new Dictionary<string, object>();
        }

        public List<string> GetAllKeys()
        {
            return internalStorage.Keys.ToList<string>();
        }

        public object GetValue(string key)
        {
            return internalStorage[key];
        }

        public void SetValue(string key, object value)
        {
            internalStorage[key] = value;
        }
    }
}
