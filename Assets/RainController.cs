using UnityEngine;
using UnityEngine.InputSystem;

public class RainController : MonoBehaviour
{
    public GameObject rainEffect;
    private bool isRaining = false;

    void Update()
    {
        // กด R เพื่อสลับฝน
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            ToggleRain();
        }
    }

    void ToggleRain()
    {
        isRaining = !isRaining;
        rainEffect.SetActive(isRaining);
    }

    // ฟังก์ชันที่เรียกจาก ESP32 ผ่าน Serial/UDP
    public void SetRain(bool state)
    {
        isRaining = state;
        rainEffect.SetActive(isRaining);
    }
}
