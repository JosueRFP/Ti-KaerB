using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ErrorTXT : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI erroTxt;
    [SerializeField] UnityEvent OnLose;
    [SerializeField] UnityEvent OnPropler;

    [SerializeField] public float startErrors;
    float maxErorQTD;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxErorQTD = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        erroTxt.text = "Erros: " + startErrors + "/" + maxErorQTD;
    }



   public void MaxErrorsController()
   {
        if(startErrors == maxErorQTD)
        {
            Time.timeScale = 1f;
            OnLose.Invoke();
            OnPropler.Invoke();
        }   
   }


    public void Teleport(string sceneRepeat)
    {
        SceneManager.LoadScene(sceneRepeat);
    }
}
