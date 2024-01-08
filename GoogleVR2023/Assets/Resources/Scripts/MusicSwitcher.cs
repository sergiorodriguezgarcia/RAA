using UnityEngine;

public class MusicSwitcher : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float switchDistance; // Distancia para cambiar la música

    public AudioSource backgroundMusic; // Música de fondo
    public AudioSource npcMusic; // Música de proximidad de los NPCs

    private bool isNearNPCs = false;

    private float npcMusicStartTime;

    void Start() {
        Invoke("SwitchToBackgroundMusic", 0);
    }

    void Update()
    {
        // Calcular la distancia entre el jugador y el grupo de NPCs
        float distance = Vector3.Distance(player.position, transform.position);

        // Calcular un valor de escala para el volumen basado en la distancia
        float volumen = (1f - distance / switchDistance) * 0.66f;

        // Comprobar si el jugador está lo suficientemente cerca de los NPCs
        if (distance <= switchDistance && !isNearNPCs)
        {
            isNearNPCs = true;
            SwitchToNPCMusic(volumen);
        }
        else if (distance > switchDistance && isNearNPCs)
        {
            isNearNPCs = false;
            SwitchToBackgroundMusic();
        } else if (distance <= switchDistance && isNearNPCs) {
            npcMusic.volume = volumen;
        }
    }

    void SwitchToNPCMusic(float volumeScale)
    {
        // Restaurar la posición de reproducción de la música de los NPCs
        npcMusic.time = npcMusicStartTime + backgroundMusic.time;

        // Regula el volumen al que suena según la distancia a los feriantes
        npcMusic.volume = volumeScale;

        // Detener la música de fondo y reproducir la música de los NPCs
        backgroundMusic.Stop();
        npcMusic.Play();
    }

    void SwitchToBackgroundMusic()
    {
        // Guardar la posición actual de reproducción de la música de los NPCs
        npcMusicStartTime = npcMusic.time;

        // Detener la música de los NPCs y reproducir la música de fondo
        npcMusic.Stop();
        backgroundMusic.Play();
    }
}
