using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Renderer _renderer;
    private Color _color;
    private Material _material;

    public void Initialize(Color color)
    {
        _color = color;
        _material = transform.GetChild(0).GetComponent<Renderer>().materials[1];
        _material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out var player))
        {
            if (player.Color == _color)
            {
                Destroy(gameObject);
            }
        }
    }
}
