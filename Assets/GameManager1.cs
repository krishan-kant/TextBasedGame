using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public void LoadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
