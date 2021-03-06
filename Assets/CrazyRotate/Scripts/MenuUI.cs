﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// 菜单UI脚本
/// </summary>
public class MenuUI : MonoBehaviour 
{
	public Button soundOn;
	public Button soundOff;

	void Start()
	{
		ButtonSetup();
	}

	private void ButtonSetup()
	{
		soundOn.gameObject.SetActive(GameManager.GetInstance().soundOn);
		soundOff.gameObject.SetActive(!GameManager.GetInstance().soundOn);
		soundOn.onClick.AddListener(SoundManager.GetInstance().DisableSound);
		soundOff.onClick.AddListener(SoundManager.GetInstance().EnableSound);
	}

	public void GoLevel(string levelName){
		//Application.LoadLevel(levelName);
        SceneManager.LoadScene(levelName);
	}

	public void GoMedium()
	{
		SoundManager.GetInstance().PlayClickSound();
		GoLevel("Medium");
	}

	public void GoHard()
	{
		SoundManager.GetInstance().PlayClickSound();
		GoLevel("Hard");
	}
}
