using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManeger : MonoBehaviour
{
    [SerializeField] GameObject painel;
    
    public void Teleport(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenCreditsBTN()
    {
        painel.SetActive(true);
    }

    public void CloseCreditsBTN()
    {
        painel.SetActive(false);
    }
}
