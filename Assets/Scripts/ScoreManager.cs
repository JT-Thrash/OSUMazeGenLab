using UnityEngine;

namespace ThrashJT.Lab3
{
    public class ScoreManager : MonoBehaviour
    {

        [SerializeField] private GameObject displayManagerObject;
        private static DisplayManager displayManager;


        [SerializeField] private int scoreMultiplier;
        private static int multiplier;

        private static int score;
        private static float startTime;

        public static float TotalTime { get; private set; }
        public static int TimeBonus { get; private set; }

        private void Start()
        {
            TotalTime = 0;
            TimeBonus = 0;
            score = 0;
            multiplier = scoreMultiplier;
            startTime = Time.time;
            displayManager = displayManagerObject.GetComponent<DisplayManager>();
        }

        public static void IncreaseScore(int amount)
        {
            score += amount;
            displayManager.UpdateScore(score);
        }


        public static void FinishGame()
        {
            TotalTime = Time.time - startTime;
            TimeBonus = (int)(multiplier / TotalTime);
        }

        public static int GetFinalScore()
        {
            if (TotalTime > 0)
                return score * TimeBonus;

            return -1;
        }



    }
}