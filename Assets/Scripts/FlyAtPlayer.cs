using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float moveSpeed = 10f;
    Vector3 PlayerPosition;
    
    void Awake()
    {
        gameObject.SetActive(false);
    }
    
    void Start()
    {
        PlayerPosition = player.transform.position;
    }

    void Update()
    {    
        MoveToPlayer();
        DestroyWhenHit();
    }

    void DestroyWhenHit()
    {
        if (transform.position == PlayerPosition)
        {
            Destroy(gameObject);
        }
    }

    void MoveToPlayer()
    {
        transform.position =
         Vector3.MoveTowards(transform.position, PlayerPosition, moveSpeed * Time.deltaTime);
    }
}
