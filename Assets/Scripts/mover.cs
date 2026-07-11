using UnityEngine;

public class mover : MonoBehaviour
{
   [SerializeField] float moveSpeed = 10f;
    Rigidbody rb;
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      PrintInstructions();
    }

    void FixedUpdate()
    {  
      MovePlayer();
    } 
 void PrintInstructions()
    {
      Debug.Log("Welcome to the Game!");
      Debug.Log("Use Arrow Keys or WASD to Move");
      Debug.Log("Dodge the Obstacles");
    } 
    
    void MovePlayer()
   {
       float xValue = Input.GetAxis("Horizontal") * moveSpeed;
       float yValue = 0f;
       float zValue = Input.GetAxis("Vertical") *  moveSpeed;
       rb.linearVelocity = new Vector3(xValue, yValue, zValue);
   }
}
