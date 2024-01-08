using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneToLoad; // Reemplaza con el nombre de la escena a cargar

    void Start()
    {
        // Cambia de escena después de 14 segundos
        Invoke("Change", 14f);
    }

    void Change()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
