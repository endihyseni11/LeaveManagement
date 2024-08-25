

using Hanssens.Net;
using HR.LeaveManagament.MVC.Contracts;

namespace HR.LeaveManagament.MVC.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        private LocalStorage _localStorage;

        public LocalStorageService()
        {
            var config = new LocalStorageConfiguration()
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "HR.LEAVEMGMT"
            };
            _localStorage = new LocalStorage(config);
        }
        public void ClearStorage(List<string> keys)
        {
            foreach(var key in keys)
            {
                _localStorage.Remove(key);
            }
        }

        public bool Exists(string key)
        {
            return _localStorage.Exists(key);
        }

        public T GetStorage<T>(string key)
        {
            return _localStorage.Get<T>(key);
        }

        public void SetStorageValue<T>(string key, T value)
        {
            _localStorage.Store(key, value);
            _localStorage.Persist();
        }
    }
}
