using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // 1. Khai báo biến này để kéo cái Canvas vào
    public GameObject gameOverCanvas;

    void Start()
    {
        // Lúc đầu game thì ẩn màn hình Game Over đi cho chắc
        if (gameOverCanvas != null) {
            gameOverCanvas.SetActive(false);
        }
    }

    void Update()
    {
        // Điều khiển máy bay đi theo chuột
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;
    }

    // 2. Hàm này để gọi hiện chữ Game Over khi thua
    public void ShowGameOver() 
    {
        if (gameOverCanvas != null) 
        {
            gameOverCanvas.SetActive(true); 
        }
    }

    // 3. Tặng thêm cho Ngọc: Hàm tự động hiện chữ khi va chạm
    // (Giả sử thiên thạch hoặc địch có Tag là "Enemy")
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ShowGameOver();
            // Có thể thêm hiệu ứng nổ hoặc ẩn máy bay ở đây
            // gameObject.SetActive(false); 
        }
    }
}