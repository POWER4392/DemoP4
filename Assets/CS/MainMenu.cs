using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có dòng này để chuyển Scene

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        // Có thể để trống nếu không có logic gì cần chạy lúc mới mở menu
    }

    // Hàm chuyển Scene đã được đưa ra ngoài hàm Start và dùng chữ 'p' thường
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("Battle");
    }

    void Update()
    {
        
    }
}