
using UnityEngine;

//This is a TUTORIAL i found on YouTube
public class Enemy : MonoBehaviour
{
	public float speed;
	public float stopDistance;
	public float retreatDistance;
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	void Update () 
	{
		if (Vector2.Distance(transform.position, player.position) > stopDistance)
		{
			transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
		}
	}
}
