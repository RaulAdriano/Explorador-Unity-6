using UnityEngine;

public class InstanciarDiamantes : MonoBehaviour
{
    [SerializeField] private GameObject diamantePrefab;
    private int totalDiamantes = 5;
    [SerializeField] private Transform[] pontoDeSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < totalDiamantes; i++)
        {
            int randomIndex = Random.Range(0, pontoDeSpawn.Length);

            Instantiate(diamantePrefab, pontoDeSpawn[randomIndex].position, Quaternion.identity);
        }
    }

}
