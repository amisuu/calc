using System.Collections.Generic;

namespace calc
{
    public interface IVariableStorage
    {
        List<string> GetAllKeys();
        object GetValue(string key);
        void SetValue(string key, object value);
    }
}
