using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void Reintentar()
    {
        SceneManager.LoadScene("Tetris");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
