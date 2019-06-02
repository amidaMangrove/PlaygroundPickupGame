using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject _particle;
    [SerializeField] UIScript _uiScript;

    AudioSource _audio;
    bool _gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        _gameEnd = false;
        _audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (_uiScript.GameClearFlag && !_gameEnd) {
            Instantiate(_particle);
            _gameEnd = true;
            _audio.Play();
        }
    }

    
}
