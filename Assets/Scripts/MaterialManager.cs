using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{
	[SerializeField] private ModelVariants _renderers;

	public void SetMaterial(Material material) 
    {
        foreach (var item in _renderers.Models)
            item.GetComponent<Renderer>().material = material;
    }
}
