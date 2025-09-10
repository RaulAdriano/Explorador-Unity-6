using UnityEngine;

public class ControladorCamera : MonoBehaviour
{
    [SerializeField] private Transform jogadorTransform;
    [SerializeField] private Vector3 offset;


    // Update is called once per frame
    void LateUpdate()
    {
       transform.position = jogadorTransform.position + offset; 
    }
}
