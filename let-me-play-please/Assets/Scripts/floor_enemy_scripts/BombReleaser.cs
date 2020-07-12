using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombReleaser : MonoBehaviour
{
	[SerializeField] private BombBehaviour bomb = null;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		bomb.ReleaseBomb();
	}
}
