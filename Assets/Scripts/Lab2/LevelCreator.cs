using System.Collections.Generic;
using UnityEngine;


namespace ThrashJT.Lab3
{

    public class LevelCreator
    {


        public GameObject Level { get; }

        public LevelCreator()
        {
            Level = Object.Instantiate(new GameObject());
            Level.name = "Maze";
        }


        public void Create(IPrefabFactory factory, List<Vector3> positions)
        {

            foreach (Vector3 position in positions)
            {
                GameObject obj = factory.CreatePrefab(position);
                obj.transform.SetParent(Level.transform);
            }

        }

        public void CreateRandomObjects(IPrefabFactory factory, List<Vector3> positions, float frequency)
        {

            foreach (Vector3 position in positions)
            {
                int place = Seed.Next((int)(100 / frequency));
                if (place == 0)
                {
                    GameObject obj = factory.CreatePrefab(position);
                    obj.transform.SetParent(Level.transform);
                }
            }
        }

    }
}

