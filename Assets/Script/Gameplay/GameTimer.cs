using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI Timer;
    [SerializeField]
    private float Playtime;
    [SerializeField]
    private GameFlow _gameFlow;
    // Start is called before the first frame update
    void Start()
    {
        Timer.text = Playtime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Playtime >= 0 && !_gameFlow.isPaused)
        {
            Playtime -= Time.deltaTime;
            Timer.text = Playtime.ToString();
        }
        else if(Playtime <= 0)
        {

        }
    }
}
