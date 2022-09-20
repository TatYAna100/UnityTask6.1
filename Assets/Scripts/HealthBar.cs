using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;

    private float _updatingTime = 0.3f;

    public void OnHealthChanged()
    {
        StartCoroutine(ChangeValue());
    }

    private IEnumerator ChangeValue()
    {
        int targetValue = _player.Health;

        while (_slider.value != targetValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetValue, _updatingTime);

            yield return null;
        }
    }
}