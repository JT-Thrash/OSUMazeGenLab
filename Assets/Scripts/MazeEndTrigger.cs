using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThrashJT.Lab3
{
    public class MazeEndTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                EventManager.MazeFinish();
                Destroy(gameObject);
            }
        }
    }
}