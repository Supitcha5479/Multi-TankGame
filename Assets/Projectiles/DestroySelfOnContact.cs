using UnityEngine;

public class DestroySelfOnContact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 1. เช็คว่าถ้าสิ่งที่ชนมี Layer เดียวกัน (คือ Projectile เหมือนกัน) ให้ ignore ไปซะ
        if (collision.gameObject.layer == gameObject.layer)
        {
            return;
        }

        // 2. ถ้าไม่ใช่พวกเดียวกัน (เช่น ชนกำแพง หรือ ชนรถถังศัตรู) ให้ทำลายตัวเอง
        Destroy(gameObject);
    }
}