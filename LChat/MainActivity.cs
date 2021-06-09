using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;
using Cometchat.Inscripts.Com.Cometchatcore.Coresdk;
using CometChatUIBinding.Additions;
using Org.Json;

namespace LChat
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        CometChat cometChat;
        String licenseKey = "COMETCHAT-XXXXX-XXXXX-XXXXX-XXXXX";
        String apiKey = "xxxxxxxxxxxxxxxxxxxxxx";
        private String UID1 = "SUPERHERO1";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           // Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
           // Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
           // Button button = FindViewById<Button>(Resource.Id.myButton);

           // button.Click += delegate { initcalizeCometChat(); };

        }

       

        private void initcalizeCometChat()
        {
            cometChat = CometChat.GetInstance(this.ApplicationContext);

            cometChat.InitializeCometChat("", licenseKey, apiKey, true, new CometChatCallback(success => initalizeSuccess(success), fail => initializeFail(fail)));
        }

        private void initializeFail(JSONObject fail)
        {
            
        }

        private void initalizeSuccess(JSONObject success)
        {
            cometChat.LoginWithUID(this, UID1, new CometChatCallback(loginsuccess => loginSuccess(loginsuccess), fail => loginFail(fail)));
        }

        private void loginFail(JSONObject fail)
        {
            
        }

        private void loginSuccess(JSONObject loginsuccess)
        {
            cometChat.LaunchCometChat(this, true, new LaunchCallbacks(successObj => successCall(successObj), fail => failCall(fail), onChatroomInfo => ChatroomInfo(onChatroomInfo), onError => Error(onError), onLogout => Logout(onLogout), onMessageReceive => MessageReceive(onMessageReceive), onUserInfo => UserInfo(onUserInfo), onWindowClose => WindowClose(onWindowClose)));
        }

        private void WindowClose(JSONObject onWindowClose)
        {
            
        }

        private void UserInfo(JSONObject onUserInfo)
        {
            
        }

        private void MessageReceive(JSONObject onMessageReceive)
        {
            
        }

        private void Logout(JSONObject onLogout)
        {
            
        }

        private void Error(JSONObject onError)
        {
            
        }

        private void ChatroomInfo(JSONObject onChatroomInfo)
        {
            
        }

        private void failCall(JSONObject fail)
        {
            
        }

        private void successCall(JSONObject successObj)
        {
            
        }

        
    }
    
}