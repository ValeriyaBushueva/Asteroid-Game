using MessageBrokerSystem;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnDestroy()
    {
        MessageBroker.Publish($"Enemy destroyed: {gameObject.name}");
    }
}