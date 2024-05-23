using UnityEngine;
using UnityEngine.UI;

public class SoundButton : AudioMixerHandler
{
    protected const string EffectButton = nameof(EffectButton);

    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Button _button;

    private void Start() => _button.onClick.AddListener(PlaySound);

    private void OnDisable() => _button.onClick.RemoveListener(PlaySound);

    public void OnSliderValueChanged(float volume) => SetVolume(EffectButton, volume);

    private void PlaySound() => _audioSource.Play();
}