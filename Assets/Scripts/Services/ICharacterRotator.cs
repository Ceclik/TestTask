using UnityEngine;

namespace Services
{
    public interface ICharacterRotator
    {
        public void Rotate(float mouseSensitivity, Rigidbody rigidbody, ref float verticalRotation, Transform cameraTransform);
    }
}