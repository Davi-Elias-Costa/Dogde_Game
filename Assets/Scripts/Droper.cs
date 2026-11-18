using UnityEngine;

public class Droper : MonoBehaviour
{
    [SerializeField] float TempoQueda;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

   
    void Update()
    { 
        if (Time.time > TempoQueda)
        {
        

          myMeshRenderer.enabled = true;
          myRigidbody.useGravity = true;
        }
       
    }
}
