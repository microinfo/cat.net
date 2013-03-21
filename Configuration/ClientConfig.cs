﻿namespace Com.Dianping.Cat.Configuration
{
    using System.Collections.Generic;

    /// <summary>
    ///   Cat客户端配置
    /// </summary>
    public class ClientConfig
    {
        private readonly IList<Server> _mServers;
        private Domain _mDomain;

        public ClientConfig()
        {
            _mServers = new List<Server>();
        }

        /// <summary>
        ///   是否是开发模式
        /// </summary>
        public bool DevMode { get; set; }

        public Domain Domain
        {
            //NOTE: Enabled = false
            get { return _mDomain ?? (_mDomain = new Domain {Id = "Unknown", Enabled = false}); }

            set { _mDomain = value; }
        }

        /// <summary>
        ///   Cat日志服务器，可以有多个
        /// </summary>
        public IList<Server> Servers
        {
            get { return _mServers; }
        }
    }
}