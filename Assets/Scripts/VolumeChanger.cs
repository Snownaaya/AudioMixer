
public class VolumeChanger : AudioMixerHandler
{
    private const string MusicVolume = nameof(MusicVolume);

    private void Start() => _volumeSlider.onValueChanged.AddListener(OnVolumeChanged);

    private void OnDisable() => _volumeSlider.onValueChanged.RemoveListener(OnVolumeChanged);

    public void OnVolumeChanged(float volume) => SetVolume(MusicVolume, volume);
}