using System;

namespace tt.Template.Core.Exceptions
{
    /// <summary>
    /// 异常1,无参构造异常的异常
    /// </summary>
    public class Demo1ErrorException : BusinessException
    {
	
	    /// <summary>
        /// 初始化<see cref="Demo1ErrorException"/>类的新实例。
        /// </summary>
        public Demo1ErrorException()
            : base(BusinessStatusCode.Demo1Error) { }

        /// <summary>
        /// 初始化<see cref="Demo1ErrorException"/>类的新实例。
        /// </summary>
        /// <param name="excep">异常</param>
        public Demo1ErrorException(Exception excep)
            : base(BusinessStatusCode.Demo1Error, excep) { }
	    }
}
