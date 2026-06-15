using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light sunLight;

    // ค่า LDR ที่จะถูกอัปเดตจาก MQTT
    public float ldrValue = 3000f;

    void Update()
    {
        // LDR 0 = มืดสนิท, LDR 4095 = สว่าง
        float normalized = Mathf.InverseLerp(0f, 4095f, ldrValue);

        // ทำให้แสงไม่แรงเกิน (0.2–1.5)
        float targetIntensity = Mathf.Lerp(0.2f, 1.5f, normalized);

        // ทำให้เปลี่ยนแบบ smooth
        sunLight.intensity = Mathf.Lerp(sunLight.intensity, targetIntensity, Time.deltaTime * 2f);
    }

    // ฟังก์ชันนี้จะถูกเรียกโดย MQTT ภายหลัง
    public void UpdateLDR(float value)
    {
        ldrValue = value;
    }
}
