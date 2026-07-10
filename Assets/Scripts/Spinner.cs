using UnityEngine;

public class Spinner : MonoBehaviour
{
     
        void Start()
    {
        
    }

        void Update()
    { 
     SpinObject();  
    }
    void SpinObject()
     {      
            float xAngle = 0f;
            float yAngle = 150f*Time.deltaTime;
            float zAngle = 0f;
            transform.Rotate(xAngle, yAngle, zAngle);
     } 
      
      
}

