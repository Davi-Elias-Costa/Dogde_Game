using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] GameObject parede;
    Vector3 playerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que encostou é o mesmo player referenciado acima
        if (other.transform == player)
        {
            Destroy(parede);
        }
    }
}
