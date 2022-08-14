using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace MaxValentine
{
    public class GameTimer : MonoBehaviour
    {
        public int timerTime;
        public Text timerDisplay;

        //
        //  private void Start()
        //{
        //    StartCoroutine(CountdownToEnd());
        //}

        //IEnumerable CountdownToEnd()
        //{
        //   while(timerTime > 0)
        //    {
        //        timerDisplay.text = timerTime.ToString();

        //        yield return new WaitForSeconds(1f);

        //        timerTime--;
        //    }

        //    timerDisplay.text = "GAME OVER";

        //    yield return new WaitForSeconds(1f);

        //    timerDisplay.gameObject.SetActive(false);
        //}
        //}
        /// </summary>
       
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

}