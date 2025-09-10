using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JogadorUI : MonoBehaviour
{
    [SerializeField] private TMP_Text diamantesColetadosText;
    [SerializeField] private TMP_Text contadorText;
    [SerializeField] private TMP_Text contadorFimDeJogoText;
    [SerializeField] private GameObject panelFimDeJogo;
    [SerializeField] private GameObject panelPause;

   public void AtualizarColetados(int diamantesColetados, int totalDiamantes)
    {
        diamantesColetadosText.text = diamantesColetados + "/" + totalDiamantes;
    }

    public void AtualizarContador(float tempo)
    {
        contadorText.text = tempo.ToString("00") + "s";
    }

    public void AbrirPanelFimDeJogo()
    {
        panelFimDeJogo.SetActive(true);
        contadorFimDeJogoText.text = contadorText.text;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) || Input.GetKeyUp(KeyCode.JoystickButton7))
        {
            panelPause.SetActive(true);
            Time.timeScale = 0; //pausar o tempo do jogo
        }
    }

    public void VoltarParaPartida()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1; //despausa o tempo do jogo
    }

    public void SairPartida()
    {
        Time.timeScale = 1; //despausa o tempo do jogo
        SceneManager.LoadScene(0);
    }
}
