using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public GameObject explosionPrefab; // Ô để kéo hiệu ứng nổ vào

    // Hàm này chạy khi có cái gì đó đâm vào kẻ địch
    void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra nếu cái đâm vào có Tag là "Bullet"
        if (other.CompareTag("Bullet"))
        {
            // Tạo vụ nổ tại vị trí kẻ địch
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            
            // Xóa viên đạn
            Destroy(other.gameObject);
            
            // Xóa kẻ địch
            Destroy(gameObject);
        }
    }
}