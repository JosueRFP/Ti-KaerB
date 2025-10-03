using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManeger : MonoBehaviour
{
    [SerializeField] GameObject creditsPainel, storePainel;
    
    public void Teleport(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenCreditsBTN()
    {
        creditsPainel.SetActive(true);
    }

    public void CloseCreditsBTN()
    {
        creditsPainel.SetActive(false);
    }

    public void OpenStoreBTN()
    {
        storePainel.SetActive(true);
    }

    public void CloseStoreBTN()
    {
        storePainel.SetActive(false);
    }
}
