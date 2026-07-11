using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    [SerializeField] Transform player;
    Vector3 playerPosition; 
    
    void Start()
    {
        playerPosition = player.transform.position;
    }

    
    void Update()
    {
       MoveToPlayer();
       DestroyWhenReached();         
    }

        void MoveToPlayer()
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        }    
         

    void DestroyWhenReached()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, playerPosition);
        if (distanceToPlayer < 0.1f)
        {
          Destroy(gameObject);  
        }
        
    }
}
