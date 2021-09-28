using UnityEngine;

namespace MessageBrokerSystem
{
    public static class MessageBroker
    {
        public static void Publish(string message)
        {
            Debug.Log(message);
        }
    }
}