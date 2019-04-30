namespace Avtec.DevMorningFix.Dora
{
    public interface IMonitoringSubject
    {
        void Attach(IMonitoringObserver observer);
        void Detach(IMonitoringObserver observer);
        void Notify();
        string SubjectState { get; }
    }
}