using UnityEngine;

public class SoundButton : AudioMixerHandler
{
    protected const string EffectButton = nameof(EffectButton);

    [SerializeField] private AudioSource _audioSource;

    private void Start() => _volumeSlider.onValueChanged.AddListener(OnSliderValueChanged);

    private void OnDisable() => _volumeSlider.onValueChanged.RemoveListener(OnSliderValueChanged);

    public void OnSliderValueChanged(float volume) => SetVolume(EffectButton, volume);
}