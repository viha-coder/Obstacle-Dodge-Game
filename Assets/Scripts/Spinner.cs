using UnityEngine;

public class Spinner : MonoBehaviour
{    [SerializeField] float rotationSpeed = 150f;
     Rigidbody rb;
        void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

        void FixedUpdate()
    { 
     SpinObject();  
    }
    void SpinObject()
     {      
         Quaternion deltaRotation = Quaternion.Euler(0f, rotationSpeed * Time.fixedDeltaTime, 0f);
         rb.MoveRotation(rb.rotation * deltaRotation);
     } 
      
      
}

