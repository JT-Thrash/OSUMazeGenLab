using System.Collections.Generic;
using UnityEngine;

namespace ThrashJT.Lab3
{


    public class RandomObjectFactory : IPrefabFactory
    {

        private List<GameObject> objects; 
        public RandomObjectFactory(List<GameObject> objects)
        {
            this.objects = objects;
        }


        public GameObject CreatePrefab(Vector3 position)
        {
            int num = Seed.Next(objects.Count);
            Vector3 pos = OffsetPosition(position, objects[num].transform);
            return Object.Instantiate(objects[num], pos, RandomRotation());
        }


        //offset object positions and rotations to add sufficient randomness//


        private Vector3 OffsetPosition(Vector3 position, Transform obj)
        {
            float xOffset = ((float)Seed.NextDouble() * 0.25f) * obj.localScale.x;
            float zOffset = (float)Seed.NextDouble() * 0.25f * obj.localScale.z;
            return new Vector3(position.x + xOffset, position.y, position.z + zOffset);
        }

        private Quaternion RandomRotation()
        {
            float rotateAmount = (float)Seed.NextDouble() * 360;
            return Quaternion.Euler(0, rotateAmount, 0);
        }
    }
}

