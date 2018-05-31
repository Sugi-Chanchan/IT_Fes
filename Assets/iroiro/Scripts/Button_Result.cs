using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_Result : MonoBehaviour
{

    public void Push()
    {
        Bullet_easy.bullet_number = 1;
        SceneManager.LoadScene("Start_air");
    }

}
