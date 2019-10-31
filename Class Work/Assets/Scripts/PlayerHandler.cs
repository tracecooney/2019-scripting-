using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerHandler : ScriptableObject
{
	public PlayerData playerDataObj;

	public void SwitchPlayer(PlayerData data)
	{
		playerDataObj = data;
	}
	
	// Update is called once per frame
	//void Update (OnRun)
	//{
		//playerDataObj.Run;
	//}
}
