using TMPro; // Import TextMeshPro namespace
using UnityEngine;

namespace HealthManager

{
    public class HealthHandler : MonoBehaviour
    {
        public TextMeshProUGUI healthText;
        public TextMeshProUGUI conditionText;

        private int currentHealth = 100;

        void Start()
        {
            UpdateHealthText();
            conditionText.text = "alive";
        }

        public void DecreaseHealth()
        {
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
