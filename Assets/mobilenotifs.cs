using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class mobilenotifs : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        //Remove notifications that have already been displayed
        AndroidNotificationCenter.CancelAllDisplayedNotifications();

        //Create the Android Notification Channel to send messages through
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Notifications Channel",
            Importance = Importance.Default,
            Description = "Generic Notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        //Create the Notification that is going to be sent
        var notification = new AndroidNotification();
        notification.Title = "Hey! Come Back!";
        notification.Text = "View some of this dope ads!";
        notification.FireTime = System.DateTime.Now.AddMinutes(30);

        var notification2 = new AndroidNotification();
        notification2.Title = "COME BACK NOW!!";
        notification2.Text = "WATCH THIS ADS!!!";
        notification2.FireTime = System.DateTime.Now.AddHours(24);

        //Send Notification
        AndroidNotificationCenter.SendNotification(notification, "channel_id");
        AndroidNotificationCenter.SendNotification(notification2, "channel_id");

        ////If the script is run and a message is already scheduled, cancel it and reschedule another message
        //if (AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
        //{
        //    AndroidNotificationCenter.CancelAllNotifications();
        //    AndroidNotificationCenter.SendNotification(notification, "channel_id");
        //}
    }

    public void Click()
    {

    }
}
