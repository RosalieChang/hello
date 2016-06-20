using UnityEngine;
using System.Collections;

public class trace : MonoBehaviour {

	public Transform target;    //目標
	NavMeshAgent agent;            //尋徑物件

	// Use this for initialization
	void Start () {
	
		//找到物體身上的尋徑元件
		agent = GetComponent<NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		//不斷的向目標前進
		if (target && !agent.hasPath)
		{
			agent.SetDestination(target.position);
		}

	}
}

