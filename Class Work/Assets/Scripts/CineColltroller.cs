using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CineColltroller : MonoBehaviour
{
	public PlayerData playerData;
	private CinemachinrVirtualCamera virtualCamera;

	// Use this for initialization
	void Start ()
	{
		virtualCamera = GetComponent<CinemachinrVirtualCamera>();
		playerData.instanceAction = InstanceHandler;
		playerData.InstancePlayer();
	}

	private void InstanceHandler(GameObject obj)
	{
		virtualCamera.Follow = obj.transform;
	}
}
