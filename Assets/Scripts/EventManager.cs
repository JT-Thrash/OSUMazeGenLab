using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace ThrashJT.Lab3
{
    public class EventManager : MonoBehaviour
    {
        [SerializeField] private MazeGenerator mazeGenerator;
        [SerializeField] private GameObject displayManagerObject;
        private static DisplayManager displayManager;

        private static int mazesBeaten = 0;

        private void Start()
        {
            //Keep track of number of mazes completed,
            //increase size of maze each time level is loaded
            if (mazesBeaten > 0)
            {
                int rows = mazeGenerator.RowsColumns.Item1;
                int columns = mazeGenerator.RowsColumns.Item2;
                mazeGenerator.SetRowColumns(rows + mazesBeaten, columns + mazesBeaten);
            }

            //Use maze generator to set up scene
            mazeGenerator.GenerateMaze();
            mazeGenerator.SpawnPlayer();
            mazeGenerator.SpawnCollectibles();
            mazeGenerator.PlaceEndTrigger();

            displayManager = displayManagerObject.GetComponent<DisplayManager>();
        }

        public static void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public static void MazeFinish()
        {
            mazesBeaten += 1;
            ScoreManager.FinishGame();
            displayManager.DisplayWinMessage();
            displayManager.RestartCountdown(3);
        }


    }
}

