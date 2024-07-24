using TMPro; // Import TextMeshPro namespace
using UnityEngine;

namespace YourNamespace
{
    public class HealthHandler : MonoBehaviour
    {
        public TextMeshProUGUI healthText;
        public TextMeshProUGUI conditionText;

        private int currentHealth = 100;

        void Start()
        {
            if (healthText == null || conditionText == null)
            {
                Debug.LogError("TextMeshProUGUI components are not assigned.");
                return;
            }

            UpdateHealthText();
            conditionText.text = "alive";
        }

        public void DecreaseHealth()
        {
            if (healthText == null || conditionText == null)
            {
                Debug.LogError("TextMeshProUGUI components are not assigned.");
                return;
            }

            if (currentHealth > 0)
            {
                currentHealth -= 10;
                if (currentHealth <= 0)
                {
                    currentHealth = 0;
                    conditionText.text = "Dead";
                }
                UpdateHealthText();
                Debug.Log("Health is now: " + currentHealth);
            }
            else
            {
                Debug.Log("Character is already dead");
            }
        }

        public void ResetHealth()
        {
            if (healthText == null || conditionText == null)
            {
                Debug.LogError("TextMeshProUGUI components are not assigned.");
                return;
            }

            currentHealth = 100;
            UpdateHealthText();
            conditionText.text = "alive";
            Debug.Log("Health has been reset to: " + currentHealth);
        }

        private void UpdateHealthText()
        {
            healthText.text = currentHealth.ToString();
        }
    }
}
