using UnityEngine;

public class CerrarApp : MonoBehaviour
{
    // Este m�todo se llamar�a desde tu sistema de di�logo cuando sea necesario cerrar el juego
    public void EjecutarScriptCerrarJuego()
    {
        CerrarJuego();
    }

    private void CerrarJuego()
    {
        Application.Quit();
    }
}
