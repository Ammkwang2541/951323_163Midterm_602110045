using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApplicationManager : MonoBehaviour
{
    static public GameApplicationManager Instance
    {
        get
        {
            if (_singletonInstance == null)
            {
                _singletonInstance = GameObject.FindObjectOfType<GameApplicationManager>();
                GameObject container = new GameObject("GameApplicationManager");
                _singletonInstance = container.AddComponent<GameApplicationManager>();
            }
            return _singletonInstance;
        }
    }
    static protected GameApplicationManager _singletonInstance = null;
   
    public bool IsOptionMenuActive
    {
        get { return _isOptionMenuActive; }
        set { _isOptionMenuActive = value; }
    }

    protected bool _isOptionMenuActive = false;
    public int DifficultyLevel
    {
        get { return _difficultyLevel; }
        set { _difficultyLevel = value; }
    }
    protected int _difficultyLevel;
    public bool _isMusicEnabled
    {
        get { return _isMusicEnabled; }
        set { _isMusicEnabled = value; }
    }
    public bool SFXEnabled
    {
        get { return _isSFXEnabled; }
        set { _isSFXEnabled = value; }
    }
    protected bool _isSFXEnabled = true;
    void Awake()
    {
        if (_singletonInstance == null)
        {
            _singletonInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (this != _singletonInstance)
            {
                Destroy(this.gameObject);
            }
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}