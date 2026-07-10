using UnityEngine;

public class mover : MonoBehaviour
{
   [SerializeField] float moveSpeed = 10f;
   
    void Start()
    {
      PrintInstructions();
    }

    void Update()
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
       float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
       float yValue = 0f;
       float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
       transform.Translate(xValue, yValue, zValue);
   }
}
