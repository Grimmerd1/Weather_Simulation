using UnityEngine;
using TMPro;

public class DHTController : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    float temperature = 28f; // mock data
    float humidity = 65f; // mock data

    void Start()
    {
        UpdateDisplay();
        InvokeRepeating("SimulateSensor", 1f, 2f);
    }

    void SimulateSensor()
    {
        // ค่า mock สุ่มเบาๆ ให้ดูเหมือนจริง
        temperature = Random.Range(26f, 32f);
        humidity = Random.Range(50f, 80f);

        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        displayText.text =
            "Temperature: " + temperature.ToString("F1") + " °C\n" +
            "Humidity: " + humidity.ToString("F1") + " %";
    }
}
