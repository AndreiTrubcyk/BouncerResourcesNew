using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private int _enemyCounts = 6;
    private RandomPoint _randomPoint;
    private Colors _colors;

    public void Initialize(RandomPoint randomPoint, Colors colors)
    {
        _randomPoint = randomPoint;
        _colors = colors;
        for (int i = 0; i < _enemyCounts; i++)
        {
            var position = _randomPoint.GetRandomPoint();
            var enemy = Instantiate(_enemyPrefab);
            enemy.transform.position = position;
            enemy.Initialize(_colors.SetColor());
        }

    }
}
