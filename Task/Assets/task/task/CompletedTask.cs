﻿
namespace GameFramework
{
    /// <summary>
    /// @details 异步完成任务。
    /// </summary>
    public sealed class CompletedTask : AsyncTask
    {
        /// <summary>
        /// 构造函数。
        /// </summary>
        /// <param name="result">返回的结果，默认为null。</param>
        public CompletedTask(object result = null) : base(true)
        {
            Result = result;
        }
    }
}
