using System.Collections.Generic;
namespace HR.LeaveManagament.MVC.Contracts
{
    public interface ILocalStorageService
    {
        void ClearStorage(List<string> keys);
        bool Exists(string key);
        T GetStorage<T>(string key);
        void SetStorageValue<T>(string key, T value);
    }
}
