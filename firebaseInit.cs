/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Analytics;
using Firebase.Messaging;



public class firebaseInit : MonoBehaviour
{
    private const string Topic = "projects/ultra-complex-311215/topics/my-topic";
    public string topicMessage;



    // Start is called before the first frame update
    void Start()
    {

        FirebaseMessaging.TokenReceived += OnTokenReceived;

        FirebaseMessaging.MessageReceived += OnMessageReceived;


        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(continuationAction: task =>
        {
            FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
   
        });
        FirebaseMessaging.SubscribeAsync(Topic);
    }


    public void OnMessageReceived(object sender, MessageReceivedEventArgs e)
    {
        Debug.Log("Received a new message");
        if (e.Message.From.Length > 0)
            Debug.Log("from: " + e.Message.From);
        
        if (e.Message.Data.Count > 0)
        {
            Debug.Log("data:");
            foreach (KeyValuePair<string, string> iter in
                     e.Message.Data)
            {
                Debug.Log("  " + iter.Key + ": " + iter.Value);
            }
        }
    }

    public void OnTokenReceived(object sender, TokenReceivedEventArgs token)
    {
        Debug.Log("Received a new token: " + token.Token);
       
    }

    // Update is called once per frame
    void Update()
    {

        
    }

   




}
*/