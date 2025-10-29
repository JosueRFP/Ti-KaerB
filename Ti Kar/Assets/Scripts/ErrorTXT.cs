using TMPro;
using UnityEngine;

public class ErrorTXT : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI erroTxt;

    [SerializeField] GameObject gameOverPainel;
    [SerializeField] public float startErrors;
    float maxErorQTD = 5f;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            Time.timeScale = 0f;
            gameOverPainel.SetActive(true);
        }   
   }
}
