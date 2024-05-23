
public class MuteButton : AudioMixerHandler
{
    private const string MasterMusic = nameof(MasterMusic);

    private bool _isMuted = false;

    public void ToggleMute()
    {
        _isMuted = !_isMuted;

        if (_isMuted)
            _mixer.SetFloat(MasterMusic, _minValueMusic);
        else
            _mixer.SetFloat(MasterMusic, _maxValueMusic);
    }

    public void OnSliderValueChanged(float sliderValue) => SetVolume(MasterMusic, sliderValue);
}
