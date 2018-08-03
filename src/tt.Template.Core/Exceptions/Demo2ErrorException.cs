using System;

namespace tt.Template.Core.Exceptions
{
    /// <summary>
    /// 异常1,无参构造异常的异常
    /// </summary>
    public class Demo2ErrorException : BusinessException
    {
	
	    /// <summary>
        /// 初始化<see cref="Demo2ErrorException"/>类的新实例。
        /// </summary>
        public Demo2ErrorException()
            : base(BusinessStatusCode.Demo2Error) { }

        /// <summary>
        /// 初始化<see cref="Demo2ErrorException"/>类的新实例。
        /// </summary>
        /// <param name="excep">异常</param>
        public Demo2ErrorException(Exception excep)
            : base(BusinessStatusCode.Demo2Error, excep) { }
	    }
}
