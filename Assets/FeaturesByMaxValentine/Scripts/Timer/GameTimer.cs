using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace MaxValentine
{
    public class GameTimer : MonoBehaviour
    {
        [SerializeField] private float timerDuration = 60;
        [SerializeField] private float timer;
        [SerializeField] private TextMeshProUGUI timerDisplay;
        

        private void OnEnable()
        {
            TimerManager.OnTimer += ResetTimer;
        }

        private void OnDisable()
        {
            TimerManager.OnTimer -= ResetTimer;
        }
        private void ResetTimer()
        {
            timer = timerDuration;
        }

        private void Update()
        {
            if(timer > 0)
            {
                timer -= Time.deltaTime;
                timerDisplay.text = timer.ToString();
            }
        }
    }
     
       
        // Section of code above was taken from:
        // https://www.youtube.com/watch?v=ulxXGht5D2U&ab_channel=TurboMakesGames 


        /// <summary>
        /// Start the game timer with 60 seconds
        /// Count down every second
        /// Check if the timer has reached 0
        /// If timer has reached 0, the round ends
        /// Maybe call TankGameManager.ResetRound()?
        /// Add 1 point to the winner(Does this happen already?)
        /// Display victory message
        /// Else continue counting down
        /// </summary>
}