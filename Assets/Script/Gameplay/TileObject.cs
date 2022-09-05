using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TileObject : MonoBehaviour, IRayCast
{
    public TextMeshPro IconTxT;
    [SerializeField]
    private GameObject Highlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void OnTap()
    {
        Debug.Log("Fliped");
        Highlight.SetActive(true);
    }
}
