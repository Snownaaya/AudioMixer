
public class MuteButton : AudioMixerHandler
{
    private const string MasterMusic = nameof(MasterMusic);

    private bool _isMuted = false;

    public void ToggleMute()
    {
        _isMuted = !_isMuted;

        if (_isMuted)
        {
            _mixer.SetFloat(MasterMusic, _minValueMusic);
            _volumeSlider.interactable = false;
        }
        else
        {
            _mixer.SetFloat(MasterMusic, _lastValueMusic);
            _volumeSlider.interactable = true;
        }
    }

    public void OnSliderValueChanged(float sliderValue) => SetVolume(MasterMusic, sliderValue);
}
