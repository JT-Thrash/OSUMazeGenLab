// GENERATED AUTOMATICALLY FROM 'Assets/Input/3541Inputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ThrashJT.Input
{
    public class @CSE3541Inputs : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @CSE3541Inputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""3541Inputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""a5d41cf5-6393-45b2-a830-426eb32df423"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""67e1146b-cb69-4bfe-8827-12121433183e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""da7616c5-03ae-486a-88ed-80e343423f31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""3874841e-2b64-4db0-957f-a88e1701fcde"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""1e83844b-1a63-483e-ac9c-9865f734f7e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PreviousPlayer"",
                    ""type"": ""Button"",
                    ""id"": ""ba457477-f3f5-4a07-95f2-4a56d1b7739c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NextPlayer"",
                    ""type"": ""Button"",
                    ""id"": ""4c2c5a00-5371-47f2-a816-74756618dd4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""efa91a2b-30c5-4491-9a7d-c9c2b2ddec24"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeMoveSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""a0709f13-e3ae-4de2-8ad9-1b9ab3b3525f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""47626a1f-96f5-4e39-8ee6-01493909de5c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""94ab1a88-3578-4926-96df-507d809e4263"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e53407e2-b3bc-4661-84d2-0b74a925f765"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a82273b5-bd13-4cb3-b641-910a9ae1e9c5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4c610890-09f8-40a6-97a5-e3bccf22140c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8c4fc53d-7c85-4e8c-95fb-59f83d02ff54"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5233b383-0be5-4f59-a122-75ef93ba92f6"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""282b19b4-00db-429e-ae57-275d550af56b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e67e362e-52ed-456e-9baa-3178c50e9117"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""80f8b599-8ba9-43c9-b4f5-f8084f4ac846"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""e61a6368-2832-400f-8444-67f8eb1e9a87"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a7b18d91-f55f-4d32-bd7b-24131ebf311d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9a0099cc-ea8f-4803-baab-d7697e991cbb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9ab41eae-9c0b-4204-a7ba-6429e8202e02"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""61945759-c2d7-49c7-be38-48bca97ac143"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bb904535-216b-43bb-9d48-1f6e85bb98bf"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93bea6a2-799d-4a60-8e1b-ca32f2f6a074"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64afe0ca-8340-4294-b36a-b8847359e48c"",
                    ""path"": ""*/{Menu}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f1b571b-07a5-4879-99a2-a5f49ef7061e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ca7bcc8-4c1c-41a9-8f30-87e5179d58e6"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f5fadaf-e355-4057-9cbc-595e1c11f055"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b93dead-4e1c-4fc9-9e30-74006b5e58e9"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba882e16-2fc1-4b6d-8d73-d85f731c5870"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dae6a744-8b1a-4b7c-9a77-9cff3fd80629"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc079048-dd82-419c-a17c-2f2344c9bf30"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7693377b-912f-4318-a5cb-39f911c0493d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ff49fb9-9b28-440c-8948-98c2df32c4c9"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfe1516f-a3ee-4c1e-a1b0-2a5922de8867"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeMoveSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""725434db-dfb2-4eed-b581-fd43cb3e92f3"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeMoveSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""All Control Schemes"",
            ""bindingGroup"": ""All Control Schemes"",
            ""devices"": []
        }
    ]
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
            m_Player_Reset = m_Player.FindAction("Reset", throwIfNotFound: true);
            m_Player_Quit = m_Player.FindAction("Quit", throwIfNotFound: true);
            m_Player_CameraSwitch = m_Player.FindAction("CameraSwitch", throwIfNotFound: true);
            m_Player_PreviousPlayer = m_Player.FindAction("PreviousPlayer", throwIfNotFound: true);
            m_Player_NextPlayer = m_Player.FindAction("NextPlayer", throwIfNotFound: true);
            m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
            m_Player_ChangeMoveSpeed = m_Player.FindAction("ChangeMoveSpeed", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Move;
        private readonly InputAction m_Player_Reset;
        private readonly InputAction m_Player_Quit;
        private readonly InputAction m_Player_CameraSwitch;
        private readonly InputAction m_Player_PreviousPlayer;
        private readonly InputAction m_Player_NextPlayer;
        private readonly InputAction m_Player_Rotate;
        private readonly InputAction m_Player_ChangeMoveSpeed;
        public struct PlayerActions
        {
            private @CSE3541Inputs m_Wrapper;
            public PlayerActions(@CSE3541Inputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Player_Move;
            public InputAction @Reset => m_Wrapper.m_Player_Reset;
            public InputAction @Quit => m_Wrapper.m_Player_Quit;
            public InputAction @CameraSwitch => m_Wrapper.m_Player_CameraSwitch;
            public InputAction @PreviousPlayer => m_Wrapper.m_Player_PreviousPlayer;
            public InputAction @NextPlayer => m_Wrapper.m_Player_NextPlayer;
            public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
            public InputAction @ChangeMoveSpeed => m_Wrapper.m_Player_ChangeMoveSpeed;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Reset.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReset;
                    @Reset.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReset;
                    @Reset.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReset;
                    @Quit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuit;
                    @Quit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuit;
                    @Quit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuit;
                    @CameraSwitch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraSwitch;
                    @CameraSwitch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraSwitch;
                    @CameraSwitch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraSwitch;
                    @PreviousPlayer.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPreviousPlayer;
                    @PreviousPlayer.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPreviousPlayer;
                    @PreviousPlayer.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPreviousPlayer;
                    @NextPlayer.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNextPlayer;
                    @NextPlayer.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNextPlayer;
                    @NextPlayer.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNextPlayer;
                    @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                    @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                    @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                    @ChangeMoveSpeed.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeMoveSpeed;
                    @ChangeMoveSpeed.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeMoveSpeed;
                    @ChangeMoveSpeed.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeMoveSpeed;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Reset.started += instance.OnReset;
                    @Reset.performed += instance.OnReset;
                    @Reset.canceled += instance.OnReset;
                    @Quit.started += instance.OnQuit;
                    @Quit.performed += instance.OnQuit;
                    @Quit.canceled += instance.OnQuit;
                    @CameraSwitch.started += instance.OnCameraSwitch;
                    @CameraSwitch.performed += instance.OnCameraSwitch;
                    @CameraSwitch.canceled += instance.OnCameraSwitch;
                    @PreviousPlayer.started += instance.OnPreviousPlayer;
                    @PreviousPlayer.performed += instance.OnPreviousPlayer;
                    @PreviousPlayer.canceled += instance.OnPreviousPlayer;
                    @NextPlayer.started += instance.OnNextPlayer;
                    @NextPlayer.performed += instance.OnNextPlayer;
                    @NextPlayer.canceled += instance.OnNextPlayer;
                    @Rotate.started += instance.OnRotate;
                    @Rotate.performed += instance.OnRotate;
                    @Rotate.canceled += instance.OnRotate;
                    @ChangeMoveSpeed.started += instance.OnChangeMoveSpeed;
                    @ChangeMoveSpeed.performed += instance.OnChangeMoveSpeed;
                    @ChangeMoveSpeed.canceled += instance.OnChangeMoveSpeed;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        private int m_AllControlSchemesSchemeIndex = -1;
        public InputControlScheme AllControlSchemesScheme
        {
            get
            {
                if (m_AllControlSchemesSchemeIndex == -1) m_AllControlSchemesSchemeIndex = asset.FindControlSchemeIndex("All Control Schemes");
                return asset.controlSchemes[m_AllControlSchemesSchemeIndex];
            }
        }
        public interface IPlayerActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnReset(InputAction.CallbackContext context);
            void OnQuit(InputAction.CallbackContext context);
            void OnCameraSwitch(InputAction.CallbackContext context);
            void OnPreviousPlayer(InputAction.CallbackContext context);
            void OnNextPlayer(InputAction.CallbackContext context);
            void OnRotate(InputAction.CallbackContext context);
            void OnChangeMoveSpeed(InputAction.CallbackContext context);
        }
    }
}
