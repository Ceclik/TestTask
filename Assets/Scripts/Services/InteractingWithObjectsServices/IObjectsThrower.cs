using InteractionWithObjectsScripts;
using UnityEngine;

namespace Services.InteractingWithObjectsServices
{
    public interface IObjectsThrower
    {
        public void ThrowObject(Transform objectTransform, Transform mainObjectsParent,
            ActionTextHandler actionTextHandler, ref bool isObjectPicked);
    }
}