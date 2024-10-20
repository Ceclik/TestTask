using UnityEngine;

namespace Services
{
    public interface ICharacterMover
    {
        public void Move(Rigidbody rigidbody, KeyCode key, float movingSpead);
    }
}