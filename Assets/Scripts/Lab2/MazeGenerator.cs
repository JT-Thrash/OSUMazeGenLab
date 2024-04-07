using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ThrashJT.Lab3
{
    public class MazeGenerator : MonoBehaviour
    {

        [SerializeField] List<GameObject> floorBlockList;
        [SerializeField] List<GameObject> wallBlockList;
        [SerializeField] List<GameObject> randomObjects;
        [Range(1,100)][SerializeField] private float randomObjectFrequency;
        [SerializeField] private int blockSize;

        [Range(2,100)][SerializeField] private int rows, cols;
        [Range(1, 10)][SerializeField] private int pathLength, pathWidth;

        public (int,int) RowsColumns { get => (rows, cols); }

        [SerializeField] private int seed;

        private PrimsMazeAlgorithm mazeAlg;
        private LevelCreator creator;
        private GridGraph<Direction> directionGrid;


        [SerializeField] private GameObject collectible;
        [SerializeField] private GameObject mazeEndTrigger;
        [SerializeField] private GameObject player;

        private MazeQuery query;


        public void SetRowColumns(int rows, int columns)
        {
            this.rows = rows;
            cols = columns;
        }


        public void GenerateMaze()
        {
            Seed.SetSeed(seed);


            mazeAlg = new PrimsMazeAlgorithm();


            directionGrid = mazeAlg.GenerateMaze(rows, cols);


            int boolGridRows = pathLength + 2, boolGridColumns = pathWidth + 2;
            GridGraph<bool> boolGrid = GraphConverter.Convert(directionGrid, boolGridRows, boolGridColumns);


            PositionList floorPositions = new PositionList(boolGrid, true, blockSize);
            PositionList wallPositions = new PositionList(boolGrid, false, blockSize);

            creator = new LevelCreator();

            creator.Create(new FloorFactory(floorBlockList), floorPositions.positions);
            creator.Create(new WallFactory(wallBlockList), wallPositions.positions);
            creator.CreateRandomObjects(new RandomObjectFactory(randomObjects), floorPositions.positions, randomObjectFrequency);


            query = new MazeQuery(directionGrid, boolGridColumns, boolGridRows);
        }

        //spawn collectibles at dead ends and cross sections
        public void SpawnCollectibles()
        {
            if(query == null) {
                Debug.LogError("Error: Maze must be generated before spawning collectibles");
            }
      
            foreach ((int, int) deadEnd in query.GetDeadEnds().Concat(query.GetCrossSections()))
            {
                Vector3 position = query.GetMazeSpacePosition(deadEnd.Item1, deadEnd.Item2);
                Instantiate(collectible, position, Quaternion.identity);
            }
        }

        // Place player at starting cell of the maze
        public void SpawnPlayer()
        {
            if (query == null)
            {
                Debug.LogError("Error: Maze must be placing player in scene");
            }

            Vector3 startPosition = query.GetStartPosition();

            //place collider at start so player doesn't fall off maze
            GameObject safetyNet = Instantiate(new GameObject("SafetyNet"), startPosition + Vector3.back * pathLength / 2, Quaternion.identity);
            BoxCollider collider = safetyNet.AddComponent<BoxCollider>();
            collider.size = new Vector3(pathWidth, 3, 1);

            player.transform.position = startPosition;
        }

        // Place collider at end of maze which will trigger game over
        public void PlaceEndTrigger()
        {
            if (query == null)
            {
                Debug.LogError("Error: Maze must be placing player in scene");
            }

            

            BoxCollider collider = mazeEndTrigger.GetComponentInChildren<BoxCollider>();
            collider.size = new Vector3(pathWidth, 3, 1);

            Vector3 endPosition = query.GetEndPosition() + Vector3.forward * pathLength / 2;
            Instantiate(mazeEndTrigger, endPosition, Quaternion.identity);

        }



    }
}

