
namespace TimerService
{
    partial class TimerInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timerServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.timerServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // timerServiceProcessInstaller
            // 
            this.timerServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.timerServiceProcessInstaller.Password = null;
            this.timerServiceProcessInstaller.Username = null;
            this.timerServiceProcessInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.timerServiceProcessInstaller_AfterInstall);
            // 
            // timerServiceInstaller
            // 
            this.timerServiceInstaller.Description = "20 minute timer";
            this.timerServiceInstaller.DisplayName = "Timer Service";
            this.timerServiceInstaller.ServiceName = "TimerService";
            this.timerServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            this.timerServiceInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.timerServiceInstaller_AfterInstall);
            // 
            // TimerInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.timerServiceProcessInstaller,
            this.timerServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller timerServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller timerServiceInstaller;
    }
}