using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ThrashJT.Lab3
{
    public class SoundManager : MonoBehaviour
    {
        [SerializeField] private string soundFolderPath;
        private static AudioSource audioSource;
        private static List<AudioClip> audioClips;


        private static Dictionary<string, AudioClip> soundClipMap;

        public void Awake()
        {
            soundClipMap = new Dictionary<string, AudioClip>();
            audioSource = gameObject.AddComponent<AudioSource>();
            LoadAudioClips();
        }

        public static void PlaySound(string soundName)
        {
            audioSource.PlayOneShot(soundClipMap[soundName]);
        }

        public static void PlaySoundAtPosition(string soundName, Vector3 position)
        {
            AudioSource.PlayClipAtPoint(soundClipMap[soundName], position);
        }

        private void LoadAudioClips()
        {
            audioClips = Resources.LoadAll<AudioClip>(soundFolderPath).ToList();

            foreach (AudioClip clip in audioClips)
            {
                soundClipMap.Add(clip.name, clip);
            }
        }
    }
}