using System.Collections.Generic;
using UnityEngine;


namespace ThrashJT.Lab3
{
    public class FloorFactory : IPrefabFactory
    {

        private List<GameObject> floorList;

        public FloorFactory(List<GameObject> floorList)
        {
            this.floorList = floorList;
        }

        public GameObject CreatePrefab(Vector3 position)
        {
            int random = Seed.Next(floorList.Count);
            return Object.Instantiate(floorList[random], position, Quaternion.identity);
        }

    }
}

