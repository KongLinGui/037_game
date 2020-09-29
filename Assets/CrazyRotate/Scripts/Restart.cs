using UnityEngine;
using System.Collections;
/// <summary>
/// 重新开始
/// </summary>
public class Restart : MonoBehaviour 
{
	void OnMouseDown()
	{
		GameController.instance.Restart();
	}
}
