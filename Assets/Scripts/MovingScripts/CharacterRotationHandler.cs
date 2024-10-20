﻿using Services;
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
        }
    }
}