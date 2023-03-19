using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCreator : MonoBehaviour
{
	[SerializeField] private Gold _goldPrefab;
	[SerializeField] private Resources _resources;
	[SerializeField] private int _countGold = 3;
	[SerializeField] private float _speed = 3f;

	public void CreateGold(int coins)
	{
		for (int i = 0; i < _countGold; i++)
		{
			Gold gold = Instantiate(_goldPrefab, transform.position, Quaternion.identity);

			Vector3 velocityOfGold = Vector3.up;
			
			float xAngle = Random.Range(-45, 45);
			float yAngle = Random.Range(0, 360);

			velocityOfGold = Quaternion.Euler(xAngle, yAngle, 0) * velocityOfGold;

			gold.Init(_resources, coins, velocityOfGold * _speed);
		}
	}
}
