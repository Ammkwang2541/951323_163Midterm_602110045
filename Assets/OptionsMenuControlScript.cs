using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenuControlScript : MonoBehaviour
{
   
    [SerializeField] Toggle _toggleMusic;
    [SerializeField] Toggle _toggleSFX;
    [SerializeField] Button _backButton;
    // Start is called before the first frame update
    void Start()
    {
       
        _toggleMusic.isOn = GameApplicationManager.Instance._isMusicEnabled;
        _toggleSFX.isOn = GameApplicationManager.Instance.SFXEnabled;
        
        _toggleMusic.onValueChanged.AddListener(delegate { OnToggleMusic(_toggleMusic); });
        _toggleSFX.onValueChanged.AddListener(delegate { OnToggleSFX(_toggleSFX); });
        _backButton.onClick.AddListener(delegate { BackButtonClick(_backButton); });
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BackButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneOptions");
        GameApplicationManager.Instance.IsOptionMenuActive = false;
    }
    
    public void OnToggleMusic(Toggle toggle)
    {
        GameApplicationManager.Instance._isMusicEnabled = _toggleMusic.isOn;
    }
    public void OnToggleSFX(Toggle toggle)
    {
        GameApplicationManager.Instance.SFXEnabled = _toggleSFX.isOn;
    }
}
