using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _lifeTimeInSeconds = 60f;
	[SerializeField] private HitEffect _hitEffectPrefab;

	private Resources _resources;
    private float _timeSinceCreation;
    private int _coins = 0;

    public void Init(Resources resources, int coins, Vector3 velocity)
    {
        _resources = resources;
        _rigidbody.velocity = velocity;
        _timeSinceCreation = Time.timeSinceLevelLoad;
        _coins = coins;
    }

    public void Collect()
    {
		HitEffect hitEffect = Instantiate(_hitEffectPrefab, transform.position, Quaternion.identity);
		hitEffect.Init(_coins);
		_resources.CollectCoins(1, transform.position);
        Destroy(gameObject);
	}
    
    private void Update()
    {
        if (Time.timeSinceLevelLoad - _timeSinceCreation >= _lifeTimeInSeconds)
            Destroy(gameObject);
    }

}
