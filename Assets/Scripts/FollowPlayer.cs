using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	[SerializeField] private Transform m_Player;

	void Update ()
	{
		if (m_Player.position.y > transform.position.y)
		{
			transform.position = new Vector3(transform.position.x, m_Player.position.y, transform.position.z);
		}
	}

}
