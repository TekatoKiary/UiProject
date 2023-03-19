using UnityEngine;

public class ClickableCollider : MonoBehaviour
{
	[SerializeField] private Clickable _clickable;
	public void Hit()
	{
		_clickable.Hit();
	}
}
