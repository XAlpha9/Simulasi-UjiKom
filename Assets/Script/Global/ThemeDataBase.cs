using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeDataBase : MonoBehaviour
{
    [HideInInspector]
    public static ThemeDataBase instance;
    private void Awake()
    {
        instance = GameObject.Find("GlobalLayer").GetComponent<ThemeDataBase>();

        GameObject[] obj = GameObject.FindGameObjectsWithTag("Global");
        if (obj.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public Sprite[] Themes;
    public Sprite[] ThemeLists;
    //public GameObject TestObject;

    private void Start()
    {
        //TestObject.GetComponent<Image>().sprite = Themes[0];
    }
}
