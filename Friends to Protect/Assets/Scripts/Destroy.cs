using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	void OnCollisionEnter(Collision col)
	{
		// Enemyタグがついた敵に衝突したら自身と敵を削除
		if (col.gameObject.CompareTag("Kids"))
		{
			Destroy(this.gameObject);
			Destroy(col.gameObject);
		}
	}
}
