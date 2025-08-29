using System;
using TMPro;
using UnityEngine;

public class BoxesManeger : MonoBehaviour
{
    [SerializeField] GameObject boxe;
    [SerializeField] TextMeshProUGUI boxCouter;
    [SerializeField] Collider[] checkCollider;
    [SerializeField] Transform check;
    [SerializeField] bool oneBox;
    [SerializeField] bool oneTime;
    [SerializeField] LayerMask layerMask;
    [SerializeField] BoxCheck boxScripts;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void  Start()
    {
        check = GetComponentInChildren<Transform>();
        boxScripts = GetComponentInParent<BoxCheck>();
        oneBox = true;
    }

    private void Update()
    {
        checkCollider = Physics.OverlapBox(check.position, new Vector3(.5f, .5f, .5f), check.rotation, layerMask);
        oneBox = checkCollider[checkCollider.Length - 1];

        if (oneBox && oneTime)
        {
            boxScripts.allMails++;
            oneTime = false;
        }
    }


}
