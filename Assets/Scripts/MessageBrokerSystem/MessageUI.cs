using System;
using UnityEngine;

namespace MessageBrokerSystem
{
    public class MessageUI : MonoBehaviour, IObserver<string>
    {
        [SerializeField] private Transform messageContainer;
        [SerializeField] private MessageUIElement messageElementPrefab;

        private IDisposable subscription;
        
        private void Start()
        {
            subscription = MessageBroker.Instance.Subscribe(this);
        }

        private void OnDestroy()
        {
            subscription?.Dispose();
        }

        public void OnNext(string value)
        {
            MessageUIElement messageUIElement = Instantiate(messageElementPrefab, messageContainer);

            messageUIElement.Text = value;
        }

        public void OnError(Exception error)
        {
            Debug.LogException(error);
        }

        public void OnCompleted()
        {
            //NONE
        }
    }
}