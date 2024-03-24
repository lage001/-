using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Start,
    Game,
    End,
    Empty,
}

public class GameManager : MonoBehaviour
{
    public State state;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.Start:
                OnStart();
                break;
            case State.Game:
                OnGame();
                break;
            case State.End:
                OnEnd();
                break;
        }
    }
    void OnStart()
    {

    }
    void OnGame()
    {

    }
    void OnEnd()
    {

    }
}