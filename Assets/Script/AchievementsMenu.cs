using UnityEngine;
using UnityEngine.UI;

public class AchievementsMenu : MonoBehaviour
{
    [SerializeField] private Image[] achievementImages; // Ba�ar�mlar i�in Image objeleri (6 adet)
    private string[] achievementKeys = { "Happiness", "Cleanliness", "Power", "Money", "DayWin", "Trust" };

    private void Start()
    {
        UpdateAchievements();
    }

    private void UpdateAchievements()
    {
        for (int i = 0; i < achievementKeys.Length; i++)
        {
            if (PlayerPrefs.GetInt(achievementKeys[i], 0) == 1) // Ba�ar�m yap�ld�ysa
            {
                achievementImages[i].color = Color.white; // Beyaz renkte g�ster
            }
            else
            {
                achievementImages[i].color = new Color(0.2f, 0.2f, 0.2f); // Siyah renkte g�ster
            }
        }
    }
}
