using System;
using System.Collections.Generic;
using UnityEngine;

namespace MessageBrokerSystem
{
    public class MessageBroker : IObservable<string>
    {
        private List<IObserver<string>> observers = new List<IObserver<string>>();

        public static MessageBroker Instance { get; } = new MessageBroker();
        
        public static void Publish(string message)
        {
            Debug.Log(message);
            
            Instance.PublishToObservers(message);
        }

        private void PublishToObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.OnNext(message);
            }
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            observers.Add(observer);

            return new MockDisposable(() => observers.Remove(observer));
        }
    }
}