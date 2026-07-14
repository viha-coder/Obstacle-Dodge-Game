using UnityEngine;


public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeToWait = 2f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    float TimeWhenSpawned;
    
    void Start()
    { 
     TimeWhenSpawned = Time.time;
     Debug.Log("Dropper script is active");  
     myMeshRenderer = GetComponent<MeshRenderer>();
     myRigidBody = GetComponent<Rigidbody>();

     myMeshRenderer.enabled = false;
     myRigidBody.useGravity = false;    
    }

    void Update()
    {
     if(Time.time - TimeWhenSpawned > TimeToWait)
     {
        myMeshRenderer.enabled = true;
        myRigidBody.useGravity = true;
     }
    
    }

}
