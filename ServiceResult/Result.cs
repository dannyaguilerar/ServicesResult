using System.Collections.Generic;

namespace ServiceResult
{
    public abstract class Result<T> where T : class
    {
        public abstract ResultType _type { get; set; }
        public abstract IEnumerable<string> _messages { get; set; }
        public abstract T _data { get; set; }
        public bool Sucess
        {
            get
            {
                return (int)_type >= 200 && (int)_type < 300;
            }
        }

    }
}
