using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThrashJT.Lab3
{
    public class Rotate_Y_Axis : MonoBehaviour
    {

        private void Update()
        {
            transform.Rotate(Vector3.up, 1, Space.World);
        }
    }
}