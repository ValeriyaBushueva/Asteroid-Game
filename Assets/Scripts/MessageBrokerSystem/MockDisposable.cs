using System;

namespace MessageBrokerSystem
{
    public class MockDisposable : IDisposable
    {
        private Action onDispose;

        public MockDisposable(Action onDispose)
        {
            this.onDispose = onDispose;
        }

        public void Dispose() => onDispose();
    }
}