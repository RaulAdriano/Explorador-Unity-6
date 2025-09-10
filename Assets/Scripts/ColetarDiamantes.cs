using UnityEngine;
using UnityEngine.Events;

public class ColetarDiamantes : MonoBehaviour
{
    [SerializeField] private int diamantesColetados;
    [SerializeField] private JogadorUI jogadorUI;

    [SerializeField] UnityEvent onFimDeJogo;
    [SerializeField] private AudioSource coletarDiamanteAudioSource;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Diamante")
        {
            diamantesColetados++;
            jogadorUI.AtualizarColetados(diamantesColetados, 5);
            Destroy(hit.gameObject);

            if (diamantesColetados >= 5)
            {
                onFimDeJogo.Invoke();
            }

            coletarDiamanteAudioSource.Play();
        }
    }
}
