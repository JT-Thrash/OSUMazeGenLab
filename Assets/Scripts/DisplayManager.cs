using System.Collections;
using TMPro;
using UnityEngine;

namespace ThrashJT.Lab3
{
    public class DisplayManager : MonoBehaviour
    {

        [SerializeField] private TextMeshProUGUI winMessage;
        [SerializeField] private TextMeshProUGUI finalScoreMessage;
        [SerializeField] private TextMeshProUGUI restartingMessage;
        [SerializeField] private TextMeshProUGUI scoreDisplay;

        private void Start()
        {
            winMessage.gameObject.SetActive(false);
            restartingMessage.gameObject.SetActive(false);
            finalScoreMessage.gameObject.SetActive(false);
        }

        public void DisplayWinMessage()
        {
            winMessage.gameObject.SetActive(true);
            restartingMessage.gameObject.SetActive(true);
            finalScoreMessage.gameObject.SetActive(true);
            scoreDisplay.gameObject.SetActive(false);

            finalScoreMessage.text = string.Format(
                "Time To Finish {0}\n" +
                "Time Bonus: {1}\n " +
                "Grand Total: {2}",
                ScoreManager.TotalTime, ScoreManager.TimeBonus, ScoreManager.GetFinalScore());
        }

        public void UpdateScore(int score)
        {
            scoreDisplay.text = "Score: " + score;
        }

        // Display countdown, shows time until level reloads
        public void RestartCountdown(int time)
        {
            StartCoroutine(RestartCountdownRoutine(time));
        }

        public IEnumerator RestartCountdownRoutine(int time)
        {
            for (int i = time; i >= 0; i--)
            {
                restartingMessage.text = "Next maze in " + i;
                yield return new WaitForSeconds(1);
            }

            EventManager.RestartScene();
            yield break;

        }

    }
}