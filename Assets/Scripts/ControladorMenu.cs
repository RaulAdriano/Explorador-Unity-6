using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text recordeText;

    private void Start()
    {
        float recorde = GerenciarRecorde.GetRecordeTempoDePartida();
        if (recorde > 0) 
        { 
            recordeText.text = "Melhor Tempo: " + recorde.ToString("00") + "s";
        }
    }

    public void IniciarJogo()
    {
        SceneManager.LoadScene(1);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
