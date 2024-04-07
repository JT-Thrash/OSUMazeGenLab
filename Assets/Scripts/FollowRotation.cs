using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ThrashJT.Lab3
{
    public class FollowRotation : MonoBehaviour
    {
        [SerializeField] private Transform objectToRotate;
        [SerializeField] private Transform targetObject;

        private void Update()
        {

            Vector3 camRotation = targetObject.rotation.eulerAngles;
            Vector3 newRotation = new Vector3(0, camRotation.y, 0);
            objectToRotate.rotation = Quaternion.Euler(newRotation);

        }

    }
}