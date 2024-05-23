using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerHandler : MonoBehaviour
{
    [SerializeField] protected AudioMixer _mixer;

    protected float _minValueMusic = -80f;
    protected float _maxValueMusic = 0f;

    public void SetVolume(string parameter, float volume) => _mixer.SetFloat(parameter, Mathf.Lerp(_minValueMusic, _maxValueMusic, volume));
}
