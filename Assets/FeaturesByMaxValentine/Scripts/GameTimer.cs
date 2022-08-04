using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class GameTimer : MonoBehaviour
    {
        [SerializeField] float gameTimer = 60;

        private void update()
        {
            gameTimer 
        }

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

}