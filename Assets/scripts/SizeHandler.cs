using TMPro; // Import TextMeshPro namespace
using UnityEngine;

namespace SizeManager
{
    public class SizeHandler : MonoBehaviour
    {
        public RectTransform imageToResize;
        public TextMeshProUGUI objectIncrease;
        public TextMeshProUGUI objectDecrease;

        private float currentSize = 1f;
        private const float maxMultiplier = 4f;
        private const float minMultiplier = 0.25f;
        private Vector2 originalSize;

        void Start()
        {
            originalSize = imageToResize.sizeDelta;
        }

        public void ObjectDecrease()
        {
            if (currentSize / 2 >= minMultiplier)
            {
                currentSize /= 2;
                UpdateSize();
                Debug.Log("Size is now: " + (originalSize * currentSize).ToString());
            }
            else
            {
                Debug.Log("Size is already at its minimum limit");
            }
        }

        public void ObjectIncrease()
        {
            if (currentSize * 2 <= maxMultiplier)
            {
                currentSize *= 2;
                UpdateSize();
                Debug.Log("Size is now: " + (originalSize * currentSize).ToString());
            }
            else
            {
                Debug.Log("Size is already at its maximum limit");
            }
        }

        private void UpdateSize()
        {
            imageToResize.sizeDelta = originalSize * currentSize;
        }
    }
}
