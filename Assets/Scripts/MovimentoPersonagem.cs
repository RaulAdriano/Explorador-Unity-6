using UnityEngine;

public class MovimentoPersonagem : MonoBehaviour
{
    private CharacterController characterController;
    [SerializeField] private float velocidade;
    private Animator animator;

    Vector3 gravidade = new Vector3(0, -9.81f, 0);

    [SerializeField] private AudioSource passosAudioSource;
    [SerializeField] private AudioClip[] passosAudioClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(movimentoHorizontal,0,movimentoVertical);
        
        //mover personagem
        characterController.Move(movimento.normalized * Time.deltaTime * velocidade); //multiplica-se por deltatime para movimentar por segundo e nao por fps
       
        //aplicar gravidade
        characterController.Move(gravidade * Time.deltaTime);


        //rotacionar personagem
        if (movimento != Vector3.zero)
        {
            Quaternion rotacaoAlvo = Quaternion.LookRotation(movimento);
            //rotacionar menos brusco com Slerp
            transform.rotation = Quaternion.Slerp(transform.rotation,rotacaoAlvo,Time.deltaTime*10);
        }

        animator.SetBool("Andar", movimento != Vector3.zero);
    }

    private void OnPassos()
    {
        int indice = Random.Range(0, passosAudioClip.Length);
        passosAudioSource.PlayOneShot(passosAudioClip[indice]);
    }
}
