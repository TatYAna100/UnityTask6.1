using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;
    
    private int _currentHealth;
    private int _treatment;
    private int _damage;

    public int Health { get;private set; }

    public event UnityAction<int> HealthChanged;
    
    private void Start()
    {
        _currentHealth = 100;
        _treatment = 10;
        _damage = 10;
        Health = _currentHealth;
    }

    public void ApplyDamage()
    {
        Health -= _damage;

        _healthBar.OnHealthChanged();
    }

    public void ApplyTreatment()
    {
        Health += _treatment;

        _healthBar.OnHealthChanged();
    }    
}
