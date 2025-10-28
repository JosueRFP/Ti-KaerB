using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPhase : MonoBehaviour
{
   public void Teleport(string name)
    {
        SceneManager.LoadScene(name);
    }
}
