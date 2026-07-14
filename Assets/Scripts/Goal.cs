using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
 private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("You Win!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
