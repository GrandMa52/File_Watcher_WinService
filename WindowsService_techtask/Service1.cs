﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.IO;
using System.Text;
using System.Threading;

namespace WindowsService_techtask
{
    public partial class Service1 : ServiceBase
    {
        Logger logger;
        public Service1()
        {
            InitializeComponent();
            this.CanStop = true;
            this.CanPauseAndContinue = true;
            this.AutoLog = true;
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        class Logger 
        {
            FileSystemWatcher watcher;
            object obj = new object();
            bool enabled = true;
            public Logger() 
            {
                watcher = new FileSystemWatcher("C:\\Temp");

            }
        }
    }
}
