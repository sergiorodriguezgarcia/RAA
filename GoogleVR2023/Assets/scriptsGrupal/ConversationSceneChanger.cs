using UnityEngine;
using UnityEngine.SceneManagement;

public class ConversationSceneChanger : MonoBehaviour
{
    public void TryChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void OnOptionSelected()
    {
        TryChangeScene("Laberinto"); // Reemplaza con el nombre de la escena pertinente
    }
}
