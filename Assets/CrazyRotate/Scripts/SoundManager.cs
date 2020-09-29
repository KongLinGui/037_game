using UnityEngine;
using System.Collections;

/// <summary>
/// 声音管理脚本
/// </summary>
public class SoundManager : Singleton<SoundManager>
{
	public AudioClip clickSound;
	public AudioClip scoreSound;
	public AudioClip gameOverSound;

	public AudioSource mySource;

	protected override void Initialize()
	{

	}

	public void EnableSound()
	{
		PlayClickSound();
		mySource.volume = 1f;
		GameManager.GetInstance().soundOn = true;
	}

	public void DisableSound()
	{
		mySource.volume = 0f;
		GameManager.GetInstance().soundOn = false;
	}
	
    /// <summary>
    /// 游戏点击声音
    /// </summary>
	public void PlayClickSound()
	{
		mySource.clip = clickSound;
		MakeSound();
	}

    /// <summary>
    /// 游戏得分声音
    /// </summary>
	public void PlayScoreSound()
	{
		mySource.clip = scoreSound;
		mySource.Play();
	}

    /// <summary>
    /// 游戏结束声音
    /// </summary>
	public void PlayGameOverSound()
	{
		mySource.clip = gameOverSound;
		mySource.Play();
	}

	void MakeSound() 
	{
		mySource.Play();
	}
}
