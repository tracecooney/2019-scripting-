using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{

	public List<GameArtData> CollectionList;

	public void AddData(GameArtData obj)
	{
		if (!obj.collected)
		{
			CollectionList.Add(obj);
			obj.collected = true;
		}
		
	}
}
