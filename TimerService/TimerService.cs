using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;
using System.Media;

namespace TimerService
{
    public partial class TimerService : ServiceBase
    {
        private static Timer timer;
        private int eventId = 1;
        private SoundPlayer simpleSound;

        public TimerService()
        {
            InitializeComponent();
            //This is a eventlog used for debugging
            timerEventLog = new System.Diagnostics.EventLog();
            //This creates a eventlog for this service if there isn't already one
            if (!System.Diagnostics.EventLog.SourceExists("TimerSource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "TimerSource", "MyTimerLog");
            }
            timerEventLog.Source = "TimerSource";
            timerEventLog.Log = "MyTimerLog";
            //This sets up the sound to be ready to be played
            simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
        }

        //
        protected override void OnStart(string[] args)
        {
            timerEventLog.WriteEntry("In OnStart.", EventLogEntryType.Information, eventId++);
            StartMinTimer();
        }

        protected override void OnStop()
        {
            timerEventLog.WriteEntry("In OnStop.", EventLogEntryType.Information, eventId++);
        }

        protected override void OnContinue()
        {
            timerEventLog.WriteEntry("In OnContinue.", EventLogEntryType.Information, eventId++);
        }
        
        //This starts a 20 minute timer
        private void StartMinTimer()
        {
            timerEventLog.WriteEntry("Start 20 min timer", EventLogEntryType.Information, eventId++);
            timer = new Timer(1200000); // default 1200000
            timer.AutoReset = false;
            timer.Elapsed += OnMinTimer;
            timer.Start();
        }

        //This starts a 20 second timer
        private void StartSecTimer()
        {
            timerEventLog.WriteEntry("Start 20 sec timer", EventLogEntryType.Information, eventId++);
            timer = new Timer(20000);
            timer.AutoReset = false;
            timer.Elapsed += OnSecTimer;
            timer.Start();
        }

        private void OnMinTimer(object sender, ElapsedEventArgs args)
        {
            //This plays to tell the user to start looking away
            simpleSound.Play();
            StartSecTimer();
        }

        private void OnSecTimer(object sender, ElapsedEventArgs args)
        {
            //This plays to tell the user to stop looking away
            simpleSound.Play();
            StartMinTimer();
        }
    }
}
