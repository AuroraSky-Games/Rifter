using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts
{
    public class SystemManager : MonoBehaviour
    {
        private static Camera _mainCamera;

        private void Awake()
        {
            GetInput = new GameInput();
            _mainCamera = Camera.main;
        }

        private void OnEnable()
        {
            GetInput.Enable();
        }

        private void OnDisable()
        {
            GetInput.Disable();
        }

        private static Vector3 MousePosition()
        {
            //Rotation
            var aimScreenPosition = GetInput.PlayerControls.TargetPosition.ReadValue<Vector2>();
            var aimScreenWorldPosition = _mainCamera.ScreenToWorldPoint(aimScreenPosition);
            return aimScreenWorldPosition;
        }

        protected static Vector3 GetMousePosition => MousePosition();

        protected static GameInput GetInput { get; private set; }
    }
}