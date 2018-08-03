using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using tt.Template.Core.Exceptions;

namespace tt.Template.Core
{
    public class BaseException : Exception
    {
        /// <summary>
        /// 初始化<see cref="BaseException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 本构造函数使用框架预设<para>错误</para>信息.
        /// </remarks>
        /// <param name="statusCode">通用错误类型<see cref="MicroServiceStatus"/></param>
        /// <param name="notification">提示内容</param>
        public BaseException(int statusCode, string notification)
            : base($"StatusCode:{statusCode},Message:{notification}")
        {
        }

        /// <summary>
        /// 初始化<see cref="BaseException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 本构造函数使用框架预设<para>通用状态码</para>信息.
        /// </remarks>
        /// <param name="statusCode">服务状<see cref="BusinessStatusCode"/></param>
        /// <param name="notification">提示内容</param>
        /// <param name="innerException">
        /// 导致当前异常的异常，如果<see cref="System.Exception"/> 参数不为空引用，则在处理内部异常的 catch 块中引发当前异常。
        /// </param>
        public BaseException(int statusCode, string notification, Exception innerException)
            : base($"StatusCode:{statusCode},Message:{notification}", innerException)
        {
        }


        /// <summary>
        /// 用序列化数据初始化<see cref="BusinessException"/>类的新实例。
        /// </summary>
        /// <remarks>
        /// 在反序列化过程中调用该构造函数来重建通过流传输的异常对象.
        /// </remarks>
        /// <param name="info">保存序列化对象<see cref="System.Runtime.Serialization.SerializationInfo"/>数据的对象。</param>
        /// <param name="context">有关源或目标的上下文信息。</param>
        protected BaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}
