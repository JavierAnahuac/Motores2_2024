using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartPanel : MonoBehaviour
{
    public void StartGameButton_OnClick(){
        ScreenManager.instance.OpenScreen("Pause");
    }

    public void OpenAlert(){
        ScreenManager.instance.OpenPopUp("asdjfhkjashfdsa", "nfdjksahfdhjajkfhdsjkafhjkdsahfgjkdsahgfjksadhg");
    }
}
