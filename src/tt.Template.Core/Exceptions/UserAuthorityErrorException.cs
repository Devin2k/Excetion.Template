using System;

namespace tt.Template.Core.Exceptions
{
    /// <summary>
    /// 该用户没有这个权限的异常
    /// </summary>
    public class UserAuthorityErrorException : BusinessException
    {
		    /// <summary>
        /// 初始化<see cref="UserAuthorityErrorException"/>类的新实例。
        /// </summary>
		/// <param name="parameters">格式化参数</param>
        public UserAuthorityErrorException(params string[] parameters)
            : base(BusinessStatusCode.UserAuthorityError,parameters) { }

	    /// <summary>
        /// 初始化<see cref="UserAuthorityErrorException"/>类的新实例。
        /// </summary>
        /// <param name="excep">异常</param>
        public UserAuthorityErrorException(Exception excep,params string[] parameters)
            : base(BusinessStatusCode.UserAuthorityError, excep,parameters) { }

	    }
}
