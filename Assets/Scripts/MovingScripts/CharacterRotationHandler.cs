using Services;
using UnityEngine;

namespace MovingScripts
{
    public class CharacterRotationHandler : MonoBehaviour
    {
        [SerializeField] private float mouseSensitivity = 100f;
        [SerializeField] private Transform cameraTransform;
        
        private Rigidbody _rigidbody;
        private float _verticalRotation = 0f;
        private ICharacterRotator _characterRotator;
        

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            _rigidbody = GetComponent<Rigidbody>();
            _rigidbody.freezeRotation = true;
            _characterRotator = new CharacterRotationService();
        }

        private void Update()
        {
            _characterRotator.Rotate(mouseSensitivity, _rigidbody, ref _verticalRotation, cameraTransform);
            
            /*float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.fixedDeltaTime;
            Quaternion deltaRotationY = Quaternion.Euler(0f, mouseX, 0f);
            _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotationY);

            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.fixedDeltaTime;
            _verticalRotation -= mouseY;

            _verticalRotation = Mathf.Clamp(_verticalRotation, -90f, 90f);

            cameraTransform.localRotation = Quaternion.Euler(_verticalRotation, 0f, 0f);*/
        }
    }
}