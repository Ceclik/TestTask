using Services.MovingServices;
using UnityEngine;

namespace MovingScripts
{
    public class CharacterMovementsHandler : MonoBehaviour
    {
        [SerializeField] private float movingSpeed;
        private ICharacterMover _characterMover;

        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _characterMover = new CharacterMovingService();
        }

        private void FixedUpdate()
        {
            KeyCode keyCode;
            if (Input.GetKey(KeyCode.W))
            {
                keyCode = KeyCode.W;
                _characterMover.Move(_rigidbody, keyCode, movingSpeed);
            }

            if (Input.GetKey(KeyCode.A))
            {
                keyCode = KeyCode.A;
                _characterMover.Move(_rigidbody, keyCode, movingSpeed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                keyCode = KeyCode.S;
                _characterMover.Move(_rigidbody, keyCode, movingSpeed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                keyCode = KeyCode.D;
                _characterMover.Move(_rigidbody, keyCode, movingSpeed);
            }
        }
    }
}