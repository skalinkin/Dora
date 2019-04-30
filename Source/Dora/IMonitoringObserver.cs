namespace Avtec.DevMorningFix.Dora
{
    public interface IMonitoringObserver
    {
        void Update();
        void SetSubject(IMonitoringSubject subject);
    }
}