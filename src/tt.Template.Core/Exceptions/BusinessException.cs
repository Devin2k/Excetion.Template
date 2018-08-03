using System;
using System.Collections.Generic;
using System.Text;

namespace tt.Template.Core.Exceptions
{
    /// <summary>
    /// 业务标准异常
    /// </summary>
    [Serializable]
    public class BusinessException :BaseException
    {
        /// <summary>
        /// 初始化<see cref="BusinessException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 本构造函数使用框架预设<para>错误</para>信息.
        /// </remarks>
        /// <param name="status">通用错误类型<see cref="BusinessStatusCode"/></param>
        public BusinessException(BusinessStatusCode status)
                : base((int)status, status.Description()) { }

        /// <summary>
        /// 初始化<see cref="BusinessException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 本构造函数使用框架预设<para>错误</para>信息.
        /// </remarks>
        /// <param name="status">通用错误类型<see cref="BusinessStatusCode"/></param>
        /// <param name="parameters">格式化参数</param>
        protected BusinessException(BusinessStatusCode status, params string[] parameters)
                : base((int)status, string.Format(status.Description(), parameters)) { }

        /// <summary>
        /// 初始化<see cref="BusinessException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 本构造函数使用框架预设<para>通用状态码</para>信息.
        /// </remarks>
        /// <param name="status">服务状<see cref="BusinessStatusCode"/></param>
        /// <param name="innerException">
        /// 导致当前异常的异常，如果<see cref="System.Exception"/> 参数不为空引用，则在处理内部异常的 catch 块中引发当前异常。
        /// </param>
        public BusinessException(BusinessStatusCode status, Exception innerException)
        : base((int)status, status.Description(), innerException) { }
       

        /// <summary>
        /// 初始化<see cref="BusinessException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 本构造函数使用框架预设<para>通用状态码</para>信息.
        /// </remarks>
        /// <param name="status">服务状态码<see cref="BusinessStatusCode"/></param>
        /// <param name="notification">提示内容</param>
        /// <param name="innerException">
        /// 导致当前异常的异常，如果<see cref="System.Exception"/> 参数不为空引用，则在处理内部异常的 catch 块中引发当前异常。
        /// </param>
        protected BusinessException(BusinessStatusCode status, Exception innerException, params string[] parameters)
            : base((int)status, string.Format(status.Description(), parameters), innerException) { }

    }
}
