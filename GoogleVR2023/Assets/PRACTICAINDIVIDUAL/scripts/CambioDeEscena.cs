using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour

{

    public string nextScene = "";
    public void CambiarEscena()
    {
        SceneManager.LoadScene(nextScene);
    }
}
