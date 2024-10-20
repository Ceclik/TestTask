﻿using UnityEngine;

namespace Services
{
    public class CharacterRotationService : ICharacterRotator
    {
        public void Rotate(float mouseSensitivity, Rigidbody rigidbody, ref float verticalRotation,
            Transform cameraTransform)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.fixedDeltaTime;
            Quaternion deltaRotationY = Quaternion.Euler(0f, mouseX, 0f);
            rigidbody.MoveRotation(rigidbody.rotation * deltaRotationY);

            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.fixedDeltaTime;
            verticalRotation -= mouseY;

            verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

            cameraTransform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
        }
    }
}