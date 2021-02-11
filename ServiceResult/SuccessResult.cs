using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceResult
{
    public class SuccessResult<T> : Result<T>
    {
        public override ResultType _type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IEnumerable<string> Messages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override T _data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SuccessResult(T data = null, string[] messages)
        {
            _data
        }
    }
}
