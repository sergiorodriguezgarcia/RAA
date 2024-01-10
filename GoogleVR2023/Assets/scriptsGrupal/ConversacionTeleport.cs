using UnityEngine;
using UnityEngine.SceneManagement;

public class ConversacionTeleport : MonoBehaviour
{
    public void TryChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void OnOptionSelected()
    {
        TryChangeScene("Cinematica"); // Reemplaza con el nombre de la escena pertinente
    }
}