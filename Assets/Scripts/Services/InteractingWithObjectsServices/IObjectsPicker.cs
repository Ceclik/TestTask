using InteractionWithObjectsScripts;
using UnityEngine;

namespace Services.InteractingWithObjectsServices
{
    public interface IObjectsPicker
    {
        public void PickObject(Camera camera, float rayDistance, Transform objectTransform,
            ActionTextHandler actionTextHandler, ref bool isObjectPicked, Transform characterTransform);
    }
}