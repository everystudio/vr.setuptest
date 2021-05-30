using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputActionManager : MonoBehaviour
{
	public List<InputActionAsset> assets;
	private void OnEnable()
	{
		foreach(InputActionAsset asset in assets)
		{
			asset.Enable();
		}
	}
	private void OnDisable()
	{
		foreach (InputActionAsset asset in assets)
		{
			asset.Disable();
		}
	}
}
