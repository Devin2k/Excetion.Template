using System;
using System.ComponentModel;

namespace tt.Template.Core
{	
	/// <summary>
    /// 公告状态
    /// </summary>
	public enum BusinessStatusCode
    {

        /// <summary>
        /// 异常1,无参构造异常
        /// </summary>
        [Description("异常1,无参构造异常")]
        Demo1Error = 12001,

        /// <summary>
        /// 用户:{0}权限不足
        /// </summary>
        [Description("用户:{0}权限不足")]
        UserAuthorityError = 12002,

        /// <summary>
        /// 异常2,无参构造异常
        /// </summary>
        [Description("异常2,无参构造异常")]
        Demo2Error = 12001,
    }
}
