namespace Avtec.DevMorningFix.Dora
{
    internal class RadioMonitor:IMonitoringObserver
    {
        private readonly IMonitorOutput _output;
        private IMonitoringSubject _subject;

        public RadioMonitor(IMonitorOutput output)
        {
            _output = output;
        }
        public void Update()
        {
            _output.Write(_subject.SubjectState);
        }

        public void SetSubject(IMonitoringSubject subject)
        {
            _subject = subject;
        }
    }
}