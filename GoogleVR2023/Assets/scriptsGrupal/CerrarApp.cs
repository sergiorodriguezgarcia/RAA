using UnityEngine;

public class CerrarApp : MonoBehaviour
{
    // Este método se llamaría desde tu sistema de diálogo cuando sea necesario cerrar el juego
    public void EjecutarScriptCerrarJuego()
    {
        CerrarJuego();
    }

    private void CerrarJuego()
    {
        Application.Quit();
    }
}
