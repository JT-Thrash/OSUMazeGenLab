using UnityEngine;
using UnityEngine.InputSystem;

namespace ThrashJT.Lab3
{
    public class MovementControl : MonoBehaviour
    {
        [SerializeField] private Transform playerToMove;
        [SerializeField] private float speed;
        [SerializeField] [Range(1,10)]private float sprintMultiplier;
        private InputAction moveAction, sprintAction;
        private float normalSpeed;
        private float sprintSpeed => normalSpeed * sprintMultiplier;

        public void Initialize(InputAction moveAction, InputAction sprintAction)
        {
            this.moveAction = moveAction;
            this.moveAction.Enable();
            this.sprintAction = sprintAction;
            this.sprintAction.Enable();

            normalSpeed = speed;
            sprintAction.started += SprintAction_started;
            sprintAction.canceled += SprintAction_canceled;
     
        }

        private void SprintAction_started(InputAction.CallbackContext obj)
        {
            speed = sprintSpeed;
        }

        private void SprintAction_canceled(InputAction.CallbackContext obj)
        {
            speed = normalSpeed;
        }

        private void Update()
        {
            Vector2 moveInput = moveAction.ReadValue<Vector2>();

            Vector3 newXPosition = playerToMove.right * moveInput.x;
            Vector3 newZPosition = playerToMove.forward * moveInput.y;
            
            Vector3 newPosition = playerToMove.position + newXPosition + newZPosition;

            playerToMove.transform.position = Vector3.MoveTowards(playerToMove.transform.position, newPosition, Time.deltaTime * speed);

        }


    }
}
