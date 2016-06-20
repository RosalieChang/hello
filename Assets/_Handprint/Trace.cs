using UnityEngine;

public class Trace : MonoBehaviour {

	public Transform target;    //目標
	NavMeshAgent agent;  //尋徑物件

	public float _x;
	public bool more_x;
	public float  _z;
	public bool more_z;
	float x;
	float z;


	void Start()
	{
		//找到物體身上的尋徑元件
		agent = GetComponent<NavMeshAgent> ();
	}

	void Update()
	{
		x = target.position.x;
		z = target.position.z;
			
		//不斷的向目標前進
		if ( (x > _x == more_x) && (z > _z == more_z) && target && !agent.hasPath)
		{
			agent.SetDestination(target.position);
			print("step");

		}
	
	}
}