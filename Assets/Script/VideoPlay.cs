using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Collections;

public class VideoPlay : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        // Hide the video at the start
        rawImage.enabled = false;
    }

    public void PlayVideoClip()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Stop();
            rawImage.enabled = false;
        }
        else
        {
            StartCoroutine(PlayVideo());
        }
    }

    IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();

        // Show the video
        rawImage.enabled = true;
    }
}
