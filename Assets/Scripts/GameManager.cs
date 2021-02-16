using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameManager : ScriptableObject
{
    static GameManager _instance;

    public static GameManager instance
    {
        get
        {
            if (_instance != null) return _instance;
            _instance = Resources.Load<GameManager>("GlobalGameManager");
            return _instance;
        }
        set => _instance = value;
    }

    public GameObject player;
    public List<GameObject> enemies;

    public bool playerWon;
}
