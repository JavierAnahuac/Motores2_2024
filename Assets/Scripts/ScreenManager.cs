using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Screen{
    public string screenName;
    public GameObject screen;
}

public class ScreenManager : MonoBehaviour
{
    private static ScreenManager _instance;
    public static ScreenManager instance{
        get{
            if(_instance == null){
                _instance = GameObject.FindObjectOfType<ScreenManager>();
            }

            return _instance;
        }
    }

    public PopUpScreen popUpScreen;
    public List<Screen> screens;

    public void OpenScreen(string _screenName){
        for(int i = 0; i < screens.Count; i++){
            screens[i].screen.SetActive(false);

            if(screens[i].screenName == _screenName){
                screens[i].screen.SetActive(true);
            }

        }
    }

    public void OpenPopUp(string _title, string _description){
        popUpScreen.titleText.text = _title;
        popUpScreen.descriptionText.text =  _description;

        popUpScreen.gameObject.SetActive(true);
    }

}
