using UnityEngine;

public class ContadorPartida : MonoBehaviour
{
    private float contador;
    [SerializeField] private JogadorUI jogadorUI;

    void Update()
    {
        contador += Time.deltaTime;
        jogadorUI.AtualizarContador(contador); 
    }

    public void SalvarResultado()
    {
        GerenciarRecorde.SalvarTempoDePartida(contador);
    }
}
