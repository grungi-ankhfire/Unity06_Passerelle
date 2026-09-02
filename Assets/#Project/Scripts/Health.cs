using System;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] int _current;
    [SerializeField] int _maximum;

    public Action onHealthChanged;

    public int maximum
    {
        get { return _maximum; }
        private set { _maximum = value; }
    }

    public int current
    {
        get { return _current; }
        set
        {
            if (value < 0) value = 0;
            if (value > _maximum) value = _maximum;

            if (value != _current)
            {
                _current = value;
                onHealthChanged?.Invoke();
            }

        }
    }

    void Awake()
    {
        _current = _maximum;
    }

    public void TakeDamage(int damage)
    {
        current -= damage;
    }
    

    void Update()
    {

    }
}

