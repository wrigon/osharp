﻿// -----------------------------------------------------------------------
//  <copyright file="DataLoggingInitializer.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2015 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2015-09-23 9:58</last-date>
// -----------------------------------------------------------------------

using OSharp.Core.Configs;


namespace OSharp.Core.Initialize
{
    /// <summary>
    /// 数据日志初始化器，用于初始化数据日志功能
    /// </summary>
    public class DataLoggingInitializer : LoggingInitializerBase, IDataLoggingInitializer
    {
        /// <summary>
        /// 开始初始化数据日志
        /// </summary>
        /// <param name="config">数据日志配置信息</param>
        public virtual void Initialize(DataLoggingConfig config)
        {
            LoggingAdapterConfig adapterConfig = new LoggingAdapterConfig()
            {
                Enabled = config.Enabled,
                AdapterType = config.AdapterType
            };
            SetLoggingFromAdapterConfig(adapterConfig);
        }
    }
}