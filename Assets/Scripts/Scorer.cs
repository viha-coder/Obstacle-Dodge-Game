using UnityEngine;
using UnityEngine.SceneManagement;
public class Scorer : MonoBehaviour
{
  int hits = 0;
  [SerializeField] int Life = 3;
  private void OnCollisionEnter(Collision other) 
   {
    if(other.gameObject.tag != "Hit")
    {
    hits++;
    Debug.Log("You've bumped into a thing this many times: "+ hits);
    
      if(hits >= Life)
      {
        Debug.Log("You Lose!");       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
    
    }
   }
  }
