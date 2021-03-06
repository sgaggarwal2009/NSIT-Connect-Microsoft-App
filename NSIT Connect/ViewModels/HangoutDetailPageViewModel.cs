﻿using NSIT_Connect.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.Data.Json;
using Windows.Devices.Geolocation;
using Windows.UI.Popups;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace NSIT_Connect.ViewModels
{
    class HangoutDetailPageViewModel : ViewModelBase
    {
        private const string MAIN_HTTP = "https://maps.googleapis.com/maps/api/place/details/json?placeid=";
        private const string KEY = "&key=AIzaSyDU_a1tyoeYORYMjXzqzWrNJ8IhP8Ycgts";
        private string URL = null;
        private string result = null;
        private string address;
        private string phone;
        private string internationalPhone;
        private string website;
        private string googlemaps;
        private BitmapImage imageSource;
        private string distance;
        private string time;
        private string directions;

        public string Distance
        {
            get { return distance; }
            set { Set(ref distance, value); }
        }

        public string Time
        {
            get { return time; }
            set { Set(ref time, value); }
        }

        public string Directions
        {
            get { return directions; }
            set { Set(ref directions, value); }
        }

        public string Address
        {
            get { return address; }
            set { Set(ref address, value ); }
        }

        public string Phone
        {
            get { return phone; }
            set { Set(ref phone, value ); }
        }

        public string InternationalPhone
        {
            get { return internationalPhone; }
            set { Set(ref internationalPhone, value ); }
        }

        public string Website
        {
            get { return website; }
            set { Set(ref website, value ); }
        }

        public string Googlemaps
        {
            get { return googlemaps; }
            set { Set(ref googlemaps, value ); }
        }

        public BitmapImage ImageSource
        {
            get { return imageSource; }
            set { Set(ref imageSource, value ) ; }
        }

        private HangoutItem _selectedhangout = default(HangoutItem);
        public HangoutItem SelectedHangout
        {
            get { return _selectedhangout; }
            set
            {
                var message = value as HangoutItem;
                Set(ref _selectedhangout, message);
            }
        }

        private ObservableCollection<ReviewItem> item = new ObservableCollection<ReviewItem>();
        public ObservableCollection<ReviewItem> Item { get { return item; } set { item = value; } }


        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            SelectedHangout = (suspensionState.ContainsKey(nameof(SelectedHangout))) ? suspensionState[nameof(SelectedHangout)] as HangoutItem : parameter as HangoutItem;
            getinfo();
            
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(SelectedHangout)] = SelectedHangout;
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        public async void getinfo()
        {
            URL = MAIN_HTTP + SelectedHangout.Place_ID + KEY;
            if (URL != null)
            {
                var httpClient = new HttpClient();
                var uri = new Uri(URL);

                try
                {
                    HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);
                    responseMessage.EnsureSuccessStatusCode();
                    result = await responseMessage.Content.ReadAsStringAsync();
                }
                catch (Exception ex) { }
                httpClient.Dispose();
            }

            if (result != null)
            {
                JsonObject jplaceobject = JsonObject.Parse(result);
                JsonObject jplacearray = jplaceobject.GetNamedObject("result");

                    if (jplacearray.ContainsKey("formatted_address"))
                        Address = jplacearray.GetNamedString("formatted_address");
                    else
                        Address = null;

                    if (jplacearray.ContainsKey("formatted_phone_number"))
                        Phone = "National :" + jplacearray.GetNamedString("formatted_phone_number");
                    else
                        Phone = null;

                    if (jplacearray.ContainsKey("international_phone_number"))
                        InternationalPhone = "International :" + jplacearray.GetNamedString("international_phone_number");
                    else
                        InternationalPhone = null;

                    if (jplacearray.ContainsKey("website"))
                        Website = jplacearray.GetNamedString("website");
                    else
                        Website = null;

                    if (jplacearray.ContainsKey("url"))
                        Googlemaps = jplacearray.GetNamedString("url");
                    else
                        Googlemaps = null;

                if (jplacearray.ContainsKey("reviews"))
                {
                    JsonArray jreviewarray = jplacearray.GetNamedArray("reviews");
                    string name = null;
                    double rating = -1;
                    string profile = null;
                    string text = null;
                    double time = -1;

                    for(uint i =0 ; i < jreviewarray.Count; i++)
                    {
                        if (jreviewarray.GetObjectAt(i).ContainsKey("author_name"))
                            name = jreviewarray.GetObjectAt(i).GetNamedString("author_name");
                        else
                            name = null;

                        if (jreviewarray.GetObjectAt(i).ContainsKey("author_url"))
                            profile = jreviewarray.GetObjectAt(i).GetNamedString("author_url");
                        else
                            profile = null;

                        if (jreviewarray.GetObjectAt(i).ContainsKey("rating"))
                            rating = jreviewarray.GetObjectAt(i).GetNamedNumber("rating");
                        else
                            rating = 0;

                        if (jreviewarray.GetObjectAt(i).ContainsKey("text"))
                            text = jreviewarray.GetObjectAt(i).GetNamedString("text");
                        else
                            text = null;

                        if (jreviewarray.GetObjectAt(i).ContainsKey("time"))
                            time = jreviewarray.GetObjectAt(i).GetNamedNumber("time");
                        else
                            time = 0;

                        System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                        dtDateTime = dtDateTime.AddSeconds(time).ToLocalTime();
                        Item.Add(new ReviewItem() {Name=name,Profile = profile,Rating =rating,Text=text,Time = dtDateTime.ToString("d MMM , yyy") });
                    }
                }
                    ImageSource = new BitmapImage(SelectedHangout.Photo_Ref);

            }
        }
    }
}
