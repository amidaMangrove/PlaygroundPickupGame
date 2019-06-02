using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject _particle;
    [SerializeField] UIScript _uiScript;

    bool _gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        _gameEnd = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (_uiScript.GameClearFlag && !_gameEnd) {
            Instantiate(_particle);
            _gameEnd = true;
        }
    }

    
}
