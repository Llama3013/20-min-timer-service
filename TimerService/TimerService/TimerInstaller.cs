﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace TimerService
{
    [RunInstaller(true)]
    public partial class TimerInstaller : System.Configuration.Install.Installer
    {
        public TimerInstaller()
        {
            InitializeComponent();
        }

        private void timerServiceInstaller_AfterInstall(object sender, InstallEventArgs e)
        {

        }

        private void timerServiceProcessInstaller_AfterInstall(object sender, InstallEventArgs e)
        {

        }
    }
}
