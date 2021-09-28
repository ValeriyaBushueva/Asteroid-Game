using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace MessageBrokerSystem
{
    public class MessageUIElement : MonoBehaviour
    {
        [SerializeField] private TMP_Text textComponent;
        [SerializeField] private float selfDestroySeconds;
        
        public string Text
        {
            set => textComponent.text = value;
        }

        private IEnumerator Start()
        {
            yield return new WaitForSeconds(selfDestroySeconds);
            
            Destroy(gameObject);
        }
    }
}