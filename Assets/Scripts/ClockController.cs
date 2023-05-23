using UnityEngine;

public class ClockController : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    private void Update()
    {
        // Calculate current time
        float hours = System.DateTime.Now.Hour;
        float minutes = System.DateTime.Now.Minute;
        float seconds = System.DateTime.Now.Second;

        // Rotate the hands accordingly
        hourHand.rotation = Quaternion.Euler(0f, 0f, hours * -30f);
        minuteHand.rotation = Quaternion.Euler(0f, 0f, minutes * -6f);
        secondHand.rotation = Quaternion.Euler(0f, 0f, seconds * -6f);
    }
}
