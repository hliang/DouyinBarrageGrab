﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarrageGrab.Modles.JsonEntity;
using static System.Configuration.ConfigurationManager;
using System.Drawing;

namespace BarrageGrab
{
    internal class Appsetting
    {
        private static readonly Appsetting ins = new Appsetting();

        public static Appsetting Current { get { return ins; } }

        public Appsetting()
        {
            try
            {
                ProcessFilter = AppSettings["processFilter"].Trim().Split(',');
                WsProt = int.Parse(AppSettings["wsListenPort"]);
                PrintBarrage = AppSettings["printBarrage"].ToLower() == "true";
                ProxyPort = int.Parse(AppSettings["proxyPort"]);
                PrintFilter = Enum.GetValues(typeof(PackMsgType)).Cast<int>().Where(w=>w>0).ToArray();
                PushFilter = Enum.GetValues(typeof(PackMsgType)).Cast<int>().Where(w => w > 0).ToArray();
                LogFilter = Enum.GetValues(typeof(PackMsgType)).Cast<int>().Where(w => w > 0).ToArray();
                FilterHostName = bool.Parse(AppSettings["filterHostName"].Trim());
                HostNameFilter = AppSettings["hostNameFilter"].Trim().Split(',').Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();
                RoomIds = AppSettings["roomIds"].Trim().Split(',').Where(w => !string.IsNullOrWhiteSpace(w)).Select(s => long.Parse(s)).ToArray();
                UsedProxy = bool.Parse(AppSettings["usedProxy"].Trim());
                ListenAny = bool.Parse(AppSettings["listenAny"].Trim());
                UpstreamProxy = AppSettings["upstreamProxy"].Trim();
                HideConsole = bool.Parse(AppSettings["hideConsole"].Trim());
                BarrageLog = bool.Parse(AppSettings["barrageFileLog"].Trim());
                ShowWindow = bool.Parse(AppSettings["showWindow"].Trim());

                var printFilter = AppSettings["printFilter"].Trim().ToLower();
                var pushFilter = AppSettings["pushFilter"].Trim().ToLower();
                var logFilter = AppSettings["logFilter"].Trim().ToLower();                
                if (!string.IsNullOrWhiteSpace(printFilter))
                {
                    if (string.IsNullOrWhiteSpace(printFilter)) PrintFilter = new int[0];
                    else PrintFilter = printFilter.Split(',').Select(x => int.Parse(x)).ToArray();
                    Console.WriteLine("PrintFilter " + AppSettings["printFilter"] + " => " + string.Join(",", PrintFilter));
                }
                if (!string.IsNullOrWhiteSpace(pushFilter))
                {
                    if (string.IsNullOrWhiteSpace(pushFilter)) PushFilter = new int[0];
                    else PushFilter = pushFilter.Split(',').Select(x => int.Parse(x)).ToArray();
                }
                if (!string.IsNullOrWhiteSpace(logFilter))
                {
                    if (string.IsNullOrWhiteSpace(logFilter)) LogFilter = new int[0];
                    else LogFilter = logFilter.Split(',').Select(x => int.Parse(x)).ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("配置文件读取失败,请检查配置文件是否正确");
                throw ex;
            }
        }

        public void Save()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            config.AppSettings.Settings["wsListenPort"].Value = WsProt.ToString();            
            config.AppSettings.Settings["printBarrage"].Value = PrintBarrage.ToString().ToLower();
            config.AppSettings.Settings["printFilter"].Value = string.Join("", PrintFilter);
            config.AppSettings.Settings["pushFilter"].Value = string.Join("", PushFilter);
            config.AppSettings.Settings["logFilter"].Value = string.Join("", LogFilter);
            config.AppSettings.Settings["upstreamProxy"].Value = UpstreamProxy;
            config.AppSettings.Settings["listenAny"].Value = ListenAny.ToString().ToLower();
            config.AppSettings.Settings["hideConsole"].Value = HideConsole.ToString().ToLower();
            config.AppSettings.Settings["barrageFileLog"].Value = HideConsole.ToString().ToLower();
            
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        /// <summary>
        /// 弹幕颜色映射
        /// </summary>
        public Dictionary<PackMsgType, Tuple<ConsoleColor, Color>> ColorMap = new Dictionary<PackMsgType, Tuple<ConsoleColor, Color>>()
        {
            { PackMsgType.弹幕消息, Tuple.Create(ConsoleColor.White, Color.White) },
            { PackMsgType.点赞消息, Tuple.Create(ConsoleColor.Cyan, Color.Cyan) },
            { PackMsgType.进直播间, Tuple.Create(ConsoleColor.Green, Color.Green) },
            { PackMsgType.关注消息, Tuple.Create(ConsoleColor.Yellow, Color.Yellow) },
            { PackMsgType.礼物消息, Tuple.Create(ConsoleColor.Red, Color.Red) },
            { PackMsgType.直播间统计, Tuple.Create(ConsoleColor.Magenta, Color.Magenta) },
            { PackMsgType.粉丝团消息, Tuple.Create(ConsoleColor.Blue, Color.Blue) },
            { PackMsgType.直播间分享, Tuple.Create(ConsoleColor.DarkBlue, Color.DarkBlue) },
            { PackMsgType.下播, Tuple.Create(ConsoleColor.DarkCyan, Color.DarkCyan) }
        };

        /// <summary>
        /// 使用系统代理
        /// </summary>
        public bool UsedProxy { get; private set; } = true;

        /// <summary>
        /// 过滤的进程
        /// </summary>
        public string[] ProcessFilter { get; private set; }

        /// <summary>
        /// 端口号
        /// </summary>
        public int WsProt { get; set; } = 8888;

        /// <summary>
        /// true:监听在0.0.0.0，接受任意Ip连接，false:监听在127.0.0.1，仅接受本机连接
        /// </summary>
        public bool ListenAny { get; set; } = true;

        /// <summary>
        /// 控制台打印消息开关
        /// </summary>
        public bool PrintBarrage { get; set; }

        /// <summary>
        /// 代理端口
        /// </summary>
        public int ProxyPort { get; private set; } = 8827;

        /// <summary>
        /// 控制台输出过滤器
        /// </summary>
        public int[] PrintFilter { get; set; }

        /// <summary>
        /// 推送弹幕过滤器
        /// </summary>
        public int[] PushFilter { get; set; }

        /// <summary>
        /// 弹幕日志过滤器
        /// </summary>
        public int[] LogFilter { get; set; }

        /// <summary>
        /// 监听的房间号
        /// </summary>
        public long[] RoomIds { get; private set; } = new long[0];

        /// <summary>
        /// 使用域名过滤
        /// </summary>
        public bool FilterHostName { get; private set; } = true;

        /// <summary>
        /// 域名白名单列表
        /// </summary>
        public string[] HostNameFilter { get; private set; } = new string[0];

        /// <summary>
        /// 上游代理地址
        /// </summary>
        public string UpstreamProxy { get; set; }

        /// <summary>
        /// 隐藏控制台
        /// </summary>
        public bool HideConsole { get; set; }

        /// <summary>
        /// 弹幕日志
        /// </summary>
        public bool BarrageLog { get; set; } = false;

        /// <summary>
        /// 显示窗体
        /// </summary>
        public bool ShowWindow { get; private set; } = false;
    }
}
