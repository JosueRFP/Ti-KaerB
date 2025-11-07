using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class AdController : MonoBehaviour
{
    Button adBTN;
    [SerializeField] GameObject[] ads;
    private void Start()
    {

        adBTN = GetComponent<Button>();
        adBTN.clicked += ShowAd;
    }

     public  void ShowAd()
     {
        ads[Random.Range(0, ads.Length)].SetActive(true);
    }
}
