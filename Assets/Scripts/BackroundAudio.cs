
public class BackroundAudio : AudioMixerHandler
{ 
    private const string MusicVolume = nameof(MusicVolume);

    public void OnVolumeChanged(float volume) => SetVolume(MusicVolume, volume);
}