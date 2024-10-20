using UnityEngine;

namespace Services.MovingServices
{
    public class CharacterMovingService : ICharacterMover
    {
        public void Move(Rigidbody rigidbody, KeyCode key, float movingSpeed)
        {
            var movement = Vector3.zero;

            // Двигаем персонажа относительно его локальных осей
            switch (key)
            {
                case KeyCode.W:
                    movement = rigidbody.transform.forward * movingSpeed * Time.fixedDeltaTime;
                    break;
                case KeyCode.A:
                    movement = -rigidbody.transform.right * movingSpeed * Time.fixedDeltaTime;
                    break;
                case KeyCode.S:
                    movement = -rigidbody.transform.forward * movingSpeed * Time.fixedDeltaTime;
                    break;
                case KeyCode.D:
                    movement = rigidbody.transform.right * movingSpeed * Time.fixedDeltaTime;
                    break;
            }

            // Применяем движение
            rigidbody.MovePosition(rigidbody.position + movement);
        }
    }
}