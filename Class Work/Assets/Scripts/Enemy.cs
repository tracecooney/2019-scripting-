
using UnityEngine;

//This is a TUTORIAL i found on YouTube
public class Enemy : MonoBehaviour
{
	public float speed;
	public float stopDistance;
	public float retreatDistance;

	private float timeBtwShots;
	private float startTimeBtwShots;

	public GameObject projectille;
	private Transform player;
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
		timeBtwShots = startTimeBtwShots
	}
	void Update () 
	{
		if (Vector2.Distance(transform.position, player.position) > stopDistance)
		{
			transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
		}
		else if (Vector2.Distance(transform.position, player.position) < stopDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
		{
			transform.position = this.transform.position;
		}
		else if (Vector2.Distance(transform.position,player.position) < retreatDistance)
		{
			transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
		}

		if (timeBtwShots <= 0)
		{
			Instantiate(projectille, transform.position, Quaternion.identity);
			timeBtwShots = startTimeBtwShots;
		}
		else
		{
			timeBtwShots -= Time.deltaTime;
		}



	}
}
