using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();
        public string Value { get; set; }
        private Singleton(string value)
        {
            this.Value = value;
        }
        public static Singleton GetInstance(string value)
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance= new Singleton(value);
                    }
                }
            }
            return _instance;
        }
    }
}
