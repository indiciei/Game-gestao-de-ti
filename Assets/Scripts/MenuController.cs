using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("JOGO");
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene("MENU");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
