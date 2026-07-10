using UnityEngine;


public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeToWait = 2f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    void Start()
    {
     myMeshRenderer = GetComponent<MeshRenderer>();
     myRigidBody = GetComponent<Rigidbody>();
      
     myMeshRenderer.enabled = false;
     myRigidBody.useGravity = false;
    }

    void Update()
    {
     if(Time.time > TimeToWait)
        {
        myMeshRenderer.enabled = true;
        myRigidBody.useGravity = true;      
        }  
    
    }

}
