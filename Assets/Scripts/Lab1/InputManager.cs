using UnityEngine;
using ThrashJT.Input;

namespace ThrashJT.Lab3
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private MovementControl movementController;
        [SerializeField] private FirstPersonCamera FPCamera;


        private CSE3541Inputs inputScheme;


        private void Awake()
        {
            inputScheme = new CSE3541Inputs();
            movementController.Initialize(inputScheme.Player.Move, inputScheme.Player.ChangeMoveSpeed);
            FPCamera.Initialize(inputScheme.Player.Rotate);

            Cursor.lockState = CursorLockMode.Locked;
        }
        private void OnEnable()
        {
            var _ = new QuitHandler(inputScheme.Player.Quit);
        }
    }
}
