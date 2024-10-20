using TMPro;

namespace Services.InteractingWithObjectsServices
{
    public interface IActionTextHandler
    {
        public void HandleActionText(TextMeshProUGUI actionText, bool isObjectPicked);
    }
}