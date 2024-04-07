using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ThrashJT.Lab3
{
    public class FirstPersonCamera : MonoBehaviour
    {
        [SerializeField] [Range(1, 10)] private float rotationSpeed;
        [SerializeField] private bool invertY;
        private float invertModifier;
        private const float speedMultiplier = 500;
        private InputAction moveAction;

        public void Initialize(InputAction action)
        {
            moveAction = action;
            moveAction.Enable();

            invertModifier = invertY ? 0 : -1;
        }

        private void Update()
        {

            Vector2 mouseDelta = moveAction.ReadValue<Vector2>();

            //looking left and right (rotating on y axis)
            float horizontal = mouseDelta.x;

            //looking up and down (rotating on x axis)
            float vertical = mouseDelta.y * invertModifier;

            var step = Time.deltaTime * speedMultiplier;

            Quaternion newRot = GetNewRotation(vertical, horizontal);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRot, step);

        }

        private Quaternion GetNewRotation(float vertical, float horizontal)
        {
            Vector3 oldRot = transform.rotation.eulerAngles;

            //clamp vertical look to prevent weird rotation when looking all the way up or down
            (float min, float max) = oldRot.x > 0 && oldRot.x < 90 ? (0, 60) : (270, 360);
            float clampedVertical = Mathf.Clamp(oldRot.x + vertical, min, max);

            Vector3 newRot = new Vector3(clampedVertical, oldRot.y + horizontal, 0);
            return Quaternion.Euler(newRot);
        }


    }
}