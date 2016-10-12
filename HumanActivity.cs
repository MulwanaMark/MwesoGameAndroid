using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MwesoGameAndroid
{
    [Activity(Label = "HumanActivity")]
    public class HumanActivity : Activity
    {
        private LinearLayout mLinearLayout;
        private Button mDraggableBtn;
        private Button mDraggableBtn2;
        private Button mDraggableBtn3;
        private Button mDraggableBtn4;
        private Button mDraggableBtn5;
        private Button mDraggableBtn6;
       private float mXDelta;
       private float mYDelta;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Window.RequestFeature(WindowFeatures.NoTitle);
            // Create your application here

            SetContentView(Resource.Layout.HumanBoard);
            mDraggableBtn = FindViewById<Button>(Resource.Id.draggablebutton1);
            mDraggableBtn2 = FindViewById<Button>(Resource.Id.draggablebutton2);
            mDraggableBtn3 = FindViewById<Button>(Resource.Id.draggablebutton3);
            mDraggableBtn4 = FindViewById<Button>(Resource.Id.draggablebutton4);
            mDraggableBtn5 = FindViewById<Button>(Resource.Id.draggablebutton5);
            mDraggableBtn6 = FindViewById<Button>(Resource.Id.draggablebutton6);
            mLinearLayout = FindViewById<LinearLayout>(Resource.Id.root);
            //this listener is called everytime the objectis dragged
            mDraggableBtn.Touch += MDraggableBtn_Touch;
            mDraggableBtn2.Touch += MDraggableBtn2_Touch;
            mDraggableBtn3.Touch += MDraggableBtn3_Touch;
            mDraggableBtn4.Touch += MDraggableBtn4_Touch;
            mDraggableBtn5.Touch += MDraggableBtn5_Touch;
            mDraggableBtn6.Touch += MDraggableBtn6_Touch;
        }

        private void MDraggableBtn6_Touch(object sender, View.TouchEventArgs e)
        {
            float x = e.Event.RawX;
            float y = e.Event.RawY;
            View touchedView = sender as View;
            //check for event actions
            switch (e.Event.Action)
            {
                case MotionEventActions.Down:
                    mXDelta = touchedView.GetX() - x;
                    mYDelta = touchedView.GetY() - y;
                    break;

                case MotionEventActions.Move:
                    touchedView.Animate()
                        .X(e.Event.RawX + mXDelta)
                        .Y(e.Event.RawY + mYDelta)
                        .SetDuration(0)
                        .Start();
                    break;

                default:
                    break;
            }
            mLinearLayout.Invalidate();
        }

        private void MDraggableBtn5_Touch(object sender, View.TouchEventArgs e)
        {
            float x = e.Event.RawX;
            float y = e.Event.RawY;
            View touchedView = sender as View;
            //check for event actions
            switch (e.Event.Action)
            {
                case MotionEventActions.Down:
                    mXDelta = touchedView.GetX() - x;
                    mYDelta = touchedView.GetY() - y;
                    break;

                case MotionEventActions.Move:
                    touchedView.Animate()
                        .X(e.Event.RawX + mXDelta)
                        .Y(e.Event.RawY + mYDelta)
                        .SetDuration(0)
                        .Start();
                    break;

                default:
                    break;
            }
            mLinearLayout.Invalidate();
        }

        private void MDraggableBtn4_Touch(object sender, View.TouchEventArgs e)
        {
            float x = e.Event.RawX;
            float y = e.Event.RawY;
            View touchedView = sender as View;
            //check for event actions
            switch (e.Event.Action)
            {
                case MotionEventActions.Down:
                    mXDelta = touchedView.GetX() - x;
                    mYDelta = touchedView.GetY() - y;
                    break;

                case MotionEventActions.Move:
                    touchedView.Animate()
                        .X(e.Event.RawX + mXDelta)
                        .Y(e.Event.RawY + mYDelta)
                        .SetDuration(0)
                        .Start();
                    break;

                default:
                    break;
            }
            mLinearLayout.Invalidate();
        }

        private void MDraggableBtn3_Touch(object sender, View.TouchEventArgs e)
        {
            float x = e.Event.RawX;
            float y = e.Event.RawY;
            View touchedView = sender as View;
            //check for event actions
            switch (e.Event.Action)
            {
                case MotionEventActions.Down:
                    mXDelta = touchedView.GetX() - x;
                    mYDelta = touchedView.GetY() - y;
                    break;

                case MotionEventActions.Move:
                    touchedView.Animate()
                        .X(e.Event.RawX + mXDelta)
                        .Y(e.Event.RawY + mYDelta)
                        .SetDuration(0)
                        .Start();
                    break;

                default:
                    break;
            }
            mLinearLayout.Invalidate();
        }

        private void MDraggableBtn2_Touch(object sender, View.TouchEventArgs e)
        {
            float x = e.Event.RawX;
            float y = e.Event.RawY;
            View touchedView = sender as View;
            //check for event actions
            switch (e.Event.Action)
            {
                case MotionEventActions.Down:
                    mXDelta = touchedView.GetX() - x;
                    mYDelta = touchedView.GetY() - y;
                    break;

                case MotionEventActions.Move:
                    touchedView.Animate()
                        .X(e.Event.RawX + mXDelta)
                        .Y(e.Event.RawY + mYDelta)
                        .SetDuration(0)
                        .Start();
                    break;

                default:
                    break;
            }
            mLinearLayout.Invalidate();
        }

        private void MDraggableBtn_Touch(object sender, View.TouchEventArgs e)
        {
            float x = e.Event.RawX;
            float y = e.Event.RawY;
            View touchedView = sender as View;
            //check for event actions
            switch (e.Event.Action)
            {
                case MotionEventActions.Down:
                    mXDelta = touchedView.GetX() - x;
                    mYDelta = touchedView.GetY() - y;
                    break;

                case MotionEventActions.Move:
                    touchedView.Animate()
                        .X(e.Event.RawX + mXDelta)
                        .Y(e.Event.RawY + mYDelta)
                        .SetDuration(0)
                        .Start();
                    break;

                default:
                    break;
            }
            mLinearLayout.Invalidate();
        }
    }
}