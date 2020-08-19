using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
	//　弾のプレハブ
	[SerializeField] private GameObject bullet;
	//　レンズからのオフセット値
	[SerializeField] private float offset;

	//　弾を飛ばす間隔時間
	[SerializeField] private float waitTime = 0.1f;
	//　経過時間
	private float elapsedTime = 0f;

	void Update()
	{
		elapsedTime += Time.deltaTime;
		if (elapsedTime < waitTime)
		{
			return;
		}
		if (Input.GetButton("Fire1"))
		{
			//　カメラのレンズの中心を求める
			var centerOfLens = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane + offset));
			//　カメラのレンズの中心から弾を飛ばす
			var bulletObj = Instantiate(bullet, centerOfLens, Quaternion.identity) as GameObject;
			elapsedTime = 0f;
		}
	}
}