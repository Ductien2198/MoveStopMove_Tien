using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameplay : UICanvas
{
    public Text aliveText;
    
    public void SettingButton()
    {
        UIManager.Instance.OpenUI<UISetting>();
        //Time.timeScale = 0;
    }
    public void ChangeAlive(int numAlive)
    {
        aliveText.text = "Alive:" + numAlive.ToString();
    }
}