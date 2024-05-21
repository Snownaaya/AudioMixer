using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    protected const string EffectButton = nameof(EffectButton);

    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Button _button;
    [SerializeField] private AudioPanel _audioPanel;
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _button.onClick.AddListener(PlaySound);
        _slider.onValueChanged.AddListener(ToggleMusic);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(PlaySound);
        _slider.onValueChanged.AddListener(ToggleMusic);
    }

    private void ToggleMusic(float volume) => _audioPanel.SetVolume(EffectButton, volume);

    private void PlaySound() => _audioSource.Play();
}
