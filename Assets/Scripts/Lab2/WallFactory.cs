using System.Collections.Generic;
using UnityEngine;

namespace ThrashJT.Lab3
{
    public class WallFactory : IPrefabFactory
    {

        private List<GameObject> walls;

        public WallFactory(List<GameObject> walls)
        {
            this.walls = walls;
        }


        public GameObject CreatePrefab(Vector3 position)
        {
            int random = Seed.Next(walls.Count);
            return Object.Instantiate(walls[random], position, Quaternion.identity);
        }
    }
}

