namespace Avtec.DevMorningFix.Dora.ConsoleApp
{
    class DoraStart : IStart
    {
        private readonly IProcessor _processor;

        public DoraStart(IProcessor processor)
        {
            _processor = processor;
        }
        public void Execute(string[] args)
        {
            _processor.Parse(args);
        }
    }
}