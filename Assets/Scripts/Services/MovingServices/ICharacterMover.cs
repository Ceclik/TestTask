using UnityEngine;

namespace Services.MovingServices
{
    public interface ICharacterMover
    {
        public void Move(Rigidbody rigidbody, KeyCode key, float movingSpead);
    }
}