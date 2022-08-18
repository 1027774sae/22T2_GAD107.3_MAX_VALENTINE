using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class CounterListener : MonoBehaviour
    {
        // This class will be LISTENING to the "Increase Counter" event
        // When the event is announced, this calss will...
        // ...increase the counter
        // ... update the UI text

        [SerializeField] public int counter;
        [SerializeField] private TMPro.TextMeshProUGUI counterUiText;

        // For events, we need ot subscribe and unsubscribe to whichever event we want to hear.

        private void OnEnable()
        {
            // Subscribe to our event
            CounterAnnouncer.OnStart += IncreaseCount;
        }

        private void OnDisable()
        {
            // Unsubscribe to our event
            CounterAnnouncer.OnStart -= IncreaseCount;
        }
        private void IncreaseCount()
        {
            counter++;
            counterUiText.text = ("Number of game starts: ") + counter.ToString();
        }
    }
}